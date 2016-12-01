using System;
using System.Collections.Generic;

namespace MQ
{

	public class Memoria
	{
		private Dictionary<string,Tipo> memoria = new Dictionary<string,Tipo>();

		public Tipo load(string index){
			return memoria [index];
		}
		public void store(string index, Tipo tipo){

			memoria[index] = tipo;
		}


		public override string ToString ()
		{
			String buffer = "";
			foreach (String key in memoria.Keys) {
				buffer += "[{" + key + "}-->{" + memoria [key] + "}]";
			}
			return buffer;
		}
	}

}

