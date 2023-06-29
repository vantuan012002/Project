using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_bird_2
{
    public partial class choidon : Form
    { 
        int pipespeed = 5;
        int gravity;
        int score = 0;
        public choidon()
        {
            InitializeComponent();
        }
        private void Timerflappy(object sender, EventArgs e)
        {
            flappyBird.Left += 5;
            if (flappyBird.Left > 130)
                timerflappy.Enabled = false;
        }
        private void gametimerevent(object sender, EventArgs e)
        {
          
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipespeed;
            pipeTop.Left -= pipespeed;
            scoreText.Text = "Score:" + score;
            Random r = new Random();
            int b = r.Next(30, 200);
            //pipeTop.Location.X = 100;
            if (pipeTop.Left < -70 && pipeBottom.Left < -70)
            { 
                pipeTop.Size = new Size(55,b);
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
            gametimer.Enabled=false;
            DialogResult go = MessageBox.Show("ban co muon choi lai", "Game Over:" + score + " diem", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            dbdiemDataContext db = new dbdiemDataContext();
            quanlidata t = new quanlidata();
            t.điểm = score;
            DateTime x = DateTime.Now;
            t.Lần_chơi = x;
            t.chế_độ="chơi offline";
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
                    pipeTop.Size = new Size(55, 100);
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

        private void pipeTop_Click(object sender, EventArgs e)
        {

        }

        private void choidon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gametimer.Enabled==false)
            {
                e.Cancel = false;
                return;
            }
                gametimer.Enabled = false;
                DialogResult go = MessageBox.Show("Bạn có muốn thoát game khong ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (go)
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        MessageBox.Show("diem cua ban:" + score);
                        dbdiemDataContext db = new dbdiemDataContext();
                        quanlidata t = new quanlidata();
                        t.điểm = score;
                        DateTime x = DateTime.Now;
                        t.Lần_chơi = x;
                        t.chế_độ = "chơi offline";
                        db.quanlidatas.InsertOnSubmit(t);
                    db.SubmitChanges();
                    break;
                    case System.Windows.Forms.DialogResult.No:
                        gametimer.Enabled = true;
                        e.Cancel = true;
                        break;

                }
            
        }

        private void chơiMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gametimer.Enabled = true;
            pipeTop.Left = 500;
            pipeBottom.Left = 500;
            score = 0;
            gravity = 0;
            flappyBird.Top = 150;
            pipespeed = 5;
            pipeBottom.Size = new Size(55, 100);
            pipeTop.Size = new Size(55, 100);
            pipeBottom.Top = 230;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gametimer.Enabled = false;
            MessageBox.Show("diem cua ban:" + score);
            dbdiemDataContext db = new dbdiemDataContext();
            quanlidata t = new quanlidata();
            t.điểm = score;
            DateTime x = DateTime.Now;
            t.Lần_chơi = x;
            t.chế_độ = "chơi offline";
            db.quanlidatas.InsertOnSubmit(t);
            db.SubmitChanges();
            this.Close();
        }

        private void tùyChọnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gametimer.Enabled = false;
        }
    }  
}
