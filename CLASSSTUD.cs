using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class CLASSSTUD
    {
        class Student
        {
            private int rollNumber;
            private string name;

            public void SetName(string n)
            {
                name = n;
            }
            public string GetName()
            {
                return name;
            }

            public void SetRollNumber(int r)
            {
                rollNumber = r;
            }
            public int GetRollNumber()
            {
                return rollNumber;
            }
        }

        class Test
        {
            static void Main(string[] args)
            {
                Student s = new Student();
                s.SetRollNumber(1);

                s.SetName("Andrew");

                string a = s.GetName();

                Console.WriteLine(a);
            }
        }
    }

}
