using System;
using System.Collections.Generic;

namespace Cep
{
	public class Cidade
	{
		public string Codigo{ get; set; }
		public string Nome{ get; set; }

		public Estado Estado{ get; set; }
		public List<Bairro> bairros{ get; set; }



		public Cidade(){
		}

		public Cidade(string codigo,string nome, Estado estado){
			this.Codigo = codigo;
			this.Nome = nome;
			this.Estado = estado;
		}

		public override string ToString ()
		{
			return string.Format ("[Cidade: Codigo={0}, Nome={1}, Estado={2}, bairros={3}]", Codigo, Nome, Estado, bairros);
		}


	}

}

