using System;

namespace Golomb
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите n и m по почереди: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int A = n / m;
            int B = n % m;
            string Rez = Ynar(A);
            string Bstr = Convert.ToString(B, 2);
            n = step(m);
            if (Bstr.Length < n)
            {
                m = n - Bstr.Length;
                while(m != 0)
                {
                    Bstr = "0" + Bstr;
                    m--;
                }
            }
            Console.Write(Rez + Bstr);
        }

        static string Ynar(int num)
        {
            string rez = "";
            while(num > 0)
            {
                rez += "0";
                num--;
            }
            rez += "1";
            return rez;
        }
        public static int step(int a)
        {
            int k = 0;
            while (a != 1)
            {
                if (a % 2 == 1)
                {
                    break;
                }
                else
                {
                    a /= 2;
                    k++;
                }
            }
            return k;
        }
    }
}
