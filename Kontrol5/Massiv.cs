using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace laba_9_10
{
    internal class Massiv
    {
        public int multiplyChet(int[] mass)//произведение четных чисел
        {
            int multi = 1;
            for (int i = 0; i < mass.Length; i++)
            { 
                    if (mass[i] % 2 == 0)
                    {
                        multi *= mass[i];
                    }
            }
            return multi;
        }
        public int multiply(int[] mass)//произведение всех чисел в массиве
        {
            int multi = 1;
            for(int i =0; i<mass.Length; i++)
            {
               multi *= mass[i];   
            }
            return multi;
        }
        public int MinElementMass(int[] mass)//минимальный элемент массива 
        {
            int min = int.MaxValue;
            int index = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < min)
                {
                    min = mass[i];
                    index = i;
                }
            }
            return min;
        }
        public string IndexOfMaxElement(int[] mass)//находит макс элемент массива и индекс
        {
            int max = mass[0];
            int index = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > max)
                {
                    max = mass[i];
                    index = i;
                }
            }
            return $"Макс число:{max}; Индекс элемента:{index}";
        }
        public string IndexOfMinAbsElement(int[] mass)//находит мин число по модулю
        {
            int min = int.MaxValue;
            int index = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                int tmp = Math.Abs(mass[i]);
                if ( mass[i] < min)
                {
                    min = tmp;
                    index = i;
                }                
            }
            return ($"Мин число по модулю:{min}; Индекс элемента:{index}");
           
        }
        public string IndexOfMaxinMinElement(int[] mass)//находит максимальное отрицательное число
        {
            int Max = mass[0];
            int index = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < 0 && mass[i] > Max)
                {
                    Max = mass[i];
                    index = i;
                }
            }
            return ($"Максимальное отрицательное  число:{Max}; Индекс элемента:{index}");
           
        }
        public int IndexPol(int[] mass)//находит первое положительное число в массиве 
        {
            int index = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > 0)
                {
                    index = mass[i];
                    break;
                }
                if(index == 0)
                {
                    index = 0;
                }
            }
            return index;
        }
        public int IndexNegative(int[] mass)//находит индекс последнего отрицательного числа
        {
            int index = 0;
            for(int i = 0; i < mass.Length; i++)
            {
                if(mass[i] < 0)
                {
                    index = mass[i];
                }
            }
            return index;
        }

    }
}
