using System;

namespace ConvertFibonachi
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[0];
            bool flag = false;
            while (num > 0)
            {
                for (int i = 0; i <= num; i++)
                {
                    if (Fibonachi(i + 1) > num)
                    {
                        if (flag == false)
                        {
                            a = new int[i];
                            flag = true;
                        }
                        a[i - 1] = 1;
                        num -= Fibonachi(i);
                        break;
                    }
                    
                }
            }
            Array.Reverse(a);
            foreach (int i in a)
            {
                
                Console.Write(i);
            }

        }
        static int Fibonachi(int n)
        {
            int a = 1;
            int b = 1;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                tmp = a;
                a = b;
                b += tmp;
            }
            return a;
        }
    }
}
