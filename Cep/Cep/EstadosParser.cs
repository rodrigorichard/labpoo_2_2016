using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Cep
{
	public class EstadosParser : Parser
	{

		public EstadosParser (Dictionary<String,Dictionary<String,Object>> colecoes) : base (colecoes){
		}

		protected override void addObject (Dictionary<string, object> objetos, string linha)
		{
			string[] campos = linha.Split (',');
			Estado estado = new Estado (campos [1], campos [2]);
			objetos.Add (estado.Sigla, estado);
		}
	}
}

