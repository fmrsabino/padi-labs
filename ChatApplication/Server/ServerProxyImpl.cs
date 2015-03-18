using System;
using System.Collections.Generic;

namespace ChatApplication
{
    public class Client {
        private string nick;
        private string proxyUrl;

        public Client(string nick, string proxyUrl)
        {
            this.nick = nick;
            this.proxyUrl = proxyUrl;
        }

        public string ProxyUrl
        {
            get { return proxyUrl; }
        }
    }

    public class ServerProxyImpl : MarshalByRefObject, CommonTypes.ServerProxy
    {
        private List<Client> clients = new List<Client>();

        public void sendMessage(string src, string msg)
        {
            foreach (Client client in clients)
            {
                if (!client.ProxyUrl.Equals(src))
                {
                    CommonTypes.ClientProxy obj = (CommonTypes.ClientProxy)Activator.GetObject(
                        typeof(CommonTypes.ClientProxy),
                        client.ProxyUrl + "/ClientProxy");
                    if (obj != null)
                    {
                        obj.registerMessage(msg);
                    }
                }
            }
        }

        public void registerClient(string nick, string proxy)
        {
            clients.Add(new Client(nick, proxy));
            Console.WriteLine("Client {0} registred at {1}!", nick, proxy);
        }
    }
}
