using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
namespace flappy_bird_2
{
    public partial class choionlline : Form
    {
        int pipespeed = 5;
        int gravity;
        int score = 0;
       // SoketManager socket;
        private Socket sock;
        private BackgroundWorker MessageReceiver = new BackgroundWorker();
        private TcpListener server = null;
        private TcpClient client;
        private bool value;
        public choionlline()
        {
            MessageReceiver.DoWork += MessageReceiver_DoWork;
            CheckForIllegalCrossThreadCalls = false;

            if (value)
            {
                
                server = new TcpListener(System.Net.IPAddress.Any, 5732);
                server.Start();
                sock = server.AcceptSocket();
            }
            else
            {
              
                try
                {
                    client = new TcpClient(textBox1.Text, 5732);
                    sock = client.Client;
                    MessageReceiver.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
        }

        private void MessageReceiver_DoWork(object sender, DoWorkEventArgs e)
        {
            if (endgame())
                return;
           // FreezeBoard();
           
            ReceiveMove();
           
           // if (!CheckState())
               // UnfreezeBoard();
        }
            private void LAN_Click(object sender, EventArgs e)
        {
            //Game newGame = new Game(false, textBox1.Text);
            Visible = false;
            gametimer.Enabled = true;
            //if (!newGame.IsDisposed)
            //    newGame.ShowDialog();
            //Visible = true;
        }

        private void choionlline_Shown(object sender, EventArgs e)
        {
            //textBox1.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            //if (string.IsNullOrEmpty(textBox1.Text))
            //{
            //    textBox1.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            //}
        }
        void Listen()
        {
          //  flappyBird.Top = (int)socket.Receive();

           //essageBox.Show(data);
        }

        private void gametimerevent(object sender, EventArgs e)
        {
          
      //    Listen();
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipespeed;
            pipeTop.Left -= pipespeed;
            scoreText.Text = "Score:" + score;
            Random r = new Random();
            int b = r.Next(30, 200);
            //pipeTop.Location.X = 100;
            if (pipeTop.Left < 170 && pipeBottom.Left < 170)
            {
                pipeTop.Size = new Size(55, b);
                pipeBottom.Top = b + 140;
                pipeBottom.Size = new Size(55, 420 - pipeBottom.Top);
                pipeBottom.Left = 550;
                pipeTop.Left = 550;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) || flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -10)
            {
                endgame();
            }
            if (score > 4)
                pipespeed = score;


        }

        private bool endgame()
        {
            gametimer.Enabled = false;
            DialogResult go = MessageBox.Show("ban co muon choi lai", "Game Over:" + score + " diem", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            dbdiemDataContext db = new dbdiemDataContext();
            quanlidata t = new quanlidata();
            t.điểm = score;
            DateTime x = DateTime.Now;
            t.Lần_chơi = x;
            t.chế_độ = "chơi offline";
            db.quanlidatas.InsertOnSubmit(t);
            db.SubmitChanges();
            switch (go)
            {
                case System.Windows.Forms.DialogResult.Yes:
                    gametimer.Enabled = true;
                    pipeTop.Left = 500;
                    pipeBottom.Left = 500;
                    score = 0;
                    gravity = 0;
                    flappyBird.Top = 150;
                    pipespeed = 5;
                    pipeBottom.Size = new Size(55, 100);
                    pipeTop.Size = new Size(55, 140);
                    pipeBottom.Top = 230;
                    break;
                case System.Windows.Forms.DialogResult.No:
                    this.Close();
                    break;
            }
            server.Stop();
            return true;
        }



        private void gameiskeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
                byte[] num = { Convert.ToByte(-10) };
                sock.Send(num);
                MessageReceiver.RunWorkerAsync();
            }
        }

        private void gameiskeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
                byte[] num = { Convert.ToByte(5) };
                sock.Send(num);
                MessageReceiver.RunWorkerAsync();
            }
        }
        private void ReceiveMove()
        {
            byte[] buffer = new byte[16];
            sock.Receive(buffer);
            if (value)
                flappybird2.Top +=(int)sock.Receive(buffer);
            else
                flappyBird.Top += (int)sock.Receive(buffer);
        }

        private void bnthost_Click(object sender, EventArgs e)
        {
            value = true;
            Visible = false;
            gametimer.Enabled = true;
            //if (!newGame.IsDisposed)
            //    newGame.ShowDialog();
            //Visible = true;
        }
    }
    
}
