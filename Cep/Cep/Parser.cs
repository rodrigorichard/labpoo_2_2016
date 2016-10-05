using System;
using System.Collections.Generic;
namespace Cep
{
	public abstract class Parser
	{
		protected Dictionary<String,Dictionary<String,Object>> colecoes;

		public Parser (Dictionary<String,Dictionary<String,Object>> colecoes){
				this.colecoes = colecoes;
		}

		protected string[] lerDoArquivo(string nomeArquivo){
			return System.IO.File.ReadAllLines(nomeArquivo);
		}

		public Dictionary<string,Object> ler(string nomeArquivo){
			Dictionary<string,Object> objetos = new Dictionary<string,Object> ();
			foreach (string linha in lerDoArquivo(nomeArquivo)) {
				addObject (objetos, linha);
			}
			return objetos;
		}

		protected abstract void addObject (Dictionary<string,Object> objetos,
		                                  string linha);


	}
}

