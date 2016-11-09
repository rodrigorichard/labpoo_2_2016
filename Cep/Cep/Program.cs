using System;
using System.Collections.Generic;
namespace Cep
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Dictionary<String,Dictionary<string,Object>> colecoes = 
				new Dictionary<string, Dictionary<string, object>> ();


			Parser estadoParser = new EstadosParser (null);
			colecoes.Add("estados",estadoParser.ler ("/Users/rodrigosol/puc/poo/labpoo_2_2016/Cep/estados.csv"));


			Parser cidadeParser = new CidadeParser (colecoes);
			colecoes.Add("cidades",cidadeParser.ler ("/Users/rodrigosol/puc/poo/labpoo_2_2016/Cep/cidades.csv"));

			Parser bairrosParser = new BairrosParser (colecoes);
			colecoes.Add("bairros",bairrosParser.ler ("/Users/rodrigosol/puc/poo/labpoo_2_2016/Cep/bairros.csv"));

			foreach (Bairro bairro in colecoes["bairros"].Values) {
				Console.WriteLine (bairro);
			}

		}
	}
}
