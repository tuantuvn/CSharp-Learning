using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bai1_1();
            Console.WriteLine("\n");
            Bai1_2();
            Console.WriteLine("\n");
            Bai1_3();


            
        }
        static void Bai1_1()
        {
            Console.WriteLine("Ten: Ten cua ban");
            Console.WriteLine("Tuoi: Tuoi cua ban");
            Console.WriteLine("Đia chi cua ban");
        }
        static void Bai1_2()
        {
            Console.Write("Nhap ten cua ban: ");
            string ten = Console.ReadLine();

            Console.Write("Nhap tuoi cua ban: ");
            int tuoi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Xin chao, {ten}! Ban da {tuoi} tuoi.");
        }
        static void Bai1_3()
        {
            Console.Write("Nhap ten cua ban: ");
            string ten = Console.ReadLine();
            int tuoi = 25;
            string Diachi = "Dia chi nha ban";
            string thongtin = string.Format("Ten: {0}, Tuoi {1}, Điachi: {2}", ten, tuoi, Diachi);
            Console.WriteLine(thongtin);
        }

       
        
    }
}
