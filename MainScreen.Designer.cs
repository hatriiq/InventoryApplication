using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApplication
{
    partial class MainScreen
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
            this.labelHome = new System.Windows.Forms.Label();
            this.lblParts = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.btnPartsSearch = new System.Windows.Forms.Button();
            this.btnProductsSearch = new System.Windows.Forms.Button();
            this.searchBoxParts = new System.Windows.Forms.TextBox();
            this.searchBoxProducts = new System.Windows.Forms.TextBox();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnModifyPart = new System.Windows.Forms.Button();
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBoxProducts = new System.Windows.Forms.GroupBox();
            this.mainProductGrid = new System.Windows.Forms.DataGridView();
            this.groupBoxParts = new System.Windows.Forms.GroupBox();
            this.mainPartsGrid = new System.Windows.Forms.DataGridView();
            this.groupBoxProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainProductGrid)).BeginInit();
            this.groupBoxParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPartsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Location = new System.Drawing.Point(13, 13);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(35, 13);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "Home";
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Location = new System.Drawing.Point(6, 16);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(31, 13);
            this.lblParts.TabIndex = 1;
            this.lblParts.Text = "Parts";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(6, 16);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(49, 13);
            this.lblProducts.TabIndex = 2;
            this.lblProducts.Text = "Products";
            // 
            // btnPartsSearch
            // 
            this.btnPartsSearch.Location = new System.Drawing.Point(65, 16);
            this.btnPartsSearch.Name = "btnPartsSearch";
            this.btnPartsSearch.Size = new System.Drawing.Size(75, 23);
            this.btnPartsSearch.TabIndex = 3;
            this.btnPartsSearch.Text = "Search";
            this.btnPartsSearch.UseVisualStyleBackColor = true;
            this.btnPartsSearch.Click += new System.EventHandler(this.BtnPartsSearch_Click);
            // 
            // btnProductsSearch
            // 
            this.btnProductsSearch.Location = new System.Drawing.Point(62, 16);
            this.btnProductsSearch.Name = "btnProductsSearch";
            this.btnProductsSearch.Size = new System.Drawing.Size(75, 23);
            this.btnProductsSearch.TabIndex = 4;
            this.btnProductsSearch.Text = "Search";
            this.btnProductsSearch.UseVisualStyleBackColor = true;
            this.btnProductsSearch.Click += new System.EventHandler(this.BtnProductsSearch_Click);
            // 
            // searchBoxParts
            // 
            this.searchBoxParts.Location = new System.Drawing.Point(146, 19);
            this.searchBoxParts.Name = "searchBoxParts";
            this.searchBoxParts.Size = new System.Drawing.Size(293, 20);
            this.searchBoxParts.TabIndex = 5;
            this.searchBoxParts.TextChanged += new System.EventHandler(this.SearchBoxParts_TextChanged);
            // 
            // searchBoxProducts
            // 
            this.searchBoxProducts.Location = new System.Drawing.Point(143, 19);
            this.searchBoxProducts.Name = "searchBoxProducts";
            this.searchBoxProducts.Size = new System.Drawing.Size(293, 20);
            this.searchBoxProducts.TabIndex = 6;
            this.searchBoxProducts.TextChanged += new System.EventHandler(this.SearchBoxProducts_TextChanged);
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(0, 211);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(75, 23);
            this.btnAddPart.TabIndex = 0;
            this.btnAddPart.Text = "Add";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.BtnAddPart_Click);
            // 
            // btnModifyPart
            // 
            this.btnModifyPart.Location = new System.Drawing.Point(81, 211);
            this.btnModifyPart.Name = "btnModifyPart";
            this.btnModifyPart.Size = new System.Drawing.Size(75, 23);
            this.btnModifyPart.TabIndex = 1;
            this.btnModifyPart.Text = "Modify";
            this.btnModifyPart.UseVisualStyleBackColor = true;
            this.btnModifyPart.Click += new System.EventHandler(this.BtnModifyPart_Click);
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.Location = new System.Drawing.Point(162, 211);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePart.TabIndex = 2;
            this.btnDeletePart.Text = "Delete";
            this.btnDeletePart.UseVisualStyleBackColor = true;
            this.btnDeletePart.Click += new System.EventHandler(this.BtnDeletePart_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(6, 211);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Location = new System.Drawing.Point(87, 211);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(75, 23);
            this.btnModifyProduct.TabIndex = 1;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = true;
            this.btnModifyProduct.Click += new System.EventHandler(this.BtnModifyProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(168, 211);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProduct.TabIndex = 2;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.BtnDeleteProduct_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(334, 211);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 30);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // groupBoxProducts
            // 
            this.groupBoxProducts.Controls.Add(this.btnExit);
            this.groupBoxProducts.Controls.Add(this.btnDeleteProduct);
            this.groupBoxProducts.Controls.Add(this.lblProducts);
            this.groupBoxProducts.Controls.Add(this.searchBoxProducts);
            this.groupBoxProducts.Controls.Add(this.mainProductGrid);
            this.groupBoxProducts.Controls.Add(this.btnProductsSearch);
            this.groupBoxProducts.Controls.Add(this.btnModifyProduct);
            this.groupBoxProducts.Controls.Add(this.btnAddProduct);
            this.groupBoxProducts.Location = new System.Drawing.Point(595, 29);
            this.groupBoxProducts.Name = "groupBoxProducts";
            this.groupBoxProducts.Size = new System.Drawing.Size(533, 245);
            this.groupBoxProducts.TabIndex = 12;
            this.groupBoxProducts.TabStop = false;
            // 
            // mainProductGrid
            // 
            this.mainProductGrid.AllowUserToAddRows = false;
            this.mainProductGrid.AllowUserToDeleteRows = false;
            this.mainProductGrid.AllowUserToResizeColumns = false;
            this.mainProductGrid.AllowUserToResizeRows = false;
            this.mainProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainProductGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mainProductGrid.Location = new System.Drawing.Point(0, 45);
            this.mainProductGrid.MultiSelect = false;
            this.mainProductGrid.Name = "mainProductGrid";
            this.mainProductGrid.RowHeadersVisible = false;
            this.mainProductGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainProductGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainProductGrid.Size = new System.Drawing.Size(527, 160);
            this.mainProductGrid.TabIndex = 0;
            // 
            // groupBoxParts
            // 
            this.groupBoxParts.Controls.Add(this.btnAddPart);
            this.groupBoxParts.Controls.Add(this.mainPartsGrid);
            this.groupBoxParts.Controls.Add(this.lblParts);
            this.groupBoxParts.Controls.Add(this.btnDeletePart);
            this.groupBoxParts.Controls.Add(this.btnModifyPart);
            this.groupBoxParts.Controls.Add(this.btnPartsSearch);
            this.groupBoxParts.Controls.Add(this.searchBoxParts);
            this.groupBoxParts.Location = new System.Drawing.Point(26, 29);
            this.groupBoxParts.Name = "groupBoxParts";
            this.groupBoxParts.Size = new System.Drawing.Size(550, 245);
            this.groupBoxParts.TabIndex = 13;
            this.groupBoxParts.TabStop = false;
            // 
            // mainPartsGrid
            // 
            this.mainPartsGrid.AllowUserToAddRows = false;
            this.mainPartsGrid.AllowUserToDeleteRows = false;
            this.mainPartsGrid.AllowUserToResizeColumns = false;
            this.mainPartsGrid.AllowUserToResizeRows = false;
            this.mainPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainPartsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mainPartsGrid.Location = new System.Drawing.Point(2, 45);
            this.mainPartsGrid.MultiSelect = false;
            this.mainPartsGrid.Name = "mainPartsGrid";
            this.mainPartsGrid.RowHeadersVisible = false;
            this.mainPartsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainPartsGrid.Size = new System.Drawing.Size(542, 160);
            this.mainPartsGrid.TabIndex = 6;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1140, 276);
            this.Controls.Add(this.labelHome);
            this.Controls.Add(this.groupBoxProducts);
            this.Controls.Add(this.groupBoxParts);
            this.Name = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.groupBoxProducts.ResumeLayout(false);
            this.groupBoxProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainProductGrid)).EndInit();
            this.groupBoxParts.ResumeLayout(false);
            this.groupBoxParts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPartsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Button btnPartsSearch;
        private System.Windows.Forms.Button btnProductsSearch;
        private System.Windows.Forms.TextBox searchBoxParts;
        private System.Windows.Forms.TextBox searchBoxProducts;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnModifyPart;
        private System.Windows.Forms.Button btnDeletePart;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBoxProducts;
        private System.Windows.Forms.GroupBox groupBoxParts;
        public System.Windows.Forms.DataGridView mainProductGrid;
        public System.Windows.Forms.DataGridView mainPartsGrid;

        public int searchBoxPartsText
        {
            get
            {
                int result;
                if (int.TryParse(searchBoxParts.Text, out result))
                {
                    return result;
                }
                return 0; // Default value if parsing fails
            }
            set { searchBoxParts.Text = value.ToString(); }
        }

        public int searchBoxProductsText
        {
            get
            {
                int result;
                if (int.TryParse(searchBoxProducts.Text, out result))
                {
                    return result;
                }
                return 0; // Default value if parsing fails
            }
            set { searchBoxProducts.Text = value.ToString(); }
        }
    }   
}
