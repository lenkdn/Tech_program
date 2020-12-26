using System;

namespace Lab9
{
    class Calculator2 : ITrigonometria
    {
        public void Cos(double Gradus)
        {
            Console.WriteLine("Cos(" + Gradus + ") = " + 
                string.Format("{0:N2}", Math.Cos(Math.PI / 180 * Gradus)) + "\n");
        }

        public void Ctg(double Gradus)
        {
            if (Gradus == 0 | Math.Abs(Gradus) % 180 == 0)
                Console.WriteLine("Ctg(" + Gradus + ") = значение не определено\n");
            else
                Console.WriteLine("Ctg(" + Gradus + ") = " + 
                    string.Format("{0:N2}", (Math.Cos(Math.PI / 180 * Gradus) / Math.Sin(Math.PI / 180 * Gradus))) + "\n");
        }

        public void Sin(double Gradus)
        {
            Console.WriteLine("Sin(" + Gradus + ") = " + 
                string.Format("{0:N2}", Math.Sin(Math.PI / 180 * Gradus)) + "\n");
        }

        public void Tan(double Gradus)
        {
            double gradus = Gradus;
            while (Gradus > 360 | Gradus < -360)
            {
                if (Gradus > 360) { Gradus -= 360; }
                if (Gradus < -360) { Gradus += 360; }
            }
            if (Math.Abs(Gradus) == 90 | Math.Abs(Gradus) == 270)
                Console.WriteLine("Tan(" + gradus + ") = значение не определено\n");
            else
                Console.WriteLine("Tan(" + gradus + ") = " +
                    string.Format("{0:N2}", Math.Tan(Math.PI / 180 * Gradus)) + "\n");
        }
    }
}
