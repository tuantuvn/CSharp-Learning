using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_tuan_12
 
{
    class Sinh_Vien
    {
        public int MSSV { get; set; }
        public string Ho_ten { get; set; }
        public DateTime Ngay_sinh { get; set; }
        public double Diem_Trung_Binh { get; set; }
        public void Nhap()
        {
            do {
                Console.Write("Mã số sinh viên: ");
                this.MSSV = Convert.ToInt32(Console.ReadLine());
                if (this.MSSV <= 0)
                    Console.WriteLine("MSSV không hợp lệ. Vui lòng nhập lại!");
            }while (this.MSSV <= 0);
            Console.Write("Họ và tên sinh viên: ");
            this.Ho_ten = Console.ReadLine();
            DateTime ns;
            Console.Write("Ngày sinh: ");
            while (!DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",CultureInfo.InvariantCulture, DateTimeStyles.None, out ns))
            {
                Console.Write("Sai định dạng! Nhập lại (dd/MM/yyyy): ");
            }
            this.Ngay_sinh = ns;
            
            Console.Write("Điểm trung bình: ");
            this.Diem_Trung_Binh = Convert.ToDouble(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine($"{this.MSSV,-6}{this.Ho_ten,-15}\t{this.Ngay_sinh:dd/MM/yyyy}\t{this.Diem_Trung_Binh,-15}");

        }
        public int Tinh_tuoi()
        {
            return DateTime.Now.Year - Ngay_sinh.Year;
        }


    }
    internal class Program
    {
         static void Nhap_danh_sach (List<Sinh_Vien> danh_sach)
        {
            int n;
            do
            {
                Console.Write("Nhập số lượng sinh viên cần nhập (5 < n < 100): ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 5 || n > 100)
                {
                    Console.WriteLine("n không đúng, vui lòng nhập lại !");
                }
            } while (n < 5 || n > 100);
            danh_sach.Clear();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập sinh viên thứ {i + 1}: ");
                Sinh_Vien sv = new Sinh_Vien();
                sv.Nhap();
                danh_sach.Add(sv);
            }

        }
        static void Xuat_Danh_Sach (List <Sinh_Vien> danh_sach)
        {
            Console.WriteLine("\nMã số \t Họ và tên \t Ngày sinh \t Điểm trung bình");
            foreach (Sinh_Vien sv in danh_sach)
            {
                sv.Xuat();
            }
        }
        static void Them_Sinh_Vien (List <Sinh_Vien> danh_sach)
        {
            Console.Write("Nhập vị trí i: ");
            int i = Convert.ToInt32 (Console.ReadLine());
            if (i <= 0 && i <= danh_sach.Count)
            {
                Sinh_Vien sv = new Sinh_Vien();
                sv.Nhap();
                danh_sach.Insert(i, sv);
            }
            else
                Console.WriteLine("Vị trí không hợp lệ!");
            Xuat_Danh_Sach(danh_sach);
        }
        static void Xoa_Sinh_Vien_Diem_0(List <Sinh_Vien> danh_sach)
        {
            for (int i = danh_sach.Count - 1; i >= 0; i--)
            {
                if (danh_sach[i].Diem_Trung_Binh == 0)
                    danh_sach.RemoveAt(i);
            }
            Console.WriteLine("Danh sách sinh viên sau khi xoá:");
            Xuat_Danh_Sach(danh_sach);
        }
        static void Sua_Ma_Sinh_Vien(List<Sinh_Vien> danh_sach)
        {
            Console.WriteLine("Nhập mã số sinh viên cần sửa: ");
            int ma_so = Convert.ToInt32(Console.ReadLine());
            foreach (Sinh_Vien sv in danh_sach){
                if (ma_so == sv.MSSV)
                {
                    Console.WriteLine("Nhập lại thông tin: ");
                    sv.Nhap();
                    return;
                }
                else
                    Console.WriteLine("Không tìm thấy thông tin sinh viên!");
            }
            Console.WriteLine("Danh sách sau khi sửa: ");
            Xuat_Danh_Sach(danh_sach);
        }
        static void Tuoi_Trung_Binh(List<Sinh_Vien> danh_sach)
        {
            int tong = 0;
            foreach (Sinh_Vien sv in danh_sach)
            {
                tong += sv.Tinh_tuoi();

            }
            double tb = (double)tong / danh_sach.Count;
            Console.WriteLine($"Tuổi trung bình của cả lớp: {tb}");

        }
        static void Sap_xep_diem (List <Sinh_Vien> danh_sach)
        {
            for (int i = 0;i < danh_sach.Count - 1; i++)
            {
                for (int j = i + 1; j < danh_sach.Count; j++)
                {
                    Sinh_Vien temp = danh_sach[i];
                    danh_sach[i] = danh_sach[j];
                    danh_sach[j] = temp;
                }
            }
            Console.WriteLine("Danh sách sinh viên sau khi sắp xếp:");
            Xuat_Danh_Sach(danh_sach);
        }
        
        
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding =Encoding.Unicode;
            List <Sinh_Vien> danh_Sach = new List <Sinh_Vien>();
            byte Lua_chon;
            do
            {
                Console.WriteLine("\n======MENU======");
                Console.WriteLine("1. Nhập danh sách sinh viên");
                Console.WriteLine("2. Xuất danh sách sinh viên");
                Console.WriteLine("3. Thêm sinh viên vào vị trí i");
                Console.WriteLine("4. Xoá sinh viên có điểm trung bình = 0");
                Console.WriteLine("5. Sửa thông tin sinh viên theo mã số");
                Console.WriteLine("6. Tính tuổi trung bình của lớp");
                Console.WriteLine("7. Sắp Xếp sinh viên theo điểm giảm dần");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn: ");
                Lua_chon = Convert.ToByte(Console.ReadLine());

                switch (Lua_chon)
                {
                    case 1:
                        Nhap_danh_sach(danh_Sach); break;
                    case 2:
                        Xuat_Danh_Sach(danh_Sach); break;
                    case 3:
                        Them_Sinh_Vien(danh_Sach); break;
                    case 4:
                        Xoa_Sinh_Vien_Diem_0(danh_Sach); break;
                    case 5:
                        Sua_Ma_Sinh_Vien(danh_Sach); break;
                    case 6:
                        Tuoi_Trung_Binh(danh_Sach); break;
                    case 7:
                        Sap_xep_diem(danh_Sach); break;

                }

            } while (Lua_chon != 0);

        }
    }
}
