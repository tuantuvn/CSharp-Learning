using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapmang1
{
    internal class Program
    {
        static void Bai1()
        {
            int[] mang = { 4, 2, 9, 7, 1, 5, 6 };
            int max = mang[0];
            for (int i = 1; i < mang.Length; i++)
            {
                if (mang[i] > max)
                    max = mang[i];
            }
            Console.WriteLine($"Giá trị lớn nhất trong mảng là: {max}");
        }
        static void Bai2()
        {
            int[] mang = { 1, 3, 5, 7, 9 };
            int tong = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                tong += mang[i];
            }
            Console.WriteLine($"Tổng của các phần tử trong mảng là: {tong}");

        }
        static void Inmang (int[] mang)
        {
            for (int i = 0;i < mang.Length; i++)
            {
                Console.Write($"{mang[i]}\t");
            }
        }
        static void Bai3()
        {
            int[] mang = { 1, 2, 3, 4, 5, 6 };
            Inmang(mang);
            //Đảo ngược mảng
            Array.Reverse(mang);
            Console.WriteLine();

            //Mảng sau đảo ngược
            Console.WriteLine($"Mảng sau khi đảo ngược: ");
            Inmang(mang);


        }
        static void Bai4()
        {
            int[] mang = { 2, 4, 6, 8, 10 };
            int Phantucantim = 6;
            bool Ketqua = Kiem_tra_xuat_hien(mang, Phantucantim);
            if (Ketqua)
            {
                Console.WriteLine($"{Phantucantim} xuất hiện trong mảng.");
            }
            else
            {
                Console.WriteLine($"{Phantucantim} không xuất hiện trong mảng.");
            }

        }
        static bool Kiem_tra_xuat_hien(int [] mang, int x)
        {
            for (int i = 0;i < mang.Length; i++)
            {
                if (mang[i] == x)
                {
                    return true;
                }
            }
            return false;
        }

            static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Nhập vào số bài cần chạy: ");
            byte chon = Convert.ToByte(Console.ReadLine());
            switch(chon)
            {
                case 1: Bai1(); break;
                case 2: Bai2(); break;
                case 3: Bai3(); break;
                case 4: Bai4(); break; 

            }
        }
    }
}
