using System;
using System.Text;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;


namespace Xatty
{
	public class Conn
	{
		private MqttClient client;

		IUser user;

		XattyCallback callback;

		public Conn (IUser user,XattyCallback callback)
		{
			this.callback = callback;
			// create client instance
			this.user = user;
			client = new MqttClient("mosquitto.rarolabs.com.br");


			client.Connect(user.getId(), null, null,
				false, // will retain flag
				MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, // will QoS
				true, // will flag
				"/xatty/status/offline", // will topic
				JsonParser.userToJson(this.user), // will message
				true,
				60);

			client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
			client.Subscribe(new string[] { "/xatty/status/+" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
			client.Subscribe(new string[] { "/xatty/message/+/"+ user.getId() }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
			onConnect ();
		}


	
		public void sendMessage(IMessage msg){
			this.send ("/xatty/message/" + msg.getSender().getId() + "/" + msg.getReceiver().getId(),JsonParser.messageToJson(msg));
		}

		private void onConnect(){
			send ("/xatty/status/online", JsonParser.userToJson (this.user));
		}

		private void send(string topic,string content){
			client.Publish(topic, Encoding.UTF8.GetBytes(content));
		}

		public void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e){
			string textoRecebido = Encoding.UTF8.GetString (e.Message);

			if (e.Topic.Equals ("/xatty/status/online")) {
				callback.onUserOnline (JsonParser.userFromJson(textoRecebido));
			} else if (e.Topic.Equals ("/xatty/status/offline")) {
				callback.onUserOffline ((JsonParser.userFromJson(textoRecebido)));
			} else if (e.Topic.StartsWith ("/xatty/message")) {
				callback.onMessageArrives (JsonParser.messageFromJson (textoRecebido));
			}
		}
	}
}

