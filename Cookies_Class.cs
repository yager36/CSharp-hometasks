using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cookie
    {
        private bool gluten;

        public bool Gluten
        {
            get { return gluten; }
            set { gluten = value; }
        }

        private int eggs;

        public int Eggs
        {
            get { return eggs; }
            set { eggs = value; }
        }

        private Double sugar;

        public Double Sugar
        {
            get { return sugar; }
            set { sugar = value; }
        }

        private Double flour;

        public Double Flour
        {
            get { return flour; }
            set { flour = value; }
        }
        public void printCookie()
        {

            Console.WriteLine($"You have this amount of groceries to make a cookie:\n" +
                              $"gluten {gluten}\n" +
                              $"{Eggs} eggs\n" +
                              $"{sugar} sugar\n" +
                              $"{flour} flour\n");

        }

    }
}

