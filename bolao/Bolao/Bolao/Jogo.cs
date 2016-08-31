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

		public int pontos(Time time){
			int ponto = 0;
			if (time.Equals (mandante)) {
				if (golsMandante > golsVisitante) {
					ponto = 3;
				}else if(golsMandante == golsVisitante){
					ponto = 1;
				}
			} else if (time.Equals (visitante)) {
				if (golsVisitante > golsMandante) {
					ponto = 3;
				}else if(golsVisitante == golsMandante){
					ponto = 1;
				}
			}

			return ponto;
		}
	}
}

