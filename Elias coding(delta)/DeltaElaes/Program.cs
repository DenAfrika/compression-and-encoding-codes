using System;

namespace DeltaElaes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число : ");
            var num = Convert.ToString(Convert.ToInt32(Console.ReadLine()), 2);
            Console.WriteLine("ElaisDelta Encode = {0}", Encode(num));
            Console.WriteLine("ElaisDelta Decode = {0}", Decode(Encode(num)));
        }
        static string Encode(string num)
        {
            var L = Convert.ToString(num.Length, 2);
            num = num.Substring(1, num.Length - 1);
            num = L + num;
            var m = L.Length - 1;
            for (int i = 0; i < m; i++)
            {
                num = "0" + num;
            }
            return num;
        }
        static int Decode(string num)
        {
            int m = num.IndexOf("1");
            int L = Convert.ToInt32(num.Substring(m, m + 1), 2);
            m = (num.Substring(0, 2 * m + 1)).Length;
            return Convert.ToInt32("1" + num.Substring(m, L - 1), 2);
        }
    }
}
