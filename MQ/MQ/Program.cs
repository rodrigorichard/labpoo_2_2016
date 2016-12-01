using System;
using System.Collections.Generic;

namespace MQ
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<string> instrucoes = new List<string> ();
			instrucoes.Add ("Read");
			instrucoes.Add ("Store N");
			instrucoes.Add ("Label loop");
			instrucoes.Add ("Push 2");
			instrucoes.Add ("Load N");
			instrucoes.Add ("Sub");
			instrucoes.Add ("Store N");
			instrucoes.Add ("Push 0");
			instrucoes.Add ("Load N");
			instrucoes.Add ("Le");
			instrucoes.Add ("Goto fim");
			instrucoes.Add ("Push false");
			instrucoes.Add ("Gotof loop");
			instrucoes.Add ("Label fim");
			instrucoes.Add ("Load N");
			instrucoes.Add ("Push 0");
			instrucoes.Add ("Eq");
			instrucoes.Add ("Print");
			instrucoes.Add ("End");



			new Processador (instrucoes);

		}
	}
}
