using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace RestaurantManagement
{
    public partial class FormLogin : MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from UserInfo where UserId = '" + this.txtUserId.Text + "' and Password = '" + this.txtPassword.Text + "';";

                SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-M8FKIN1;Initial Catalog=RestaurantManagement;Persist Security Info=True;User ID=sa;Password=1110244718");
                sqlCon.Open();
                SqlCommand sqlCom = new SqlCommand(sql, sqlCon);
                SqlDataAdapter sdAdapter = new SqlDataAdapter(sqlCom);
                DataSet ds = new DataSet();
                sdAdapter.Fill(ds);

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
                sqlCon.Close();
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
    }
}
