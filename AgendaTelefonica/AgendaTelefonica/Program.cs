using System;
using System.Collections.Generic;

namespace AgendaTelefonica
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Pessoa joao = new Pessoa ("Joao", "Souza");
			Pessoa maria = new Pessoa ("Maria", "Miranda");

			Pessoa novaMaria = joao + maria;
			Console.WriteLine (novaMaria);
			List<Pessoa> pessoas;
			pessoas [1];


		}
	}
}
