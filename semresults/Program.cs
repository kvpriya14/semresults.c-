using System;

namespace ConsoleApp3
{
    internal class programm
    {
        public void Main(string[] args)
        {
            string name, rollno;
            int S1, S2, S3, S4;
            double total;
            double per;
            Console.WriteLine("            SEMRESULTS                 ");
            Console.WriteLine("NAME:");
            name = Console.ReadLine();
            Console.WriteLine("ROLL NO:");
            rollno = Console.ReadLine();
            Console.WriteLine("                                              ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("             3-1 SEM RESULTS                  ");
            Console.WriteLine("DSP:");
            S1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("VLSI:");
            S2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("MWE:");
            S3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ES:");
            S4 = Convert.ToInt32(Console.ReadLine());
            total = (S1 + S2 + S3 + S4);
            Console.WriteLine("total marks:" + total);
            per = (((total) / 400) * 100);
            Console.WriteLine("per:" + per + "%");


        }
    }
}
