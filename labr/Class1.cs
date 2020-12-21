using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labr
{

    public class Сlass1
    { //сформировать n целых чисел от 2 до 14
      //найти суммц чисел < 8
      //вывести результат на экран

        
        public int[] Rand(int countNumbers, int minValue = 2, int maxValue = 14)
        {
            Random rand = new Random();
            int[] ms = new int[countNumbers];
            for (int i = 0; i < ms.Length; i++)
            {
                ms[i] = rand.Next(minValue, maxValue);
            }
            return ms;
        }


        //находим сумму < 8
        public int Summa(int[] mass)
        {
            int sum = 0;

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < 8)
                    sum += mass[i];
            }
            return sum;


        }

        
    }
   

}
    

