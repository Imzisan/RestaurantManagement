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
    public partial class FormEmp : MetroForm
    {
        private DataAccess Da { get; set; }
        public FormEmp()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();

        }
        private void ClearContent()
        {
            this.txtCartFoodType.Text = "";
            this.txtCartFoodName.Text = "";
            this.txtCartPrice.Text = "";

            this.txtSearch.Text = "";
            this.txtAutoSearch.Text = "";
            this.txtQuantity.Value = 0;
            this.txtTotal.Text = "";

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

        private void BtnFoodInfo_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }
 
        private void DgvFoodInfo_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.txtCartFoodId.Text = this.dgvFoodInfo.CurrentRow.Cells["FoodId"].Value.ToString();
            this.txtCartFoodName.Text = this.dgvFoodInfo.CurrentRow.Cells["FoodName"].Value.ToString();
            this.txtCartFoodType.Text = this.dgvFoodInfo.CurrentRow.Cells["FoodType"].Value.ToString();
            this.txtCartPrice.Text = this.dgvFoodInfo.CurrentRow.Cells["Price"].Value.ToString();
        }

        private void BtnPlaceOrder_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into OrderInfo values('" + this.dtpTodayDate.Text + "', '" + this.lblGrandTotal.Text + "'); ";

                int count = this.Da.ExecuteDML(sql);

                if (count == 1)
                {
                    MessageBox.Show("Order Placed");
                }
                else
                {
                    MessageBox.Show("Order Placing Failed Please Re-order");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
            this.ClearContent();
            this.lblGrandTotal.Text = "Tk.";
            while (dgvOrderInfo.Rows.Count > 0)
            {
                this.dgvOrderInfo.Rows.RemoveAt(this.dgvOrderInfo.SelectedRows[0].Index);
            }
        }
        internal int c, total = 0;
        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text != "0" && txtTotal.Text != "")
            {
                c = this.dgvOrderInfo.Rows.Add();
                this.dgvOrderInfo.Rows[c].Cells[0].Value = this.txtCartFoodName.Text;
                this.dgvOrderInfo.Rows[c].Cells[1].Value = this.txtCartPrice.Text;
                this.dgvOrderInfo.Rows[c].Cells[2].Value = this.txtQuantity.Text;
                this.dgvOrderInfo.Rows[c].Cells[3].Value = this.txtTotal.Text;

                total += int.Parse(this.txtTotal.Text);
                lblGrandTotal.Text = "Tk." + total;
            }
            else
            {
                MessageBox.Show("Enter Quantity Please");
            }

            this.txtQuantity.Value = 0;
            this.txtTotal.Text = "";
        }
        int amount;
        private void BtnRemove_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.dgvOrderInfo.Rows.RemoveAt(this.dgvOrderInfo.SelectedRows[0].Index);
            }
            catch
            {
                MessageBox.Show("Please click on a row first to remove");
            }

            total -= amount;
            this.lblGrandTotal.Text = "Tk." + total;
            ClearContent();
        }

        private void DgvOrderInfo_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                amount = int.Parse(dgvOrderInfo.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void BtnSearch_Click_1(object sender, EventArgs e)
        {
            string sql = "select * from FoodInfo where FoodType = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void TxtAutoSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from FoodInfo where FoodName  like '" + this.txtAutoSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void TxtQuantity_ValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtCartFoodId.Text) || String.IsNullOrEmpty(this.txtCartFoodName.Text) ||
                String.IsNullOrEmpty(this.txtCartFoodType.Text) || String.IsNullOrEmpty(this.txtCartPrice.Text))

                {
                    MessageBox.Show("Please select food items before increasing quantity");
                    return;

                }

                int quan = int.Parse(this.txtQuantity.Value.ToString());
                int price = int.Parse(this.txtCartPrice.Text);
                this.txtTotal.Text = (quan * price).ToString();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }

        }

        
        

        
    }
    
}
