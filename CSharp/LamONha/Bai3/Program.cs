using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("N = ");
            n = int.Parse(Console.ReadLine());
            int[] numbers = Enumerable.Range(1, n).ToArray();
            SoChinhPhuong(n, numbers);
            SoNguyenTo(n);

        }
        static void SoChinhPhuong(int n, params int[] numbers)
        {
            int[] SquareNumber = numbers.Where(x => Math.Sqrt(x) % 1 == 0).ToArray();
            Console.Write("So chinh phuong nho hon {0} la: ", n);
            Console.Write(string.Join(", ", SquareNumber));
        }
        /*
        static void SoNguyenTo(int n,params int[] numbers)
        { int i,j,a=0;
            bool[] PrimeNumbers = Enumerable.Repeat(true, n).ToArray();
            for (i = 2; i <= Math.Sqrt(n); i++)
            {
                if (PrimeNumbers[i] == true)
                {
                    for (j = i * (i + a); j <= n; a++)
                    {
                        PrimeNumbers[j] = false;
                    }
                }
            }
            int[] PrintPrimeNumbers = new int[n];
            for (i = 2; i <= n; i++)
            {
                if (PrimeNumbers[i] == true)
                {
                    PrintPrimeNumbers[i] = i;
                }
            }
            Console.Write("So chinh nguyen to hon {0} la: ", n);
            Console.Write(PrintPrimeNumbers);
        }*/
        static void SoNguyenTo(int n)
        {
            bool[] PrimeNumbers = Enumerable.Repeat(true, n + 1).ToArray();
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (PrimeNumbers[i] == true)
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        PrimeNumbers[j] = false;
                    }
                }
            }

            List<int> PrintPrimeNumbers = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                if (PrimeNumbers[i] == true)
                {
                    PrintPrimeNumbers.Add(i);
                }
            }
            Console.Write("\n");
            Console.Write("So nguyen to nho hon {0} la: ", n);
            Console.Write(string.Join(", ", PrintPrimeNumbers));
        }
    }

}

