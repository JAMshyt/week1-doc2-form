using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Форма_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = 0, B = 0, X = 0, Y = 0,count = 0;
            do
            {
                do
                {
                    try
                    {
                        A = Convert.ToInt32(textBox1.Text);
                        break;
                    }
                    catch
                    {
                        textBox1.Text = "Error";
                        break;
                    }
                } while (true);
                do
                {
                    try
                    {
                        B = Convert.ToInt32(textBox2.Text);
                        break;
                    }
                    catch
                    {
                        textBox2.Text = "Error";
                        break;
                    }
                } while (true);
                if (A <= B)
                {
                }
                else
                {
                    richTextBox1.Text = "А должно быть <= B";
                    break;
                }
                do
                {
                    try
                    {
                        X = Convert.ToInt32(textBox3.Text);
                        Y = Convert.ToInt32(textBox4.Text);
                        richTextBox1.Text = "";
                        richTextBox1.Text += "Do while \n";
                        int i = A;
                        do
                        {
                            if (i % 10 == X || i % 10 == -X || i % 10 == Y || i % 10 == -Y)
                            {
                                richTextBox1.Text += " " + i + "\n";
                                count++;
                            }
                            i++;
                        } while (i <= B & count < 5);
                        richTextBox1.Text += "While \n";
                        i = A;
                        count = 0;
                        while (i <= B & count < 5)
                        {
                            if (i % 10 == X || i % 10 == -X || i % 10 == Y || i % 10 == -Y)
                            {
                                richTextBox1.Text += " " + i + "\n";
                                count++;
                            }
                            i++;
                        }
                        int j = A;
                        count = 0;
                        richTextBox1.Text += "For \n";
                        for (; j <= B & count < 5; j++)
                        {
                            if (j % 10 == X || j % 10 == -X || j % 10 == Y || j % 10 == -Y)
                            {
                                richTextBox1.Text += " " + j + "\n";
                                count++;
                            }
                        }
                        break;
                    }
                    catch
                    {
                        richTextBox1.Text = "только цифры";
                        break;
                    }
                } while (true);
                break;
            } while (true);
        }
    }
}
