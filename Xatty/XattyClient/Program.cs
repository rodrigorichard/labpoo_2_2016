using System;

namespace XattyClient
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Chat trump = new Chat ("Donald Trump");
			Chat pato = new Chat ("Pato Donald");
			Console.ReadKey ();
			trump.send ("Ola", (ChatUser)trump.getFirstUser ());
			Console.ReadKey ();

		}
	}
}
