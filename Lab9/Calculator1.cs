using System;

namespace Lab9
{
    class Calculator1 : ISimpleOperations
    {
        public Calculator1() { }

        public void Delen(double Perem1, double Perem2)
        {
            if (Perem2 == 0)
                Console.WriteLine(Perem1 + " / " + Perem2 + " = на ноль делить нельзя\n");
            else
                Console.WriteLine(Perem1 + " / " + Perem2 + " = " + 
                    string.Format("{0:N2}", (Perem1 / Perem2)) + "\n");
        }

        public void Proizv(double Perem1, double Perem2)
        {
            Console.WriteLine(Perem1 + " * " + Perem2 + " = " + 
                string.Format("{0:N2}", (Perem1 * Perem2)) + "\n");
        }

        public void Razn(double Perem1, double Perem2)
        {
            Console.WriteLine(Perem1 + " - " + Perem2 + " = " + (Perem1 - Perem2) + "\n");
        }

        public void Sum(double Perem1, double Perem2)
        {
            Console.WriteLine(Perem1 + " + " + Perem2 + " = " + (Perem1 + Perem2) + "\n");
        }
    }
}
