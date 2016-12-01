using System;
using System.Collections.Generic;

namespace MQ
{
	public class Print : Instrucao
	{
		public Print (Memoria memoria, Pilha pilha, Dictionary<string, int> labels,string nome, string argumento) 
			: base(memoria,pilha,labels,nome,argumento){}

		public override int executar (int contador)
		{
			Console.WriteLine (pilha.inspect ());
			return contador + 1;
		}
	}
}

