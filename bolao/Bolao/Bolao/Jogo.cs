using System;
using System.Collections.Generic;

namespace Bolao
{
	public class Jogo
	{
		public Time mandante;
		public Time visitante;
		public int golsMandante;
		public int golsVisitante;
		public Rodada rodada;
		public List<Aposta> apostas;

		public Jogo ()
		{
		}

		public override string ToString ()
		{
			return mandante.nome + " x " + visitante.nome + " --> " + golsMandante + ":" + golsVisitante;
		}
	}
}

