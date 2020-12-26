using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator1 calc1 = new Calculator1();

            Console.WriteLine("\t================\n" +
                "\tПростые операции\n" +
                "\t================\n");

            calc1.Sum(2.91, 3.5);
            calc1.Razn(14, 5.812);
            calc1.Proizv(4.54, 7.6);
            calc1.Delen(9, 0);

            Calculator2 calc2 = new Calculator2();

            Console.WriteLine("\t==========================\n" +
                "\tТригонометричекие операции\n" +
                "\t==========================\n");

            calc2.Sin(180);
            calc2.Cos(60);
            calc2.Tan(-270);
            calc2.Ctg(45);

            Console.ReadKey();
        }
    }
}