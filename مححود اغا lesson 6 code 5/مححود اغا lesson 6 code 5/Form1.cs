using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace مححود_اغا_lesson_6_code_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        int s = 0, m = 0, h = 0, y = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            if (s > 9)
                label1.Text = s.ToString();
            else
                label1.Text = 0 + s.ToString();
            if (s > 59)
            {
                m++; s = 0;
                if (m > 9)
                    label2.Text = m.ToString();
                else
                    label2.Text = 0 + m.ToString();}
                if (m > 59)
                {
                    h++; m = 0;
                    if (h > 9)
                        label3.Text = h.ToString();
                    else
                        label3.Text = 0 + h.ToString();
                }
                if (h > 12)
                {
                    h = 0;
                    y++;
                    switch(y)
                    { case '1':
                            label4.Text="Sat";
                            break;
                        case '2':
                            label4.Text="sun";
                            break;
                        case '3':
                            label4.Text="Mon";
                            break;
                        case '4':
                            label4.Text="tus";
                            break;
                        case '5':
                            label4.Text="wed";
                            break;
                        case '6':
                            label4.Text="thr";
                            break;
                        case '7':
                            label4.Text="fri";
                            break;
                        default:
                            break;
                    }
                    

                }


            }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.SeaGreen;
            button1.BackColor = Color.Blue;
            button2.BackColor = Color.Red;
        }

        }
    
}
