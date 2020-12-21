using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using labr;

namespace soldat1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

            private void button1_Click(object sender, EventArgs e)
            {
              Сlass1 сlass1 = new Сlass1();
              int count = (int)numericUpDown1.Value;
              






               int[] ms = сlass1.Rand(count);
                textBox2.Text = сlass1.Summa(ms).ToString();
                textBox1.Clear();
              for (int i = 0; i < ms.Length; i++)
              {
                textBox1.Text += ms[i].ToString() + " ";
              }


            }
    
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Солдатова Анастасия ИСП-31\n" +
            "Практическая работа №1\n" +
            "9. Сформировать n целых чисел от 2 до 14, найти суммц чисел < 8, вывести результат на экран.\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
