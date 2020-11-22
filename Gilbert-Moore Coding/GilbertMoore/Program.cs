using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace GilbertMoore
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите алфавит (символы разделять через пробел): ");
            var symbols = Console.ReadLine().Split();
            Console.WriteLine("Введите вероятности каждого символа через пробел: ");
            var input = Console.ReadLine().Split();
            var dict = symbols.Zip(input.Select(double.Parse)).ToList();  // обьединение двух списков

            List<double> qList = new List<double>(dict.Count);
            List<double> bList = new List<double>(dict.Count);

            qList.Add(0);
            bList.Add(dict[0].Second / 2);

            for (int i = 1; i < dict.Count; i++)
            {
                qList.Add(qList[i - 1] + dict[i - 1].Second);
                bList.Add(bList[i - 1] + dict[i].Second / 2);
            }
            for(int i = 0; 0 < bList.Count; i++)
            {
                Console.WriteLine("{0}\t{1}", dict[i].First, Encode(bList[i]));
            }
        }
        static private String Encode(double p)
        {
            var l = Math.Ceiling(Math.Abs(Math.Log2(p)));

            String res = "";
            for (int i = 0; i < l; ++i)
            {
                p *= 2;
                res += Math.Floor(p);
                if (p >= 1)
                    p -= 1;
            }
            return res;
        }
    }
}
