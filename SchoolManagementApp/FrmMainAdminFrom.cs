using SchoolManagementApp.SystemManage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementApp
{
    public partial class FrmMainAdminFrom : Form
    {
        public FrmMainAdminFrom()
        {
            InitializeComponent();
        }

        private void 登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        private void FrmMainAdminFrom_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModifiedPwd frm = new FrmModifiedPwd();
            frm.Show();
        }

        private void 退出登录ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void FrmMainAdminFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
