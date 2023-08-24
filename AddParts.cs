using System;
using System.Windows.Forms;

namespace WGUSOFTWARE1
{
    public partial class AddPartScreen : Form
    {
        public AddPartScreen()
        {
            InitializeComponent();
        }
        private void BtnAddPartClickSave(object sender, EventArgs e)
        {
            // minMax exception
            if (AddPartsMaximumBoxText < AddPartsMinimumBoxText)
            {
                MessageBox.Show("The maximum must be greater than the minimum.");
                return;
            }

            if (radioAddInHouse.Checked)
            {
                InHousePart inHouse = new InHousePart((Inventory.Parts.Count + 1),
                                                      AddPartsNameBoxText,
                                                      AddPartsInvBoxText,
                                                      AddPartsPriceBoxText,
                                                      AddPartsMaximumBoxText,
                                                      AddPartsMinimumBoxText,
                                                      int.Parse(AddPartsMachineComBoxText));
                Inventory.AddPart(inHouse);
            }
            else
            {
                OutsourcedPart outsourced = new OutsourcedPart((Inventory.Parts.Count + 1),
                                                               AddPartsNameBoxText,
                                                               AddPartsInvBoxText,
                                                               AddPartsPriceBoxText,
                                                               AddPartsMaximumBoxText,
                                                               AddPartsMinimumBoxText,
                                                               AddPartsMachineComBoxText);
                Inventory.AddPart(outsourced);
            }
            this.Close();
        }
        //in-house or outsourced
        private void RadioAddOutsourcedCheck(object sender, EventArgs e)
        {
            radioLabel.Text = "Company Name:";

        }
        private void RadioAddInHouseCheck(object sender, EventArgs e)
        {
            radioLabel.Text = "Machine ID:";

        }
        private void BtnAddPartsClickCancel(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddPartLoadScreen(object sender, EventArgs e)
        {

        }
    }
}