using System;
using System.Collections.Generic;

namespace MQ
{
	public class Lt : Instrucao
	{
		public Lt (Memoria memoria, Pilha pilha, Dictionary<string, int> labels,string nome, string argumento) 
			: base(memoria,pilha,labels,nome,argumento){}

		public override int executar (int contador)
		{
			Inteiro op1 = new Inteiro(pilha.pop ());
			Inteiro op2 = new Inteiro(pilha.pop ());
			if ((int) op1.valor < (int)(op2.valor)) {
				pilha.push (new Tipo (true));
			} else {
				pilha.push (new Tipo (false));
			}
			return contador + 1;
		}
	}
}

