using System;
using System.IO;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum_diag_elem_ch_stol_in_matrix(string pFileName)
            {
                int sum = 0;
                if (File.Exists(pFileName))
                {
                    try
                    {
                        string line;
                        string[] substring;

                        TextReader tr = File.OpenText(pFileName);
                        int m = Convert.ToInt32(tr.ReadLine());
                        int n = Convert.ToInt32(tr.ReadLine());
                        int perem = 0;
                        if (n % 2 == 0)
                            perem = n + 1;

                        for (int i = 0; i < m; i++)
                            for (int j = 0; j < n; j++)
                            {
                                line = tr.ReadLine();
                                substring = line.Split(new char[] { ' ' }, 3);
                                if ((j % 2 != 0) && ((i == j) | ((i + j) == (perem - 1))))
                                    sum += Convert.ToInt32(substring[2]);
                            }

                        tr.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                    throw new FileNotFoundException();

                return sum;
            }

            Matrix m1 = new Matrix();
            Matrix m2 = new Matrix();

            m1.GenerateMatrix(4, 4);
            m1.SaveMatrix("Matrix_1.txt");

            m2.GenerateMatrix(3, 3);
            m2.SaveMatrix("Matrix_2.txt");

            if (m1.LoadMatrix("Matrix_1.txt") && m2.LoadMatrix("Matrix_2.txt"))
            {
                Console.WriteLine("Матрица 1\n");
                m1.PrintMatrix();
                Console.WriteLine("Матрица 2\n");
                m2.PrintMatrix();
                Console.WriteLine("Сумма диагональных элементов\n" +
                    "чётных столбцов матриц: " + (Sum_diag_elem_ch_stol_in_matrix("Matrix_1.txt") +
                    Sum_diag_elem_ch_stol_in_matrix("Matrix_2.txt")));
            }

            Console.ReadKey();
        }
    }
}