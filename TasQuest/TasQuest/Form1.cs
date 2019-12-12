using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasQuest
{
    public partial class TasQuest : Form
    {
        public TasQuest()
        {
            InitializeComponent();
        }

        private void RunAway_Button_MouseClick(object sender, MouseEventArgs e)
        {
            message_box.Text = "しょうぶのさいちゅうにせなかをむけることなんてできない!";
            message_box.Visible = true;
        }
    }
}
