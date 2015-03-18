using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class ChatWindow : Form
    {
        static public string chatLocation = "tcp://localhost:8086/ChatAPI";
        static private string clientUrl;
        static private string name;

        public delegate void AddMessage(string message);
        public AddMessage myDelegate;

        //Receives Message from server
        public void addMessage(string msg)
        {
            if (!msg.Equals(""))
            {
                messagesList.AppendText("\r\n" + msg);
            }
        }

        public ChatWindow()
        {
            InitializeComponent();

            myDelegate = new AddMessage(addMessage);

            //can only send after registering in the channel
            send.Enabled = false;
        }

        private void registerClientChannel(string port)
        {
            TcpChannel receiveChannel = new TcpChannel(Convert.ToInt32(port));
            ChannelServices.RegisterChannel(receiveChannel, true);
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(ClientProxyImpl),
                "ClientProxy",
                WellKnownObjectMode.Singleton);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ChatWindow_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = nameValue.Text;
            string port = portValue.Text;

            if (!(name.Equals("") || port.Equals("")))
            {

                try
                {
                    registerClientChannel(port);
                }
                catch (System.Net.Sockets.SocketException)
                {
                    Console.WriteLine("Exception: System.Net.Sockets.SocketException");
                    return;
                }


                CommonTypes.ServerProxy obj = (CommonTypes.ServerProxy)Activator.GetObject(
                typeof(CommonTypes.ServerProxy),
                chatLocation);

                clientUrl = "tcp://localhost:" + port;
                obj.registerClient(name, clientUrl);
                nameValue.ReadOnly = true;
                portValue.ReadOnly = true;
                registerButton.Enabled = false;
                send.Enabled = true;

            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Sends message to server
        private void button2_Click(object sender, EventArgs e)
        {
            string msg = messageEditor.Text;

            if (!msg.Equals(""))
            {
                CommonTypes.ServerProxy obj = (CommonTypes.ServerProxy)Activator.GetObject(
                    typeof(CommonTypes.ServerProxy),
                    chatLocation);
                string formattedMsg = name + ": " + msg;
                obj.sendMessage(clientUrl, formattedMsg);
                messagesList.AppendText("\r\n" + formattedMsg);
                messageEditor.Clear();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void messageEditor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
