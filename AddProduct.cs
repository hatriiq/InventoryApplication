using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WGUSOFTWARE1
{
    public partial class AddProductScreen : Form
    {
        BindingList<Parts> partsToAdd = new BindingList<Parts>();
        public AddProductScreen()
        {
            InitializeComponent();
            AddProductScreenLoad();
        }

        public void AddProductScreenLoad()
        {
            // The top table Parts
            var topBindingSource = new BindingSource();
            topBindingSource.DataSource = Inventory.Parts;
            addProductGridTop.DataSource = topBindingSource;
            addProductGridTop.Columns["PartID"].HeaderText = "Part ID";
            addProductGridTop.Columns["Name"].HeaderText = "Part Name";
            addProductGridTop.Columns["InStock"].HeaderText = "Inventory Level";
            addProductGridTop.Columns["Price"].HeaderText = "Price per Unit";
            addProductGridTop.Columns["Max"].Visible = false;
            addProductGridTop.Columns["Min"].Visible = false;

            // The table below is parts in product selected
            var belowBindingSource = new BindingSource();
            belowBindingSource.DataSource = partsToAdd;
            addProductGridBelow.DataSource = belowBindingSource;
            addProductGridBelow.Columns["PartID"].HeaderText = "Part ID";
            addProductGridBelow.Columns["Name"].HeaderText = "Part Name";
            addProductGridBelow.Columns["InStock"].HeaderText = "Inventory Level";
            addProductGridBelow.Columns["Price"].HeaderText = "Price per Unit";
            addProductGridBelow.Columns["Max"].Visible = false;
            addProductGridBelow.Columns["Min"].Visible = false;
        }
        private void BtnClickDelete(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in addProductGridBelow.SelectedRows)
            {
                addProductGridBelow.Rows.RemoveAt(row.Index);
            }
        }

        private void BtnClickSearch(object sender, EventArgs e)
        {
            int searchValue = int.Parse(addProductSearchBox.Text);

            Parts match = Inventory.SearchPart(searchValue);

            foreach (DataGridViewRow row in addProductGridTop.Rows)
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

        private void BtnClickAdd(object sender, EventArgs e)
        {
            Parts partToAdd = (Parts)addProductGridTop.CurrentRow.DataBoundItem;
            partsToAdd.Add(partToAdd);
        }

        private void BtnClickSave(object sender, EventArgs e)
        {
            // Exception minMax
            if (AddProductMaxBoxText < AddProductMinBoxText)
            {
                MessageBox.Show("Minimum must be less than Maximum.");
                return;
            }

            // Makes product and adds to inventory.
            Product productToAdd = new Product((Inventory.Products.Count + 1),
                                               AddProductNameBoxText,
                                               AddProductInvBoxText,
                                               AddProductPriceBoxText,
                                               AddProductMaxBoxText,
                                               AddProductMinBoxText);
            Inventory.AddProduct(productToAdd);

            foreach (Parts part in partsToAdd)
            {
                productToAdd.AddAssociatedPart(part);
            }
            this.Close();
        }

        private void BtnClickCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
