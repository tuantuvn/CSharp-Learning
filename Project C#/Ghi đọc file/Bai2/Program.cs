using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                FileStream f = new FileStream("\"D:\\Học tập\\Coding\\C#\\Ghi đọc file\\data.txt\"",
            FileMode.Open);
                StreamReader rd = new StreamReader(f, Encoding.UTF8);
                string line;
                // doc va hien thi cac dong cho toi cuoi file
                while ((line = rd.ReadLine()) != null)
                { Console.WriteLine(line); }
            }
            catch
            {
                Console.WriteLine("Khong the doc file da cho: ");
















            }
        }
    }
}
