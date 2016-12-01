using System;

namespace XattyClient
{
	class MainClass
	{

		public static void Main (string[] args)
		{

			int a = 10;
			a = x (a);
			Console.WriteLine (a);
		}

		public static int x(int a){

			return a + 1;
		}
	}
}
