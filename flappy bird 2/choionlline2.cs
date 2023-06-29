using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace flappy_bird_2
{
    public partial class choionlline2 : Form
    {
        
        public choionlline2(bool isHost, string ip = null)
        {
            InitializeComponent();
            MessageReceiver.DoWork += MessageReceiver_DoWork;
            CheckForIllegalCrossThreadCalls = false;

            if (isHost)
            {
               
                server = new TcpListener(System.Net.IPAddress.Any, 5732);
                server.Start();
                sock = server.AcceptSocket();
            }
            else
            {
                
                try
                {
                    client = new TcpClient(ip, 5732);
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
        int pipespeed = 5;
        int gravity;
        int score = 0;
        private void MessageReceiver_DoWork(object sender, DoWorkEventArgs e)
        {
            if (endgame())
                return;
            //FreezeBoard();
            gametimer.Enabled = false;
          
            ReceiveMove();
          
            //if (!CheckState())
            //    UnfreezeBoard();
            if (!endgame())
                gametimer.Enabled = true;

        }
        private void ReceiveMove()
        {
            byte[] buffer = new byte[16];
            sock.Receive(buffer);
           
            flappyBird.Top = (int)sock.Receive(buffer);
          
        }

        private Socket sock;
        private BackgroundWorker MessageReceiver = new BackgroundWorker();
        private TcpListener server = null;
        private TcpClient client;
    
        private void gametimerevent(object sender, EventArgs e)
        {
            byte[] num = { Convert.ToByte(flappyBird.Top) };
            sock.Send(num);
            MessageReceiver.RunWorkerAsync();
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipespeed;
            pipeTop.Left -= pipespeed;
            scoreText.Text = "Score:" + score;
            Random r = new Random();
            int b = r.Next(30, 200);
         
            if (pipeTop.Left < -70 && pipeBottom.Left < -70)
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
            t.chế_độ = "chơi online";
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
                    pipeTop.Size = new Size(55, 130);
                    pipeBottom.Top = 230;
                    break;
                case System.Windows.Forms.DialogResult.No:
                    this.Close();
                    break;
            }
            return true;
        }


        private void gameiskeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
                
            }
        }

        private void gameiskeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
               
            }
        }

        private void choionlline2_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageReceiver.WorkerSupportsCancellation = true;
            MessageReceiver.CancelAsync();
            if (server != null)
                server.Stop();
        }
    }
}
