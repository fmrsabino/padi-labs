
namespace CommonTypes
{
    public interface ClientProxy {
        void registerMessage(string msg);
    }

    public interface ServerProxy  {
        void sendMessage(string src, string msg);
        void registerClient(string nick, string proxy);
    }
}
