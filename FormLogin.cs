using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace RestaurantManagement
{
    public partial class FormLogin : MetroForm
    {
        private DataAccess Da { get; set; }
        public FormLogin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from UserInfo where UserId = '" + this.txtUserId.Text + "' and Password = '" + this.txtPassword.Text + "';";
                DataSet ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Login Valid");
                    if (ds.Tables[0].Rows[0][2].ToString().Equals("admin"))
                    {
                        FormAdmin fa = new FormAdmin();
                        fa.Visible = true;
                    }
                    else if (ds.Tables[0].Rows[0][2].ToString().Equals("manager"))
                    {
                        FormGm fm = new FormGm();
                        fm.Visible = true;
                    }
                    else if (ds.Tables[0].Rows[0][2].ToString().Equals("employee"))
                    {
                        FormEmp fe = new FormEmp();
                        fe.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Login Invalid");
                 
                }
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.txtUserId.Text = "";
            this.txtPassword.Clear();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = "select * from UserInfo where UserId = '" + this.txtUserId.Text + "' and Password = '" + this.txtPassword.Text + "';";
                DataSet ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Please Enter Your New Password");
                    this.panelChangePassword.Visible = true;
                    this.txtUserId.ReadOnly = true;
                    this.txtPassword.ReadOnly = true;

                }
                else
                {
                    MessageBox.Show("Id or Password Incorrect. Please Try Again. ");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            //update password

            try
            {
                string query = "update UserInfo set Password = '" + this.txtNewPassword.Text + "' where UserId = '" + this.txtUserId.Text + "';";
                int count = this.Da.ExecuteDML(query);
                int a = int.Parse(this.txtNewPassword.Text);
                int b= int.Parse(this.txtConfirmPassword.Text);
                if (count == 1 && a==b  )
                {
                    
                    MessageBox.Show("Password updated");
                }
                else
                {
                    MessageBox.Show("Password updatation Failed. Try again ");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
            this.panelChangePassword.Visible = false;
            this.txtUserId.ReadOnly = false;
            this.txtPassword.ReadOnly = false;
            this.txtNewPassword.Text = "";
            this.txtConfirmPassword.Text = "";

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.panelChangePassword.Visible = false;
            this.txtNewPassword.Text = "";
            this.txtConfirmPassword.Text = "";
        }
    }
}
