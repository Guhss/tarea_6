using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alimentos
{
    class Vegetales
    {
        // atributos
        public string name;
        private int price;
        public float peso;

        // propiedades
        private int _quantity;
        public int quantity
        {
            get
            {
                return _quantity;
            }

            set
            {
                _quantity = value;
            }
        }




        // constructores
        public Vegetales(string name, int price)
        {
            this.name = name;
            this.price = price;
      
        }




        // metodos
        public virtual void Use()
        {
            Console.WriteLine("1. Cebolla");
            Console.WriteLine("2. Papas");
            Console.WriteLine("3. Zanahoria");
            Console.WriteLine("4. Lechuga");
            Console.WriteLine("5. Camote");
        }

        public void Use(int quantity) { }

        public int GetPrice()
        {
            // ...
            return price;
        }

        public void SetPrice(int newPrice)
        {
            price = newPrice;
        }
    }
}
