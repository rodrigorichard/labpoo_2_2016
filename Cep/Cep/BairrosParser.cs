using System;
using System.Collections.Generic;

namespace Cep
{
	public class BairrosParser : Parser
	{
		public BairrosParser (Dictionary<String,Dictionary<String,Object>> colecoes) : base (colecoes){
		}

		protected override void addObject (Dictionary<string, object> objetos, string linha)
		{
			string[] campos = linha.Split (',');
			Cidade cidade = null;
			if(colecoes["cidades"].ContainsKey(campos[2])){
				cidade = (Cidade) colecoes["cidades"][campos[2]];
			}
			Bairro bairro = new Bairro (campos [0], campos [3],cidade);
			objetos.Add (bairro.Codigo, bairro);

		}
	}
}

