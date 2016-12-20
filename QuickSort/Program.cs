using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] qickSortAr = { 6, 2, 14, 3, 7, 4, 9, 10, 13, 19, 12, 5, 11 };
            int firstEl = 0;
            int lastEl = qickSortAr.Length - 1;
            qickSort(qickSortAr, firstEl, lastEl); //Вызов метода

            foreach (int i in qickSortAr) //Вывод на экран через foreach
            {
                Console.WriteLine(i);
            }
        }
        static void qickSort(int[] qickSortAr, int firstEl, int lastEl)
        {
            int middleElement = firstEl + (lastEl - firstEl) / 2;
            int i = firstEl;
            int j = lastEl;
            Console.WriteLine("i= " + i + "  J = " + j + " middleElement= " + middleElement); // Провека счетчиков

            while (i <= j)
            {
                while (qickSortAr[middleElement] > qickSortAr[i])
                {
                    i++;
                }
                while (qickSortAr[middleElement] < qickSortAr[j])
                {
                    j--;
                }
                if (i <= j)
                {
                    int empty = qickSortAr[i];
                    qickSortAr[i] = qickSortAr[j];
                    qickSortAr[j] = empty;
                    i++;
                    j--;
                }
                else
                { }
            } // конец метода сортировки
            if (firstEl < j)
            {
                qickSort(qickSortAr, firstEl, j);   //рекурсия
            }
            else
            { }

            if (lastEl > i)
            {
                qickSort(qickSortAr, i, lastEl);   //рекурсия
            }
            else
            { }
        }
    }
}

    