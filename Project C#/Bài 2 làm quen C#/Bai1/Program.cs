using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bai1_1();
            Bai1_2();
            Bai1_3();
            
            
        }
        static void Bai1_1()
        {
            int So_nguyen = 10;
            double So_thuc = 3.14;
            string Chuoi = "Hello, World";

            Console.WriteLine($"So nguyen: {So_nguyen}");
            Console.WriteLine($"So thuc: {So_thuc}");
            Console.WriteLine($"Chuoi: {Chuoi}");
            
        }

        static void Bai1_2()
        {
            Console.WriteLine("Nhap so thu nhat: ");
            double So_thu_nhat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai: ");
            double So_thu_hai = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Tong: {So_thu_nhat + So_thu_hai}");
            Console.WriteLine($"Hieu: {So_thu_nhat - So_thu_hai}");
            Console.WriteLine($"Tich: {So_thu_nhat * So_thu_hai}");

            if (So_thu_hai != 0)
            {
                Console.WriteLine($"Thuong: {So_thu_nhat / So_thu_hai}");

            } else
            {
                Console.WriteLine("Khong the chia cho 0.");
            }

        }
        static void Bai1_3()
        {
            Console.Write("Nhap ten cua ban: ");
            string ten = Console.ReadLine();
            Console.Write("Nhap tuoi cua ban: ");
            int tuoi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Xin chao, {ten}! Ban da {tuoi} tuoi.");
        }
    }
}
