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
    public class OutsourcedPart : Parts
    {
        public string CompanyName { get; set; }
        public OutsourcedPart()
        {/*constructor*/}
        public OutsourcedPart(int partID, string name, int inStock, decimal price, int max, int min, string companyCompanyName)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price.ToString();
            Max = max;
            Min = min;
            CompanyName = companyCompanyName;
        }
    }
}