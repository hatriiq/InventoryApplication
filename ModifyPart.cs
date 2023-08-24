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
    public partial class ModifyPartScreen : Form
    {
        readonly MainScreen MainForm = (MainScreen)Application.OpenForms["MainScreen"];

        public ModifyPartScreen(InHousePart inPart)
        {
            InitializeComponent();

            ModifyPartIDBoxText = inPart.PartID;
            ModifyPartNameBoxText = inPart.Name;
            ModifyPartInventoryBoxText = inPart.InStock;
            ModifyPartPriceBoxText = decimal.Parse(inPart.Price.Substring(1));
            ModifyPartMaxBoxText = inPart.Max;
            ModifyPartMinBoxText = inPart.Min;
            ModifyPartMachineCompanyBoxText = inPart.MachineID.ToString();
        }
        public ModifyPartScreen(OutsourcedPart outPart)
        {
            InitializeComponent();

            ModifyPartIDBoxText = outPart.PartID;
            ModifyPartNameBoxText = outPart.Name;
            ModifyPartInventoryBoxText = outPart.InStock;
            ModifyPartPriceBoxText = decimal.Parse(outPart.Price.Substring(1));
            ModifyPartMaxBoxText = outPart.Max;
            ModifyPartMinBoxText = outPart.Min;
            ModifyPartMachineCompanyBoxText = outPart.CompanyName;

            radioModifyOutsourced.Checked = true;
        }
          private void BtnModifyPartSave_Click(object sender, EventArgs e)
        {
               // Exception minMax
               if (ModifyPartMaxBoxText < ModifyPartMinBoxText)
               {
                   MessageBox.Show("Minimum cannot be greater than maximum.");
                   return;
               }
            if (ModifyPartInventoryBoxText < ModifyPartMinBoxText || ModifyPartInventoryBoxText > ModifyPartMaxBoxText)
            {
                MessageBox.Show("Inventory must be between minimum and maximum.");
                return;
            }


            if (radioModifyInhouse.Checked)
               {
                   InHousePart inHouse = new InHousePart(ModifyPartIDBoxText, ModifyPartNameBoxText, ModifyPartInventoryBoxText, ModifyPartPriceBoxText, ModifyPartMaxBoxText, ModifyPartMinBoxText, int.Parse(ModifyPartMachineCompanyBoxText));
                   Inventory.UpdateInHousePart(ModifyPartIDBoxText, inHouse);
                   radioModifyInhouse.Checked = true;
               }
               else
               {
                   OutsourcedPart outSourced = new OutsourcedPart(ModifyPartIDBoxText, ModifyPartNameBoxText, ModifyPartInventoryBoxText, ModifyPartPriceBoxText, ModifyPartMaxBoxText, ModifyPartMinBoxText, ModifyPartMachineCompanyBoxText);
                   Inventory.UpdateOutsourcedPart(ModifyPartIDBoxText, outSourced);
                   radioModifyOutsourced.Checked = true;
               }
               this.Close();

            
           }
       private void RadioModifyOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (radioModifyOutsourced.Checked)
            {
                lblMachineOrCompany.Text = "Company Name"; 
                lblMachineOrCompany.Refresh(); 
            }
        }

        private void RadioModifyInhouse_CheckedChanged(object sender, EventArgs e)
        {
            if (radioModifyInhouse.Checked)
            {
                lblMachineOrCompany.Text = "Machine ID"; 
                lblMachineOrCompany.Refresh(); 
            }
        }



        private void btnModPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}