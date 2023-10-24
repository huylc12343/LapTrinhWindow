using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo ps = new PhanSo();
            ps.NhapPhanSo();
            ps.InPhanSo();
            Console.WriteLine();
            PhanSo ps2 = new PhanSo();
            ps2.NhapPhanSo();
            ps2.InPhanSo();
            Console.WriteLine();
            PhanSo ps3 = new PhanSo();
            ps3 = ps + ps2;
            ps3.InPhanSo();
        }
        
    }
    public class PhanSo
    {
        public double tuso, mauso;
        public PhanSo()
        {

        }
        public PhanSo(double tuso, double mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;
        }
        public void NhapPhanSo()
        {
            bool isValid = false;

            do
            {
                Console.Write("Nhap tu so: ");
                tuso = int.Parse(Console.ReadLine());

                Console.Write("Nhap mau so: ");
                mauso = int.Parse(Console.ReadLine());

                if (mauso == 0)
                {
                    Console.WriteLine("Mau so khong duoc bang 0. Vui long nhap lai.");
                }
                else
                {
                    isValid = true;
                }
            } while (!isValid);

        }
        public void InPhanSo()
        {
            RutGon();
            if(mauso == 1)
            {
                Console.Write("{0}", tuso);
            }
            else
            {
                Console.Write("{0}/{1}", tuso, mauso);
            }
        }
        private void RutGon()
        {
            double x = UCLN(tuso, mauso);
            tuso = tuso / x;
            mauso = mauso / x;
        }
        private double UCLN(double a, double b)
        {
            if (b == 0)
            {
                return a;
            }

            return UCLN(b, a % b);

        }
        public static PhanSo  operator + (PhanSo ps1, PhanSo ps2) 
        {
            PhanSo ps3 = new PhanSo();
            ps3.tuso = ps1.tuso*ps2.mauso + ps2.tuso*ps1.mauso;
            ps3.mauso = ps1.mauso*ps2.mauso + ps2.mauso*ps1.mauso;
            return ps3;
        }
        public static PhanSo operator -(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps3 = new PhanSo();
            ps3.tuso = ps1.tuso * ps2.mauso - ps2.tuso * ps1.mauso;
            ps3.mauso = ps1.mauso * ps2.mauso - ps2.mauso * ps1.mauso;
            return ps3;
        }
        public static PhanSo operator *(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps3 = new PhanSo();
            ps3.tuso = ps1.tuso* ps2.tuso ;
            ps3.mauso = ps1.mauso* ps2.mauso ;
            return ps3;
        }
        public static PhanSo operator /(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps3 = new PhanSo();
            ps3.tuso = ps1.tuso * ps2.mauso;
            ps3.mauso = ps1.mauso * ps2.tuso;
            return ps3;
        }
    }

}

