using System;
using System.Collections.Generic;

namespace Bolao
{
	public class Turno
	{
		public int numero;
		public List<Rodada> rodadas;
		public Campeonato	campeonato;

		public Turno ()
		{
		}

		public override string ToString ()
		{
			return "Turno " + this.numero;
		}
	}
}

