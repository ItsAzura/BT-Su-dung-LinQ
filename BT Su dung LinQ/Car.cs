using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Su_dung_LinQ
{
    public class Car : Vehicle
    {
        public string Manufacturer { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine("---- Xe Car ----");
            Console.WriteLine("Ten: {0}- Mo ta: {1} - Gia: {2} - Nam san xuat: {3} - Hang san xuat: {4}", Name, Description, Price, Year, Manufacturer);
        }
    }
}
