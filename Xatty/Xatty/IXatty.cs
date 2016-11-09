using System;
using System.Collections.Generic;

namespace Xatty
{
	public interface IXattyCallback
	{
		void userOnline(IUser user);
		void userOffline(IUser user);
		void receive (IMessage message);
	}

	public class Xatty{

		void send(IMessage message){
			//Serializar a mensagem
			//Enviar de verdade
		}

//		List<IUser> listUsers(){
//			//Retornar a lista de usuarios;
//		}

	}
}

