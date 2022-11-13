using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		/// <summary>
		/// IsOdd 判斷奇數 , IsEven 判斷偶數
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			bool result=20.IsOdd();
			bool result1=21.IsOdd();
			Console.WriteLine(result.ToString()+"\r\n"+result1.ToString());

			bool result3 = 20.IsEven();
			bool result4 = 21.IsEven();
			Console.WriteLine(result3.ToString() + "\r\n" + result4.ToString());

		}
	}
	public static class MyMath
	{
		public static bool IsOdd(this int source)
		{
			return source % 2 == 1;
		}
		public static bool IsEven(this int source)
		{
			return source % 2 == 0;
		}
	}
}
