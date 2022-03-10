using SchoolManagementApp.User;
using SchoolManagementApp.User.Models;
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
    public partial class FrmLogin : Form
    {
        //创建数据访问对象
        private UserManager objUserManager = new UserManager();
        private Guid userid = Guid.Empty;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtUserName.Text = null;
            this.txtPassword.Text = null;

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = txtUserName.Text;
            var pwd = txtPassword.Text;
            
            //数据验证
            if (user.Trim().Length == 0)
            {
                MessageBox.Show("请输入用户名", "登录提示");
                this.txtUserName.Focus();
            }
            else if (pwd.Trim().Length == 0)
            {
                MessageBox.Show("请输入密码", "登录提示");
                this.txtPassword.Focus();
            }
            else {
                // 封装对象
                user_infoModel objUser = new user_infoModel
                {
                    userno = user.Trim(),
                    password = pwd.Trim()
                };

                try
                {
                    objUser = objUserManager.UserLogin(objUser);
                    if (objUser != null)
                    {
                        this.userid = objUser.userid;
                        if (objUser.role == "园长")
                        {
                            FrmMainAdminFrom frm = new FrmMainAdminFrom();
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            FrmTeacherFrom frm = new FrmTeacherFrom();
                            frm.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误！", "登录提示");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("登录异常：" + ex.Message, "登录提示");
                }

            }

        }

        private void btnLogin_TextChanged(object sender, EventArgs e)
        {
            Common.userid = this.userid;
        }
    }
}
