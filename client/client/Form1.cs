using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            
            Connect();
            
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage(txbMessage.Text);

        }
        IPEndPoint IP;
        Socket client;
        void Connect()
        {
            //IP la dia chi cua server
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            // client se ket noi voi server

            try
            {

                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("khong the ket noi", " Loi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();

        }
        void Closes()
        {
            client.Close();
        }
        void Send()
        {
            if ( txbMessage.Text != String.Empty)
            client.Send(Serialize(txbMessage.Text));

           
           

        }


        void Receive()
        {
            try
            {

                // vong lap nhan tin
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)(Deserializa(data));


                    AddMessage(message);

                }
            }
            // neu messae qua tai -> dong ket noi
            catch
            {
                Close();

            }
        }
        // message Dc luu vao lsvMessage
        void AddMessage(string s)
        {
            lsvMessage.Items.Add(new ListViewItem { Text = s });
            txbMessage.Clear();
        }
        byte[] Serialize(object obj)
        {
            MemoryStream Stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();  
            formatter.Serialize(Stream, obj);
            //ghi thong tin thanh ma byte
            return Stream.ToArray();
            


        }
        object Deserializa(byte[] data)
        {
            MemoryStream Stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(Stream);
            //ghi thong tin thanh ma byte
            

        }


        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        

    }
}