using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        bool Clicked = false;
        Class1 num1 = new WindowsFormsApplication1.Class1();
        Class1 num2 = new WindowsFormsApplication1.Class1();
        Class1 num3 = new WindowsFormsApplication1.Class1();
        Class1 num4 = new WindowsFormsApplication1.Class1();
        Class1 num5 = new WindowsFormsApplication1.Class1();
        int sum;


        public Form1()
        {
           
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
            



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Clicked==false)
            {
                Random r = new Random();
                num1.setnum(r.Next(1, 100));
                label1.Text = num1.getnum().ToString();

                num2.setnum(r.Next(1, 100));
                label2.Text = num2.getnum().ToString();

                num3.setnum(r.Next(1, 100));
                label3.Text = num3.getnum().ToString();

                num4.setnum(r.Next(1, 100));
                label4.Text = num4.getnum().ToString();

                num5.setnum(r.Next(1, 100));
                label5.Text = num5.getnum().ToString();
            }
            else
            {
                sum = num1.getnum() + num2.getnum() + num3.getnum() + num4.getnum() + num5.getnum();
                timer1.Enabled = false;
                MessageBox.Show("To Athrisma Einai : " + sum);
            }
            



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Clicked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            Clicked = false;
            timer1.Enabled = true;
        }
    }
    
}
