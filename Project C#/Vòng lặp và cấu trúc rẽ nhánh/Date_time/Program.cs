using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhập tháng: ");
            string month = Console.ReadLine();
            Console.Write("Nhập năm: ");
            string year = Console.ReadLine();
            int month_1 = Convert.ToInt32(month);
            int year_1 = Convert.ToInt32(year);
            int day = 0;

            if (month_1 >= 1 && month_1 <= 12)
            {
                switch (month_1)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        day = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        day = 30;
                        break;
                    case 2:
                        if (year_1 % 400 == 0 || year_1 % 4 == 0 && year_1 % 100 != 0)
                            day = 29;
                        else day = 28;
                        break;
                }
                Console.WriteLine($"Tháng {month_1}/{year_1} có {day} ngày");

            }
            else
                Console.WriteLine("Tháng không hợp lệ");
            Console.ReadLine();
        }
    }
}
