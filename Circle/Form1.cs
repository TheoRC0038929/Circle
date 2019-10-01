using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            double radius;

            try
            {
                radius = double.Parse(Textbox1.Text);
            }
            catch
            {
                MessageBox.Show(Textbox1.Text + " , this doesnt look like a number");
                radius = 0;
            }

            double circumference = 2 * Math.PI * radius;
            label1.Text = "Circumference =" + circumference;

            double area = Math.PI * (radius * radius);
            label2.Text = "Area =" + area;

        }
    }
}
