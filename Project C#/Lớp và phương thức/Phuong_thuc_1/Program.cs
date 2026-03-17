using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phuong_thuc_1
{
    class Hinh_tron
    {
        private double Bankinh;
        public Hinh_tron(double r)
        {
            Bankinh = r;
        }
        public double TinhDienTich()
        {
            return Math.PI * Bankinh * Bankinh;
        }
        public double TinhChuVi()
        {
            return 2 * Math.PI * Bankinh;
        }
    }
    class Sinh_Vien
    {
        private string ten;
        private double diemToan;
        private double diemVan;

        public Sinh_Vien(string Ten, double diemToan, double diemVan) 
        {
            this.ten = Ten;
            this.diemToan = diemToan;
            this.diemVan = diemVan;
        }
        public double Diem_TB()
        {
            return (diemToan + diemVan) / 2; 
        }
        public void XepLoai()
        {
            double diemTB = Diem_TB();
            if (diemTB >= 5)
            {
                Console.WriteLine($"Sinh viên {ten} đậu với điểm trung bình {diemTB}");
            }
            else
            {
                Console.WriteLine($"Sinh viên {ten} rớt với điểm trung bình {diemTB}");
            }
        }
    }
    class Danh_ba
    {
        private List<string> danhBa;
        public Danh_ba()
        {
            danhBa = new List<string>();

        }
        public void ThemSDT (string SDT)
        {
            danhBa.Add(SDT);
        }
        public void XoaSDT (string SDT)
        {
            danhBa.Remove(SDT);
        }
        public void HienthiDanhba()
        {
            Console.WriteLine("Danh bạ điện thoại: ");
            foreach (string SDT in danhBa)
            {
                Console.WriteLine(SDT);
            }
        }
    }

    internal class Program
    {
        static void Bai_1()
        {
            Hinh_tron hinhTron = new Hinh_tron(5.0);
            Console.WriteLine($"Diện tích của hình tròn: {hinhTron.TinhDienTich()}");
            Console.WriteLine($"Chu vi của hình tròn là: {hinhTron.TinhChuVi()}");


        }
        static void Bai_2()
        {
            Sinh_Vien sv1 = new Sinh_Vien("Nguyễn Văn A", 7.5, 8.0);
            Sinh_Vien sv2 = new Sinh_Vien("Trần Hồ Như Ý", 4.5, 4.2);
            sv1.XepLoai();
            sv2.XepLoai();
        }
        static void Bai_3()
        {
            Danh_ba danh_Ba = new Danh_ba();
            danh_Ba.ThemSDT("0123456789");
            danh_Ba.ThemSDT("0987654321");
            danh_Ba.ThemSDT("0365478219");
            danh_Ba.HienthiDanhba();
            danh_Ba.XoaSDT("0123456789");
            Console.WriteLine("\nSau khi xoá là: ");
            danh_Ba.HienthiDanhba();
        }


        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhập số bài cần chạy: ");
            byte chon = Convert.ToByte(Console.ReadLine());
            switch (chon)
            {
                case 1: Bai_1(); break;
                case 2: Bai_2(); break;
                case 3: Bai_3(); break;


            }

        }
    }
}
