using System;

namespace Xatty
{
	public class Message : IMessage
	{

		public DateTime date{ set; get;}
		public string text{set;get;}
		public IUser sender{set;get;}
		public IUser receiver{set;get;}

		public Message ()
		{
		}

		public DateTime getTimestamp ()
		{
			return this.date;
		}

		public string getText ()
		{
			return this.text;
		}

		public IUser getSender ()
		{
			return this.sender;
		}

		public IUser getReceiver ()
		{
			return this.receiver;
		}


	}
}

