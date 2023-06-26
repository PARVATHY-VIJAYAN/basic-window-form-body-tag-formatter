using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Q3{
public partial class Form1 : Form
{
        static String decToHexa(int n)        {
            char[] hexaDeciNum = new char[2];
            int i = 0;
            while (n != 0)// n =142   {
                int temp = 0;
                temp = n % 16;//142%16 = 14
                if (temp < 10)                {
                    hexaDeciNum[i] = (char)(temp + 48);
                    i++;
                }
                else {
                    hexaDeciNum[i] = (char)(temp + 55);//e
                    i++;
                }
                n = n / 16;//8
            }
            String hexCode = "";
            if (i == 2)            {
                hexCode += hexaDeciNum[0];
                hexCode += hexaDeciNum[1];
            }
            else if (i == 1)            {
                hexCode = "0";
                hexCode += hexaDeciNum[0];
            }
            else if (i == 0)                hexCode = "00";
            return hexCode;
        }
        static String convertRGBtoHex(int R, int G, int B)     {
            String hexCode = "#";
            hexCode += decToHexa(R);
            hexCode += decToHexa(G);
            hexCode += decToHexa(B);

            return hexCode;
        }
        public Form1()        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)        {
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox1.Text = convertRGBtoHex(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            textBox9.Text = "<body bgcolor=" + textBox1.Text + " text=" + textBox2.Text + " link = " + textBox3.Text + " alink = " + textBox4.Text + " vlink=" + textBox4.Text + ">";
        }
        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)        {
            textBox7.Text = vScrollBar2.Value.ToString();
            if (radioButton1.Checked)            {
                panel2.BackColor = Color.FromArgb(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
                panel1.BackColor = panel2.BackColor;
                textBox1.Text = convertRGBtoHex(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            }
            else if (radioButton2.Checked)
            {
                label2.ForeColor = Color.FromArgb(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
                panel1.BackColor = label2.ForeColor;
                textBox2.Text = convertRGBtoHex(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            }
            else if (radioButton3.Checked)
            {
                label3.ForeColor = Color.FromArgb(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
                panel1.BackColor = label3.ForeColor;
                textBox3.Text = convertRGBtoHex(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            }
            else if (radioButton4.Checked)
            {
                label4.ForeColor = Color.FromArgb(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
                panel1.BackColor = label4.ForeColor;
                textBox4.Text = convertRGBtoHex(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            }
            else if (radioButton5.Checked)
            {
                label5.ForeColor = Color.FromArgb(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
                panel1.BackColor = label5.ForeColor;
                textBox5.Text = convertRGBtoHex(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            }

            textBox9.Text = "<body bgcolor=" + textBox1.Text + " text=" + textBox2.Text + " link = " + textBox3.Text + " alink = " + textBox4.Text + " vlink=" + textBox4.Text + ">";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.BackColor = label2.ForeColor;
            vScrollBar1.Value = panel1.BackColor.R;
            vScrollBar2.Value = panel1.BackColor.G;
            vScrollBar3.Value = panel1.BackColor.B;
            textBox6.Text = vScrollBar1.Value.ToString();
            textBox7.Text=vScrollBar2.Value.ToString();
            textBox8.Text = vScrollBar3.Value.ToString();
            textBox2.Text = convertRGBtoHex(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            textBox9.Text = "<body bgcolor=" + textBox1.Text + " text=" + textBox2.Text + " link = " + textBox3.Text + " alink = " + textBox4.Text + " vlink=" + textBox4.Text + ">";
        }
        private void button2_Click(object sender, EventArgs e) {this.Close();}
        private void button1_Click(object sender, EventArgs e)
        {
            textBox9.SelectAll();
            textBox9.Copy();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.BackColor = panel2.BackColor;
            vScrollBar1.Value = panel1.BackColor.R;
            vScrollBar2.Value = panel1.BackColor.G;
            vScrollBar3.Value = panel1.BackColor.B;
            textBox6.Text = vScrollBar1.Value.ToString();
            textBox7.Text = vScrollBar2.Value.ToString();
            textBox8.Text = vScrollBar3.Value.ToString();
            
            textBox1.Text = convertRGBtoHex(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            textBox9.Text = "<body bgcolor=" + textBox1.Text + " text=" + textBox2.Text + " link = " + textBox3.Text + " alink = " + textBox4.Text + " vlink=" + textBox4.Text + ">";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            panel1.BackColor = label3.ForeColor;
            vScrollBar1.Value = panel1.BackColor.R;
            vScrollBar2.Value = panel1.BackColor.G;
            vScrollBar3.Value = panel1.BackColor.B;
            textBox6.Text = vScrollBar1.Value.ToString();
            textBox7.Text = vScrollBar2.Value.ToString();
            textBox8.Text = vScrollBar3.Value.ToString();

            textBox3.Text = convertRGBtoHex(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            textBox9.Text = "<body bgcolor=" + textBox1.Text + " text=" + textBox2.Text + " link = " + textBox3.Text + " alink = " + textBox4.Text + " vlink=" + textBox4.Text + ">";
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            panel1.BackColor = label4.ForeColor;
            vScrollBar1.Value = panel1.BackColor.R;
            vScrollBar2.Value = panel1.BackColor.G;
            vScrollBar3.Value = panel1.BackColor.B;
            textBox6.Text = vScrollBar1.Value.ToString();
            textBox7.Text = vScrollBar2.Value.ToString();
            textBox8.Text = vScrollBar3.Value.ToString();

            textBox4.Text = convertRGBtoHex(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            textBox9.Text = "<body bgcolor=" + textBox1.Text + " text=" + textBox2.Text + " link = " + textBox3.Text + " alink = " + textBox4.Text + " vlink=" + textBox4.Text + ">";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            panel1.BackColor = label5.ForeColor;
            vScrollBar1.Value = panel1.BackColor.R;
            vScrollBar2.Value = panel1.BackColor.G;
            vScrollBar3.Value = panel1.BackColor.B;
            textBox6.Text = vScrollBar1.Value.ToString();
            textBox7.Text = vScrollBar2.Value.ToString();
            textBox8.Text = vScrollBar3.Value.ToString();

            textBox5.Text = convertRGBtoHex(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            textBox9.Text = "<body bgcolor=" + textBox1.Text + " text=" + textBox2.Text + " link = " + textBox3.Text + " alink = " + textBox4.Text + " vlink=" + textBox4.Text + ">";
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox6.Text = vScrollBar1.Value.ToString();
            if (radioButton1.Checked)
            {
                panel2.BackColor = Color.FromArgb(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
                panel1.BackColor = panel2.BackColor;
                textBox1.Text = convertRGBtoHex(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            }
            else if (radioButton2.Checked)
            {
                label2.ForeColor = Color.FromArgb(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
                panel1.BackColor = label2.ForeColor;
                textBox2.Text = convertRGBtoHex(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            }
            else if (radioButton3.Checked)
            {
                label3.ForeColor = Color.FromArgb(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
                panel1.BackColor = label3.ForeColor;
                textBox3.Text = convertRGBtoHex(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            }
            else if (radioButton4.Checked)
            {
                label4.ForeColor = Color.FromArgb(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
                panel1.BackColor = label4.ForeColor;
                textBox4.Text = convertRGBtoHex(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            }
            else if (radioButton5.Checked)
            {
                label5.ForeColor = Color.FromArgb(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
                panel1.BackColor = label5.ForeColor;
                textBox5.Text = convertRGBtoHex(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            }
            
            textBox9.Text = "<body bgcolor=" + textBox1.Text + " text=" + textBox2.Text + " link = " + textBox3.Text + " alink = " + textBox4.Text + " vlink=" + textBox5.Text + ">";
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            textBox8.Text = vScrollBar3.Value.ToString();
            if (radioButton1.Checked)
            {
                panel2.BackColor = Color.FromArgb(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
                panel1.BackColor = panel2.BackColor;
                textBox1.Text = convertRGBtoHex(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            }
            else if (radioButton2.Checked)
            {
                label2.ForeColor = Color.FromArgb(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
                panel1.BackColor = label2.ForeColor;
                textBox2.Text = convertRGBtoHex(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            }
            else if (radioButton3.Checked)
            {
                label3.ForeColor = Color.FromArgb(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
                panel1.BackColor = label3.ForeColor;
                textBox3.Text = convertRGBtoHex(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            }
            else if (radioButton4.Checked)
            {
                label4.ForeColor = Color.FromArgb(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
                panel1.BackColor = label4.ForeColor;
                textBox4.Text = convertRGBtoHex(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            }
            else if (radioButton5.Checked)
            {
                label5.ForeColor = Color.FromArgb(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
                panel1.BackColor = label5.ForeColor;
                textBox5.Text = convertRGBtoHex(int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text));
            }

            textBox9.Text = "<body bgcolor=" + textBox1.Text + " text=" + textBox2.Text + " link = " + textBox3.Text + " alink = " + textBox4.Text + " vlink=" + textBox5.Text + ">";
        }
    }
}
