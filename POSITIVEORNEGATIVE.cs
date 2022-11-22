using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class POSITIVEORNEGATIVE
    {
        public static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter the num");
            a = int.Parse(Console.ReadLine());
          
            if (a>0)
            {
                Console.WriteLine(a + " is positive");
            }
            else if (a<0)
            {
                Console.WriteLine(a + " is negative");
            }
            else
            {
                Console.WriteLine(a+ " is neither negtive nor positive");
            }
            Console.ReadKey();
        }
    }
}
