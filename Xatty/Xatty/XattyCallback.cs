using System;

namespace Xatty
{
	public interface XattyCallback
	{

		void onMessageArrives(IMessage message);
		void onUserOnline(IUser user);
		void onUserOffline(IUser user);

	}
}

