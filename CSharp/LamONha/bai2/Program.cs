using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ngay, thang, nam;
            Console.Write("Nhap ngay: ");
            ngay = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            nam = int.Parse(Console.ReadLine());
            if (KiemTraHopLe(ngay, thang, nam) == 1)
            {
                Console.WriteLine("Ngay {0}/{1}/{2} la ngay hop le",ngay,thang,nam);
                GhiNgayTiepTheo(ngay, thang, nam);
            }
            else
            {
                Console.WriteLine("Ngay {0}/{1}/{2} la ngay khong hop le",ngay,thang,nam);
                Console.WriteLine("Khong tra ve ngay tiep theo");
            }
        }
        static int KiemTraHopLe(int ngay,int thang, int nam)
        {
            if(nam > 0) 
            {
                if(nam % 4 == 0 && nam %100 == 0)
                {
                    if (thang == 2)
                    {
                        if (ngay <= 29)
                        {
                            return 1;
                        }
                        else
                        {
                            
                            return 0;
                        }
                    }else if(thang == 4|| thang == 6 || thang == 9 || thang == 11)
                    {
                        if (ngay <= 30)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }else  if(thang > 12)
                    {
                        return 0;
                    }
                    else
                    {
                        if (ngay <= 31)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    
                }
                else
                {
                    if(thang == 2)
                    {
                        if (ngay <= 28)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
                    {
                        if (ngay <= 30)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else if (thang > 12)
                    {
                        return 0;
                    }
                    else
                    {
                        if (ngay <= 31)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
            else
            {
                return 0;
            }
        }
        static int SoNgayTrongThang(int ngay, int thang, int nam)
        {
            if(thang == 2)
            {
                 if ( nam % 4 == 0 && nam%100 == 0)
                {
                    return 29;
                }
                else
                {
                    return 28;
                }
            }else if(thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                return 30;
            }
            else
            {
                return 31;
            }
        }
        static void GhiNgayTiepTheo(int ngay, int thang,int nam)
        {
            int NgayTiepTheo = ngay + 1;
            int ThangTiepTheo = thang;
            if( NgayTiepTheo > SoNgayTrongThang(ngay,thang,nam))
            {
                NgayTiepTheo = 1;
                ThangTiepTheo = thang + 1;
                if(ThangTiepTheo > 12)
                {
                    ThangTiepTheo = 1;
                    nam = nam + 1;
                }
            }
            Console.WriteLine("Ngay tiep theo la: {0}/{1}/{2}",NgayTiepTheo,ThangTiepTheo,nam);
        }
    }
}

