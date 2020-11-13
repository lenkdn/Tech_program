using System;
using System.IO;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter("output.txt");
            var new_in = new StreamReader("input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int t = 0, N = 1;
            double X = 0, Z = 0;
            t = Convert.ToInt32(Console.ReadLine());
            N = Convert.ToInt32(Console.ReadLine());
            X = Convert.ToDouble(Console.ReadLine());

            int i;
            double znam, chisl;

            if (t == 0)
            {
                for (i = 1; i <= N; i++)
                {
                    znam = i * (i + 2);
                    if (i % 2 == 0)
                        chisl = -Math.Pow(X, i - 1);
                    else
                        chisl = Math.Pow(X, i - 1);
                    Z += chisl / znam;
                }
            }

            if (t == 1)
            {
                i = 1;
                while (i <= N)
                {
                    znam = i * (i + 2);
                    if (i % 2 == 0)
                        chisl = -Math.Pow(X, i - 1);
                    else
                        chisl = Math.Pow(X, i - 1);
                    Z += chisl / znam;
                    i++;
                }
            }

            if (t == 2)
            {
                i = 1;
                do
                {
                    znam = i * (i + 2);
                    if (i % 2 == 0)
                        chisl = -Math.Pow(X, i - 1);
                    else
                        chisl = Math.Pow(X, i - 1);
                    Z += chisl / znam;
                    i++;
                } while (i <= N);
            }

            Console.WriteLine(string.Format("{0:N4}", Z));

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();

            Console.WriteLine("Программа выполнена!\nОтвет в файле 'output.txt'");
            Console.ReadKey();
        }
    }
}
