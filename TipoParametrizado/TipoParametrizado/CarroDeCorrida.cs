using System;

namespace TipoParametrizado
{
	public class CarroDeCorrida : TemNome, TemSobrenome
	{

		public string Nome{ get; set; }
		public string Sobrenome{ get; set; }
		public CarroDeCorrida (string nome, string sobrenome)
		{
			this.Nome = nome;
			this.Sobrenome = sobrenome;
		}

		public string meuNome ()
		{
			return this.Nome;
		}

		public string meuSobrenome(){
			return this.Sobrenome;
		}

		public string meuTipo(){
			return "Cavalo";
		}

	}
}

