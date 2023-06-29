using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace may_chu
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            Connect();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {

            foreach (Socket Item in clientList)
            {
                Send(Item);
            }
            AddMessage(txbMessage.Text);
            txbMessage.Clear();
        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;

        void Connect()
        {
            // dnah sach client ket noi
            clientList = new List<Socket>();
            //IP la dia chi cua server, ANy doi cac client ket noi
            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            // client se ket noi voi server

            server.Bind(IP);
            // nhan tin tu cac client
            Thread Listen = new Thread(() => {
                try
                {
                    while (true)
                    {

                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);
                        Thread recieve = new Thread(Receive);
                        recieve.IsBackground = true;
                        recieve.Start(client);
                    }
                }
                catch
                {
                    //khoi tao lai IP va server
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                }
            });
            Listen.IsBackground = true;
            Listen.Start();



        }
        void Closes()
        {
            server.Close();
        }
        void Send(Socket client)
        {
            if (client != null && txbMessage.Text != String.Empty)
                client.Send(Serialize(txbMessage.Text));

        }


        void Receive(object obj)

        {
            Socket client = obj as Socket;
            try
            {

                // vong lap nhan tin
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)(Deserializa(data));
                    //cho phep thay message cua ca client
                    foreach (Socket Item in clientList)
                    {
                        if (Item != null && Item != client)
                        {

                            Item.Send(Serialize(message));
                        }

                        AddMessage(message);
                    }

                }
            }
            // neu messae qua tai -> dong ket noi
            catch
            {
                clientList.Remove(client);
                client.Close();

            }
        }
        // message Dc luu vao lsvMessage
        void AddMessage(string s)
        {
            lsvMessage.Items.Add(new ListViewItem { Text = s });
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

    }
}