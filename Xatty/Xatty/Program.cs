using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Xatty
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			IUser donald = new Usuario ("Donald", "Trump");
			IUser roberto = new Usuario ("Roberto", "Justus");
			Message m = new Message ();
			m.text = "Vou fazer o mesmo aqui na ...";
			m.sender = roberto;
			m.receiver = donald;

			Conn connDonald = new Conn (donald);
			Conn connRoberto = new Conn (roberto);



			//connEu.send ("/xatty/status/online",JsonParser.userToJson(eu));
			connRoberto.send ("/xatty/message/" + roberto.getId() + "/" + donald.getId(),JsonParser.messageToJson(m));

			Console.ReadKey ();
			//Console.WriteLine (JsonParser.messageToJson(m));
		}
	}
}
