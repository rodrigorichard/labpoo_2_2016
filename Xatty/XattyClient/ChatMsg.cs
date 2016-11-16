using System;
using Xatty;

namespace XattyClient
{
	public class ChatMsg : IMessage
	{
		string text;

		ChatUser sender;

		ChatUser receiver;

		public ChatMsg (string text, ChatUser sender, ChatUser receiver)
		{
			this.text = text;
			this.sender = sender;
			this.receiver = receiver;
		}


		public DateTime getTimestamp ()
		{
			return new DateTime();
		}

		public string getText ()
		{
			return text;
		}

		public IUser getSender ()
		{
			return sender;
		}

		public IUser getReceiver ()
		{
			return receiver;
		}


	}
}

