using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string number = "abc";
			int answer = number.ToInt(123);
			Console.WriteLine(answer);

		}
	}
	public static class StringOnly
	{
		public static int ToInt(this string value, int defaultValue)
		{
			int result = 0;
			try
			{
				result = Convert.ToInt32(value);
			}
			catch (Exception ex)
			{
				result = defaultValue;
			}
			return result;
		}
	}
}
