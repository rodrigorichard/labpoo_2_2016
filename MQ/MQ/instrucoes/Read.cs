using System;
using System.Collections.Generic;

namespace MQ
{
	public class Read : Instrucao
	{
		public Read (Memoria memoria, Pilha pilha, Dictionary<string, int> labels,string nome, string argumento) 
			: base(memoria,pilha,labels,nome,argumento){}

		public override int executar (int contador)
		{
			Tipo tipo = new Tipo (int.Parse(Console.ReadLine ()));
			pilha.push (tipo);
			return contador + 1;
		}
	}
}

