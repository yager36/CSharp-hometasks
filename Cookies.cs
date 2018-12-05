using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Program
    {
        static void Main(string[] args)
        {

            string Choice;

   
            Cookie[] CookieList = new Cookie[3];
            for (int i = 0; i < 3; i++)
            {
                CookieList[i] = new Cookie();
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"cookie number {i + 1}");
                Console.WriteLine("Please enter if you want gluten in your cookie press y/n...");
                Choice = Console.ReadLine();
                while (Choice!="y" && Choice != "n")
                {
                    Console.WriteLine("Please enter again y/n!..");
                    Choice = Console.ReadLine();
                }
                if (Choice=="y")
                {
                    CookieList[i].Gluten = true;

                }
                else if (Choice == "n")
                {
                    CookieList[i].Gluten = false;

                }
                Console.WriteLine("Please enter number of eggs.");
                CookieList[i].Eggs = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter sugar gram.");
                CookieList[i].Sugar =Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter flour gram.");
                CookieList[i].Flour = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"cookie number {i + 1}");
                CookieList[i].printCookie();
            }
            CookieList[0].Sugar = 4.5;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"cookie number {i + 1}");
                CookieList[i].printCookie();
            }
            CookieList[1] = CookieList[0];
            CookieList[1].Eggs = 4;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"cookie number {i + 1}");
                CookieList[i].printCookie();
            }


        }
    }
}
