using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuyenDoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhập giá trị: ");
            double Giatri = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập đơn vị đo (m, km, mile): ");
            string Donvi = Console.ReadLine().ToLower();
            switch (Donvi)
            {
                case "m":
                    Console.WriteLine($"Giá trị chuyển đổi: {Giatri} mét = {Giatri * 0.001} kilômét");
                    break;
                case "km":
                    Console.WriteLine($"Giá trị chuyển đổi: {Giatri} mét = {Giatri * 1000} mét");
                    break;
                case "mile":
                    Console.WriteLine($"Giá trị chuyển đổi: {Giatri} mét = {Giatri * 1.60934} kilômét");
                    break;
                default:
                    Console.WriteLine("Đơn vị đo không hợp lệ");
                    break;
                    
            }
            

        }
    }
}
