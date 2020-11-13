using System;
using System.IO;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.Write("Введите кол-во элементов (N): ");
            N = Convert.ToInt32(Console.ReadLine());

            TextWriter save_out = Console.Out;
            var new_out = new StreamWriter("input.txt");
            Console.SetOut(new_out);

            Console.WriteLine(N);

            Random r = new Random();
            int x = 0;
            for (int i = 0; i < N; i++)
            {
                x = r.Next(200001) - 100000;
                Console.Write(x + " ");
            }

            Console.SetOut(save_out); new_out.Close();

            TextReader save_in = Console.In;
            var new_in = new StreamReader("input.txt");
            new_out = new StreamWriter("output.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            N = Convert.ToInt32(Console.ReadLine());
            string str_all = Console.ReadLine();
            string[] str_elem = str_all.Split(' ');

            int[] mas = new int[N];
            for (int i = 0; i < N; i++)
                mas[i] = Convert.ToInt32(str_elem[i]);

            int max_kr5 = -100001,
                min_kr3 = 100001,
                sum_del10 = 0;
            for (int i = 0; i < N; i++)
            {
                if ((mas[i] % 5 == 0) && (mas[i] > max_kr5))
                    max_kr5 = mas[i];
                if ((mas[i] % 3 == 0) && (mas[i] < min_kr3))
                    min_kr3 = mas[i];
                if (mas[i] % 10 == 0)
                    sum_del10 += mas[i];
            }

            Console.WriteLine(max_kr5);
            Console.WriteLine(min_kr3);
            Console.WriteLine(sum_del10);

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();

            Console.WriteLine("Программа выполнена!\n" +
                "Было создано 2 файла:\n" +
                "1. input.txt - содержит входные данные\n" +
                "2. output.txt - содержит ответ на основе 1-го файла");
            Console.ReadKey();
        }
    }
}