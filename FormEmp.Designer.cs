namespace RestaurantManagement
{
    partial class FormEmp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnFoodInfo = new MetroFramework.Controls.MetroButton();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.txtAutoSearch = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRemove = new MetroFramework.Controls.MetroButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotal = new MetroFramework.Controls.MetroTextBox();
            this.btnAddToCart = new MetroFramework.Controls.MetroButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCartFoodId = new MetroFramework.Controls.MetroTextBox();
            this.txtCartFoodName = new MetroFramework.Controls.MetroTextBox();
            this.txtCartFoodType = new MetroFramework.Controls.MetroTextBox();
            this.txtCartPrice = new MetroFramework.Controls.MetroTextBox();
            this.dtpTodayDate = new MetroFramework.Controls.MetroDateTime();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvFoodInfo = new MetroFramework.Controls.MetroGrid();
            this.FoodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPlaceOrder = new MetroFramework.Controls.MetroButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new MetroFramework.Controls.MetroLabel();
            this.dgvOrderInfo = new MetroFramework.Controls.MetroGrid();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Honeydew;
            this.metroPanel1.Controls.Add(this.btnClear);
            this.metroPanel1.Controls.Add(this.btnFoodInfo);
            this.metroPanel1.Controls.Add(this.txtSearch);
            this.metroPanel1.Controls.Add(this.btnSearch);
            this.metroPanel1.Controls.Add(this.txtAutoSearch);
            this.metroPanel1.Controls.Add(this.label5);
            this.metroPanel1.Controls.Add(this.label13);
            this.metroPanel1.Controls.Add(this.btnRemove);
            this.metroPanel1.Controls.Add(this.label7);
            this.metroPanel1.Controls.Add(this.label9);
            this.metroPanel1.Controls.Add(this.txtTotal);
            this.metroPanel1.Controls.Add(this.btnAddToCart);
            this.metroPanel1.Controls.Add(this.label10);
            this.metroPanel1.Controls.Add(this.txtQuantity);
            this.metroPanel1.Controls.Add(this.label11);
            this.metroPanel1.Controls.Add(this.label12);
            this.metroPanel1.Controls.Add(this.txtCartFoodId);
            this.metroPanel1.Controls.Add(this.txtCartFoodName);
            this.metroPanel1.Controls.Add(this.txtCartFoodType);
            this.metroPanel1.Controls.Add(this.txtCartPrice);
            this.metroPanel1.Controls.Add(this.dtpTodayDate);
            this.metroPanel1.Controls.Add(this.label8);
            this.metroPanel1.Controls.Add(this.label15);
            this.metroPanel1.Controls.Add(this.dgvFoodInfo);
            this.metroPanel1.Controls.Add(this.btnPlaceOrder);
            this.metroPanel1.Controls.Add(this.label6);
            this.metroPanel1.Controls.Add(this.lblGrandTotal);
            this.metroPanel1.Controls.Add(this.dgvOrderInfo);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1268, 767);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Aquamarine;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(357, 35);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 84);
            this.btnClear.TabIndex = 72;
            this.btnClear.Text = "Clear";
            this.btnClear.UseCustomBackColor = true;
            this.btnClear.UseCustomForeColor = true;
            this.btnClear.UseSelectable = true;
            this.btnClear.UseStyleColors = true;
            // 
            // btnFoodInfo
            // 
            this.btnFoodInfo.BackColor = System.Drawing.Color.Aquamarine;
            this.btnFoodInfo.ForeColor = System.Drawing.Color.Black;
            this.btnFoodInfo.Location = new System.Drawing.Point(220, 35);
            this.btnFoodInfo.Name = "btnFoodInfo";
            this.btnFoodInfo.Size = new System.Drawing.Size(126, 84);
            this.btnFoodInfo.TabIndex = 71;
            this.btnFoodInfo.Text = "Show  Menu";
            this.btnFoodInfo.UseCustomBackColor = true;
            this.btnFoodInfo.UseCustomForeColor = true;
            this.btnFoodInfo.UseSelectable = true;
            this.btnFoodInfo.UseStyleColors = true;
            this.btnFoodInfo.Click += new System.EventHandler(this.BtnFoodInfo_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Aqua;
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(6, 97);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(208, 23);
            this.txtSearch.TabIndex = 68;
            this.txtSearch.UseCustomBackColor = true;
            this.txtSearch.UseCustomForeColor = true;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.UseStyleColors = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(24, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(163, 27);
            this.btnSearch.TabIndex = 67;
            this.btnSearch.Text = "Search By Type";
            this.btnSearch.UseCustomBackColor = true;
            this.btnSearch.UseCustomForeColor = true;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click_1);
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.BackColor = System.Drawing.Color.Aqua;
            // 
            // 
            // 
            this.txtAutoSearch.CustomButton.Image = null;
            this.txtAutoSearch.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.txtAutoSearch.CustomButton.Name = "";
            this.txtAutoSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAutoSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAutoSearch.CustomButton.TabIndex = 1;
            this.txtAutoSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAutoSearch.CustomButton.UseSelectable = true;
            this.txtAutoSearch.CustomButton.Visible = false;
            this.txtAutoSearch.Lines = new string[0];
            this.txtAutoSearch.Location = new System.Drawing.Point(433, 97);
            this.txtAutoSearch.MaxLength = 32767;
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.PasswordChar = '\0';
            this.txtAutoSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAutoSearch.SelectedText = "";
            this.txtAutoSearch.SelectionLength = 0;
            this.txtAutoSearch.SelectionStart = 0;
            this.txtAutoSearch.ShortcutsEnabled = true;
            this.txtAutoSearch.Size = new System.Drawing.Size(218, 23);
            this.txtAutoSearch.TabIndex = 69;
            this.txtAutoSearch.UseCustomBackColor = true;
            this.txtAutoSearch.UseCustomForeColor = true;
            this.txtAutoSearch.UseSelectable = true;
            this.txtAutoSearch.UseStyleColors = true;
            this.txtAutoSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAutoSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAutoSearch.Click += new System.EventHandler(this.TxtAutoSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(463, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 19);
            this.label5.TabIndex = 70;
            this.label5.Text = "Auto Search By Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(669, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 19);
            this.label13.TabIndex = 66;
            this.label13.Text = "Quantity";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemove.Location = new System.Drawing.Point(1102, 93);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(130, 108);
            this.btnRemove.TabIndex = 54;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseCustomBackColor = true;
            this.btnRemove.UseCustomForeColor = true;
            this.btnRemove.UseSelectable = true;
            this.btnRemove.UseStyleColors = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(669, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 19);
            this.label7.TabIndex = 56;
            this.label7.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(668, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 19);
            this.label9.TabIndex = 62;
            this.label9.Text = "Food Id";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.MediumSpringGreen;
            // 
            // 
            // 
            this.txtTotal.CustomButton.Image = null;
            this.txtTotal.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtTotal.CustomButton.Name = "";
            this.txtTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotal.CustomButton.TabIndex = 1;
            this.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotal.CustomButton.UseSelectable = true;
            this.txtTotal.CustomButton.Visible = false;
            this.txtTotal.Enabled = false;
            this.txtTotal.Lines = new string[0];
            this.txtTotal.Location = new System.Drawing.Point(777, 178);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(174, 23);
            this.txtTotal.TabIndex = 53;
            this.txtTotal.UseCustomBackColor = true;
            this.txtTotal.UseCustomForeColor = true;
            this.txtTotal.UseSelectable = true;
            this.txtTotal.UseStyleColors = true;
            this.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.Thistle;
            this.btnAddToCart.Location = new System.Drawing.Point(957, 93);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(130, 108);
            this.btnAddToCart.TabIndex = 51;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseCustomBackColor = true;
            this.btnAddToCart.UseCustomForeColor = true;
            this.btnAddToCart.UseSelectable = true;
            this.btnAddToCart.UseStyleColors = true;
            this.btnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label10.Location = new System.Drawing.Point(668, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 19);
            this.label10.TabIndex = 63;
            this.label10.Text = "Food Name";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtQuantity.Location = new System.Drawing.Point(777, 151);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(174, 20);
            this.txtQuantity.TabIndex = 52;
            this.txtQuantity.ValueChanged += new System.EventHandler(this.TxtQuantity_ValueChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(668, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 19);
            this.label11.TabIndex = 64;
            this.label11.Text = "Food Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(668, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 19);
            this.label12.TabIndex = 65;
            this.label12.Text = "Price";
            // 
            // txtCartFoodId
            // 
            this.txtCartFoodId.BackColor = System.Drawing.Color.MediumSpringGreen;
            // 
            // 
            // 
            this.txtCartFoodId.CustomButton.Image = null;
            this.txtCartFoodId.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtCartFoodId.CustomButton.Name = "";
            this.txtCartFoodId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCartFoodId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCartFoodId.CustomButton.TabIndex = 1;
            this.txtCartFoodId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCartFoodId.CustomButton.UseSelectable = true;
            this.txtCartFoodId.CustomButton.Visible = false;
            this.txtCartFoodId.Enabled = false;
            this.txtCartFoodId.Lines = new string[0];
            this.txtCartFoodId.Location = new System.Drawing.Point(777, 35);
            this.txtCartFoodId.MaxLength = 32767;
            this.txtCartFoodId.Name = "txtCartFoodId";
            this.txtCartFoodId.PasswordChar = '\0';
            this.txtCartFoodId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCartFoodId.SelectedText = "";
            this.txtCartFoodId.SelectionLength = 0;
            this.txtCartFoodId.SelectionStart = 0;
            this.txtCartFoodId.ShortcutsEnabled = true;
            this.txtCartFoodId.Size = new System.Drawing.Size(174, 23);
            this.txtCartFoodId.TabIndex = 58;
            this.txtCartFoodId.UseCustomBackColor = true;
            this.txtCartFoodId.UseCustomForeColor = true;
            this.txtCartFoodId.UseSelectable = true;
            this.txtCartFoodId.UseStyleColors = true;
            this.txtCartFoodId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCartFoodId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtCartFoodName
            // 
            this.txtCartFoodName.BackColor = System.Drawing.Color.LightSteelBlue;
            // 
            // 
            // 
            this.txtCartFoodName.CustomButton.Image = null;
            this.txtCartFoodName.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtCartFoodName.CustomButton.Name = "";
            this.txtCartFoodName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCartFoodName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCartFoodName.CustomButton.TabIndex = 1;
            this.txtCartFoodName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCartFoodName.CustomButton.UseSelectable = true;
            this.txtCartFoodName.CustomButton.Visible = false;
            this.txtCartFoodName.Enabled = false;
            this.txtCartFoodName.ForeColor = System.Drawing.Color.White;
            this.txtCartFoodName.Lines = new string[0];
            this.txtCartFoodName.Location = new System.Drawing.Point(777, 64);
            this.txtCartFoodName.MaxLength = 32767;
            this.txtCartFoodName.Name = "txtCartFoodName";
            this.txtCartFoodName.PasswordChar = '\0';
            this.txtCartFoodName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCartFoodName.SelectedText = "";
            this.txtCartFoodName.SelectionLength = 0;
            this.txtCartFoodName.SelectionStart = 0;
            this.txtCartFoodName.ShortcutsEnabled = true;
            this.txtCartFoodName.Size = new System.Drawing.Size(174, 23);
            this.txtCartFoodName.TabIndex = 59;
            this.txtCartFoodName.UseCustomBackColor = true;
            this.txtCartFoodName.UseCustomForeColor = true;
            this.txtCartFoodName.UseSelectable = true;
            this.txtCartFoodName.UseStyleColors = true;
            this.txtCartFoodName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCartFoodName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCartFoodType
            // 
            this.txtCartFoodType.BackColor = System.Drawing.Color.MediumSpringGreen;
            // 
            // 
            // 
            this.txtCartFoodType.CustomButton.Image = null;
            this.txtCartFoodType.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtCartFoodType.CustomButton.Name = "";
            this.txtCartFoodType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCartFoodType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCartFoodType.CustomButton.TabIndex = 1;
            this.txtCartFoodType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCartFoodType.CustomButton.UseSelectable = true;
            this.txtCartFoodType.CustomButton.Visible = false;
            this.txtCartFoodType.Enabled = false;
            this.txtCartFoodType.Lines = new string[0];
            this.txtCartFoodType.Location = new System.Drawing.Point(777, 93);
            this.txtCartFoodType.MaxLength = 32767;
            this.txtCartFoodType.Name = "txtCartFoodType";
            this.txtCartFoodType.PasswordChar = '\0';
            this.txtCartFoodType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCartFoodType.SelectedText = "";
            this.txtCartFoodType.SelectionLength = 0;
            this.txtCartFoodType.SelectionStart = 0;
            this.txtCartFoodType.ShortcutsEnabled = true;
            this.txtCartFoodType.Size = new System.Drawing.Size(174, 23);
            this.txtCartFoodType.TabIndex = 60;
            this.txtCartFoodType.UseCustomBackColor = true;
            this.txtCartFoodType.UseCustomForeColor = true;
            this.txtCartFoodType.UseSelectable = true;
            this.txtCartFoodType.UseStyleColors = true;
            this.txtCartFoodType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCartFoodType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCartPrice
            // 
            this.txtCartPrice.BackColor = System.Drawing.Color.MediumSpringGreen;
            // 
            // 
            // 
            this.txtCartPrice.CustomButton.Image = null;
            this.txtCartPrice.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtCartPrice.CustomButton.Name = "";
            this.txtCartPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCartPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCartPrice.CustomButton.TabIndex = 1;
            this.txtCartPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCartPrice.CustomButton.UseSelectable = true;
            this.txtCartPrice.CustomButton.Visible = false;
            this.txtCartPrice.Enabled = false;
            this.txtCartPrice.Lines = new string[0];
            this.txtCartPrice.Location = new System.Drawing.Point(777, 122);
            this.txtCartPrice.MaxLength = 32767;
            this.txtCartPrice.Name = "txtCartPrice";
            this.txtCartPrice.PasswordChar = '\0';
            this.txtCartPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCartPrice.SelectedText = "";
            this.txtCartPrice.SelectionLength = 0;
            this.txtCartPrice.SelectionStart = 0;
            this.txtCartPrice.ShortcutsEnabled = true;
            this.txtCartPrice.Size = new System.Drawing.Size(174, 23);
            this.txtCartPrice.TabIndex = 61;
            this.txtCartPrice.UseCustomBackColor = true;
            this.txtCartPrice.UseCustomForeColor = true;
            this.txtCartPrice.UseSelectable = true;
            this.txtCartPrice.UseStyleColors = true;
            this.txtCartPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCartPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtpTodayDate
            // 
            this.dtpTodayDate.CalendarFont = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTodayDate.CalendarForeColor = System.Drawing.Color.Gold;
            this.dtpTodayDate.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtpTodayDate.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.dtpTodayDate.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtpTodayDate.CalendarTrailingForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtpTodayDate.DisplayFocus = true;
            this.dtpTodayDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtpTodayDate.Enabled = false;
            this.dtpTodayDate.Location = new System.Drawing.Point(1068, 0);
            this.dtpTodayDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpTodayDate.Name = "dtpTodayDate";
            this.dtpTodayDate.Size = new System.Drawing.Size(200, 29);
            this.dtpTodayDate.TabIndex = 57;
            this.dtpTodayDate.UseCustomBackColor = true;
            this.dtpTodayDate.UseCustomForeColor = true;
            this.dtpTodayDate.UseStyleColors = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(901, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 26);
            this.label8.TabIndex = 55;
            this.label8.Text = "Your Cart";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 740);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(406, 19);
            this.label15.TabIndex = 50;
            this.label15.Text = "-Click a row once to select items and add to cart or remove ";
            // 
            // dgvFoodInfo
            // 
            this.dgvFoodInfo.AllowUserToAddRows = false;
            this.dgvFoodInfo.AllowUserToDeleteRows = false;
            this.dgvFoodInfo.AllowUserToResizeRows = false;
            this.dgvFoodInfo.BackgroundColor = System.Drawing.Color.Cyan;
            this.dgvFoodInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFoodInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvFoodInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFoodInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFoodInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodID,
            this.FoodName,
            this.FoodType,
            this.Price});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFoodInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFoodInfo.EnableHeadersVisualStyles = false;
            this.dgvFoodInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvFoodInfo.GridColor = System.Drawing.Color.Teal;
            this.dgvFoodInfo.Location = new System.Drawing.Point(3, 137);
            this.dgvFoodInfo.Name = "dgvFoodInfo";
            this.dgvFoodInfo.ReadOnly = true;
            this.dgvFoodInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFoodInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFoodInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFoodInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodInfo.Size = new System.Drawing.Size(654, 518);
            this.dgvFoodInfo.TabIndex = 44;
            this.dgvFoodInfo.UseCustomBackColor = true;
            this.dgvFoodInfo.UseCustomForeColor = true;
            this.dgvFoodInfo.UseStyleColors = true;
            this.dgvFoodInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFoodInfo_CellClick_1);
            // 
            // FoodID
            // 
            this.FoodID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodID.DataPropertyName = "FoodId";
            this.FoodID.HeaderText = "Food Id";
            this.FoodID.Name = "FoodID";
            this.FoodID.ReadOnly = true;
            // 
            // FoodName
            // 
            this.FoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodName.DataPropertyName = "FoodName";
            this.FoodName.HeaderText = "Food Name";
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            // 
            // FoodType
            // 
            this.FoodType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodType.DataPropertyName = "FoodType";
            this.FoodType.HeaderText = "Food Type";
            this.FoodType.Name = "FoodType";
            this.FoodType.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPlaceOrder.Location = new System.Drawing.Point(663, 669);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(212, 90);
            this.btnPlaceOrder.TabIndex = 48;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseCustomBackColor = true;
            this.btnPlaceOrder.UseCustomForeColor = true;
            this.btnPlaceOrder.UseSelectable = true;
            this.btnPlaceOrder.UseStyleColors = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.BtnPlaceOrder_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1098, 669);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 47;
            this.label6.Text = "Grand Total";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.BackColor = System.Drawing.Color.Aquamarine;
            this.lblGrandTotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblGrandTotal.ForeColor = System.Drawing.Color.Black;
            this.lblGrandTotal.Location = new System.Drawing.Point(1083, 702);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(140, 57);
            this.lblGrandTotal.TabIndex = 46;
            this.lblGrandTotal.Text = "Tk.";
            this.lblGrandTotal.UseCustomBackColor = true;
            this.lblGrandTotal.UseCustomForeColor = true;
            this.lblGrandTotal.UseStyleColors = true;
            // 
            // dgvOrderInfo
            // 
            this.dgvOrderInfo.AllowUserToAddRows = false;
            this.dgvOrderInfo.AllowUserToDeleteRows = false;
            this.dgvOrderInfo.AllowUserToResizeRows = false;
            this.dgvOrderInfo.BackgroundColor = System.Drawing.Color.Cyan;
            this.dgvOrderInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrderInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvOrderInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.UnitPrice,
            this.Quantity,
            this.TotalPrice});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderInfo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOrderInfo.EnableHeadersVisualStyles = false;
            this.dgvOrderInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvOrderInfo.GridColor = System.Drawing.Color.Teal;
            this.dgvOrderInfo.Location = new System.Drawing.Point(663, 260);
            this.dgvOrderInfo.Name = "dgvOrderInfo";
            this.dgvOrderInfo.ReadOnly = true;
            this.dgvOrderInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOrderInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOrderInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderInfo.Size = new System.Drawing.Size(597, 395);
            this.dgvOrderInfo.TabIndex = 45;
            this.dgvOrderInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOrderInfo_CellClick_1);
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemName.HeaderText = "Added Item";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalPrice.HeaderText = "Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // FormEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 847);
            this.Controls.Add(this.metroPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormEmp";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "FormEmp";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label label15;
        private MetroFramework.Controls.MetroGrid dgvFoodInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private MetroFramework.Controls.MetroButton btnPlaceOrder;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroLabel lblGrandTotal;
        private MetroFramework.Controls.MetroGrid dgvOrderInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Label label13;
        private MetroFramework.Controls.MetroButton btnRemove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroTextBox txtTotal;
        private MetroFramework.Controls.MetroButton btnAddToCart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown txtQuantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private MetroFramework.Controls.MetroTextBox txtCartFoodId;
        private MetroFramework.Controls.MetroTextBox txtCartFoodName;
        private MetroFramework.Controls.MetroTextBox txtCartFoodType;
        private MetroFramework.Controls.MetroTextBox txtCartPrice;
        private MetroFramework.Controls.MetroDateTime dtpTodayDate;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTextBox txtAutoSearch;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton btnFoodInfo;
        private MetroFramework.Controls.MetroButton btnClear;
    }
}