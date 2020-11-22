using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Shenon
{
    class Program
    {
        static private double prPrev = 0; //для суммирования частот в Encode
        static void Main()
        {
            Console.WriteLine("Введите алфавит (символы разделять через пробел): ");
            var symbols = Console.ReadLine().Split();
            Console.WriteLine("Введите вероятности каждого символа через пробел: ");
            var input = Console.ReadLine().Split();
            var dict = symbols.Zip(input.Select(double.Parse)).ToList();  // обьединение двух списков

            dict.Sort((a, b) => b.Second.CompareTo(a.Second)); //сортировка по не возрастанию

            foreach(var pr in dict)     //вывод
            {
                Console.WriteLine("{0}\t{1}", pr.First, Encode(pr.Second));  
            }
        }
        
       //работа по вычислению B(x) и реализация перевода в двоичный код от l(x)
        static private String Encode(double pr)
        {
            var b = prPrev;
            prPrev += pr;   //прибавление b(i-1) 

            var l = Math.Ceiling(Math.Abs(Math.Log2(pr)));   

            String res = "";
            for(int i = 0; i < l; ++i)
            {
                b *= 2;
                res += Math.Floor(b);
                if (b >= 1)
                    b -= 1;
            }

            return res;
        }
    }
}
