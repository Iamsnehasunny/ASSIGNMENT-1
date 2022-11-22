using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class MARKPERCENTAGE
    {
        public static void Main(string[] args)
        {
            int m1, m2, m3;
            string name;
             int rlno;
            Console.WriteLine("enter the name and RollNo of the student:\n");
            name = Console.ReadLine();
            rlno = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the three marks of the student:");
            m1 = int.Parse(Console.ReadLine());
            m2 = int.Parse(Console.ReadLine());
            m3 = int.Parse(Console.ReadLine());

            Console.WriteLine(" the total mark of the student:" + (m1 + m2 + m3));
            Console.WriteLine("the percentage of the mark:" + (((m1 + m2 + m3) * 100) / 300.0f));
            Console.ReadKey();
        }
    }
}
