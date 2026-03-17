using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinhluong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhập số tiền lương: ");
            string So_luong = Console.ReadLine();
            Console.Write("Nhập số tiền thưởng: ");
            string So_thuong = Console.ReadLine();
            int So_luong_int = Convert.ToInt32(So_luong);
            int So_thuong_int = Convert.ToInt32(So_thuong);
            int Thu_nhap = So_luong_int + So_thuong_int;
            if (Thu_nhap < 9)
            {
                Console.WriteLine("Không đóng thuế.");

            }else if (Thu_nhap >= 9 && Thu_nhap <= 15)
            {
                Console.WriteLine("Thuế 10%.");
            }else if (Thu_nhap >= 15 &&  Thu_nhap <= 30)
            {
                Console.WriteLine("Thuế 20%.");
            }
            else
            {
                Console.WriteLine("Thuế 20%");
            }
            
        }
    }
}
