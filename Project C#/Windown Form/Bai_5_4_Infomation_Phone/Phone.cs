using System;
namespace Bai_5_4_Infomation_Phone
{
    public class Phone : IComparable<Phone>
    {
        public string MaSo { get; set; }
        public string NhanHieu { get; set; }
        public double GiaNhap { get; set; }
        public string HinhAnh { get; set; }
        public Phone() { }
        public Phone(string maSo, string nhanHieu, double giaNhap, string hinhAnh)
        {
            MaSo = maSo;
            NhanHieu = nhanHieu;
            GiaNhap = giaNhap;
            HinhAnh = hinhAnh;
        }
        public double TinhGiaBan()
        {
            if (NhanHieu.ToLower() == "iphone")
            {
                return GiaNhap * 1.5;
            }else
                return GiaNhap * 1.3;
        } 
        public int CompareTo(Phone other)
        {
            return this.MaSo.CompareTo(other.MaSo);
        }
    }
}
