using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        const double PI = 3.14;
        const int SoNgayTrongTuan = 7;
        const int SoThangTrongNam = 12;
        static void Main(string[] args)
        {
           Bai1_1();
           Bai1_2();
           Bai1_3();

        }
        static void Bai1_1()
        {
            Console.WriteLine($"Giá trị của pi là: {PI}");
            Console.WriteLine($"Số ngày trong một tuần là: {SoNgayTrongTuan}");
            Console.WriteLine($"Số tháng trong một năm là: {SoThangTrongNam}");
        }
        static void Bai1_2()
        {
            Console.Write("Nhập bán kính của hình tròn: ");
            double banKinh = Convert.ToDouble(Console.ReadLine());

            // Tính diện tích và chu vi sử dụng hằng PI
            double dienTich = PI * banKinh * banKinh;
            double chuVi = 2 * PI * banKinh;

            Console.WriteLine($"Diện tích của hình tròn là: {dienTich}");
            Console.WriteLine($"Chu vi của hình tròn là: {chuVi}");
        }
        static void Bai1_3()
        {
            Console.Write("Nhập bán kính của hình tròn: ");
            double banKinh = Convert.ToDouble(Console.ReadLine());

            // Tính diện tích sử dụng hằng PI
            double dienTich = PI * banKinh * banKinh;

            Console.WriteLine($"Diện tích của hình tròn là: {dienTich}");
        }

    }
}
