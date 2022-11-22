using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class EQLORNOTINT
    {
        public static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("enter first num");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second num");
            b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine(a + " and " +b+ " are equal");
            }
           
            else
            {
                Console.WriteLine(a + " and " + b + " are not equal");
            }
            Console.ReadKey();
        }
    }
}
