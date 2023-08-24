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
    public class InHousePart : Parts
    {
        public int machineID;

        public int MachineID { get; set; }


        public InHousePart()
        {/* Constructor*/}

        public InHousePart(int partID, string name, int inStock, decimal price, int max, int min, int machineID)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price.ToString();
            Max = max;
            Min = min;
            MachineID = machineID;
        }
    }
}