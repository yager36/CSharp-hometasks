using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_row = 3;
            int num_col = 3;



            string[][] matrix = new string[num_row][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new string[num_col];
            }

            for (int i = 0; i < num_row; i++)
            {
                for (int j = 0; j < num_col; j++)
                {
                    if (i == j && i != 1 && j != 1)
                    {
                        matrix[i][j] = "main";
                    }
                    if (i == 1 && j == 1)
                    {
                        matrix[i][j] = "center";
                    }
                    if (i == 2 && j == 1 || i == 1 && j == 0)
                    {
                        matrix[i][j] = "down";
                    }
                    if (i == 2 && j == 0 || i == 0 && j == 2)
                    {
                        matrix[i][j] = "sub";
                    }
                    if (i == 0 && j == 1 || i == 1 && j == 2)
                    {
                        matrix[i][j] = "up";
                    }
                 


                }
      
            }


            foreach (string[] item in matrix)
            {
                foreach (string item1 in item)
                {
                    Console.Write(item1+"   ");
                }
                Console.WriteLine();

            }

        }

    }
}


