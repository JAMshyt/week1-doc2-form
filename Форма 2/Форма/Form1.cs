using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Форма
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime today = DateTime.Now;
            int days;
            do
            {
                try
                {
                    days = Convert.ToInt32(textBox1.Text);
                    if (days < 0)
                    {
                        MessageBox.Show("вы ввели отрицательнок кол-во");
                        break;
                    }
                    else
                    {
                        var d = today.AddDays(-days).ToString("dd.MM.yyyy");
                        textBox2.Text = d;
                        break;
                    }
                }
                catch (Exception)
                {
                    textBox1.Text = "Ошибка";
                    break;
                }
            } while (true);


        }
    }
}
