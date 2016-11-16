using System;
using Xatty;

namespace XattyClient
{
	public class ChatUser : IUser
	{

		private string id;
		private string nome;

		public ChatUser (string nome)
		{
			this.id = System.Guid.NewGuid ().ToString();
			this.nome = nome;
		}

		public ChatUser (string nome,string id)
		{
			this.id = id;
			this.nome = nome;
		}

		public string getId ()
		{
			return this.id;
		}

		public string getDisplayName ()
		{
			return this.nome;
		}

		public override string ToString ()
		{
			return getDisplayName ();
		}

	}
}

