using System;

using System.IO;

using System.Text;


namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            FileStream f = new FileStream("D:\\Học tập\\Coding\\C#\\Ghi đọc file\\hello.txt",
 FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for (int i = 0; i <= 20;i++)
            {
                string s = i + " ";
                byte[] data = Encoding.Unicode.GetBytes(s);
                f.Write(data, 0, data.Length);
            }
            f.Position = 0;
            StreamReader reader = new StreamReader(f, Encoding.Unicode);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
            f.Close();

        }
    }
}
