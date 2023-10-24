using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bai1 { 
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            double thit, banhpho, hanh;
            Console.Write("Nhap so luong bat pho:");
            n = int.Parse(Console.ReadLine());
            pho[] arr = new pho[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap du lieu cho bat pho thu {0}:", i + 1);
                Console.Write("Luong thit: ");
                thit = double.Parse(Console.ReadLine());
                Console.Write("Luong banh pho: ");
                banhpho = double.Parse(Console.ReadLine());
                Console.Write("Luong hanh: ");
                hanh = double.Parse(Console.ReadLine());
                arr[i] = new pho(i+1,thit,banhpho,hanh);
            }
            Console.WriteLine("STT\tThit\tbanh pho\thanh\tthanh tien ");
            for (int i = 0; i < n; i++)
            {
                arr[i].IN();
            }
            pho phoMax = new pho();
            pho phoMin = new pho();
            phoMax = phoMax.MaxPho(n, arr);
            phoMin = phoMin.MinPho(n, arr); 
            Console.WriteLine("Bat pho thu {0} co gia thap nhat la: {1} ", phoMin.STT, phoMin.tongtien);
            Console.WriteLine("Bat pho thu {0} co gia cao nhat la: {1} ", phoMax.STT, phoMax.tongtien);

        }
    }
    public class pho
    {
        public int STT;
        public double thit;
        public double BanhPho;
        public double hanh;
        public double tongtien;
        private double PriceThit = 15000;
        private double PriceBanhPho = 10000;
        private double PriceHanh = 2000;

        public pho()
        {
            this.STT = 0;
            this.thit = 0;
            this.BanhPho = 0;
            this.hanh = 0;
            this.tongtien = 0;
        }
        public pho(int STT, double thit, double BanhPho, double hanh)
        {
            this.STT = STT;
            this.thit = thit;
            this.BanhPho = BanhPho;
            this.hanh = hanh;
            this.tongtien = TinhGiaTien(thit, BanhPho, hanh);
        }
        public double TinhGiaTien(double thit, double BanhPho, double hanh)
        {
            double TongTien = thit*PriceThit + BanhPho*PriceBanhPho +hanh*PriceHanh;
            return TongTien;
            
        }
        public pho MaxPho(int n,params pho[] arr)
        {
            int i = 0;
            pho max = arr[0];
            for (; i < n; i++)
            {
                if(max.tongtien < arr[i].tongtien)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public pho MinPho(int n, params pho[] arr)
        {
            int i = 0;
            pho min = arr[0];
            for (; i < n; i++)
            {
                if (arr[i].tongtien < min.tongtien)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        public void IN()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t{4}",this.STT ,this.thit, this.BanhPho, this.hanh, this.tongtien);
            
        }

        ~pho(){

        }
    }
}

