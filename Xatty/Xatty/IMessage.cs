using System;

namespace Xatty
{
	public interface IMessage
	{

		DateTime getTimestamp();
		string getText();
		IUser getSender();
		IUser getReceiver();

	}
}

