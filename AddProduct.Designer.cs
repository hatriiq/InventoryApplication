namespace InventoryApplication
{
    partial class AddProductScreen
    {

        // Required variable.

        private System.ComponentModel.IContainer components = null;


        // Clean up

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        // Required method 

        private void InitializeComponent()
        {
            this.lblAddProduct = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInv = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.addProductIDBox = new System.Windows.Forms.TextBox();
            this.addProductNameBox = new System.Windows.Forms.TextBox();
            this.addProductInvBox = new System.Windows.Forms.TextBox();
            this.addProductPriceBox = new System.Windows.Forms.TextBox();
            this.addProductMaxBox = new System.Windows.Forms.TextBox();
            this.addProductMinBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.addProductSearchBox = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.addProductGridTop = new System.Windows.Forms.DataGridView();
            this.addProductGridBelow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.addProductGridTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductGridBelow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.Location = new System.Drawing.Point(13, 13);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(66, 13);
            this.lblAddProduct.TabIndex = 0;
            this.lblAddProduct.Text = "Add Product";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(15, 115);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 155);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblInv
            // 
            this.lblInv.AutoSize = true;
            this.lblInv.Location = new System.Drawing.Point(15, 195);
            this.lblInv.Name = "lblInv";
            this.lblInv.Size = new System.Drawing.Size(22, 13);
            this.lblInv.TabIndex = 3;
            this.lblInv.Text = "Inv";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(15, 235);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(15, 275);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(27, 13);
            this.lblMax.TabIndex = 5;
            this.lblMax.Text = "Max";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(135, 275);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(24, 13);
            this.lblMin.TabIndex = 6;
            this.lblMin.Text = "Min";
            // 
            // addProductIDBox
            // 
            this.addProductIDBox.Location = new System.Drawing.Point(65, 110);
            this.addProductIDBox.Name = "addProductIDBox";
            this.addProductIDBox.ReadOnly = true;
            this.addProductIDBox.Size = new System.Drawing.Size(100, 20);
            this.addProductIDBox.TabIndex = 7;
            this.addProductIDBox.Text = "No action needed.";
            // 
            // addProductNameBox
            // 
            this.addProductNameBox.Location = new System.Drawing.Point(65, 152);
            this.addProductNameBox.Name = "addProductNameBox";
            this.addProductNameBox.Size = new System.Drawing.Size(100, 20);
            this.addProductNameBox.TabIndex = 8;
            // 
            // addProductInvBox
            // 
            this.addProductInvBox.Location = new System.Drawing.Point(65, 192);
            this.addProductInvBox.Name = "addProductInvBox";
            this.addProductInvBox.Size = new System.Drawing.Size(100, 20);
            this.addProductInvBox.TabIndex = 9;
            // 
            // addProductPriceBox
            // 
            this.addProductPriceBox.Location = new System.Drawing.Point(65, 232);
            this.addProductPriceBox.Name = "addProductPriceBox";
            this.addProductPriceBox.Size = new System.Drawing.Size(100, 20);
            this.addProductPriceBox.TabIndex = 10;
            // 
            // addProductMaxBox
            // 
            this.addProductMaxBox.Location = new System.Drawing.Point(65, 272);
            this.addProductMaxBox.Name = "addProductMaxBox";
            this.addProductMaxBox.Size = new System.Drawing.Size(50, 20);
            this.addProductMaxBox.TabIndex = 11;
            // 
            // addProductMinBox
            // 
            this.addProductMinBox.Location = new System.Drawing.Point(168, 272);
            this.addProductMinBox.Name = "addProductMinBox";
            this.addProductMinBox.Size = new System.Drawing.Size(50, 20);
            this.addProductMinBox.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(440, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnClickSearch);
            // 
            // addProductSearchBox
            // 
            this.addProductSearchBox.Location = new System.Drawing.Point(530, 37);
            this.addProductSearchBox.Name = "addProductSearchBox";
            this.addProductSearchBox.Size = new System.Drawing.Size(160, 20);
            this.addProductSearchBox.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(635, 196);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnClickAdd);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(635, 366);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnClickDelete);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(540, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnClickSave);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(635, 409);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnClickCancel);
            // 
            // addProductGridTop
            // 
            this.addProductGridTop.AllowUserToAddRows = false;
            this.addProductGridTop.AllowUserToDeleteRows = false;
            this.addProductGridTop.AllowUserToResizeColumns = false;
            this.addProductGridTop.AllowUserToResizeRows = false;
            this.addProductGridTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProductGridTop.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.addProductGridTop.Location = new System.Drawing.Point(310, 70);
            this.addProductGridTop.MultiSelect = false;
            this.addProductGridTop.Name = "addProductGridTop";
            this.addProductGridTop.RowHeadersVisible = false;
            this.addProductGridTop.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.addProductGridTop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addProductGridTop.Size = new System.Drawing.Size(400, 120);
            this.addProductGridTop.TabIndex = 21;
            // 
            // addProductGridBelow
            // 
            this.addProductGridBelow.AllowUserToAddRows = false;
            this.addProductGridBelow.AllowUserToDeleteRows = false;
            this.addProductGridBelow.AllowUserToResizeColumns = false;
            this.addProductGridBelow.AllowUserToResizeRows = false;
            this.addProductGridBelow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProductGridBelow.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.addProductGridBelow.Location = new System.Drawing.Point(310, 240);
            this.addProductGridBelow.MultiSelect = false;
            this.addProductGridBelow.Name = "addProductGridBelow";
            this.addProductGridBelow.RowHeadersVisible = false;
            this.addProductGridBelow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.addProductGridBelow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addProductGridBelow.Size = new System.Drawing.Size(400, 120);
            this.addProductGridBelow.TabIndex = 22;
            // 
            // AddProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.addProductGridBelow);
            this.Controls.Add(this.addProductGridTop);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.addProductSearchBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.addProductMinBox);
            this.Controls.Add(this.addProductMaxBox);
            this.Controls.Add(this.addProductPriceBox);
            this.Controls.Add(this.addProductInvBox);
            this.Controls.Add(this.addProductNameBox);
            this.Controls.Add(this.addProductIDBox);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblInv);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAddProduct);
            this.Name = "AddProductScreen";
            ((System.ComponentModel.ISupportInitialize)(this.addProductGridTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductGridBelow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label lblAddProduct;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInv;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox addProductIDBox;
        private System.Windows.Forms.TextBox addProductNameBox;
        private System.Windows.Forms.TextBox addProductInvBox;
        private System.Windows.Forms.TextBox addProductPriceBox;
        private System.Windows.Forms.TextBox addProductMaxBox;
        private System.Windows.Forms.TextBox addProductMinBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox addProductSearchBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView addProductGridTop;
        private System.Windows.Forms.DataGridView addProductGridBelow;
        public int AddProductIDBoxText
        {
            get { return int.Parse(addProductIDBox.Text); }
            set { addProductIDBox.Text = value.ToString(); }
        }
        public string AddProductNameBoxText
        {
            get { return addProductNameBox.Text; }
            set { addProductNameBox.Text = value; }
        }
        public int AddProductInvBoxText
        {
            get { return int.Parse(addProductInvBox.Text); }
            set { addProductInvBox.Text = value.ToString(); }
        }
        public decimal AddProductPriceBoxText
        {
            get { return decimal.Parse(addProductPriceBox.Text); }
            set { addProductPriceBox.Text = value.ToString(); }
        }
        public int AddProductMinBoxText
        {
            get { return int.Parse(addProductMinBox.Text); }
            set { addProductMinBox.Text = value.ToString(); }
        }
        public int AddProductMaxBoxText
        {
            get { return int.Parse(addProductMaxBox.Text); }
            set { addProductMaxBox.Text = value.ToString(); }
        }
    }
}