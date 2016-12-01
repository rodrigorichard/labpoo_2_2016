using System;
using System.Collections.Generic;

namespace MQ
{
	public class Label : Instrucao
	{
		public Label (Memoria memoria, Pilha pilha, Dictionary<string, int> labels,string nome, string argumento) 
			: base(memoria,pilha,labels,nome,argumento){
		}

		public override int executar (int contador)
		{
			labels[argumento] = contador;
			return contador + 1;
		}
	}
}

