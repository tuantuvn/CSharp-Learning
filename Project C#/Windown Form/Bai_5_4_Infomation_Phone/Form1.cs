using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Bai_5_4_Infomation_Phone
{

    public partial class Form1 : Form
    {
        List<Phone> ds_dienthoai = new List<Phone>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            this.Region = new Region(path);

           






            DocFile();
            HienThi();
        }
        void DocFile()
        {
            if (!File.Exists("Phones.txt")) return;
            string [] lines = File.ReadAllLines("Phones.txt");
            for (int i = 0; i < lines.Length; i+=4)
            {
                Phone p = new Phone(lines[i],
                    lines[i + 1],
                    double.Parse(lines[i + 2]),
                    lines[i + 3]
                    );
                ds_dienthoai.Add(p);

            }
        }
        void GhiFile()
        {
            StreamWriter sw = new StreamWriter("Phones.txt");

            foreach (Phone p in ds_dienthoai)
            {
                sw.WriteLine(p.MaSo);
                sw.WriteLine(p.NhanHieu);
                sw.WriteLine(p.GiaNhap);
                sw.WriteLine(p.HinhAnh);
            }
            sw.Close();


        }
        void HienThi()
        {
            dgvPhone.DataSource = null;
            dgvPhone.DataSource = ds_dienthoai;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnMax_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "JPG Files|*.jpg;*.jpeg|" +
              "PNG Files|*.png|" +
              "BMP Files|*.bmp|" +
              "WEBP Files|*.webp|" +
              "All Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.webp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picHinh.ImageLocation = open.FileName;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Phone p = new Phone(txtMaSo.Text, 
                    label2.Text, 
                    double.Parse(txtGiaNhap.Text), 
                    picHinh.ImageLocation);
            ds_dienthoai.Add(p);
            HienThi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string maSo = txtMaSo.Text; 
            Phone p = ds_dienthoai.Find(x => x.MaSo == maSo);
            if (p != null)
            {
                ds_dienthoai.Remove(p);
                HienThi();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string maSo = txtMaSo.Text;
            Phone p = ds_dienthoai.Find(x => x.MaSo == maSo);
            if (p != null)
            {
                txtGiaBan.Text = p.TinhGiaBan().ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ds_dienthoai.Sort();
            HienThi();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            GhiFile();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
