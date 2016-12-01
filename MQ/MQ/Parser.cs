using System;
using System.Collections.Generic;

namespace MQ
{
	public class Parser
	{
		public static Instrucao parse (string i,Memoria memoria,Pilha pilha, Dictionary<string, int> labels)
		{

			string[] partes = i.Split (' ');
			string atributo = null;
			if (partes.Length == 2){
				atributo = partes [1];
			}

			var instruction = Activator.CreateInstance(
				Type.GetType("MQ." + partes [0]), memoria, pilha, labels,partes[0],atributo);

			Console.WriteLine (instruction);
			return (Instrucao)instruction;

		}
	}

}

