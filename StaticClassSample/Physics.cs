using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassSample
{
    public static class Physics
    {
        public static decimal Gravity {  get; set; } // encapsulation anlamında bir şey değişmedi, sadece class.property şeklinde erişebiliyor olmam farklılık gösterdi
        public const int BuoyancyOfWater = 12; // const sabit değişken
        public static readonly int force = 2; // sadece okunabilir değişken (field) 

        public static void UseBuoyancyOfWater()
        {
            Console.WriteLine($"Buoyancy of water: {BuoyancyOfWater}");
        }
    }
}
