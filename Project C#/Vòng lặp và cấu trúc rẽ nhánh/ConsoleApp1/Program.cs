using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

{
    internal class Program
    {
        static void Bai1_1()
        {
            string Ho_ten;
            DateTime Ngay_sinh;
            string gt;
            Console.Write("Nhập họ và tên sinh viên: ");
            Ho_ten = Console.ReadLine();
            Console.Write("Nhập ngày sinh: ");
            Ngay_sinh = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Nhập giới tính: ");
            gt = Console.ReadLine();
            if (gt == "Nam")
            {
                Console.WriteLine($"{Ho_ten}\t{Ngay_sinh.ToShortDateString()}\t{gt}");
            }
            else if (gt == "Nữ")
            {
                Console.WriteLine($"{Ho_ten}\t{Ngay_sinh.ToShortDateString()}\t{gt}");
            }



        }
        static void Bai1_2()
        {
            DateTime Ngay_sinh;
            Console.Write("Nhập họ và tên: ");
            string Ho_va_ten = Console.ReadLine();
            Console.Write("Nhập ngày sinh: ");
            Ngay_sinh = Convert.ToDateTime(Console.ReadLine());

            int tuoi = DateTime.Today.Year - Ngay_sinh.Year;
            Console.WriteLine($"{Ho_va_ten}\t{tuoi} tuổi");


        }
        static void Bai1_3()
        {
            byte So_gio, Luong_gio;
            Console.Write("Nhập số giờ làm: ");
            while (true)
            {
                if (byte.TryParse(Console.ReadLine(), out So_gio) && So_gio >= 8 && So_gio <= 24)
                    break;
                Console.WriteLine("Nhập lại số giờ làm");
            }
            Console.Write("Nhập số lương giờ: ");
            while (true)
            {
                if (byte.TryParse(Console.ReadLine(), out Luong_gio) && Luong_gio >= 0 && Luong_gio <= 50) ;
                break;
                Console.WriteLine("Nhập lại số lương giờ.");

            }
            if (So_gio <= 8)
            {
                double Tien_luong = So_gio * Luong_gio;
                Console.WriteLine($"Lương một ngày của nhân viên: {Tien_luong}");
            }
            else
            {
                double Tien_luong = Luong_gio + (So_gio - 8) * Luong_gio * 1.5;
                Console.WriteLine($"Lương một ngày của nhân viên: {Tien_luong}");

            }
        }
        static void Bai1_4()
        {
            char c;
            Console.Write("Nhập số thứ 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập số thứ 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập phép tính cần tính (+, -, *, /): ");
            c = Convert.ToChar(Console.ReadLine());
            float? kq = null;
            switch (c)
            {
                case '+': kq = a + b; break;
                case '-': kq = a - b; break;
                case '*': kq = a * b; break;
                case '/': kq = a / b; break;
            }
            Console.WriteLine($"{a} {c} {b} = {kq}");




        }
        static void Bai1_5()
        {
            int count = 0;
            string password, user;
            Console.Write("Tên đăng nhập: ");
            user = Console.ReadLine();
            do
            {
                if (count == 0)
                {
                    Console.Write("Nhập mật khẩu: ");

                }
                else
                    Console.Write("Nhập lại mật khẩu!");
                password = Console.ReadLine();
                if (password == "123")
                {
                    Console.WriteLine("Đăng nhập thành công!");
                    break;
                }
            } while (count < 3);


        }
        static int[] NhapMang()
        {
            int[] a;
            int n;
            do
            {
                Console.Write("Nhập số lượng phần tử mảng [3, 20]: ");
                n = Convert.ToInt32(Console.ReadLine());

            } while (n < 3 || n > 20);
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i}: ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            return a;

        }
        static void XuatMang(int[] a)
        {
            Console.WriteLine("Xuất mảng: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{a[i]}\t");
            }
        }
        static void Hoandoi(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
            y = temp;
        }
        static void SapXep(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                for (int j = i + 1; j < a.Length; j++)
                    if (a[i] > a[j])
                        Hoandoi(ref a[i], ref a[j]);
        }

        static void Bai1_6()
        {
            int[] a = NhapMang();
            Console.WriteLine("Mảng trước khi được sắp xếp: ");
            XuatMang(a);
            SapXep(a);
            Console.WriteLine("Mảng sau khi được sắp xếp: ");
            XuatMang(a);

        }
        static void Bai1_7()
        {
            int year;
            do
            {
                Console.Write("Nhập số nanmw cần kiểm tra: ");
                year = Convert.ToInt32(Console.ReadLine());
                if (year <= 0)
                {
                    Console.WriteLine("Năm không hợp lệ");
                }
            } while (year <= 0);
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine($"Năm {year} là năm nhuận.");
            }
            else
            {
                Console.WriteLine($"Năm {year} không là năm nhuận.");
            }
        }
        static void Bai1_8()
        {
            char kitu;
            Console.Write("Nhập một kí tự cần kiểm tra: ");
            kitu = Convert.ToChar(Console.ReadLine());
            switch (kitu)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine($"Kí tự {kitu} là nguyên âm.");
                    break;
                default:
                    if (kitu >= '0' && kitu <= '9')
                    {
                        Console.WriteLine($"Kí tự {kitu} là chữ số.");
                    }
                    else if ((kitu >= 'a' && kitu <= 'z') || (kitu >= 'A' && kitu <= 'Z'))
                    {
                        Console.WriteLine($"Kí tự {kitu} là phụ âm.");
                    }
                    else
                    {
                        Console.WriteLine($"Kí tự {kitu} là kí tự đặc biệt.");
                    }
                    break;




            }
        }  
        static void Bai1_9()
        {
            double p, m;
            int n;
            Console.Write("Nhập số dân hiện tại: ");
            p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập số năm: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập tỉ lệ gia tăng dân số: ");
            m = Convert.ToDouble(Console.ReadLine());
            double P = p * Math.Pow(1 + m / 100, n);
            Console.WriteLine($"Dân số sau {n} năm là: {P}");

        }


            static void Main(string[] args)
            {
                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Console.Write("Nhập vào số bài cần chạy: ");
                byte chon = Convert.ToByte(Console.ReadLine());
                switch (chon)
                {
                    case 1: Bai1_1(); break;
                    case 2: Bai1_2(); break;
                    case 3: Bai1_3(); break;
                    case 4: Bai1_4(); break;
                    case 5: Bai1_5(); break;
                    case 6: Bai1_6(); break;
                    case 7: Bai1_7(); break;
                    case 8: Bai1_8(); break;
                    case 9: Bai1_9(); break;

                   




                }


            }
        }
    }
