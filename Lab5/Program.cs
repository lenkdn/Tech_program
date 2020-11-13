using System;
using System.IO;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            Console.Write("Введите кол-во строк матрицы (M): ");
            M = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во столбцов матрицы (N): ");
            N = Convert.ToInt32(Console.ReadLine());

            TextWriter save_out = Console.Out;
            var new_out = new StreamWriter("input.txt");
            Console.SetOut(new_out);

            Console.WriteLine(M);
            Console.WriteLine(N);

            Random r = new Random();
            int x;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    x = r.Next(2001) - 1000;
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }

            Console.SetOut(save_out); new_out.Close();

            TextReader save_in = Console.In;
            var new_in = new StreamReader("input.txt");
            new_out = new StreamWriter("output.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            M = Convert.ToInt32(Console.ReadLine());
            N = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[M, N];
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < M; i++)
            {
                string str_all = Console.ReadLine();
                string[] str_elem = str_all.Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mas[i, j] = Convert.ToInt32(str_elem[j]);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }

            float[] sa = new float[M];
            Console.WriteLine("\nСреднее арифметическое для чётных элементов строки:");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mas[i, j] % 2 == 0)
                        sa[i] += mas[i, j];
                }
                sa[i] = sa[i] / N;
                Console.WriteLine(sa[i]);
            }

            Console.WriteLine("\nМодифицированная матрица:");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mas[i, j] < sa[i])
                        Console.Write("q ");
                    else
                        Console.Write("z ");
                }
                Console.WriteLine();
            }

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();

            Console.WriteLine("\nПрограмма выполнена!\n" +
                "Было создано 2 файла:\n" +
                "1. input.txt - содержит входные данные\n" +
                "2. output.txt - содержит ответ на основе 1-го файла");
            Console.ReadKey();
        }
    }
}