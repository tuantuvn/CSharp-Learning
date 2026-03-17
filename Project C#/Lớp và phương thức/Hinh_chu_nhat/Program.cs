using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinh_chu_nhat
{
    class Hinh_Chu_Nhat
    {
        private int Chieu_dai, Chieu_rong;
        public Hinh_Chu_Nhat()
        {
            Chieu_dai = 0;
            Chieu_rong = 0;
        }
            
        
        public Hinh_Chu_Nhat(int dai, int rong)
        {
            Chieu_dai = dai;
            Chieu_rong = rong;
        }
        public Hinh_Chu_Nhat(Hinh_Chu_Nhat hcn)
        {
            Chieu_dai = hcn.Chieu_dai;
            Chieu_rong = hcn.Chieu_rong;
        }
        public void Cap_nhat_gia_tri()
        {
            Console.Write("Nhập chiều dài: ");
            Chieu_dai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập chiều rộng: ");
            Chieu_rong = Convert.ToInt32(Console.ReadLine());
        }
        
        public int Chu_vi()
        {
            return (Chieu_dai + Chieu_rong) * 2;
        }
        public int Dien_tich()
        {
            return Chieu_dai * Chieu_rong;
        }
        public void Xuat()
        {
            Console.WriteLine($"Chiều dài:{Chieu_dai}\tChiều rộng: {Chieu_rong}\tChu vi: {Chu_vi()}\tDiện tích:{Dien_tich()}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập thông tin các hình chữ nhật: ");
            Console.WriteLine("Hình 1:");
            Hinh_Chu_Nhat hcn1 = new Hinh_Chu_Nhat();
            hcn1.Cap_nhat_gia_tri();
            Hinh_Chu_Nhat hcn2 = new Hinh_Chu_Nhat(5,3);
            Hinh_Chu_Nhat hcn3 = new Hinh_Chu_Nhat(hcn2);
            Console.WriteLine("Thông tin hình chữ nhật 1: ");
            hcn1.Xuat();
            Console.WriteLine("Thông tin hình chữ nhật 2: ");
            hcn2.Xuat();
            Console.WriteLine("Thông tin hình chữ nhật 3: ");
            hcn3.Xuat();
            int Tong_dien_tich = hcn1.Dien_tich() + hcn2.Dien_tich() + hcn3.Dien_tich();
            Console.WriteLine($"Tổng diện tích của 3 hình chữ nhật là: {Tong_dien_tich}");

        }
    }
}
