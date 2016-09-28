using System;

namespace CalculadoraSemIf
{
	public class Soma : Operacao
	{
		public Soma ()
		{
		}

		public override int executa (Numero n1, Numero n2)
		{
			return n1.valor () + n2.valor ();
		}
	}
}

