using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

//https://qiita.com/ara-bot/items/36946bb10ef25261e814のコード

namespace TasQuest
{
    class DBManager
    {
        private SqlConnection sqlConnection;
        private SqlTransaction sqlTransaction;
     
        public DBManager(string dbServer, string dbName, string dbUser, string dbPass)
        {
            string connectString =
            "Data Source = " + dbServer
            + ";Initial Catalog = " + dbName
            + ";User ID = " + dbUser
            + ";Password = " + dbPass
            + ";MultipleActiveResultSets=True";

            this.sqlConnection = new SqlConnection(connectString);

            this.sqlConnection.Open();
        }

        public void Close()
        {
            this.sqlConnection.Close();
            this.sqlConnection.Dispose();
        }

        public void BeginTran()
        {
            this.sqlTransaction = this.sqlConnection.BeginTransaction();
        }

        public void CommitTran()
        {
            if (this.sqlTransaction.Connection != null)
            {
                this.sqlTransaction.Commit();
                this.sqlTransaction.Dispose();
            }
        }

        public void RollBack()
        {
            if (this.sqlTransaction.Connection != null)
            {
                this.sqlTransaction.Rollback();
                this.sqlTransaction.Dispose();
            }
        }

        public SqlDataReader ExecuteQuery(string query, Dictionary<string, Object> paramDict)
        {
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = this.sqlConnection;
            sqlCom.Transaction = this.sqlTransaction;

            sqlCom.CommandText = query;
            foreach (KeyValuePair<string, Object> item in paramDict)
            {
                sqlCom.Parameters.Add(new SqlParameter(item.Key, item.Value));
            }

            SqlDataReader reader = sqlCom.ExecuteReader();

            return reader;
        }

        public SqlDataReader ExecuteQuery(string query)
        {
            return this.ExecuteQuery(query, new Dictionary<string, Object>());
        }

        public void ExecuteNonQuery(string query, Dictionary<string, Object> paramDict)
        {
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = this.sqlConnection;
            sqlCom.Transaction = this.sqlTransaction;

            sqlCom.CommandText = query;
            foreach (KeyValuePair<string, Object> item in paramDict)
            {
                sqlCom.Parameters.Add(new SqlParameter(item.Key, item.Value));
            }

            sqlCom.ExecuteNonQuery();
        }
    }
}