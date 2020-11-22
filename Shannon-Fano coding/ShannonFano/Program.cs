using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ShenonFano
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

            dict.Sort((a, b) => b.Second.CompareTo(a.Second)); //сортировка по не возрастанию
            var resultDict = symbols.ToDictionary(x => x, x => ""); // Словарь Символ - Результат

            EncodeRecurse(dict, resultDict);
            foreach (var pr in resultDict)     //вывод
            {
                Console.WriteLine("{0}\t{1}", pr.Key, pr.Value);
            }
        }

        //работа по вычислению B(x) и реализация перевода в двоичный код от l(x)
        static private void EncodeRecurse(List<(String, double)> freqDict, Dictionary<String, String> resultDict)
        {
            // Для одного элемента ничего не надо добавлять
            if (freqDict.Count < 2)
                return;

            double left = 0.0;
            double rigth = 0.0;

            int i = 0, j = freqDict.Count - 1;

            // Делим список на два примерно равных по сумме
            while (i <= j)
            {
                if (left <= rigth)
                {
                    left += freqDict[i].Item2;
                    resultDict[freqDict[i].Item1] += "0";
                    i++;
                }
                else
                {
                    rigth += freqDict[j].Item2;
                    resultDict[freqDict[j].Item1] += "1";
                    j--;
                }
            }
    
            // Для двух элементов тоже ничего не надо добавлять
            // Они забрали значения пополам
            if (freqDict.Count < 3)
                return;

            EncodeRecurse(freqDict.GetRange(0, i), resultDict);
            EncodeRecurse(freqDict.GetRange(i, freqDict.Count - i), resultDict);
        }
    }
}
