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
    public partial class FormAdmin : MetroForm
    {
        private DataAccess Da { get; set; }
        public FormAdmin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.PopulateUserInfoGridView();
            this.AutoIdGenerate();
            this.AutoUserIdGenerate();
        }
        private void PopulateGridView(string sql = "select * from FoodInfo;")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);

                this.dgvFoodInfo.AutoGenerateColumns = false;
                this.dgvFoodInfo.DataSource = ds.Tables[0];

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }
        private void PopulateUserInfoGridView(string sql = "select * from UserInfo;")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);

                this.dgvUserInfo.AutoGenerateColumns = false;
                this.dgvUserInfo.DataSource = ds.Tables[0];

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void BtnFoodInfo_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from FoodInfo where FoodType = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void TxtAutoSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from FoodInfo where FoodName  like '" + this.txtAutoSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtFoodId.Text) || String.IsNullOrEmpty(this.txtFoodName.Text) ||
                String.IsNullOrEmpty(this.txtFoodType.Text) || String.IsNullOrEmpty(this.txtPrice.Text))

                {
                    MessageBox.Show("To add Items please fill all the information.");
                    return;
                }

                var query = " select * from FoodInfo where FoodId ='" + this.txtFoodId.Text + "'; ";
                var dt = this.Da.ExecuteQueryTable(query);
                if (dt.Rows.Count == 1)
                {
                    //Update
                    string sql = "update FoodInfo set FoodName = '" + this.txtFoodName.Text + "',FoodType = '" + this.txtFoodType.Text + "',Price = " + this.txtPrice.Text + " where FoodId = '" + this.txtFoodId.Text + "'; ";
                    int count = this.Da.ExecuteDML(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Data updated");
                    }
                    else
                    {
                        MessageBox.Show("Data updatation Failed.");
                    }

                }
                else
                {
                    //Insert
                    string sql = "insert into FoodInfo values ('" + this.txtFoodId.Text + "','" + this.txtFoodName.Text + "','" +
                               this.txtFoodType.Text + "','" + this.txtPrice.Text + "');";

                    int count = this.Da.ExecuteDML(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Data Inserted.");
                    }
                    else
                    {
                        MessageBox.Show("Data Insertion Failed.");
                    }
                }

                this.PopulateGridView();
                this.ClearContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void DgvFoodInfo_DoubleClick(object sender, EventArgs e)
        {
            this.txtFoodId.Text = this.dgvFoodInfo.CurrentRow.Cells["FoodId"].Value.ToString();
            this.txtFoodName.Text = this.dgvFoodInfo.CurrentRow.Cells["FoodName"].Value.ToString();
            this.txtFoodType.Text = this.dgvFoodInfo.CurrentRow.Cells["FoodType"].Value.ToString();
            this.txtPrice.Text = this.dgvFoodInfo.CurrentRow.Cells["Price"].Value.ToString();

        }
        private void ClearContent()
        {
            this.AutoIdGenerate();
            this.txtFoodType.Text = "";
            this.txtFoodName.Text = "";
            this.txtPrice.Text = "";

            this.txtSearch.Text = "";
            this.txtAutoSearch.Text = "";

            //this.txtId.ReadOnly = false;
        }
        private void ClearUserContent()
        {
            this.AutoUserIdGenerate();
            this.txtUserPassword.Text = "";
            this.txtRole.Text = "";


        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }
        private void AutoIdGenerate()
        {
            var sql = "select FoodId from FoodInfo order by FoodId desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var previousId = dt.Rows[0]["FoodId"].ToString();
            string[] sunInfo = previousId.Split('-');
            
            int temp = Convert.ToInt32(sunInfo[1]);
            var newId = "f-" + (++temp).ToString("d3");
            this.txtFoodId.Text = newId;
        }
        private void AutoUserIdGenerate()
        {
            var sql = "select UserId from UserInfo order by UserId desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var previousId = dt.Rows[0]["UserId"].ToString();
            string[] sunInfo = previousId.Split('-');

            int temp = Convert.ToInt32(sunInfo[1]);
            var newId = "u-" + (++temp).ToString("d3");
            this.txtUserId.Text = newId;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvFoodInfo.CurrentRow.Cells["FoodId"].Value.ToString();
                var Name = this.dgvFoodInfo.CurrentRow.Cells["FoodName"].Value.ToString();

                var sql = "delete from FoodInfo where FoodId ='"+id+"';";
                var count = this.Da.ExecuteDML(sql);

                if (count == 1)
                {
                    MessageBox.Show("Food " + Name + " has been deleted.");
                }
                else
                {
                    MessageBox.Show("Data Deletion Failed.");
                }

                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtUserId.Text) || String.IsNullOrEmpty(this.txtUserPassword.Text) ||
                String.IsNullOrEmpty(this.txtRole.Text) )

                {
                    MessageBox.Show("To add Items please fill all the information.");
                    return;
                }

                var query = " select * from UserInfo where UserId ='"+this.txtUserId.Text +"'; ";
                var dt = this.Da.ExecuteQueryTable(query);
                if (dt.Rows.Count == 1)
                {
                    //Update
                    string sql = "update UserInfo set Password = '"+this.txtUserPassword.Text+"',Role = '"+ this.txtRole.Text +"'where UserId = '"+this.txtUserId.Text+"'; ";
                    int count = this.Da.ExecuteDML(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("User updated");
                    }
                    else
                    {
                        MessageBox.Show("User updatation Failed.");
                    }

                }
                else
                {
                    //Insert
                    string sql = "insert into UserInfo values('"+this.txtUserId.Text+"', '"+this.txtUserPassword.Text+"', '"+this.txtRole.Text+"'); ";

                    int count = this.Da.ExecuteDML(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("User Inserted.");
                    }
                    else
                    {
                        MessageBox.Show("User Insertion Failed.");
                    }
                }

                this.PopulateUserInfoGridView();
                this.ClearUserContent();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }

        }

        private void DgvUserInfo_DoubleClick(object sender, EventArgs e)
        {
            this.txtUserId.Text = this.dgvUserInfo.CurrentRow.Cells["Id"].Value.ToString();
            this.txtUserPassword.Text = this.dgvUserInfo.CurrentRow.Cells["Password"].Value.ToString();
            this.txtRole.Text = this.dgvUserInfo.CurrentRow.Cells["Role"].Value.ToString();


        }

        private void BtnClearUserInfo_Click(object sender, EventArgs e)
        {
            this.ClearUserContent();
        }

        private void BtnRemoveUser_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvUserInfo.CurrentRow.Cells["Id"].Value.ToString();
                

                var sql = "delete from UserInfo where UserId ='" + id + "';";
                var count = this.Da.ExecuteDML(sql);

                if (count == 1)
                {
                    MessageBox.Show("User has been deleted.");
                }
                else
                {
                    MessageBox.Show("Data Deletion Failed.");
                }

                this.PopulateUserInfoGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }
    }
}
