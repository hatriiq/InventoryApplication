namespace WGUSOFTWARE1
{
    partial class AddPartScreen
    {

        // Required variable

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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAddParts = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInv = new System.Windows.Forms.Label();
            this.lblPriceCost = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.radioLabel = new System.Windows.Forms.Label();
            this.btnAddPartSave = new System.Windows.Forms.Button();
            this.btnAddPartCancel = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.addPartsIDBox = new System.Windows.Forms.TextBox();
            this.addPartsNameBox = new System.Windows.Forms.TextBox();
            this.addPartsInvBox = new System.Windows.Forms.TextBox();
            this.addPartPriceBox = new System.Windows.Forms.TextBox();
            this.addPartsMachineComBox = new System.Windows.Forms.TextBox();
            this.addPartsMaxBox = new System.Windows.Forms.TextBox();
            this.addPartsMinBox = new System.Windows.Forms.TextBox();
            this.radioAddOutsourced = new System.Windows.Forms.RadioButton();
            this.radioAddInHouse = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblAddPart
            // 
            this.lblAddParts.AutoSize = true;
            this.lblAddParts.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblAddParts.Location = new System.Drawing.Point(13, 13);
            this.lblAddParts.Name = "lblAddPart";
            this.lblAddParts.Size = new System.Drawing.Size(53, 13);
            this.lblAddParts.TabIndex = 0;
            this.lblAddParts.Text = "Add Parts";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblID.Location = new System.Drawing.Point(45, 70);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblName.Location = new System.Drawing.Point(45, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblInv
            // 
            this.lblInv.AutoSize = true;
            this.lblInv.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblInv.Location = new System.Drawing.Point(45, 150);
            this.lblInv.Name = "lblInv";
            this.lblInv.Size = new System.Drawing.Size(22, 13);
            this.lblInv.TabIndex = 5;
            this.lblInv.Text = "Inv";
            // 
            // lblPriceCost
            // 
            this.lblPriceCost.AutoSize = true;
            this.lblPriceCost.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblPriceCost.Location = new System.Drawing.Point(45, 190);
            this.lblPriceCost.Name = "lblPriceCost";
            this.lblPriceCost.Size = new System.Drawing.Size(31, 13);
            this.lblPriceCost.TabIndex = 6;
            this.lblPriceCost.Text = "Price";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblMax.Location = new System.Drawing.Point(45, 230);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(27, 13);
            this.lblMax.TabIndex = 7;
            this.lblMax.Text = "Max";
            // 
            // radioLabel
            // 
            this.radioLabel.AutoSize = true;
            this.radioLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.radioLabel.Location = new System.Drawing.Point(45, 270);
            this.radioLabel.Name = "radioLabel";
            this.radioLabel.Size = new System.Drawing.Size(62, 13);
            this.radioLabel.TabIndex = 9;
            this.radioLabel.Text = "Machine ID";
            // 
            // btnAddPartSave
            // 
            this.btnAddPartSave.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnAddPartSave.Location = new System.Drawing.Point(130, 293);
            this.btnAddPartSave.Name = "btnAddPartSave";
            this.btnAddPartSave.Size = new System.Drawing.Size(75, 23);
            this.btnAddPartSave.TabIndex = 9;
            this.btnAddPartSave.Text = "Save";
            this.btnAddPartSave.UseVisualStyleBackColor = true;
            this.btnAddPartSave.Click += new System.EventHandler(this.BtnAddPartClickSave);
            // 
            // btnAddPartCancel
            // 
            this.btnAddPartCancel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnAddPartCancel.Location = new System.Drawing.Point(210, 293);
            this.btnAddPartCancel.Name = "btnAddPartCancel";
            this.btnAddPartCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAddPartCancel.TabIndex = 10;
            this.btnAddPartCancel.Text = "Cancel";
            this.btnAddPartCancel.UseVisualStyleBackColor = true;
            this.btnAddPartCancel.Click += new System.EventHandler(this.BtnAddPartsClickCancel);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblMin.Location = new System.Drawing.Point(220, 230);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(24, 13);
            this.lblMin.TabIndex = 8;
            this.lblMin.Text = "Min";
            // 
            // addPartIDBox
            // 
            this.addPartsIDBox.Location = new System.Drawing.Point(130, 67);
            this.addPartsIDBox.Name = "addPartIDBox";
            this.addPartsIDBox.ReadOnly = true;
            this.addPartsIDBox.Size = new System.Drawing.Size(120, 20);
            this.addPartsIDBox.TabIndex = 12;
            // 
            // addPartNameBox
            // 
            this.addPartsNameBox.Location = new System.Drawing.Point(130, 107);
            this.addPartsNameBox.Name = "addPartNameBox";
            this.addPartsNameBox.Size = new System.Drawing.Size(120, 20);
            this.addPartsNameBox.TabIndex = 13;
            // 
            // addPartInvBox
            // 
            this.addPartsInvBox.Location = new System.Drawing.Point(130, 147);
            this.addPartsInvBox.Name = "addPartInvBox";
            this.addPartsInvBox.Size = new System.Drawing.Size(120, 20);
            this.addPartsInvBox.TabIndex = 14;
            // 
            // addPartPriceBox
            // 
            this.addPartPriceBox.Location = new System.Drawing.Point(130, 187);
            this.addPartPriceBox.Name = "addPartPriceBox";
            this.addPartPriceBox.Size = new System.Drawing.Size(120, 20);
            this.addPartPriceBox.TabIndex = 15;
            // 
            // addPartMachComBox
            // 
            this.addPartsMachineComBox.Location = new System.Drawing.Point(130, 267);
            this.addPartsMachineComBox.Name = "addPartMachComBox";
            this.addPartsMachineComBox.Size = new System.Drawing.Size(120, 20);
            this.addPartsMachineComBox.TabIndex = 18;
            // 
            // addPartMaxBox
            // 
            this.addPartsMaxBox.Location = new System.Drawing.Point(130, 227);
            this.addPartsMaxBox.Name = "addPartMaxBox";
            this.addPartsMaxBox.Size = new System.Drawing.Size(60, 20);
            this.addPartsMaxBox.TabIndex = 16;
            // 
            // addPartMinBox
            // 
            this.addPartsMinBox.Location = new System.Drawing.Point(260, 227);
            this.addPartsMinBox.Name = "addPartMinBox";
            this.addPartsMinBox.Size = new System.Drawing.Size(60, 20);
            this.addPartsMinBox.TabIndex = 17;
            // 
            // radioAddOutsourced
            // 
            this.radioAddOutsourced.AutoSize = true;
            this.radioAddOutsourced.ForeColor = System.Drawing.SystemColors.InfoText;
            this.radioAddOutsourced.Location = new System.Drawing.Point(210, 25);
            this.radioAddOutsourced.Name = "radioAddOutsourced";
            this.radioAddOutsourced.Size = new System.Drawing.Size(80, 17);
            this.radioAddOutsourced.TabIndex = 2;
            this.radioAddOutsourced.TabStop = true;
            this.radioAddOutsourced.Text = "Outsourced";
            this.radioAddOutsourced.UseVisualStyleBackColor = true;
            this.radioAddOutsourced.CheckedChanged += new System.EventHandler(this.RadioAddOutsourcedCheck);
            // 
            // radioAddInHouse
            // 
            this.radioAddInHouse.AutoSize = true;
            this.radioAddInHouse.Checked = true;
            this.radioAddInHouse.ForeColor = System.Drawing.SystemColors.InfoText;
            this.radioAddInHouse.Location = new System.Drawing.Point(110, 25);
            this.radioAddInHouse.Name = "radioAddInHouse";
            this.radioAddInHouse.Size = new System.Drawing.Size(68, 17);
            this.radioAddInHouse.TabIndex = 1;
            this.radioAddInHouse.TabStop = true;
            this.radioAddInHouse.Text = "In-House";
            this.radioAddInHouse.UseVisualStyleBackColor = true;
            this.radioAddInHouse.CheckedChanged += new System.EventHandler(this.RadioAddInHouseCheck);
            // 
            // AddPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(330, 324);
            this.Controls.Add(this.addPartsMinBox);
            this.Controls.Add(this.addPartsMaxBox);
            this.Controls.Add(this.addPartsMachineComBox);
            this.Controls.Add(this.addPartPriceBox);
            this.Controls.Add(this.addPartsInvBox);
            this.Controls.Add(this.addPartsNameBox);
            this.Controls.Add(this.addPartsIDBox);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.btnAddPartCancel);
            this.Controls.Add(this.btnAddPartSave);
            this.Controls.Add(this.radioLabel);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblPriceCost);
            this.Controls.Add(this.lblInv);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.radioAddOutsourced);
            this.Controls.Add(this.radioAddInHouse);
            this.Controls.Add(this.lblAddParts);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "AddPartScreen";
            this.Load += new System.EventHandler(this.AddPartLoadScreen);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddParts;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInv;
        private System.Windows.Forms.Label lblPriceCost;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label radioLabel;
        private System.Windows.Forms.Button btnAddPartSave;
        private System.Windows.Forms.Button btnAddPartCancel;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox addPartsIDBox;
        private System.Windows.Forms.TextBox addPartsNameBox;
        private System.Windows.Forms.TextBox addPartsInvBox;
        private System.Windows.Forms.TextBox addPartPriceBox;
        private System.Windows.Forms.TextBox addPartsMachineComBox;
        private System.Windows.Forms.TextBox addPartsMaxBox;
        private System.Windows.Forms.TextBox addPartsMinBox;
        private System.Windows.Forms.RadioButton radioAddOutsourced;
        private System.Windows.Forms.RadioButton radioAddInHouse;

        public int AddPartsIDBoxText
        {
            get { return int.Parse(addPartsIDBox.Text); }
            set { addPartsIDBox.Text = value.ToString(); }
        }
        public string AddPartsNameBoxText
        {
            get { return addPartsNameBox.Text; }
            set { addPartsNameBox.Text = value; }
        }
        public int AddPartsInvBoxText
        {
            get { return int.Parse(addPartsInvBox.Text); }
            set { addPartsInvBox.Text = value.ToString(); }
        }
        public decimal AddPartsPriceBoxText
        {
            get { return decimal.Parse(addPartPriceBox.Text); }
            set { addPartPriceBox.Text = value.ToString(); }
        }
        public int AddPartsMaximumBoxText
        {
            get { return int.Parse(addPartsMaxBox.Text); }
            set { addPartsMaxBox.Text = value.ToString(); }
        }
        public int AddPartsMinimumBoxText
        {
            get { return int.Parse(addPartsMinBox.Text); }
            set { addPartsMinBox.Text = value.ToString(); }
        }
        public string AddPartsMachineComBoxText
        {
            get { return addPartsMachineComBox.Text; }
            set { addPartsMachineComBox.Text = value; }
        }
    }
}
