using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Churro : ICostcoFoodCourt
    {
        public void Order()
        {
            Console.WriteLine("I'd like a churro please no extra toppings.");
        }
    }
}
