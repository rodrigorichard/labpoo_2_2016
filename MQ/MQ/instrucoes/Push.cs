using System;
using System.Collections.Generic;

namespace MQ
{
	public class Push : Instrucao
	{
		public Push (Memoria memoria, Pilha pilha, Dictionary<string, int> labels,string nome, string argumento) 
			: base(memoria,pilha,labels,nome,argumento){}

		public override int executar (int contador)
		{
			int r;
			if (int.TryParse (argumento, out r)) {
				pilha.push (new Tipo (r));
			} else {
				pilha.push (new Tipo (bool.Parse (argumento)));
			}
			return contador + 1;
		}
	}
}

