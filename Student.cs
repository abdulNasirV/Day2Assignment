using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMarks
{
    static void Main(string[] args)
    {
        double rl, Eng,Math, Science, total;
        double per;
        string nm;
        Console.Write("Calculate the total, percentage and division to take marks of three subjects:\n");
        Console.Write("-------------------------------------------------------------------------------");
       


        Console.Write("Input the Roll Number of the student :");
        rl = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the Name of the Student :");
        nm = Console.ReadLine();

        Console.Write("Input  the marks of English: ");
        Eng= Convert.ToInt32(Console.ReadLine());
        Console.Write("Input  the marks of  Maths : ");
        Math = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input  the marks of Science : ");
        Science= Convert.ToInt32(Console.ReadLine());

        total = Eng + Math + Science;
        per = total / 3.0;
        

        Console.Write("\nRoll No : {0}\nName of Student : {1}\n", rl, nm);
        Console.Write("Marks in Physics : {0}\nMarks in Chemistry : {1}\nMarks in Computer Application : {2}\n", Eng, Math, Science);
        Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n", total, per);
    }
}

