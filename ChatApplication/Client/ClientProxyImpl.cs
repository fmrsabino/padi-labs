using System;
using System.Windows.Forms;

namespace ChatApplication
{
    public class ClientProxyImpl : MarshalByRefObject, CommonTypes.ClientProxy
    {
        public void registerMessage(string msg) {
            ChatWindow form = (ChatWindow)Application.OpenForms["ChatWindow"];
            form.Invoke(form.myDelegate, new Object[] {msg});
        }
    }
}
