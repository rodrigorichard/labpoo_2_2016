using System;
using System.Collections.Generic;

namespace Cep
{
	public class CidadeParser : Parser
	{
		public CidadeParser (Dictionary<String,Dictionary<String,Object>> colecoes) : base (colecoes){
		}

		protected override void addObject (Dictionary<string, object> objetos, string linha)
		{
			string[] campos = linha.Split (',');
			Cidade cidade = new Cidade(campos[0],campos[1],
				(Estado)colecoes["estados"][campos[2]]);
			objetos.Add (cidade.Codigo, cidade);

		}
	}
}

