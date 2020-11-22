using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
	public static void Main()
	{
		int num = 0;
		

		Console.WriteLine("Введите номер теста или нажмите Enter:");
		Console.WriteLine("1.ElaisOmega");
		Console.WriteLine("2.EvenRodeh");
		Console.WriteLine("3.ElaisGamma");
		Console.WriteLine("4.Levinstain");
		Console.WriteLine("5.LevinstainGamma");
		string str = Console.ReadLine();
		switch (str)
		{
			case "1": 
				num = 13;
				Console.WriteLine(num);
				Console.WriteLine("ElaisOmega Encode = {0}", ElaisOmega(num));
				Console.WriteLine("ElaisOmega Decode = {0}", ElaisOmega(ElaisOmega(num)));
				Console.WriteLine();
				num = 10;
				Console.WriteLine(num);
				Console.WriteLine("ElaisOmega Encode = {0}", ElaisOmega(num));
				Console.WriteLine("ElaisOmega Decode = {0}", ElaisOmega(ElaisOmega(num)));
				Console.WriteLine();
				num = 5;
				Console.WriteLine(num);
				Console.WriteLine("ElaisOmega Encode = {0}", ElaisOmega(num));
				Console.WriteLine("ElaisOmega Decode = {0}", ElaisOmega(ElaisOmega(num)));
				Console.WriteLine();
				break;

			case "2": 
				num = 13;
				Console.WriteLine(num);
				Console.WriteLine("EvenRodeh Encode = {0}", EvenRodeh(num));
				Console.WriteLine("EvenRodeh Decode = {0}", EvenRodeh(EvenRodeh(num)));
				Console.WriteLine();
				num = 10;
				Console.WriteLine(num);
				Console.WriteLine("EvenRodeh Encode = {0}", EvenRodeh(num));
				Console.WriteLine("EvenRodeh Decode = {0}", EvenRodeh(EvenRodeh(num)));
				Console.WriteLine();
				num = 5;
				Console.WriteLine(num);
				Console.WriteLine("EvenRodeh Encode = {0}", EvenRodeh(num));
				Console.WriteLine("EvenRodeh Decode = {0}", EvenRodeh(EvenRodeh(num)));
				Console.WriteLine();
				break;
			case "3": 
				num = 13;
				Console.WriteLine(num);
				Console.WriteLine("ElaisGamma Encode = {0}", ElaisGamma(num));
				Console.WriteLine("ElaisGamma Decode = {0}", ElaisGamma(ElaisGamma(num)));
				Console.WriteLine();
				num = 10;
				Console.WriteLine(num);
				Console.WriteLine("ElaisGamma Encode = {0}", ElaisGamma(num));
				Console.WriteLine("ElaisGamma Decode = {0}", ElaisGamma(ElaisGamma(num)));
				Console.WriteLine();
				num = 5;
				Console.WriteLine(num);
				Console.WriteLine("ElaisGamma Encode = {0}", ElaisGamma(num));
				Console.WriteLine("ElaisGamma Decode = {0}", ElaisGamma(ElaisGamma(num)));
				Console.WriteLine();
				break;
			case "4":
				num = 13;
				Console.WriteLine(num);
				Console.WriteLine("Levinstain Encode = {0}", Levinstain(num));
				Console.WriteLine("Levinstain Decode = {0}", Levinstain(Levinstain(num)));
				Console.WriteLine();
				num = 10;
				Console.WriteLine(num);
				Console.WriteLine("Levinstain Encode = {0}", Levinstain(num));
				Console.WriteLine("Levinstain Decode = {0}", Levinstain(Levinstain(num)));
				Console.WriteLine();
				num = 5;
				Console.WriteLine(num);
				Console.WriteLine("Levinstain Encode = {0}", Levinstain(num));
				Console.WriteLine("Levinstain Decode = {0}", Levinstain(Levinstain(num)));
				Console.WriteLine();
				break;
			case "5":
				num = 13;
				Console.WriteLine(num);
				Console.WriteLine("LevinstainGamma Encode = {0}", LevinstainGamma(num));
				Console.WriteLine("LevinstainGamma Decode = {0}", LevinstainGamma(LevinstainGamma(num)));
				Console.WriteLine();
				num = 10;
				Console.WriteLine(num);
				Console.WriteLine("LevinstainGamma Encode = {0}", LevinstainGamma(num));
				Console.WriteLine("LevinstainGamma Decode = {0}", LevinstainGamma(LevinstainGamma(num)));
				Console.WriteLine();
				num = 5;
				Console.WriteLine(num);
				Console.WriteLine("LevinstainGamma Encode = {0}", LevinstainGamma(num));
				Console.WriteLine("LevinstainGamma Decode = {0}", LevinstainGamma(LevinstainGamma(num)));
				Console.WriteLine();
				break;
			default:
				Console.WriteLine("Введите число для кодирования : ");
				Int32.TryParse(Console.ReadLine(), out num);
				Console.WriteLine("Levinstain Encode = {0}", Levinstain(num));
				Console.WriteLine("Levinstain Decode = {0}", Levinstain(Levinstain(num)));
				Console.WriteLine("LevinstainGamma Encode = {0}", LevinstainGamma(num));
				Console.WriteLine("LevinstainGamma Decode = {0}", LevinstainGamma(LevinstainGamma(num)));
				Console.WriteLine("ElaisOmega Encode = {0}", ElaisOmega(num));
				Console.WriteLine("ElaisOmega Decode = {0}", ElaisOmega(ElaisOmega(num)));
				Console.WriteLine("EvenRodeh Encode = {0}", EvenRodeh(num));
				Console.WriteLine("EvenRodeh Decode = {0}", EvenRodeh(EvenRodeh(num)));
				Console.WriteLine("ElaisGamma Encode = {0}", ElaisGamma(num));
				Console.WriteLine("ElaisGamma Decode = {0}", ElaisGamma(ElaisGamma(num)));
				break;
		}
	}

	private static String Levinstain(int num)
	{
		int c = 0;
		StringBuilder k = new StringBuilder("");
		while (num != 0)
		{
			var ins = Convert.ToString(num, 2).Substring(1);
			k.Insert(0, ins);
			num = ins.Length;
			c++;
		}

		k.Insert(0, "0");
		for (int i = 0; i < c; ++i)
			k.Insert(0, "1");
		return k.ToString();
	}

	private static int Levinstain(String m)
	{
		int c = m.IndexOf("0");

		if (c == 0)
			return 0;

		var k = m.Substring(c + 1);
		int n = 1;
		for (int i = c - 1; i > 0; i--)
		{
			var tmp = n;
			n = Convert.ToInt32("1" + k.Substring(0, n), 2);
			k = k.Substring(tmp);
		}
		return n;
	}

	private static String LevinstainGamma(int num)
	{
		if (num == 0)
			return "Not Exist";
		var ins = Convert.ToString(num, 2);
		String res = "";
		for (int i = ins.Length - 1; i > 0; i--)
		{
			res += "0";
			res += ins[i];
		}
		res += "1";
		return res;
	}

	private static int LevinstainGamma(String m)
	{
		String res = "";
		res += m[m.Length - 1];
		for (int i = m.Length - 2; i >= 0; i -= 2)
		{
			res += m[i];
		}
		return Convert.ToInt32(res, 2);
	}

	private static String ElaisOmega(int num)
	{
		if (num == 0)
			return "Not Exist";

		StringBuilder res = new StringBuilder("0");

		int tmp = num;

		while (tmp != 1)
		{
			var ins = Convert.ToString(tmp, 2);
			res.Insert(0, ins);
			tmp = ins.Length - 1;
		}

		return res.ToString();
	}

	private static int ElaisOmega(String m)
	{
		int res = 1;

		int i = 0;

		while (i < m.Length - 2)
		{
			var tmp = res + 1;
			res = Convert.ToInt32(m.Substring(i, tmp), 2);
			i += tmp;
		}

		return res;
	}

	private static String EvenRodeh(int num)
	{
		var dict = new Dictionary<int, String>();
		dict.Add(0, "000");
		dict.Add(1, "001");
		dict.Add(2, "010");
		dict.Add(3, "011");

		if (dict.ContainsKey(num))
			return dict[num];

		StringBuilder res = new StringBuilder("0");
		int tmp = num;

		while (tmp > 3)
		{
			var ins = Convert.ToString(tmp, 2);
			res.Insert(0, ins);
			tmp = ins.Length;
		}

		return res.ToString();
	}

	private static int EvenRodeh(String m)
	{
		if (m == "000")
			return 0;
		if (m == "001")
			return 1;
		if (m == "010")
			return 2;
		if (m == "011")
			return 3;

		int i = 3;
		int res = Convert.ToInt32(m.Substring(0, 3), 2);

		while (i < m.Length - 2)
		{
			res = Convert.ToInt32(m.Substring(i, res), 2);
			i += res;
		}

		return res;
	}

	private static String ElaisGamma(int num)
	{
		if (num == 0)
			return "Not Exist";

		var ins = Convert.ToString(num, 2);
		StringBuilder res = new StringBuilder(ins);
		for (int i = 0; i < ins.Length - 1; i++)
			res.Insert(0, "0");

		return res.ToString();
	}

	private static int ElaisGamma(String m)
	{
		return Convert.ToInt32(m.Substring(m.IndexOf("1")), 2);
	}
}