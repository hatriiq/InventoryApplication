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
    public class Product
    {
        public BindingList<Parts> AssociatedParts = new BindingList<Parts>();

        public int ProductID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        private decimal price;
        public string Price
        {
            get => price.ToString("C");
            set
            {
                if (!value.StartsWith("$"))
                {
                    price = decimal.Parse(value);
                }
                else
                {
                    price = decimal.Parse(value.Substring(1));
                }
            }
        }
        public int Max { get; set; }
        public int Min { get; set; }

        public Product() { }
        public Product(int productID, string name, int inStock, decimal price, int max, int min)
        {
            ProductID = productID;
            Name = name;
            InStock = inStock;
            Price = price.ToString();
            Max = max;
            Min = min;
        }
        public void AddAssociatedPart(Parts part)
        {
            AssociatedParts.Add(part);
        }
        public bool RemoveAssociatedPart(int partID)
        {
            bool successful = false;
            foreach (Parts parts in AssociatedParts)
            {
                if (parts.PartID == partID)
                {
                    AssociatedParts.Remove(parts);
                    return successful = true;
                }
                else
                {
                    successful = false;
                }
            }
            return successful;
        }
        public Parts LookupAssociatedPart(int partID)
        {
            foreach (Parts parts in AssociatedParts)
            {
                if (parts.PartID == partID)
                {
                    return parts;
                }
            }
            InHousePart emptyInHousePart = new InHousePart();
            return emptyInHousePart;
        }
    }
}