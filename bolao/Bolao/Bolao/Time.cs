using System;
using System.Collections.Generic;

namespace Bolao
{
	public class Time
	{
		public String nome;
		public Campeonato campeonato;
		public List<Jogo> jogosComoMandante;
		public List<Jogo> jogosComoVisitante;

		public Time ()
		{
		}

		public override string ToString ()
		{
			return nome;
		}
	}
}

