namespace TasQuest
{
    partial class TasQuest
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Appear = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Task_Delete_Button = new System.Windows.Forms.Button();
            this.Task_Info_Button = new System.Windows.Forms.Button();
            this.Task_Change_Button = new System.Windows.Forms.Button();
            this.RunAway_Button = new System.Windows.Forms.Button();
            this.message_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Appear)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Appear
            // 
            this.Appear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Appear.Dock = System.Windows.Forms.DockStyle.Top;
            this.Appear.Location = new System.Drawing.Point(0, 0);
            this.Appear.Name = "Appear";
            this.Appear.Size = new System.Drawing.Size(800, 337);
            this.Appear.TabIndex = 0;
            this.Appear.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Task_Delete_Button);
            this.flowLayoutPanel1.Controls.Add(this.Task_Info_Button);
            this.flowLayoutPanel1.Controls.Add(this.Task_Change_Button);
            this.flowLayoutPanel1.Controls.Add(this.RunAway_Button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 329);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 121);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Task_Delete_Button
            // 
            this.Task_Delete_Button.Location = new System.Drawing.Point(3, 3);
            this.Task_Delete_Button.Name = "Task_Delete_Button";
            this.Task_Delete_Button.Size = new System.Drawing.Size(177, 118);
            this.Task_Delete_Button.TabIndex = 0;
            this.Task_Delete_Button.Text = "倒す";
            this.Task_Delete_Button.UseVisualStyleBackColor = true;
            // 
            // Task_Info_Button
            // 
            this.Task_Info_Button.Location = new System.Drawing.Point(186, 3);
            this.Task_Info_Button.Name = "Task_Info_Button";
            this.Task_Info_Button.Size = new System.Drawing.Size(189, 118);
            this.Task_Info_Button.TabIndex = 1;
            this.Task_Info_Button.Text = "調べる";
            this.Task_Info_Button.UseVisualStyleBackColor = true;
            // 
            // Task_Change_Button
            // 
            this.Task_Change_Button.Location = new System.Drawing.Point(381, 3);
            this.Task_Change_Button.Name = "Task_Change_Button";
            this.Task_Change_Button.Size = new System.Drawing.Size(204, 118);
            this.Task_Change_Button.TabIndex = 2;
            this.Task_Change_Button.Text = "変える";
            this.Task_Change_Button.UseVisualStyleBackColor = true;
            // 
            // RunAway_Button
            // 
            this.RunAway_Button.Location = new System.Drawing.Point(591, 3);
            this.RunAway_Button.Name = "RunAway_Button";
            this.RunAway_Button.Size = new System.Drawing.Size(197, 118);
            this.RunAway_Button.TabIndex = 3;
            this.RunAway_Button.Text = "逃げる";
            this.RunAway_Button.UseVisualStyleBackColor = true;
            this.RunAway_Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RunAway_Button_MouseClick);
            // 
            // message_box
            // 
            this.message_box.BackColor = System.Drawing.SystemColors.InfoText;
            this.message_box.Font = new System.Drawing.Font("メイリオ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.message_box.ForeColor = System.Drawing.Color.White;
            this.message_box.Location = new System.Drawing.Point(0, 0);
            this.message_box.Multiline = true;
            this.message_box.Name = "message_box";
            this.message_box.Size = new System.Drawing.Size(799, 77);
            this.message_box.TabIndex = 2;
            this.message_box.Text = "デフォルト";
            this.message_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.message_box.Visible = false;
            // 
            // TasQuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.message_box);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Appear);
            this.Name = "TasQuest";
            this.Text = "TasQuest";
            ((System.ComponentModel.ISupportInitialize)(this.Appear)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Appear;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Task_Delete_Button;
        private System.Windows.Forms.Button Task_Info_Button;
        private System.Windows.Forms.Button Task_Change_Button;
        private System.Windows.Forms.Button RunAway_Button;
        private System.Windows.Forms.TextBox message_box;
    }
}

