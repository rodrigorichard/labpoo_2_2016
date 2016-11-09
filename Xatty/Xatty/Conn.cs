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

		public Conn (IUser user)
		{
			// create client instance
			this.user = user;
			client = new MqttClient("mosquitto.rarolabs.com.br");
			client.Connect(user.getId());

			client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
			client.Subscribe(new string[] { "/xatty/status/+" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
			client.Subscribe(new string[] { "/xatty/message/+/"+ user.getId() }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });

		}

		public void send(string topic,string content){
			client.Publish(topic, Encoding.UTF8.GetBytes(content));
		}

		public void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e){

			Console.WriteLine("{0} recebeu {1}",user.getDisplayName(),Encoding.UTF8.GetString(e.Message));
		}
	}
}

