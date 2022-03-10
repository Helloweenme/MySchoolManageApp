using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementApp.SystemManage
{
    public partial class FrmModifiedPwd : Form
    {
        private Guid userid = Guid.Empty;
        public FrmModifiedPwd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tetOldPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmModifiedPwd_Load(object sender, EventArgs e)
        {
            this.userid = Common.userid;
            this.tetOldPwd.Text = Common.userid.ToString();
        }
    }
}
