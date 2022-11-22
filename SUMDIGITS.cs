using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class SUMDIGITS
    {
        public static void Main(string[] args)
        {
            int num, summ = 0; ;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());
            while(num>0)
            {

                summ = (num % 10)+summ;
                num = num/10;
            }
            Console.WriteLine("the sum of digits of the number="  + summ);
        }

    }
}
