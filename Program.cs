

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oaip_git1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность строки 1-й матрицы: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите размерность столбцова 1-й матрицы:");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите размерность строки 2-й матрицы: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите размерность столбцова 2-й матрицы: ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            int[,] matric = new int[n1, m1];
            int[,] matric1 = new int[n2, m2];
            int[,] matric2 = new int[n1, m2];
            funcMatric(matric, n1, m1);
            Console.WriteLine("Матрица A: ");
            OutputMatric(matric, n1, m1);
            funcMatric(matric1, n2, m2);
            Console.WriteLine("Матрица B: ");
            OutputMatric(matric1, n2, m2);
            Console.WriteLine("C=A*B (Результат умножение матриц): ");
            UmnojenieMatric(matric, matric1, matric2, n1, m1, n2, m2);
        }
        static void funcMatric(int[,] mx, int n, int m)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mx[i, j] = rnd.Next(0, 10);
                }
            }
        }
        static void OutputMatric(int[,] mx, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mx[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void UmnojenieMatric(int[,] matric, int[,] matric1, int[,] matric2, int n1, int n2, int m1, int m2)
        {
            if (n2 == m1)
            {
                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < m2; j++)
                    {
                        matric2[i, j] = 0;
                        for (int k = 0; k < m1; k++)
                        {
                            matric2[i, j] += matric[i, k] * matric1[k, j];
                        }
                        Console.Write(matric2[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Error! (Кол-во столбцов первой матрицы не равно вол-ву строк второй матрицы.) ");
            }
        }
        
    }
}
