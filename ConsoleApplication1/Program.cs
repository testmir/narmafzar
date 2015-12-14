using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
       

        // number of elements in array
        private int x;

        // Merge Sort Algorithm
       /* public void sortArray()
        {
            m_sort(0, x - 1);
        }*/

        public static void m_sort(int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                m_sort(left, mid);
                m_sort(mid + 1, right);

                merge(left, mid + 1, right);
            }
        }

        public static void merge(int left, int mid, int right)
        {
  int[] a = new int[];
        int[] b = new int[100];
            int i, left_end, num_elements, tmp_pos;

            left_end = mid - 1;
            tmp_pos = left;
            num_elements = right - left + 1;

            while ((left <= left_end) && (mid <= right))
            {
                if (a[left] <= a[mid])
                {
                    b[tmp_pos] = a[left];
                    tmp_pos = tmp_pos + 1;
                    left = left + 1;
                }
                else
                {
                    b[tmp_pos] = a[mid];
                    tmp_pos = tmp_pos + 1;
                    mid = mid + 1;
                }
            }

            while (left <= left_end)
            {
                b[tmp_pos] = a[left];
                left = left + 1;
                tmp_pos = tmp_pos + 1;
            }

 while (left <= left_end)
            {
                b[tmp_pos] = a[left];
                left = left + 1;
                tmp_pos = tmp_pos + 1;
            }
            while (mid <= right)
            {
                b[tmp_pos] = a[mid];
                mid = mid + 1;
                tmp_pos = tmp_pos + 1;
            }

            for (i = 0; i < num_elements; i++)
            {
                a[right] = b[right];
                right = right - 1;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("n ra vared -konid");
            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" x ra vared kond");
                x[i] = int.Parse(Console.ReadLine());
            }
for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" x ra vared kond");
                x[i] = int.Parse(Console.ReadLine());
            }
            int left=0;
            int right=n-1;
            m_sort(left, right);
        }
    }
}
