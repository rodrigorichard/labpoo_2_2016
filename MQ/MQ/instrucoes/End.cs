using System;
using System.Collections.Generic;

namespace MQ
{
	public class End : Instrucao
	{
		public End (Memoria memoria, Pilha pilha, Dictionary<string, int> labels,string nome, string argumento) 
			: base(memoria,pilha,labels,nome,argumento){}

		public override int executar (int contador)
		{
			return contador;
		}
	}
}
