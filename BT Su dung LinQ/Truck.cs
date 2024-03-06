using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Su_dung_LinQ
{
    public class Truck : Vehicle
    {
        public string Company { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine("---- Xe Car ----");
            Console.WriteLine("Ten: {0} - Mo ta: {1} - Gia: {2} - Nam san xuat: {3} - Cong ty chu quan: {4}", Name, Description, Price, Year, Company);
        }
    }
}
