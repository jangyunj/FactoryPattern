using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal static class CostcoFactory //1. make factory static
    {
        public static ICostcoFoodCourt GetLunch(decimal money) //2. public static interfacename methodname (para)
        {
            switch (money)
            {
                case 1.00m:
                    return new Churro();
                    break;
                case 2.00m:
                    return new Hotdog();
                    break;
                default:
                    return new Pizza();

            }
        }

    }
}
