using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class ODDNUMSUM
    {
        public static void Main(string[] args)
        {
            int num,sum=0;
            Console.WriteLine("enter the limit");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The odd numbers between 1 to " + num + "=");
            for(int i = 1; i <= num; i++)
            if(i%2!=0)
            {
                    Console.WriteLine("\n" + i);
                    sum = sum + i;  
            }
            Console.WriteLine("\nthe sum of these natural number=" +sum);
        }
    }
}

