using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            int r,m1, m2, m3, t;
            float p;
            string n,b,s;
            Console.WriteLine("Enter Roll Number :");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name :");
            n = Console.ReadLine();
            Console.WriteLine("Enter the branch:");
            b= Console.ReadLine();
            Console.WriteLine("Enter the Sem");
            s= Console.ReadLine();

            Console.WriteLine("Mark of Subject1 : ");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mark of Subject2 : ");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mark of Subject3 : ");
            m3 = Convert.ToInt32(Console.ReadLine());
           
            t = m1 + m2 + m3;
            p = t / 3.0f;
            Console.WriteLine("Total : " + t);
            Console.WriteLine("Percentage : " + p);
            if (p >= 0 && p < 35)
            {
                Console.WriteLine("Fail");
            }
            if (p >= 35 && p <= 40)
            {
                Console.WriteLine("Grade is C");
            }
            if (p >= 40 && p <= 60)
            {
                Console.WriteLine("Grade is B");
            }
            if (p > 60 && p <= 80)
            {
                Console.WriteLine("Grade is A");
            }
            if (p > 80 && p <= 100)
            {
                Console.WriteLine("Grade is A+");
            }
            Console.ReadLine();
        }

    }
}
