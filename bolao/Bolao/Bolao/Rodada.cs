using System;
using System.Collections.Generic;

namespace Bolao
{
	public class Rodada
	{
		public int numero;
		public List<Jogo> jogos;
		public Turno turno;
		public DateTime dataLimite;

		public Rodada ()
		{
			jogos = new List<Jogo> ();
		}

		public override string ToString ()
		{
			return "Rodada " + this.numero;
		}
	}
}

