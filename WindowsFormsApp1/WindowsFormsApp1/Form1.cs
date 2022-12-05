using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = 0, y = 0;
            do
            {
                try
                {
                    x = Convert.ToDouble(textBox1.Text);
                }
                catch (Exception)
                {
                    textBox3.Text = "Ошибка в x";
                    break;
                }

                try
                {
                    y = Convert.ToDouble(textBox2.Text);
                }
                catch (Exception)
                {
                    textBox3.Text = "Ошибка в y";
                    break;
                }

                try
                {
                    if (x < 50 && y < 25)
                    {
                        textBox3.Text = "Внутри";
                        break;
                    }
                    else if ((x == 50 & y <= 25) || (x <= 50 & y == 25))
                    {
                        textBox3.Text = "На границе";
                        break;
                    }
                    else
                    {
                        textBox3.Text = "Вне";
                        break;
                    }

                }
                catch (Exception)
                {
                    textBox3.Text = "Где-то ошибка";
                    break;
                }
            } while (true);
        }
    }
}
