﻿using System;
using System.IO;

namespace Lab10
{
    class Matrix
    {
        private int[,] matrix;
        int m, n;

        public Matrix() { }

        public void GenerateMatrix(int M, int N)
        {
            m = M; n = N;

            Random r = new Random();

            matrix = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = r.Next(1000);
                }
            }
        }

        public void SaveMatrix(string pFileName)
        {
            if (matrix.Length > 0)
            {
                if (File.Exists(pFileName))
                    File.Delete(pFileName);

                FileInfo f = new FileInfo(pFileName);
                TextWriter tw = f.CreateText();

                tw.WriteLine(m.ToString());
                tw.WriteLine(n.ToString());

                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                        tw.WriteLine(i.ToString() + " " + j.ToString() + " " + matrix[i, j].ToString());

                tw.Close();
            }
        }

        public Boolean LoadMatrix(string pFileName)
        {
            if (File.Exists(pFileName))
            {
                try
                {
                    TextReader tr = File.OpenText(pFileName);
                    m = Convert.ToInt32(tr.ReadLine());
                    n = Convert.ToInt32(tr.ReadLine());

                    matrix = new int[m, n];
                    string line;
                    string[] substring;

                    for (int i = 0; i < m; i++)
                        for (int j = 0; j < n; j++)
                        {
                            line = tr.ReadLine();
                            substring = line.Split(new char[] { ' ' }, 3);
                            matrix[i, j] = Convert.ToInt32(substring[2]);
                        }

                    tr.Close();

                    return true;
                }
                catch
                {
                    return false;
                }
            }

            return false;
        }

        public void PrintMatrix()
        {
            if (matrix.Length > 0)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                        Console.Write(matrix[i, j].ToString() + " ");

                    Console.WriteLine();
                }

                Console.WriteLine("\n");
            }
        }

    }
}