using System;
using Newtonsoft.Json;
using System.Text;
using System.Collections.Generic;

namespace Xatty
{
	public class JsonParser
	{
		public static IUser userFromJson(string json){
			Dictionary<string,string> values = (Dictionary<string,string>) JsonConvert.DeserializeObject (json);
			Usuario u = new Usuario ("","");
			u.Id = values ["id"];
			u.setNome (values ["name"]);
			return u;
			
		}


		public static IMessage messageFromJson(string json){
			Dictionary<string,string> values = (Dictionary<string,string>) JsonConvert.DeserializeObject (json);
			Message m = new Message ();
			//m.date = null;
			m.text = values ["text"];
			Usuario sender = new Usuario ("", "");
			sender.Id = values ["id_sender"];
			sender.setNome (values ["name_sender"]);

			Usuario receiver = new Usuario ("", "");
			receiver.Id = values ["id_receiver"];
			receiver.setNome (values ["name_receiver"]);
			m.sender = sender;
			m.receiver = receiver;
			return m;
		}
		public static string userToJson(IUser user){
			Dictionary<string,dynamic> values = new Dictionary<string,dynamic> ();
			values.Add ("id", user.getId ());
			values.Add ("name", user.getDisplayName ());
			return JsonConvert.SerializeObject (values);
		}

		public static string messageToJson(IMessage message){
			Dictionary<string,dynamic> values = new Dictionary<string,dynamic> ();
			values.Add ("text", message.getText ());
			values.Add ("id_sender", message.getSender().getId());
			values.Add ("name_sender", message.getSender().getDisplayName());

			values.Add ("id_receiver", message.getReceiver().getId());
			values.Add ("name_receiver", message.getReceiver().getDisplayName());

			return JsonConvert.SerializeObject (values);
		}

	}
}

