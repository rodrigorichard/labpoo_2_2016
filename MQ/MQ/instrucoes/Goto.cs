using System;
using System.Collections.Generic;

namespace MQ
{
	public class Goto : Instrucao
	{
		public Goto (Memoria memoria, Pilha pilha, Dictionary<string, int> labels,string nome, string argumento) 
			: base(memoria,pilha,labels,nome,argumento){}

		public override int executar (int contador)
		{
			Object valor = pilha.pop ().valor;
			if (valor is bool) {
				if ((bool)valor) {
					return labels [argumento] + 1;
				}
			}
			return contador + 1;

		}
	}
}

