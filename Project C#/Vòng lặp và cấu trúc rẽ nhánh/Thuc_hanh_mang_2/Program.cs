using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuc_hanh_mang_2
{
    internal class Program
    {
        static void Lab1()
        {
            int[] Mang_A;
            Console.Write("Nhập n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Mang_A = new int[n];
            Console.WriteLine("Nhập các phần tử mảng: ");
            for (int i = 0; i < n; i++)
            {
                Mang_A[i]= Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0;i < n; i++)
            {
                Console.Write($"{Mang_A[i]} ");
            }
            
          
        }
        static void Lab2()
        {
            int[] Mang_B;
            Console.Write("Nhập n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Mang_B = new int[n];
            Console.WriteLine("Nhập các phần tử mảng: ");
            for (int i = 0; i < n; i++)
            {
                Mang_B[i] = Convert.ToInt32(Console.ReadLine());

            }
            int max = Mang_B[0];
            for (int i = 0;i < n; i++)
            {
                if (Mang_B[i] > max)
                    max = Mang_B[i];
            }
            Console.WriteLine($"Phần tử lớn nhất trong mảng là: {max}");
        }
        static void Lab3()
        {
            int[] Mang_C;
            Console.Write("Nhập n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Mang_C = new int[n];
            Console.Write("Nhập các phần tử mảng: ");
            for (int i = 0; i < n; i++)
            {
                Mang_C[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Các phần tử chẵn có trong mảng là:");
            for (int i = 0; i < n; i++)
            {
                if (Mang_C[i] % 2 == 0)
                {
                    Console.Write($"{Mang_C[i]} ");
                }
            }
            
        }
        static void Lab4()
        {
            int[] Mang_D;
            Console.Write("Nhập n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Mang_D = new int[n];
            Console.Write("Nhập số k: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập các phần tử mảng: ");
            for (int i = 0; i < n; i++)
            {
                Mang_D[i] = Convert.ToInt32(Console.ReadLine());

            }
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (Mang_D[i] == k)
                    dem++;


            }
            Console.WriteLine($"Số {k} xuất hiện trong mảng {dem} lần.");

        }
        static void Lab5()
        {
            int[] Mang_E;
            Console.Write("Nhập n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Mang_E = new int[n];
            Console.WriteLine("Nhập các phần tử mảng: ");
            for (int i = 0; i < n; i++)
            {
                Mang_E[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Write("Các số lớn hơn 0 và nhỏ hơn 10 có trong mảng là: ");
            foreach (int i in Mang_E)
            {
                if (Mang_E[i] > 0 && Mang_E[i] < 10)
                    Console.Write($"{Mang_E[i]} ");
                    
            }
        }
        static void Lab6()
        {
            int[] Mang_F;
            Console.Write("Nhập n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Mang_F = new int[n];
            Console.WriteLine("Nhập các phần tử mảng: ");
            for (int i = 0; i < n; i++)
            {
                Mang_F[i] = Convert.ToInt32(Console.ReadLine());

            }
            Array.Sort(Mang_F);
            Console.Write("Mảng sau khi được sắp xếp là: ");
            foreach (int i in Mang_F)
            {
                Console.Write($"{Mang_F[i]} ");
            }
        }
        static void Lab7()
        {
            int m, n;
            Console.Write("Nhập m: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập n: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] Mang_2_chieu_1 = new int[m, n];
            Console.WriteLine("Nhập các phần tử mảng 2 chiều: ");
            for (int i = 0;i < m; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    Console.Write($"Phần tử a[{i},{j}]: ");
                    Mang_2_chieu_1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int Tong = 0;
            foreach (int x in Mang_2_chieu_1)
            {
                Tong += x;
            }
            Console.WriteLine($"Tổng của mảng 2 chiều là: {Tong}");
        


        }
        static void Lab8()
        {
            int m, n;
            Console.Write("Nhập m: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập n: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] Mang_2_chieu_1 = new int[m, n];
            Console.WriteLine("Nhập các phần tử mảng 2 chiều: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Phần tử a[{i},{j}]: ");
                    Mang_2_chieu_1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int Tong = 0;
            foreach (int x in Mang_2_chieu_1)
            {
                if (x % 3 == 0) 
                    Tong += x;

            }
            Console.WriteLine($"Tổng của mảng 2 chiều chia hết cho 3 là: {Tong}");
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhập số bài Lab cần thực hiện: ");
            byte chon = Convert.ToByte(Console.ReadLine());
            switch (chon)
            {
                case 1: Lab1(); break;
                case 2: Lab2(); break;
                case 3: Lab3(); break;
                case 4: Lab4(); break;
                case 5: Lab5(); break;
                case 6: Lab6(); break;
                case 7: Lab7(); break;
                case 8: Lab8(); break;






            }
        }
    }
}
