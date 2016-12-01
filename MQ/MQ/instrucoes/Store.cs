using System;
using System.Collections.Generic;

namespace MQ
{
	public class Store : Instrucao
	{
		public Store (Memoria memoria, Pilha pilha, Dictionary<string, int> labels,string nome, string argumento) 
			: base(memoria,pilha,labels,nome,argumento){}

		public override int executar (int contador)
		{
			memoria.store (argumento, pilha.pop());
			return contador + 1;
		}
	}
}


