using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSVPS_lab_3
{
    internal class Program
    {
        static int Count = 10;
        static int[] Num = new int[10] { 49, 12, 27, 4, 19, 37, 26, 11, 25, 8 };

        static void merge(int[] data, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            for (i = 0; i < n1; ++i)
                L[i] = data[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = data[m + 1 + j];

            i = 0;
            j = 0;

            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    data[k] = L[i];
                    i++;
                }
                else
                {
                    data[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                data[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                data[k] = R[j];
                j++;
                k++;
            }
        }
        static void sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;

                sort(arr, l, m);
                sort(arr, m + 1, r);

                merge(arr, l, m, r);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Набор чисел: ");
            for (int i = 0; i < Count; i++)
            {
                Console.Write(Num[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nbubbleSort сортировка: ");

            sort(Num, 0, Count - 1);

            Console.Write("Отсортированный массив: ");
            for (int j = 0; j < Count; j++)
            {
                Console.Write(Num[j] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
