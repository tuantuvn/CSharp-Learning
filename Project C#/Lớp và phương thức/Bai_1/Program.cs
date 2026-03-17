using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
   interface TPhi
    {
        double LaiSuat { get; set; }
        double TinhTienLai();
    }

    class ATM_card
    {
        protected string So_the;
        protected string Ho_va_ten;
        protected double So_du;
        public ATM_card()
        {
            So_the = null;
            Ho_va_ten = null;
            So_du = 0;
        }
        public ATM_card(string Sothe, string Hovaten, double Sodu)
        {
            this.So_the = Sothe;
            this.Ho_va_ten = Hovaten;
            this.So_du = Sodu;
        }
        public virtual void Nhap_thong_tin_the()
        {
            Console.Write("Nhập số thẻ: ");
            this.So_the = Convert.ToString(Console.ReadLine());
            Console.Write("Nhập họ và tên: ");
            this.Ho_va_ten = Convert.ToString(Console.ReadLine());
            Console.Write("Nhập số dư tài khoản: ");
            this.So_du = Convert.ToDouble(Console.ReadLine());
        }
        public virtual void Xuat_thong_tin_the()
        {
            Console.WriteLine($"Số thẻ: {this.So_the}");
            Console.WriteLine($"Họ và tên chủ thẻ: {this.Ho_va_ten}");
            Console.WriteLine($"Số dư thẻ: {this.So_du}");
        }
    }
    class Credit_Card : ATM_card, TPhi
    {
        private double So_tien_chi;
        private DateTime Ngay_chi;
        public double TinhTienLai()
        {
            int soNgay = (DateTime.Now - Ngay_chi).Days;
            if (soNgay < 45 || (So_du - So_tien_chi) > 0)
            {
                return 0;
            }else if ((So_du - So_tien_chi) < 0 && soNgay > 60)
            {
                return Math.Abs(So_du - So_tien_chi) * 1.5 * LaiSuat;
            }else if ((So_du - So_tien_chi) < 0 && soNgay >= 45)
            {
                return Math.Abs(So_du - So_tien_chi) * LaiSuat;
            }
            return 0;
           
        }
        public void Cap_nhat_so_du()
        {
            So_du -= TinhTienLai();
        }
        
        
        public Credit_Card()
        {
            So_tien_chi = 0;
            Ngay_chi = DateTime.Now;
        }
        public Credit_Card(string sothe, string Hoten, double sodu,double Sotienchi, DateTime ngaychi ): base(sothe,Hoten,sodu)
        {
            So_tien_chi = Sotienchi;
            Ngay_chi = ngaychi;
        }
        public override void Nhap_thong_tin_the()
        {
            base.Nhap_thong_tin_the();
            Console.Write("Nhập số tiền chi: ");
            So_tien_chi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập số ngày chi (dd/MM/yyyy): ");
            Ngay_chi = DateTime.Parse(Console.ReadLine());
            Console.Write("Lãi suất: ");
            LaiSuat = Convert.ToDouble(Console.ReadLine());
        }
        public double LaiSuat { get; set; }
        public override void Xuat_thong_tin_the()
        {
            base.Xuat_thong_tin_the();
            Console.Write($"Số tiền lãi: {TinhTienLai()}");
            
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.Write("Nhập số lượng thẻ Credit: ");
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 2 || n > 20)
                    Console.WriteLine("Số lượng thẻ không hợp lệ. Vui lòng nhập lại");
            } while (n < 2 || n > 20);
            List <Credit_Card> ds = new List<Credit_Card>();
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập thông tin thẻ thứ {i + 1}: ");
                Credit_Card tc = new Credit_Card(); ;
                tc.Nhap_thong_tin_the();
                ds.Add(tc);
            }
            Console.WriteLine($"Thông tin của {n} thẻ: ");
            foreach (var tc in ds)
            {
                tc.Xuat_thong_tin_the();
            }
            Console.WriteLine("Thêm 1 thẻ vào đầu danh sách: ");
            Credit_Card them = new Credit_Card();
            them.Nhap_thong_tin_the() ;
            ds.Insert(0,them);
            Console.WriteLine("Danh sách thẻ sau khi thêm: ");
            foreach (Credit_Card cc in ds)
            {
                cc.Xuat_thong_tin_the();
            }
            double tonglai = 0;
            int dem = 0;
            foreach (var tc in ds)
            {
                if (tc.TinhTienLai() != 0 && DateTime.Now.Year == DateTime.Now.Year)
                {
                    tonglai += tc.TinhTienLai();
                    dem++;
                }
            }
            if (dem > 0)
                Console.WriteLine($"Tien lai trung binh: {tonglai / dem}");
            int dem15 = 0;
            foreach (var tc in ds)
            {
                if (tc.TinhTienLai() != 0 &&
                    Math.Abs(tc.TinhTienLai() / tc.LaiSuat) > Math.Abs(tc.TinhTienLai()))
                    dem15++;
            }

            Console.WriteLine($"So the bi tinh lai 1.5 lan: {dem15}");





        }
    }
}
