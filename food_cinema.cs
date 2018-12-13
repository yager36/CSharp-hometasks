using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearTody =  DateTime.Now.Year.ToString();
            int year = Convert.ToInt32(yearTody);

            food[] list_food = new food[5];

            list_food[0] = new food("bamba", 10, true, "osem", 2017);
            list_food[1] = new food("icecream", 7, true, "strauss", 2018);
            list_food[2] = new food("chocolate", 4, true, "elit", 2015);
            list_food[3] = new food("sweet candy", 5, true, "elit", 2017);
            list_food[4] = new food("bisli", 10, true, "osem", 2018);


            for (int i = 0; i<list_food.Length ;i++)
            {
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine(list_food[i].Printf());
                if(list_food[i].Func(year))
                {
                    Console.WriteLine($"The product is expire");
                }
                else
                    Console.WriteLine($"The product is not expire");




            }


        }

       
    }
}
