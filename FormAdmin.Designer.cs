namespace RestaurantManagement
{
    partial class FormAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.btnFoodInfo = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtAutoSearch = new MetroFramework.Controls.MetroTextBox();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.dgvFoodInfo = new MetroFramework.Controls.MetroGrid();
            this.FoodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtFoodType = new MetroFramework.Controls.MetroTextBox();
            this.txtFoodName = new MetroFramework.Controls.MetroTextBox();
            this.txtFoodId = new MetroFramework.Controls.MetroTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRemoveUser = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnClearUserInfo = new MetroFramework.Controls.MetroButton();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.labelrole = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvUserInfo = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnSearch);
            this.metroPanel1.Controls.Add(this.btnFoodInfo);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 29);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(135, 268);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(0, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnFoodInfo
            // 
            this.btnFoodInfo.Location = new System.Drawing.Point(3, 81);
            this.btnFoodInfo.Name = "btnFoodInfo";
            this.btnFoodInfo.Size = new System.Drawing.Size(129, 54);
            this.btnFoodInfo.TabIndex = 2;
            this.btnFoodInfo.Text = "Foods";
            this.btnFoodInfo.UseSelectable = true;
            this.btnFoodInfo.Click += new System.EventHandler(this.BtnFoodInfo_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Blue;
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.txtAutoSearch);
            this.metroPanel2.Controls.Add(this.txtSearch);
            this.metroPanel2.Controls.Add(this.dgvFoodInfo);
            this.metroPanel2.Controls.Add(this.metroGrid1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(164, 29);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(506, 268);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(45, 12);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(97, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Search By Type";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(337, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(138, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Auto Search By Name";
            // 
            // txtAutoSearch
            // 
            // 
            // 
            // 
            this.txtAutoSearch.CustomButton.Image = null;
            this.txtAutoSearch.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtAutoSearch.CustomButton.Name = "";
            this.txtAutoSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAutoSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAutoSearch.CustomButton.TabIndex = 1;
            this.txtAutoSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAutoSearch.CustomButton.UseSelectable = true;
            this.txtAutoSearch.CustomButton.Visible = false;
            this.txtAutoSearch.Lines = new string[0];
            this.txtAutoSearch.Location = new System.Drawing.Point(315, 34);
            this.txtAutoSearch.MaxLength = 32767;
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.PasswordChar = '\0';
            this.txtAutoSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAutoSearch.SelectedText = "";
            this.txtAutoSearch.SelectionLength = 0;
            this.txtAutoSearch.SelectionStart = 0;
            this.txtAutoSearch.ShortcutsEnabled = true;
            this.txtAutoSearch.Size = new System.Drawing.Size(187, 23);
            this.txtAutoSearch.TabIndex = 5;
            this.txtAutoSearch.UseSelectable = true;
            this.txtAutoSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAutoSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAutoSearch.Click += new System.EventHandler(this.TxtAutoSearch_Click);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(0, 34);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(189, 23);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvFoodInfo
            // 
            this.dgvFoodInfo.AllowUserToAddRows = false;
            this.dgvFoodInfo.AllowUserToDeleteRows = false;
            this.dgvFoodInfo.AllowUserToResizeRows = false;
            this.dgvFoodInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvFoodInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFoodInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
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
            this.dgvFoodInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvFoodInfo.Location = new System.Drawing.Point(3, 81);
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
            this.dgvFoodInfo.Size = new System.Drawing.Size(499, 187);
            this.dgvFoodInfo.TabIndex = 3;
            this.dgvFoodInfo.DoubleClick += new System.EventHandler(this.DgvFoodInfo_DoubleClick);
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
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(-170, -75);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(240, 150);
            this.metroGrid1.TabIndex = 2;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.btnDelete);
            this.metroPanel3.Controls.Add(this.btnClear);
            this.metroPanel3.Controls.Add(this.btnSave);
            this.metroPanel3.Controls.Add(this.label4);
            this.metroPanel3.Controls.Add(this.label3);
            this.metroPanel3.Controls.Add(this.label2);
            this.metroPanel3.Controls.Add(this.label1);
            this.metroPanel3.Controls.Add(this.txtPrice);
            this.metroPanel3.Controls.Add(this.txtFoodType);
            this.metroPanel3.Controls.Add(this.txtFoodName);
            this.metroPanel3.Controls.Add(this.txtFoodId);
            this.metroPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(672, 29);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(510, 268);
            this.metroPanel3.TabIndex = 9;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(419, 170);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 62);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(419, 102);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(73, 62);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(419, 34);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 62);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Food Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Food Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Food Id";
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(157, 172);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(149, 23);
            this.txtPrice.TabIndex = 15;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFoodType
            // 
            // 
            // 
            // 
            this.txtFoodType.CustomButton.Image = null;
            this.txtFoodType.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtFoodType.CustomButton.Name = "";
            this.txtFoodType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFoodType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFoodType.CustomButton.TabIndex = 1;
            this.txtFoodType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFoodType.CustomButton.UseSelectable = true;
            this.txtFoodType.CustomButton.Visible = false;
            this.txtFoodType.Lines = new string[0];
            this.txtFoodType.Location = new System.Drawing.Point(157, 138);
            this.txtFoodType.MaxLength = 32767;
            this.txtFoodType.Name = "txtFoodType";
            this.txtFoodType.PasswordChar = '\0';
            this.txtFoodType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFoodType.SelectedText = "";
            this.txtFoodType.SelectionLength = 0;
            this.txtFoodType.SelectionStart = 0;
            this.txtFoodType.ShortcutsEnabled = true;
            this.txtFoodType.Size = new System.Drawing.Size(149, 23);
            this.txtFoodType.TabIndex = 14;
            this.txtFoodType.UseSelectable = true;
            this.txtFoodType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFoodType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFoodName
            // 
            // 
            // 
            // 
            this.txtFoodName.CustomButton.Image = null;
            this.txtFoodName.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtFoodName.CustomButton.Name = "";
            this.txtFoodName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFoodName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFoodName.CustomButton.TabIndex = 1;
            this.txtFoodName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFoodName.CustomButton.UseSelectable = true;
            this.txtFoodName.CustomButton.Visible = false;
            this.txtFoodName.Lines = new string[0];
            this.txtFoodName.Location = new System.Drawing.Point(157, 86);
            this.txtFoodName.MaxLength = 32767;
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.PasswordChar = '\0';
            this.txtFoodName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFoodName.SelectedText = "";
            this.txtFoodName.SelectionLength = 0;
            this.txtFoodName.SelectionStart = 0;
            this.txtFoodName.ShortcutsEnabled = true;
            this.txtFoodName.Size = new System.Drawing.Size(149, 23);
            this.txtFoodName.TabIndex = 13;
            this.txtFoodName.UseSelectable = true;
            this.txtFoodName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFoodName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFoodId
            // 
            // 
            // 
            // 
            this.txtFoodId.CustomButton.Image = null;
            this.txtFoodId.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtFoodId.CustomButton.Name = "";
            this.txtFoodId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFoodId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFoodId.CustomButton.TabIndex = 1;
            this.txtFoodId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFoodId.CustomButton.UseSelectable = true;
            this.txtFoodId.CustomButton.Visible = false;
            this.txtFoodId.Enabled = false;
            this.txtFoodId.Lines = new string[0];
            this.txtFoodId.Location = new System.Drawing.Point(157, 52);
            this.txtFoodId.MaxLength = 32767;
            this.txtFoodId.Name = "txtFoodId";
            this.txtFoodId.PasswordChar = '\0';
            this.txtFoodId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFoodId.SelectedText = "";
            this.txtFoodId.SelectionLength = 0;
            this.txtFoodId.SelectionStart = 0;
            this.txtFoodId.ShortcutsEnabled = true;
            this.txtFoodId.Size = new System.Drawing.Size(149, 23);
            this.txtFoodId.TabIndex = 12;
            this.txtFoodId.UseSelectable = true;
            this.txtFoodId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFoodId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRemoveUser);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.btnClearUserInfo);
            this.panel3.Controls.Add(this.txtRole);
            this.panel3.Controls.Add(this.txtUserPassword);
            this.panel3.Controls.Add(this.txtUserId);
            this.panel3.Controls.Add(this.labelrole);
            this.panel3.Controls.Add(this.labelpassword);
            this.panel3.Controls.Add(this.labelid);
            this.panel3.Location = new System.Drawing.Point(23, 303);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(358, 197);
            this.panel3.TabIndex = 12;
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(267, 139);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(74, 55);
            this.btnRemoveUser.TabIndex = 13;
            this.btnRemoveUser.Text = "Remove";
            this.btnRemoveUser.UseSelectable = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.BtnRemoveUser_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(267, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 54);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnClearUserInfo
            // 
            this.btnClearUserInfo.Location = new System.Drawing.Point(267, 71);
            this.btnClearUserInfo.Name = "btnClearUserInfo";
            this.btnClearUserInfo.Size = new System.Drawing.Size(74, 50);
            this.btnClearUserInfo.TabIndex = 12;
            this.btnClearUserInfo.Text = "Clear";
            this.btnClearUserInfo.UseSelectable = true;
            this.btnClearUserInfo.Click += new System.EventHandler(this.BtnClearUserInfo_Click);
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(98, 133);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(141, 20);
            this.txtRole.TabIndex = 5;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(98, 82);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(141, 20);
            this.txtUserPassword.TabIndex = 4;
            // 
            // txtUserId
            // 
            this.txtUserId.Enabled = false;
            this.txtUserId.Location = new System.Drawing.Point(98, 37);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(141, 20);
            this.txtUserId.TabIndex = 3;
            // 
            // labelrole
            // 
            this.labelrole.AutoSize = true;
            this.labelrole.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrole.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelrole.Location = new System.Drawing.Point(1, 133);
            this.labelrole.Name = "labelrole";
            this.labelrole.Size = new System.Drawing.Size(41, 17);
            this.labelrole.TabIndex = 2;
            this.labelrole.Text = "Role";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelpassword.Location = new System.Drawing.Point(1, 85);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(80, 17);
            this.labelpassword.TabIndex = 1;
            this.labelpassword.Text = "Password";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelid.Location = new System.Drawing.Point(1, 40);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(61, 17);
            this.labelid.TabIndex = 0;
            this.labelid.Text = "User Id";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvUserInfo);
            this.panel4.Location = new System.Drawing.Point(23, 506);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(358, 207);
            this.panel4.TabIndex = 13;
            // 
            // dgvUserInfo
            // 
            this.dgvUserInfo.AllowUserToAddRows = false;
            this.dgvUserInfo.AllowUserToDeleteRows = false;
            this.dgvUserInfo.AllowUserToResizeRows = false;
            this.dgvUserInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUserInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Password,
            this.Role});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserInfo.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUserInfo.EnableHeadersVisualStyles = false;
            this.dgvUserInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvUserInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvUserInfo.Location = new System.Drawing.Point(0, 3);
            this.dgvUserInfo.Name = "dgvUserInfo";
            this.dgvUserInfo.ReadOnly = true;
            this.dgvUserInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvUserInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUserInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserInfo.Size = new System.Drawing.Size(355, 191);
            this.dgvUserInfo.TabIndex = 0;
            this.dgvUserInfo.DoubleClick += new System.EventHandler(this.DgvUserInfo_DoubleClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "UserId";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 736);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Name = "FormAdmin";
            this.TransparencyKey = System.Drawing.Color.MidnightBlue;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnFoodInfo;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid dgvFoodInfo;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroTextBox txtAutoSearch;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroTextBox txtFoodType;
        private MetroFramework.Controls.MetroTextBox txtFoodName;
        private MetroFramework.Controls.MetroTextBox txtFoodId;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label labelrole;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label labelid;
        private MetroFramework.Controls.MetroButton btnRemoveUser;
        private MetroFramework.Controls.MetroButton btnClearUserInfo;
        private MetroFramework.Controls.MetroButton btnAdd;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroGrid dgvUserInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}