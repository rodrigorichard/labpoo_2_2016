using System;

namespace MQ
{
	public class Tipo
	{
		public object valor{ get; set;}
		public Tipo (object valor)
		{
			if (valor is Tipo) {
				this.valor = ((Tipo)valor).valor;
			} else {
				this.valor = valor;
			}

		}

		public override string ToString ()
		{
			return this.valor.ToString ();
		}

	}
}

