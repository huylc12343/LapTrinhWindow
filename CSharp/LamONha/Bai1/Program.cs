using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            string tt,tl;
            Console.WriteLine("**Tro choi tinh nhanh**");
            Console.WriteLine("** +: tinh phep cong**");
            Console.WriteLine("** -: tinh phep tru**");
            Console.WriteLine("** +: tinh phep nhan**");
            Console.WriteLine("** /: tinh phep chia**");
            Console.WriteLine("nhap 2 so va toan tu");
            Console.WriteLine("************");
            do {
                Console.Write("a = ");
                a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = double.Parse(Console.ReadLine());
                Console.Write("tt = ");
                tt = Console.ReadLine();
                double kq = TinhToan(a, b, tt);
                Console.WriteLine("{0} {1} {2} = {3}",a,tt,b,kq);
                Console.Write("ban co muon lam nua khong? y/n: ");
                tl = Console.ReadLine();
            } while (String.Equals(tl,"y")||String.Equals(tl,"Y"));
            Console.ReadKey();
        }
        static double TinhToan(double a,double b,string tt)
        {
            double kq = 0;
            switch(tt){
                case "+":
                    kq = a + b;
                    break;
                case "-":
                    kq = a - b;
                    break;
                case "*":
                    kq = a * b;
                    break;
                case "/":
                    kq = a / b;
                    break;
                default:
                    Console.WriteLine("Toan tu khong hop le");
                    break;
            }
            return kq;
        }
    }
}

