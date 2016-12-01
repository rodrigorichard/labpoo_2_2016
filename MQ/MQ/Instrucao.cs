using System;
using System.Collections.Generic;

namespace MQ
{
	public abstract class  Instrucao
	{
		protected Memoria memoria;

		protected Pilha pilha;

		protected Dictionary<string, int> labels;

		protected string nome;

		public string argumento;

		public Instrucao (Memoria memoria, Pilha pilha, Dictionary<string, int> labels,string nome, string argumento)
		{
			this.memoria = memoria;
			this.pilha = pilha;
			this.labels = labels;
			this.nome = nome;
			this.argumento = argumento;
		}

		public abstract int executar(int contador);
	}



}

