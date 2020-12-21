using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //кнопка "Рассчитать" рассчитывает, далее показывает сумму чисел <8 и показывает сами числа
            


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
    }
}
