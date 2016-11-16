using System;
using System.Collections.Generic;
using Xatty;
namespace XattyClient
{
	public class Chat : XattyCallback
	{
		private List<ChatUser> onlines = new List<ChatUser>();
		private ChatUser meuUsuario;

		Conn connection;

		public Chat (string nome)
		{
			this.meuUsuario = new ChatUser (nome);
			Console.WriteLine ("{0} --> Id {1}", this.meuUsuario, this.meuUsuario.getId ());
			this.connection = new Conn (this.meuUsuario, this);
		}

		public void send(string texto, ChatUser destino){
			ChatMsg msg = new ChatMsg (texto, this.meuUsuario, destino);
			this.connection.sendMessage (msg);
		}

		public void onMessageArrives (IMessage message)
		{
			Console.WriteLine ("{0} recebeu uma mensagem de {1}: {2}",
				this.meuUsuario.getDisplayName (),
				message.getSender ().getDisplayName (),
				message.getText ());
		}

		public void onUserOnline (IUser user)
		{
			if(!user.getId().Equals(this.meuUsuario.getId())){
				onlines.Add (new ChatUser(user.getDisplayName(),user.getId()));
			}
			Console.WriteLine ("{0} - Usuario online:{1}", this.meuUsuario.getDisplayName(),user.getDisplayName());
		}

		public void onUserOffline (IUser user)
		{
			Console.WriteLine ("{0} - Usuario offline:{1}",this.meuUsuario.getDisplayName(),  user.getDisplayName());
		}

		public ChatUser getFirstUser(){
			return onlines [0];
		}
	}
}

