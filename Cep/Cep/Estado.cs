using System;
using System.Collections.Generic;
namespace Cep
{
	public class Estado
	{
		private int id;
		public void setId(int id){
			this.id = id;
		}
		public int getId(){
			return this.id;
		}


		public String Nome { get; set;}
		public String Sigla { get; set;}
		public List<Cidade> Cidades{ get; set; }

		public Estado ()
		{
		}

		public Estado(string nome, string sigla){
			this.Nome = nome;
			this.Sigla = sigla;
		}

		public override string ToString ()
		{
			return this.Nome + " - " + this.Sigla;
		}
	}
}

