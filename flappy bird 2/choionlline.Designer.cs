namespace flappy_bird_2
{
    partial class choionlline
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bnthost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LAN = new System.Windows.Forms.Button();
            this.scoreText = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.flappybird2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Location = new System.Drawing.Point(-7, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 328);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.bnthost);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.LAN);
            this.panel2.Location = new System.Drawing.Point(-7, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 175);
            this.panel2.TabIndex = 1;
            // 
            // bnthost
            // 
            this.bnthost.Location = new System.Drawing.Point(19, 93);
            this.bnthost.Name = "bnthost";
            this.bnthost.Size = new System.Drawing.Size(134, 35);
            this.bnthost.TabIndex = 3;
            this.bnthost.Text = "Host";
            this.bnthost.UseVisualStyleBackColor = true;
            this.bnthost.Click += new System.EventHandler(this.bnthost_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 22);
            this.textBox1.TabIndex = 1;
            // 
            // LAN
            // 
            this.LAN.Location = new System.Drawing.Point(156, 42);
            this.LAN.Name = "LAN";
            this.LAN.Size = new System.Drawing.Size(88, 49);
            this.LAN.TabIndex = 0;
            this.LAN.Text = "connect";
            this.LAN.UseVisualStyleBackColor = true;
            this.LAN.Click += new System.EventHandler(this.LAN_Click);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(246, -3);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(117, 40);
            this.scoreText.TabIndex = 14;
            this.scoreText.Text = "Score:0";
            // 
            // gametimer
            // 
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimerevent);
            // 
            // ground
            // 
            this.ground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ground.Image = global::flappy_bird_2.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(238, 398);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(838, 100);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 13;
            this.ground.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pipeTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeTop.Image = global::flappy_bird_2.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(744, -3);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(65, 127);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 12;
            this.pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pipeBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeBottom.Image = global::flappy_bird_2.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(744, 274);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(65, 140);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 11;
            this.pipeBottom.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Cyan;
            this.flappyBird.Image = global::flappy_bird_2.Properties.Resources.wp6956996_flappy_bird_wallpapers_removebg;
            this.flappyBird.Location = new System.Drawing.Point(367, 134);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(65, 48);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 10;
            this.flappyBird.TabStop = false;
            // 
            // flappybird2
            // 
            this.flappybird2.BackColor = System.Drawing.Color.Cyan;
            this.flappybird2.Image = global::flappy_bird_2.Properties.Resources.bird_2;
            this.flappybird2.Location = new System.Drawing.Point(298, 209);
            this.flappybird2.Name = "flappybird2";
            this.flappybird2.Size = new System.Drawing.Size(65, 50);
            this.flappybird2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappybird2.TabIndex = 15;
            this.flappybird2.TabStop = false;
            // 
            // choionlline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1031, 493);
            this.Controls.Add(this.flappybird2);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "choionlline";
            this.Text = "choionlline";
            this.Shown += new System.EventHandler(this.choionlline_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameiskeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameiskeyup);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button LAN;
        private System.Windows.Forms.PictureBox flappybird2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnthost;
    }
}