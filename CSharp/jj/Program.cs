using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            int height, width;
            Console.Write("Nhap chieu dai: ");
            height = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            width = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Chu vi cua hinh la: " + C(height, width));
            Console.WriteLine("Dien tich cua hinh la: " + S(height, width));

        }
        static int C(int height, int width)
        {
            return (height + width) * 2;
        }
        static int S(int height, int width)
        {
            return width * height;
        }
    }
}
