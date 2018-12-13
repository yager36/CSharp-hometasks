using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class food
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int price   ;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        private bool kosher;

        public bool Kosher
        {
            get { return kosher; }
            set { kosher = value; }
        }

        private string manufacturer;

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }


        private int expyear;

        public int Expyear
        {
            get { return expyear; }
            set { expyear = value; }
        }

        public food() { }

        public food (string name, int price, bool kosher, string manufacture, int expyear)
        {
            Name = name;
            Kosher = kosher;
            Price = price;
            Manufacturer = manufacture;
            Expyear = expyear;
        }

 
        public string Printf()
        {

            return $"name: {name}\n" +
                   $"price {price}\n" +
                   $"kosher {kosher}\n" +
                   $"manufacturer {manufacturer}\n" +
                   $"expyear {expyear}";
                 
        }

        public bool Func (int Current_year)
        {
            if (expyear >= Current_year)
                return true;
            else
                return false;
               
        }


    }
}
