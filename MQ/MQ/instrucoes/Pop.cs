using System;
using System.Collections.Generic;

namespace MQ
{
	public class Pop : Instrucao
	{
		public Pop (Memoria memoria, Pilha pilha, Dictionary<string, int> labels,string nome, string argumento) 
			: base(memoria,pilha,labels,nome,argumento){}

		public override int executar (int contador)
		{
			pilha.pop ();
			return contador + 1;
		}
	}
}

