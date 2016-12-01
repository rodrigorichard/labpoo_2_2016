using System;
using System.Collections.Generic;

namespace MQ
{
	public class Sub : Instrucao
	{
		public Sub (Memoria memoria, Pilha pilha, Dictionary<string, int> labels,string nome, string argumento) 
			: base(memoria,pilha,labels,nome,argumento){}

		public override int executar (int contador)
		{
			Inteiro op1 = new Inteiro(pilha.pop ());
			Inteiro op2 = new Inteiro(pilha.pop ());
			pilha.push (op1 - op2);
			return contador + 1;
		}
	}
}

