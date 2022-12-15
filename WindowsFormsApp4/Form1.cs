using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = (double.Parse(textBox1.Text) + double.Parse(textBox2.Text) + double.Parse(textBox3.Text) + double.Parse(textBox4.Text) + double.Parse(textBox5.Text)) / 5;
            textBox6.Text = a.ToString();
            double b = a - double.Parse(textBox1.Text);
            double c = a - double.Parse(textBox2.Text);
            double d = a - double.Parse(textBox3.Text);
            double es = a - double.Parse(textBox4.Text);
            double f = a - double.Parse(textBox5.Text);
            textBox7.Text = b.ToString();
            textBox8.Text = c.ToString();
            textBox9.Text = d.ToString();
            textBox10.Text = es.ToString();
            textBox11.Text = f.ToString();
            double zebra = b;
            double zebra2 = c;
            double zebra3 = d;
            double zebra4 = es;
            double zebra5 = f;
            if(b<0 )
            {
                zebra = b*(-1);
            } 
            if(c<0)
            {
                zebra2 = c*(-1);
            }
            if (d < 0)
            {
                zebra3= d*(-1);
            }
            if (es < 0)
            {
                zebra4 = es*(-1);
            }
            if(f < 0)
            {
                zebra5 = f*(-1);
            }
            double n = Math.Sqrt(20);
            double xsr = (zebra + zebra2 + zebra3 + zebra4 + zebra5)/5;

            double ysr = (zebra +zebra2 + zebra3+ zebra4 + zebra5)/n;
            textBox12.Text = xsr.ToString();
            double r = Math.Round((xsr/a)%100,2);
            textBox13.Text = r.ToString();
            textBox14.Text = Math.Round(ysr,2).ToString();
        }
    }
}
