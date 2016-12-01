using System;
using System.Collections.Generic;

namespace MQ
{
	public class Pilha
	{
		private Stack<Tipo> stack = new Stack<Tipo>();

		public Tipo pop(){
			return stack.Pop ();
		}
		public void push(Tipo tipo){
			stack.Push (tipo);
		}
		public Tipo inspect(){
			return stack.Peek ();
		}

		public override string ToString ()
		{
			String buffer = "";
			foreach (Tipo t in stack.ToArray()) {
				buffer += "[" + t + "]";
			}
			return buffer;
		}

	}
}

