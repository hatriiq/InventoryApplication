using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WGUSOFTWARE1
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            MainScreenFormLoad();
        }

        public void MainScreenFormLoad()
        {
            Inventory.FakeProduct();

            var partsBindingSource = new BindingSource();
            partsBindingSource.DataSource = Inventory.Parts;
            mainPartsGrid.DataSource = partsBindingSource;

            mainPartsGrid.Columns["PartID"].HeaderText = "Part ID";
            mainPartsGrid.Columns["Name"].HeaderText = "Part Name";
            mainPartsGrid.Columns["InStock"].HeaderText = "Inventory";
            mainPartsGrid.Columns["Price"].HeaderText = "Price";
            mainPartsGrid.Columns["Max"].HeaderText = "Max";
            mainPartsGrid.Columns["Min"].HeaderText = "Min";
            

            var productBindingSource = new BindingSource();
            productBindingSource.DataSource = Inventory.Products;
            mainProductGrid.DataSource = productBindingSource;

            mainProductGrid.Columns["ProductID"].HeaderText = "Product ID";
            mainProductGrid.Columns["Name"].HeaderText = "Product Name";
            mainProductGrid.Columns["InStock"].HeaderText = "Inventory";
            mainProductGrid.Columns["Price"].HeaderText = "Price";
            mainProductGrid.Columns["Max"].HeaderText = "Max";
            mainProductGrid.Columns["Min"].HeaderText = "Min";
        }

        private void BtnAddPart_Click(object sender, EventArgs e)
        {
            new AddPartScreen().ShowDialog();
        }

        private void BtnModifyPart_Click(object sender, EventArgs e)
        {
            if (mainPartsGrid.CurrentRow.DataBoundItem is InHousePart inPart)
            {
                new ModifyPartScreen(inPart).ShowDialog();
            }
            else if (mainPartsGrid.CurrentRow.DataBoundItem is OutsourcedPart outPart)
            {
                new ModifyPartScreen(outPart).ShowDialog();
            }
        }
        private void BtnDeletePart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this part?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in mainPartsGrid.SelectedRows)
                {
                    mainPartsGrid.Rows.RemoveAt(row.Index);
                }
            }
        }


        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            new AddProductScreen().ShowDialog();
        }

        private void BtnModifyProduct_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)mainProductGrid.CurrentRow.DataBoundItem;
            new ModifyProductScreen(selectedProduct).ShowDialog();
        }
        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            Product prod = (Product)mainProductGrid.CurrentRow.DataBoundItem;
            if (prod.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Cannot delete product with parts associated.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in mainProductGrid.SelectedRows)
                {
                    mainProductGrid.Rows.RemoveAt(row.Index);
                }
            }
        }





        private void BtnPartsSearch_Click(object sender, EventArgs e)
        {
            int searchValue = searchBoxPartsText;

            Parts match = Inventory.SearchPart(searchValue);

            if (match != null)
            {
                foreach (DataGridViewRow row in mainPartsGrid.Rows)
                {
                    Parts part = (Parts)row.DataBoundItem;

                    if (part.PartID == match.PartID)
                    {
                        row.Selected = true;
                        mainPartsGrid.CurrentCell = row.Cells[0]; // Scroll to the selected row
                        return; 
                    }
                }

               
                MessageBox.Show("Invalid input. Please enter a valid ID number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid ID number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnProductsSearch_Click(object sender, EventArgs e)
        {
            int searchValue = searchBoxProductsText;

            Product match = Inventory.LookupProduct(searchValue);

            if (match != null)
            {
                foreach (DataGridViewRow row in mainProductGrid.Rows)
                {
                    Product prod = (Product)row.DataBoundItem;

                    if (prod.ProductID == match.ProductID)
                    {
                        row.Selected = true;
                        mainProductGrid.CurrentCell = row.Cells[0]; // Scroll to the selected row
                        return;
                    }
                }


                MessageBox.Show("Invalid input. Please enter a valid ID number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid ID number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void SearchBoxProducts_TextChanged(object sender, EventArgs e)
        {

        }
        private void SearchBoxParts_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
