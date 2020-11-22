using System;

namespace NegaDv
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число или нажмите Enter для тестов :");
            string s = Console.ReadLine();
            int num = 0;
            if (s.Length == 0)
            {
                num = 10;
                Console.WriteLine(num);
                Console.WriteLine("Code: {0}", Code(num));
                Decode(Code(num));
                Console.WriteLine();

                num = -15;
                Console.WriteLine(num);
                Console.WriteLine("Code: {0}", Code(num));
                Decode(Code(num));
                Console.WriteLine();

                num = 15;
                Console.WriteLine(num);
                Console.WriteLine("Code: {0}", Code(num));
                Decode(Code(num));
                Console.WriteLine();

                num = -19;
                Console.WriteLine(num);
                Console.WriteLine("Code: {0}", Code(num));
                Decode(Code(num));
                Console.WriteLine();
            }
            else
            {
                num = Convert.ToInt32(s);
                Console.WriteLine(Code(num));
                Decode(Code(num));
            }
        }
        static string Code(int num)
        {
            int del = 0;
            string code = "";
            do
            {
                if (Math.Abs(num % 2) != 0)
                {
                    del = (num - 1) / (-2);
                    code = "1" + code;
                }
                else
                {
                    del = num / (-2);
                    code = "0" + code;
                }

                num = del;

            } while (del != 0);
            return code;
        }
        static void Decode(string code)
        {
            int sum = 0;
            for (int i = 0; i < code.Length; i++)
            {
                sum = sum * (-2) + Convert.ToInt32(code.Substring(i, 1));
            }
            Console.WriteLine("Decode: {0}",sum);
        }
        static void Dop()
        {
            Console.WriteLine("Введите число :");
            int num = Convert.ToInt32(Console.ReadLine());
            int del;
            string code = "";
            if (Math.Abs(num % 2) != 0 && num == 15)
            {
                if (num > 0)
                {
                    del = Math.Abs(num / 2) * (-1);
                    num = del;
                    code = "1" + code;
                }
                else
                {
                    del = Math.Abs(num / 2) + 1;
                    num = del;
                    code = "0" + code;
                }
            }
            do
            {
                if (Math.Abs(num % 2) != 0) //проверка на чётность /// не чётные 
                {
                    code = "1" + code;
                    if (num < 0)
                        if (Math.Abs(num) == 3)
                            del = 1;
                        else
                            del = Math.Abs(num / 2) + 1;
                    else if (Math.Abs(num) == 3)
                        del = -1;
                    else
                        del = (Math.Abs(num / 2) + 1) * (-1);
                }
                else   ///чётные
                {
                    code = "0" + code;
                    if (num < 0)
                        del = Math.Abs(num / 2);
                    else
                        del = Math.Abs(num / 2) * (-1);
                }
                num = del;
            } while (del != 1);
            code = "1" + code;
            Console.WriteLine(code);
    }
    }
}
