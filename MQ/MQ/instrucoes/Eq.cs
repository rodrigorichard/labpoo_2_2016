using System;
using System.Collections.Generic;

namespace MQ
{
	public class Eq : Instrucao
	{
		public Eq (Memoria memoria, Pilha pilha, Dictionary<string, int> labels,string nome, string argumento) 
			: base(memoria,pilha,labels,nome,argumento){}

		public override int executar (int contador)
		{
			Inteiro op1 = new Inteiro(pilha.pop ());
			Inteiro op2 = new Inteiro(pilha.pop ());
			if (op1.valor.Equals (op2.valor)) {
				pilha.push (new Tipo (true));
			} else {
				pilha.push (new Tipo (false));
			}
			return contador + 1;
		}
	}
}

