using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Tcomplex sp = new Tcomplex();
            sp.NhapDuLieu();
            sp.InDuLieu();
        }
    }
    public class Tcomplex
    {
        public int a, b;
        public Tcomplex() 
        { 
            
        }

        public Tcomplex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void NhapDuLieu()
        {
            Console.Write("Nhap phan thuc: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap phan ao: ");
            b = int.Parse(Console.ReadLine());
        }
        public void InDuLieu()
        {
            Console.Write("z = {0} + {1}i", a, b);
        }
    }
}

