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
    public partial class ModifyProductScreen : Form
    {
        readonly BindingList<Parts> partsToAdd = new BindingList<Parts>();
        readonly MainScreen MainForm = (MainScreen)Application.OpenForms["MainScreen"];

        public ModifyProductScreen(Product prod)
        {
            InitializeComponent();
            ModifyProductScreenLoad(prod);
        }

        public void ModifyProductScreenLoad(Product selectedProd)
        {
            //prepopulated with selected data
            ModifyProductIDBoxText = selectedProd.ProductID;
            ModifyProductNameBoxText = selectedProd.Name;
            ModifyProductInvBoxText = selectedProd.InStock;
            ModifyProductPriceBoxText = decimal.Parse(selectedProd.Price.Substring(1));
            ModifyProductMaxBoxText = selectedProd.Max;
            ModifyProductMinBoxText = selectedProd.Min;

            // table of all parts
            var bindingSourceA = new BindingSource();
            bindingSourceA.DataSource = Inventory.Parts;
            modifyProductGrid1.DataSource = bindingSourceA;
            modifyProductGrid1.Columns["PartID"].HeaderText = "Part ID";
            modifyProductGrid1.Columns["Name"].HeaderText = "Part Name";
            modifyProductGrid1.Columns["InStock"].HeaderText = "Inventory amount";
            modifyProductGrid1.Columns["Price"].HeaderText = "Price";
            modifyProductGrid1.Columns["Max"].Visible = false;
            modifyProductGrid1.Columns["Min"].Visible = false;

            // parts in products
            foreach (Parts part in selectedProd.AssociatedParts)
            {
                partsToAdd.Add(part);
            }

            var bindingSourceB = new BindingSource();
            bindingSourceB.DataSource = partsToAdd;
            modifyProductGrid2.DataSource = bindingSourceB;
            modifyProductGrid2.Columns["PartID"].HeaderText = "Part ID";
            modifyProductGrid2.Columns["Name"].HeaderText = "Part Name";
            modifyProductGrid2.Columns["InStock"].HeaderText = "Inventory amount";
            modifyProductGrid2.Columns["Price"].HeaderText = "Price";
            modifyProductGrid2.Columns["Max"].Visible = false;
            modifyProductGrid2.Columns["Min"].Visible = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Parts currentPart = (Parts)modifyProductGrid2.CurrentRow.DataBoundItem;

            int lookupID = this.ModifyProductIDBoxText;
            Product currentProd = Inventory.LookupProduct(lookupID);

            DialogResult result = MessageBox.Show("Are you sure you want to remove this part from the product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                currentProd.RemoveAssociatedPart(currentPart.PartID);

                foreach (DataGridViewRow row in modifyProductGrid2.SelectedRows)
                {
                    modifyProductGrid2.Rows.RemoveAt(row.Index);
                }
            }
        }


        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // Search by partID
            int searchValue = int.Parse(searchBoxModifyProduct.Text);

            Parts match = Inventory.SearchPart(searchValue);

            foreach (DataGridViewRow row in modifyProductGrid1.Rows)
            {
                Parts part = (Parts)row.DataBoundItem;

                if (part.PartID == match.PartID)
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Parts partToAdd = (Parts)modifyProductGrid1.CurrentRow.DataBoundItem;
            partsToAdd.Add(partToAdd);
        }

        private void BtnSaveModProduct_Click(object sender, EventArgs e)
        {
            // Exception minMax
            if (ModifyProductMaxBoxText < ModifyProductMinBoxText)
            {
                MessageBox.Show("Maximum must be greater than minimum.");
                return;
            }

            Product updatedProduct = new Product(ModifyProductIDBoxText, ModifyProductNameBoxText, ModifyProductInvBoxText, ModifyProductPriceBoxText, ModifyProductMaxBoxText, ModifyProductMinBoxText);

            foreach (Parts newPart in partsToAdd)
            {
                updatedProduct.AddAssociatedPart(newPart);
            }

            Inventory.UpdateProduct(ModifyProductIDBoxText, updatedProduct);
             this.Close();


            MainForm.mainProductGrid.Refresh();
        }
        private void BtnCancelModProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}