using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace UNIXTIME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            long i = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
            label2.Text = i.ToString();                       
            label6.Text = Convert.ToString(i, 2);           
            DateTime nowDate = DateTime.Now;
            label4.Text= nowDate.ToString("r");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image baseImage = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(baseImage);
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), Screen.AllScreens[0].Bounds.Size);
            g.Dispose();
            baseImage.Save(Environment.UserName + ".jpg");
        }
    }
}
