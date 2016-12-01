using System;
using System.Collections.Generic;

namespace MQ
{
	public class Load : Instrucao
	{
		public Load (Memoria memoria, Pilha pilha, Dictionary<string, int> labels,string nome, string argumento) 
			: base(memoria,pilha,labels,nome,argumento){}

		public override int executar (int contador)
		{
			pilha.push (memoria.load (argumento));
			return contador + 1;
		}
	}
}
