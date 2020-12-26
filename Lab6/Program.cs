using System;
using System.IO;

namespace Lab6
{
    class Otrezok
    {
        private string Name = "отрезок";

        private double x1, x2, y1, y2;

        public double Length() { return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); }

        public double Ras1() { return Math.Sqrt(Math.Pow((x1 - 0), 2) + Math.Pow((y1 - 0), 2)); }

        public double Ras2() { return Math.Sqrt(Math.Pow((x2 - 0), 2) + Math.Pow((y2 - 0), 2)); }

        public void Info()
        {
            Console.WriteLine($"Название: {Name}.\n");
            Console.WriteLine($"Координаты отрезка:\n    начало ({x1}, {y1})\n    конец ({x2}, {y2})\n");
            Console.Write($"Длина отрезка: ");
            Console.WriteLine("{0:N2}", Length());
            Console.WriteLine($"\nРасстояние от начала координат:");
            Console.Write($"    Т1 ({x1}, {y1}) = ");
            Console.WriteLine("{0:N2}", Ras1());
            Console.Write($"    Т2 ({x2}, {y2}) = ");
            Console.WriteLine("{0:N2}", Ras2());
        }

        public void Load()
        {
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter("output.txt");
            var new_in = new StreamReader("input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in); 
#endif
            Otrezok otr = new Otrezok();
            otr.Load();
            otr.Info();
#if !DEBUG
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
#else
            Console.ReadKey();
#endif
        }
    }
}