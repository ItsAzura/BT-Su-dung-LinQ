using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Su_dung_LinQ
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }

        public abstract void DisplayInfo();
    }
    
}
