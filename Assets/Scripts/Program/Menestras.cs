using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alimentos
{
    class Menestras : Vegetales
    {
        public virtual void newUse()
        {
            Console.WriteLine("1. Bolsa de lentejas");
            Console.WriteLine("2. Bolsa de frijoles");
            Console.WriteLine("3. Bolsa de pallares");
          
        }
    }
}
