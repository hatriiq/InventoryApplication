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
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Parts> Parts = new BindingList<Parts>();

        public static object AllParts { get; internal set; }

        public static void FakeProduct()
        {
            Product productA = new Product(1, "Product A", 10, 12.00m, 20, 5);
            Product productB = new Product(2, "Product B", 10, 8.00m, 25, 5);
            Product productC = new Product(3, "Product C", 10, 5m, 25, 5);
            Product productD = new Product(4, "Product D", 10, 3m, 25, 5);
            Product productE = new Product(5, "Product E", 10, 2m, 65, 2);
            Product productF = new Product(6, "Product F", 10, 8m, 25, 7);

            Products.Add(productA);
            Products.Add(productB);
            Products.Add(productC);
            Products.Add(productD);
            Products.Add(productE);
            Products.Add(productF);

            // Machine ids and company names
            Parts partA = new InHousePart(1, "Part A", 15, 15.00m, 30, 10, 9001);
            Parts partB = new InHousePart(2, "Part B", 10, 12.00m, 25, 10, 9001);
            Parts partC = new InHousePart(3, "Part C", 12, 10.00m, 25, 10, 9002);
            Parts partD = new InHousePart(4, "Part D", 15, 5.00m, 25, 10, 9002);
            Parts partE = new OutsourcedPart(5, "Part E", 15, 15.00m, 30, 10, "EvilCorp");
            Parts partF = new OutsourcedPart(6, "Part F", 10, 12.00m, 25, 10, "EvilCorp");
            Parts partG = new OutsourcedPart(7, "Part G", 12, 10.00m, 25, 10, "EvilCorp");
            Parts partH = new OutsourcedPart(8, "Part H", 15, 5.00m, 25, 10, "EvilCorp");

            Parts.Add(partA);
            Parts.Add(partB);
            Parts.Add(partC);
            Parts.Add(partD);
            Parts.Add(partE);
            Parts.Add(partF);
            Parts.Add(partG);
            Parts.Add(partH);

            // Add parts
            productA.AssociatedParts.Add(partA);
            productA.AssociatedParts.Add(partB);
            productB.AssociatedParts.Add(partC);
            productB.AssociatedParts.Add(partD);
            productC.AssociatedParts.Add(partE);
            productC.AssociatedParts.Add(partF);
            productD.AssociatedParts.Add(partG);
            productD.AssociatedParts.Add(partH);
            productE.AssociatedParts.Add(partE);
            productE.AssociatedParts.Add(partH);
            productF.AssociatedParts.Add(partA);
            productF.AssociatedParts.Add(partC);
        }
        public static void AddProduct(Product prod)
        {
            Products.Add(prod);
        }

        // Try remove
        public bool RemoveProduct(int productID)
        {
            bool success = false;
            foreach (Product product in Products)
            {
                if (productID == product.ProductID)
                {
                    Products.Remove(product);
                    return success = true;
                }
                else
                {
                    MessageBox.Show("Error removing.");
                    return false;
                }
            }
            return success;
        }
        public static Product LookupProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }
            Product emptyProduct = new Product();
            return emptyProduct;
        }


        public static void UpdateProduct(int productID, Product updatedProduct)
        {
            foreach (Product currentProduct in Products)
            {
                if (currentProduct.ProductID == productID)
                {
                    currentProduct.Name = updatedProduct.Name;
                    currentProduct.InStock = updatedProduct.InStock;
                    currentProduct.Price = updatedProduct.Price;
                    currentProduct.Max = updatedProduct.Max;
                    currentProduct.Min = updatedProduct.Min;
                    currentProduct.AssociatedParts = updatedProduct.AssociatedParts;
                    return; // Exit the loop after updating the product
                }
            }
        }









        public static void AddPart(Parts parts)
        {
            Parts.Add(parts);
        }
        // try delete
        public bool DeletePart(Parts parts)
        {
            try
            {
                Parts.Remove(parts);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Parts SearchPart(int partID)
        {
            foreach (Parts parts in Parts)
            {
                if (parts.PartID == partID)
                {
                    return parts;
                }
            }
            Parts partsEmpty = null; new InHousePart();
            return partsEmpty;
        }

        private static void UpdatePartDetails<T>(int partID, T updatedPart) where T : Parts
        {
            for (int i = 0; i < Parts.Count; i++)
            {
                if (Parts[i] is T newPart && newPart.PartID == partID)
                {
                    newPart.Name = updatedPart.Name;
                    newPart.InStock = updatedPart.InStock;
                    newPart.Price = updatedPart.Price;
                    newPart.Max = updatedPart.Max;
                    newPart.Min = updatedPart.Min;

                    if (updatedPart is InHousePart inHousePart)
                    {
                        (newPart as InHousePart).MachineID = inHousePart.MachineID;
                    }
                    else if (updatedPart is OutsourcedPart outsourcedPart)
                    {
                        (newPart as OutsourcedPart).CompanyName = outsourcedPart.CompanyName;
                    }
                }
            }
        }

        public static void UpdateInHousePart(int partsID, InHousePart inHousePart)
        {
            UpdatePartDetails(partsID, inHousePart);
        }

        public static void UpdateOutsourcedPart(int partID, OutsourcedPart outsourcedPart)
        {
            UpdatePartDetails(partID, outsourcedPart);
        }

    }
}


