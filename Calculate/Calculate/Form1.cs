﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    
    public partial class Calculator : System.Windows.Forms.Form
    {

        double butt_1 = 0;
        double butt_2 = 0;
        double butt_3 = 0;
        double butt_4 = 0;
        double butt_5 = 0;
        double butt_6 = 0;
        double butt_7 = 0;
        double butt_8 = 0;
        double butt_9 = 0;
        double butt_0 = 0;

        bool status_plus;
        bool status_minus;
        bool status_mult;
        bool status_div;
        bool status_tochka;
        bool status_tochka2;
        bool status_main_clear;
        bool status_size_open;
        bool status_button_scrole;
        bool status_memory;
        bool status_ravno;
        bool status_stepen;
        bool status_chislo_obrat;

        double chislo1 = 0;
        double chislo2 = 0;
        double chislo3 = 0;
        double chislo4 = 0;
        double chislo5 = 1;
        double chislo6 = 0;
        double chislo_memory = 0;
        double chislo_koren = 0;
        double chislo_stepen = 0;
        double stepen = 0;
        double chislo_obrat = 0;

        public Calculator()
        {
            InitializeComponent();
            textBox1.Text = Convert.ToString(chislo1);
            textBox2.Text = Convert.ToString(chislo2);
            textBox3.Text = Convert.ToString(chislo3);
            label1.Text = " ";
            //label2.Text = " ";
            label4.Text = " ";
            label5.Text = " ";
            this.Size = new Size(400, 300);
            size.Text = "развернуть";
            koren.Visible = false;
            kvadrat.Visible = false;
            stepenX.Visible = false;
            obratnoe_chislo.Visible = false;
            status_button_scrole = false;
           
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }
        private void one_Click(object sender, EventArgs e)
        {
           /* ToolTip t = new ToolTip();
            t.SetToolTip(one, "цифрв Олин");*/

            butt_1 = 1;
            if (chislo1 == 0 && status_tochka == false)
            {
                chislo1 = butt_1;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_1 = 0;
            }
            else if (status_tochka == true)
            {
                butt_1 = 1;
                chislo4 = butt_1;
                chislo5 = chislo5 * 0.1;
                chislo6 = chislo4 * chislo5;
                chislo1 = chislo1 + chislo6;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_1 = 0;
            }
            else
            {
                chislo1 = (chislo1 * 10 ) + butt_1;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_1 = 0;
            }
            if (status_plus == true | status_minus == true | status_mult == true | status_div == true)
            {
                textBox2.Text = Convert.ToString(chislo1);
                if (status_size_open == true)
                {
                    textBox1.Text = Convert.ToString(0);
                }
            }
        }
        private void two_Click(object sender, EventArgs e)
        {
            butt_2 = 2;
            if (chislo1 == 0 && status_tochka == false)
            {
                chislo1 = butt_2;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_2 = 0;
            }
            else if (status_tochka == true)
            {
                butt_2 = 2;
                chislo4 = butt_2;
                chislo5 = chislo5 * 0.1;
                chislo6 = chislo4 * chislo5;
                chislo1 = chislo1 + chislo6;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_2 = 2;
            }
            else
            {
                chislo1 = (chislo1 * 10) + butt_2;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_2 = 0;
            }
            if (status_plus == true | status_minus == true | status_mult == true | status_div == true )
            {
                textBox2.Text = Convert.ToString(chislo1);
                if (status_size_open == true)
                {
                    textBox1.Text = Convert.ToString(0);
                }
            }
        }
        private void tree_Click(object sender, EventArgs e)
        {
            butt_3 = 3;
            if (chislo1 == 0 && status_tochka == false)
            {
                chislo1 = butt_3;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_3 = 0;
            }
            else if (status_tochka == true)
            {
                butt_3 = 3;
                chislo4 = butt_3;
                chislo5 = chislo5 * 0.1;
                chislo6 = chislo4 * chislo5;
                chislo1 = chislo1 + chislo6;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_3 = 0;
            }
            else
            {
                chislo1 = (chislo1 * 10) + butt_3;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_3 = 0;
            }
            if (status_plus == true | status_minus == true | status_mult == true | status_div == true )
            {
                textBox2.Text = Convert.ToString(chislo1);
                if (status_size_open == true)
                {
                    textBox1.Text = Convert.ToString(0);
                }
            }

        }
        private void fore_Click(object sender, EventArgs e)
        {
            butt_4 = 4;
            if (chislo1 == 0 && status_tochka == false)
            {
                chislo1 = butt_4;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_4 = 0;
            }
            else if (status_tochka == true)
            {
                butt_4 = 4;
                chislo4 = butt_4;
                chislo5 = chislo5 * 0.1;
                chislo6 = chislo4 * chislo5;
                chislo1 = chislo1 + chislo6;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_4 = 0;
            }
            else
            {
                chislo1 = (chislo1 * 10) + butt_4;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_4 = 0;
            }
            if (status_plus == true | status_minus == true | status_mult == true | status_div == true )
            {
                textBox2.Text = Convert.ToString(chislo1);
                if (status_size_open == true)
                {
                    textBox1.Text = Convert.ToString(0);
                }
            }
        }
        private void five_Click(object sender, EventArgs e)
        {
            butt_5 = 5;
            if (chislo1 == 0 && status_tochka == false)
            {
                chislo1 = butt_5;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_5 = 0;
            }
            else if (status_tochka == true)
            {
                butt_5 = 5;
                chislo4 = butt_5;
                chislo5 = chislo5 * 0.1;
                chislo6 = chislo4 * chislo5;
                chislo1 = chislo1 + chislo6;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_5 = 0;
            }
            else
            {
                chislo1 = (chislo1 * 10) + butt_5;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_5 = 0;
            }
            if (status_plus == true | status_minus == true | status_mult == true | status_div == true )
            {
                textBox2.Text = Convert.ToString(chislo1);
                if (status_size_open == true)
                {
                    textBox1.Text = Convert.ToString(0);
                }
            }
        }
        private void six_Click(object sender, EventArgs e)
        {
            butt_6 = 6;
            if (chislo1 == 0 && status_tochka == false)
            {
                chislo1 = butt_6;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_6 = 0;
            }
            else if (status_tochka == true)
            {
                butt_6 = 6;
                chislo4 = butt_6;
                chislo5 = chislo5 * 0.1;
                chislo6 = chislo4 * chislo5;
                chislo1 = chislo1 + chislo6;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_6 = 0;
            }
            else
            {
                chislo1 = (chislo1 * 10) + butt_6;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_6 = 0;
            }
            if (status_plus == true | status_minus == true | status_mult == true | status_div == true )
            {
                textBox2.Text = Convert.ToString(chislo1);
                if (status_size_open == true)
                {
                    textBox1.Text = Convert.ToString(0);
                }
            }
        }
        private void seven_Click(object sender, EventArgs e)
        {
            butt_7 = 7;
            if (chislo1 == 0 && status_tochka == false)
            {
                chislo1 = butt_7;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_7 = 0;
            }
            else if (status_tochka == true)
            {
                butt_7 = 7;
                chislo4 = butt_7;
                chislo5 = chislo5 * 0.1;
                chislo6 = chislo4 * chislo5;
                chislo1 = chislo1 + chislo6;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_7 = 0;
            }
            else
            {
                chislo1 = (chislo1 * 10) + butt_7;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_7 = 0;
            }
            if (status_plus == true | status_minus == true | status_mult == true | status_div == true )
            {
                textBox2.Text = Convert.ToString(chislo1);
                if (status_size_open == true)
                {
                    textBox1.Text = Convert.ToString(0);
                }
            }
        }
        private void eath_Click(object sender, EventArgs e)
        {
            butt_8 = 8;
            if (chislo1 == 0 && status_tochka == false)
            {
                chislo1 = butt_8;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_8 = 0;
            }
            else if (status_tochka == true)
            {
                butt_8 = 8;
                chislo4 = butt_8;
                chislo5 = chislo5 * 0.1;
                chislo6 = chislo4 * chislo5;
                chislo1 = chislo1 + chislo6;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_8 = 0;
            }
            else
            {
                chislo1 = (chislo1 * 10) + butt_8;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_8 = 0;
            }
            if (status_plus == true | status_minus == true | status_mult == true | status_div == true )
            {
                textBox2.Text = Convert.ToString(chislo1);
                if (status_size_open == true)
                {
                    textBox1.Text = Convert.ToString(0);
                }
            }
        }
        private void nine_Click(object sender, EventArgs e)
        {
            butt_9 = 9;
            if (chislo1 == 0 && status_tochka == false)
            {
                butt_9 = 9;
                chislo1 = butt_9;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_9 = 0;
            }
            else if (status_tochka == true)
            {
                butt_9 = 9;
                chislo4 = butt_9;
                chislo5 = chislo5 * 0.1;
                chislo6 = chislo4 * chislo5;
                chislo1 = chislo1 + chislo6;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_9 = 0;
            }
            else
            {
                butt_9 = 9;
                chislo1 = (chislo1 * 10) + butt_9;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_9 = 0;
            }
            if (status_plus == true | status_minus == true | status_mult == true | status_div == true )
            {
                textBox2.Text = Convert.ToString(chislo1);
                if (status_size_open == true)
                {
                    textBox1.Text = Convert.ToString(0);
                }
            }
        }
        private void zero_Click(object sender, EventArgs e)
        {
            if (chislo1 == 0 && status_tochka == false)
            {
                butt_0 = 0;
                chislo1 = butt_0;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_0 = 0;
            }
            else if (status_tochka == true)
            {
                if (status_tochka == true)
                {
                butt_0 = 0;
                chislo4 = butt_0;
                chislo5 = chislo5 * 0.1;
                chislo6 = chislo4 * chislo5;
                chislo1 = chislo1 + chislo6;
                    if (status_size_open == true )
                    {
                        textBox2.Text = Convert.ToString(textBox2.Text + "0");
                    }
                    else
                    {
                        textBox1.Text = Convert.ToString(textBox1.Text + "0");
                    }
                }
                butt_0 = 0;
            }
            else
            {
                butt_0 = 0;
                chislo1 = (chislo1 * 10) + butt_0;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
                butt_0 = 0;
            }
            if (status_plus == true | status_minus == true | status_mult == true | status_div == true )
            {
                textBox2.Text = Convert.ToString(chislo1);
                if (status_size_open == true)
                {
                    textBox1.Text = Convert.ToString(0);
                }
            }
        }
        private void plus_Click(object sender, EventArgs e)
        {
            if (status_size_open == true)
            {
                if (status_stepen == true)
                {
                    chislo3 = Math.Pow(chislo2, chislo1);
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                    status_stepen = false;
                }
                    else if (status_mult == true)
                {
                    chislo3 = chislo1 * chislo2;
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                    status_mult = false;
                }
                else if (status_div == true)
                {
                    chislo3 = chislo2 / chislo1;
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                    status_div = false;
                }
                else if (status_plus == true)
                {
                    chislo3 = chislo1 + chislo2;
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                }
                else if (status_minus == true)
                {
                    chislo3 = chislo2 - chislo1;
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);

                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                    status_minus = false;
                }
                else
                {
                    chislo2 = chislo1;
                    chislo1 = 0;
                    textBox1.Text = Convert.ToString(chislo1);
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox3.Text = Convert.ToString(chislo2);
                }
            }
            else
            {
                if (status_stepen == true)
                {
                    chislo3 = Math.Pow(chislo2, chislo1);
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    status_stepen = false;
                }
                if (status_mult == true)
                {
                    chislo3 = chislo1 * chislo2;
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    status_mult = false;
                }
                else if (status_div == true)
                {
                    chislo3 = chislo2 / chislo1;
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    status_div = false;
                }
                else if (status_plus == true)
                {
                    chislo3 = chislo1 + chislo2;
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                }
                else if (status_minus == true)
                {
                    chislo3 = chislo2 - chislo1;
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);

                    chislo1 = 0;
                    chislo3 = 0;
                    status_minus = false;
                }
                else
                {
                    chislo2 = chislo1;
                    chislo1 = 0;
                    textBox1.Text = Convert.ToString(chislo2);
                }
            }
            status_plus = true;
            status_stepen = false;
            status_ravno = false;
            status_tochka = false;
            status_tochka2 = false;
            if (status_tochka == false)
            {
               // label2.Text = " ";
            }
            label1.Text = "+";
            chislo5 = 1;
            chislo6 = 0;
        }
        private void minus_Click(object sender, EventArgs e)
        {
            if (status_size_open == true)
            {
                if (status_stepen == true)
                {
                    chislo3 = Math.Pow(chislo2, chislo1);
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                    status_stepen = false;
                }
                    else if (status_mult == true)
                {
                    chislo3 = chislo1 * chislo2;
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                    status_mult = false;
                }
                else if (status_div == true)
                {
                    chislo3 = chislo2 / chislo1;
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                    status_div = false;
                }
                else if (status_minus == true)
                {
                    chislo3 = chislo2 - chislo1;
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                }
                else if (status_plus == true)
                {
                    chislo3 = chislo2 + chislo1;
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                    status_plus = false;
                }
                else
                {
                    chislo2 = chislo1;
                    chislo1 = 0;
                    textBox1.Text = Convert.ToString(chislo1);
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox3.Text = Convert.ToString(chislo2);
                }
            }
            else
            {
                if (status_stepen == true)
                {
                    chislo3 = Math.Pow(chislo2, chislo1);
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    status_stepen = false;
                }
                else if (status_mult == true)
                {
                    chislo3 = chislo1 * chislo2;
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    status_mult = false;
                }
                else if (status_div == true)
                {
                    chislo3 = chislo2 / chislo1;
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    status_div = false;
                }
                else if (status_minus == true)
                {
                    chislo3 = chislo2 - chislo1;
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                }
                else if (status_plus == true)
                {
                    chislo3 = chislo2 + chislo1;
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    status_plus = false;
                }
                else
                {
                    chislo2 = chislo1;
                    chislo1 = 0;
                    textBox1.Text = Convert.ToString(chislo2);
                }
            }
            status_minus = true;
            status_stepen = false;
            status_ravno = false;
            status_tochka = false;
            status_tochka2 = false;
            if (status_tochka == false)
            {
                //label2.Text = " ";
            }
            label1.Text = "-";
            chislo5 = 1;
            chislo6 = 0;
        }
        private void mult_Click(object sender, EventArgs e)
        {
            if (status_size_open == true)
            {
                if (status_stepen == true)
                {
                    chislo3 = Math.Pow(chislo2, chislo1);
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                    status_stepen = false;
                }
                    else if (status_plus == true)
                {
                    chislo3 = chislo1 + chislo2;
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                    status_plus = false;
                }
                else if (status_minus == true)
                {
                    chislo3 = chislo2 - chislo1;
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                    status_minus = false;
                }
                else if (status_mult == true)
                {
                    chislo3 = chislo1 * chislo2;
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                }
                else if (status_div == true)
                {
                    chislo3 = chislo2 / chislo1;
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                    status_div = false;
                }
                else
                {
                    chislo2 = chislo1;
                    chislo1 = 0;
                    textBox1.Text = Convert.ToString(chislo1);
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox3.Text = Convert.ToString(chislo2);
                }
            }
            else
            {
                if (status_stepen == true)
                {
                    chislo3 = Math.Pow(chislo2, chislo1);
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    status_stepen = false;
                }
                else if (status_plus == true)
                {
                    chislo3 = chislo1 + chislo2;
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    status_plus = false;
                }
                else if (status_minus == true)
                {
                    chislo3 = chislo2 - chislo1;
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    status_minus = false;
                }
                else if (status_mult == true)
                {
                    chislo3 = chislo1 * chislo2;
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                }
                else if (status_div == true)
                {
                    chislo3 = chislo2 / chislo1;
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    status_div = false;
                }
                else
                {
                    chislo2 = chislo1;
                    chislo1 = 0;
                    textBox1.Text = Convert.ToString(chislo2);
                }
            }
            status_mult = true;
            status_stepen = false;
            status_ravno = false;
            status_tochka = false;
            status_tochka2 = false;
            if (status_tochka == false)
            {
               // label2.Text = " ";
            }
            label1.Text = "*";
            chislo5 = 1;
            chislo6 = 0;
        }
        private void div_Click(object sender, EventArgs e)
        {
            if (status_size_open == true)
            {
                if (status_stepen == true)
                {
                    chislo3 = Math.Pow(chislo2, chislo1);
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                    status_stepen = false;
                }
                    else if (status_minus == true)
                {
                    chislo3 = chislo2 - chislo1;
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                    status_minus = false;
                }
                else if (status_plus == true)
                {
                    chislo3 = chislo2 + chislo1;
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                    status_plus = false;
                }
                else if (status_div == true)
                {
                    chislo3 = chislo2 / chislo1;
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);

                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                }
                else if (status_mult == true)
                {
                    chislo3 = chislo2 * chislo1;
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);

                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                    status_mult = false;
                }
                else
                {
                    chislo2 = chislo1;
                    chislo1 = 0;
                    textBox1.Text = Convert.ToString(chislo1);
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox3.Text = Convert.ToString(chislo2);
                }
            }
            else
            {
                if (status_stepen == true)
                {
                    chislo3 = Math.Pow(chislo2, chislo1);
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    status_stepen = false;
                }
                else if (status_minus == true)
                {
                    chislo3 = chislo2 - chislo1;
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    status_minus = false;
                }
                else if (status_plus == true)
                {
                    chislo3 = chislo2 + chislo1;
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    status_plus = false;
                }
                else if (status_div == true)
                {
                    chislo3 = chislo2 / chislo1;
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);

                    chislo1 = 0;
                    chislo3 = 0;
                }
                else if (status_mult == true)
                {
                    chislo3 = chislo2 * chislo1;
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);

                    chislo1 = 0;
                    chislo3 = 0;
                    status_mult = false;
                }
                else
                {
                    chislo2 = chislo1;
                    chislo1 = 0;
                    textBox1.Text = Convert.ToString(chislo2);
                }
            }
            status_div = true;
            status_stepen = false;
            status_ravno = false;
            status_tochka = false;
            status_tochka2 = false;
            if (status_tochka == false)
            {
               // label2.Text = " ";
            }
            label1.Text = "/";
            chislo5 = 1;
            chislo6 = 0;
        }
        private void ravno_Click(object sender, EventArgs e)
        {

            if (status_plus == true)
            {
                chislo3 = chislo1 + chislo2;
            }
            if (status_minus == true)
            {
                chislo3 = chislo2 - chislo1;
            }
            if (status_mult == true)
            {
                chislo3 = chislo2 * chislo1;
            }
            if (status_div == true)
            {
                chislo3 = chislo2 / chislo1;
            }
            if (status_stepen == true)
            {
                chislo3 = Math.Pow(chislo2, chislo1);
            }
            status_ravno = true;
            status_plus = false;
            status_minus = false;
            status_mult = false;
            status_div = false;
            status_tochka = false;
            status_stepen = false;
            if (status_tochka == false)
            {
               // label2.Text = " ";
            }
            textBox2.Text = Convert.ToString(chislo1);
            textBox1.Text = Convert.ToString(chislo3);
            chislo1 = chislo3;
            //label1.Text = " ";
            chislo5 = 1;
            chislo6 = 0;
        }
        private void clr_Click(object sender, EventArgs e)
        {
            chislo1 = 0;
            chislo2 = 0;
            chislo3 = 0;
            chislo5 = 1;
            chislo6 = 0;
            textBox1.Text = Convert.ToString(chislo1);
            textBox2.Text = Convert.ToString(chislo1);
            textBox3.Text = Convert.ToString(chislo2);
            label1.Text = " ";
            status_tochka = false;
            status_tochka2 = false;
            if (status_tochka == false)
            {
               // label2.Text = " ";
            }
        }
        private void tochka_Click(object sender, EventArgs e)
        {
            status_tochka = true;
            if (status_tochka == true )
            {
                //label2.Text = "status";
            }
            if (status_size_open == true && status_tochka2 == false )
            {
                textBox2.Text = Convert.ToString(chislo1 + ",");
                status_tochka2 = true;
            }
            if (status_size_open == false && status_tochka2 == false)
            {
                textBox1.Text = Convert.ToString(chislo1 + ",");
                status_tochka2 = true;
            }
        }
        private void plus_minus_Click(object sender, EventArgs e)
        {
            if (chislo1 > 0)
            {
                chislo1 =  chislo1 * (-1);
                textBox1.Text = Convert.ToString(chislo1);       
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void local_clear_Click(object sender, EventArgs e)
        {

            status_main_clear = true;
            if (status_main_clear == true)
            {
                chislo1 = 0;
                textBox1.Text = Convert.ToString(chislo1);
                textBox2.Text = Convert.ToString(chislo1);
                status_main_clear = false;
            }
        }

        private void size_Click(object sender, EventArgs e)
        {
            if (status_size_open == false)
            {
                this.Size = new Size(400, 410);
                status_size_open = true;
                size.Text = "свернуть";
            }
            else
            {
                this.Size = new Size(400, 300);
                status_size_open = false;
                size.Text = "развернуть";
            }
           /* status_size_open = true;
            status_size_scrole = false;*/
        }


        private void MEMORY_Click(object sender, EventArgs e)
        {
            status_memory = true;
            label4.Text = "M";
            
            if (status_memory == true)
            {
                chislo_memory = chislo1;
                label5.Text = Convert.ToString(chislo_memory);

            }

        }
        private void mr_Click(object sender, EventArgs e)
        {
            if (status_memory == true)
            {
                chislo1 = chislo_memory;
                if (status_size_open == true)
                {
                    textBox2.Text = Convert.ToString(chislo1);
                }
                else
                {
                    textBox1.Text = Convert.ToString(chislo1);
                }
            }
        }
        private void mc_Click(object sender, EventArgs e)
        {
            status_memory = false;
            label4.Text = " ";
            if (status_memory == false)
            {
                chislo_memory = 0;
                label5.Text = " ";
            }
        }
        private void koren_Click(object sender, EventArgs e)
        {

            chislo_koren = Math.Sqrt(chislo1);
            chislo1 = chislo_koren;
            if (status_size_open == true && status_ravno == true)
            {
                textBox2.Text = Convert.ToString(chislo1);
            }
            if (status_size_open == true && status_ravno == false)
            {
                textBox2.Text = Convert.ToString(chislo1);
            }
            if (status_size_open == false)
            {
                textBox1.Text = Convert.ToString(chislo1);
            }
        }
        private void kvadrat_Click(object sender, EventArgs e)
        {
            stepen = 2;

            chislo_stepen = Math.Pow(chislo1, stepen);
            chislo1 = chislo_stepen;
            chislo_stepen = 0;

            if (status_size_open == true && status_ravno == true)
            {
                textBox2.Text = Convert.ToString(chislo1);
            }
            if (status_size_open == true && status_ravno == false)
            {
                textBox2.Text = Convert.ToString(chislo1);
            }
            if (status_size_open == false)
            {
                textBox1.Text = Convert.ToString(chislo1);
            }
        }
        private void obratnoe_chislo_Click(object sender, EventArgs e)
        {
            chislo_obrat = (1 / chislo1);
            chislo1 = chislo_obrat;
            chislo_obrat = 0;
            if (status_size_open == true && status_ravno == true)
            {
                textBox2.Text = Convert.ToString(chislo1);
            }
            if (status_size_open == true && status_ravno == false)
            {
                textBox2.Text = Convert.ToString(chislo1);
            }
            if (status_size_open == false)
            {
                textBox1.Text = Convert.ToString(chislo1);
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void clr_CursorChanged(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(clr, "операцияя 'Стереть'");
        }
        private void mc_CursorChanged(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(mc, "операцияя 'Удаление из памяти'");
        }
        private void mr_CursorChanged(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(mr, "операцияя 'Вставка из памяти'");
        }
        private void MEMORY_CursorChanged(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(MEMORY, "операцияя 'Сохр в память'");
        }
        private void local_clear_CursorChanged(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(local_clear, "Удаление последнего числа");
        }

        private void koren_CursorChanged(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(koren, "операцияя 'Кв корень числа'");
        }
        private void plus_CursorChanged(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(plus, "операцияя 'Сложение'");
        }
        private void minus_CursorChanged(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(minus, "операцияя 'Вычитание'");
        }
        private void mult_CursorChanged(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(mult, "операцияя 'Умножение'");
        }
        private void div_CursorChanged(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(div, "операцияя 'Деление'");
        }
        private void ravno_CursorChanged(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(ravno, "операция 'Равно'");
        }
        private void plus_minus_CursorChanged(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(plus_minus, "отрицательное число");
        }
        private void size_CursorChanged(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(size, "Развернуть окно");
        }
        private void button_scrole_CursorChanged(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(button_scrole, "показать/скрыть функ кн");
        }



        private void stepenX_Click(object sender, EventArgs e)
        {
            if (status_size_open == true)
            {
                if (status_stepen == true)
                {
                    chislo3 = Math.Pow(chislo2, chislo1);
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                }
                else if (status_plus == true)
                {
                    chislo3 = chislo2 + chislo1;
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                    status_plus = false;
                }
                else if (status_minus == true)
                {
                    chislo3 = chislo2 - chislo1;
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                    status_minus = false;
                }
                else if (status_mult == true)
                {
                    chislo3 = chislo1 * chislo2;
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                    status_mult = false;
                }
                else if (status_div == true)
                {
                    chislo3 = chislo2 / chislo1;
                    chislo2 = chislo3;
                    textBox3.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox1.Text = Convert.ToString(chislo1);
                    status_div = false;
                }
                else
                {
                    chislo2 = chislo1;
                    chislo1 = 0;
                    textBox1.Text = Convert.ToString(chislo1);
                    textBox2.Text = Convert.ToString(chislo1);
                    textBox3.Text = Convert.ToString(chislo2);
                }
            }
            else
            {
                if (status_stepen == true)
                {
                    chislo3 = Math.Pow(chislo2, chislo1);
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                }
                else if (status_plus == true)
                {
                    chislo3 = chislo1 + chislo2;
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    status_plus = false;
                }
                else if (status_minus == true)
                {
                    chislo3 = chislo2 - chislo1;
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    status_minus = false;
                }
                else if (status_mult == true)
                {
                    chislo3 = chislo1 * chislo2;
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    status_mult = false;
                }
                else if (status_div == true)
                {
                    chislo3 = chislo2 / chislo1;
                    chislo2 = chislo3;
                    textBox1.Text = Convert.ToString(chislo3);
                    chislo1 = 0;
                    chislo3 = 0;
                    status_div = false;
                }
                else
                {
                    chislo2 = chislo1;
                    chislo1 = 0;
                    textBox1.Text = Convert.ToString(chislo2);
                }
            }
            status_stepen = true;
            status_mult = false;
            status_div = false;
            status_ravno = false;
            status_tochka = false;
            status_tochka2 = false;
            if (status_tochka == false)
            {
                // label2.Text = " ";
            }
            label1.Text = "*";
            chislo5 = 1;
            chislo6 = 0;
        }

        private void button_scrole_Click(object sender, EventArgs e)
        {
            if (status_button_scrole == false)
            {
               
                //size.Text = "свернуть";

                koren.Visible = true;
                kvadrat.Visible = true;
                stepenX.Visible = true;
                obratnoe_chislo.Visible = true;

                status_button_scrole = true;
            }
            else
            {
                
                //size.Text = "развернуть";
                koren.Visible = false;
                kvadrat.Visible = false;
                stepenX.Visible = false;
                obratnoe_chislo.Visible = false;

                status_button_scrole = false;
            }
        }


    }
    }

