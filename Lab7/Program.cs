using System;
using System.IO;

namespace Lab7
{
    class Tr_cone
    {
        string Name = "усечённый конус";
        double R1, R2, H;
        static int count = 0;

        public Tr_cone() { }

        public Tr_cone(double pR1, double pR2, double pH)
        {
            R1 = pR1; R2 = pR2; H = pH;
        }

        public void Load()
        {
            R1 = Convert.ToDouble(Console.ReadLine());
            R2 = Convert.ToDouble(Console.ReadLine());
            H = Convert.ToDouble(Console.ReadLine());
        }

        public double V() { return 1.0 / 3 * Math.PI * H * (R1 * R1 + R1 * R2 + R2 * R2); }

        public double S() 
        { return 
                (Math.PI * Math.Sqrt((R2 - R1) * (R2 - R1) + H * H) * (R1 + R2)) +
                (Math.PI * R1 * R1) +
                (Math.PI * R2 * R2); 
        }

        public void Info()
        {
            count++;
            Console.WriteLine("================================");
            Console.WriteLine($"Фигура № {count}");
            Console.WriteLine($"\nНазвание: {Name}");
            Console.WriteLine("\nОбъём (V): {0:N2}", V());
            Console.WriteLine("\nПлощадь поверхности: (S): {0:N2}", S());
            Console.WriteLine("================================\n");
        }

        public void Info(ConsoleColor fg, ConsoleColor bgc)
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bgc;
            Console.Clear();
            Info();
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

#if !DEBUG
            Tr_cone figure1, figure2;
            figure1 = new Tr_cone();
            figure1.Load(); 
            figure1.Info();
            figure2 = new Tr_cone(3.51, 6.7, 8);
            figure2.Info();
#else       
            Tr_cone figure1 = new Tr_cone();
            figure1.Load();
            figure1.Info(ConsoleColor.Black, ConsoleColor.DarkGreen);
#endif

#if !DEBUG
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
#else
            Console.ReadKey();
#endif
        }
    }
}