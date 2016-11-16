using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Collections.Generic;

namespace Xatty
{
	public class JsonParser
	{
		public static IUser userFromJson(string json){
			JObject values = (JObject) JsonConvert.DeserializeObject (json);
			Usuario u = new Usuario ("","");
			u.Id = values.GetValue("id").ToString();
			u.setNome (values.GetValue("name").ToString());
			return u;
			
		}


		public static IMessage messageFromJson(string json){
			JObject values  = (JObject) JsonConvert.DeserializeObject (json);
			Message m = new Message ();
			//m.date = null;
			m.text = values.GetValue("text").ToString();
			Usuario sender = new Usuario ("", "");
			sender.Id = values.GetValue("id_sender").ToString();
			sender.setNome (values.GetValue("name_sender").ToString());

			Usuario receiver = new Usuario ("", "");
			receiver.Id = values.GetValue("id_receiver").ToString();
			receiver.setNome (values.GetValue("name_receiver").ToString());
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

