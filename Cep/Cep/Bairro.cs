using System;
using System.Collections.Generic;

namespace Cep
{
	public class Bairro
	{
		public string Codigo{ get; set; }
		public String Nome{ get; set; }
		public Cidade Cidade{ get; set; }

		public List<Endereco> enderecos{ get; set; }


		public Bairro(string codigo,string nome, Cidade cidade){
			this.Codigo = codigo;
			this.Nome = nome;
			this.Cidade = cidade;
		}

		public override string ToString ()
		{
			return string.Format ("[Bairro: Codigo={0}, Nome={1}, Cidade={2}, enderecos={3}]", Codigo, Nome, Cidade, enderecos);
		}
	}


}

