using System;
using System.Collections.Generic;

namespace MQ
{
	public class Processador
	{
		private Memoria memoria = new Memoria();
		private Pilha pilha = new Pilha();
		private int contador = 0;
		private List<Instrucao> instrucoes = new List<Instrucao>();
		private Dictionary<string,int> labels = new Dictionary<string,int>();

		public Processador (List<String> instrucoesString)
		{
			foreach (String i in instrucoesString) {
				instrucoes.Add(Parser.parse(i,memoria,pilha,labels));
			}

			preprocessar ();

			loop ();
		}

		void preprocessar ()
		{
			for (int i = 0; i < instrucoes.Count; i++) {
				if (instrucoes [i] is Label) {
					labels [((Label)instrucoes [i]).argumento] = i;
				}
			}
		}

		void loop ()
		{
			Instrucao i = null;
			do {
				i = instrucoes [contador];
				Console.WriteLine(i);
				contador = i.executar (contador);

				Console.WriteLine(memoria.ToString());
				Console.WriteLine(pilha.ToString());
			} while (!(i is End));
		}
		
	}
}

