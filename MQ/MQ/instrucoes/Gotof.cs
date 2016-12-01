using System;
using System.Collections.Generic;

namespace MQ
{
	public class Gotof : Instrucao
	{
		public Gotof (Memoria memoria, Pilha pilha, Dictionary<string, int> labels,string nome, string argumento) 
			: base(memoria,pilha,labels,nome,argumento){}

		public override int executar (int contador)
		{
			Object valor = pilha.pop ().valor;
			if (valor is bool) {
				if (!(bool)valor) {
					return labels [argumento] + 1;
				}
			}
			return contador + 1;

		}
	}
}

