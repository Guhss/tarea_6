using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alimentos;

namespace Practica__
{
    class Program
    {
        static void Main(string[] args)
        {
            Vegetales vegetales = new Vegetales("Vegetales");
             vegetales.Use();

             int price = vegetales.GetPrice();
             Console.WriteLine(price);

             vegetales.SetPrice(8);
             price = vegetales.GetPrice();
            Console.WriteLine(price);


             Console.WriteLine(vegetales.quantity);
             vegetales.quantity = 16;
             Console.WriteLine(vegetales.quantity);


            Menestras menestras = new Menestras();
            Console.WriteLine(menestras.newUse());

            Frutas frutas = new Frutas();

        }

        
    }
}
