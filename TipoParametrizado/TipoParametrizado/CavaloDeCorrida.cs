using System;

namespace TipoParametrizado
{
	public class CavaloDeCorrida : TemNome
	{
		public string Nome{ get; set;}
		public CavaloDeCorrida (string nome)
		{
			this.Nome = nome;
		}

		public string meuNome ()
		{
			return this.Nome;
		}

		public string meuTipo(){
			return "Cavalo";
		}
	}
}

