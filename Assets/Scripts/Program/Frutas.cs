using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alimentos
{
    class Frutas : Vegetales
    {
        public virtual void newUse()
        {
            Console.WriteLine("1. Platano");
            Console.WriteLine("2. Papalla");
            Console.WriteLine("3. Manzana");
            Console.WriteLine("4. Sandia");
            Console.WriteLine("5. Palta");
        }
    }
}
