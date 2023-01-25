using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Hotdog : ICostcoFoodCourt
    {
        public void Order()
        {
            Console.WriteLine("One hotdog with ketchup and mustard please.");
        }
    }
}
