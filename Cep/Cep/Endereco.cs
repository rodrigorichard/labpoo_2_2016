using System;
using System.Collections.Generic;

namespace Cep
{
	public class Endereco
	{
		public String Cep{ get; set; }
		public Bairro Bairro{ get; set; }

		public Endereco(String cep, Bairro bairro){
			this.Cep = cep;
			this.Bairro = bairro;
		}
	}



}

