using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class STAR_B_
    {
        static void Main(string[] args)
        {
            int rows, i, j, k = 0; ;
            
            Console.Write("Enter the number of rows:\t");
            rows = int.Parse(Console.ReadLine());

            for (i = rows; i >= 1; i--)
            {
                for (j = rows; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k < (i * 2); k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }    
        }    
    }
}