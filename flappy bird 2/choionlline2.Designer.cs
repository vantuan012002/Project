namespace flappy_bird_2
{
    partial class choionlline2
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
            this.flappybird2 = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flappybird2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            this.SuspendLayout();
            // 
            // flappybird2
            // 
            this.flappybird2.BackColor = System.Drawing.Color.Cyan;
            this.flappybird2.Image = global::flappy_bird_2.Properties.Resources.bird_2;
            this.flappybird2.Location = new System.Drawing.Point(38, 216);
            this.flappybird2.Name = "flappybird2";
            this.flappybird2.Size = new System.Drawing.Size(65, 50);
            this.flappybird2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappybird2.TabIndex = 21;
            this.flappybird2.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(1, -2);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(117, 40);
            this.scoreText.TabIndex = 20;
            this.scoreText.Text = "Score:0";
            // 
            // ground
            // 
            this.ground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ground.Image = global::flappy_bird_2.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-10, 369);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(863, 100);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 19;
            this.ground.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pipeTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeTop.Image = global::flappy_bird_2.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(525, -2);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(65, 127);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 18;
            this.pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pipeBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeBottom.Image = global::flappy_bird_2.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(525, 235);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(65, 140);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 17;
            this.pipeBottom.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Cyan;
            this.flappyBird.Image = global::flappy_bird_2.Properties.Resources.wp6956996_flappy_bird_wallpapers_removebg;
            this.flappyBird.Location = new System.Drawing.Point(86, 143);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(65, 48);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 16;
            this.flappyBird.TabStop = false;
            // 
            // gametimer
            // 
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimerevent);
            // 
            // choionlline2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.flappybird2);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.flappyBird);
            this.Name = "choionlline2";
            this.Text = "choionlline2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.choionlline2_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameiskeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameiskeyup);
            ((System.ComponentModel.ISupportInitialize)(this.flappybird2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappybird2;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.Timer gametimer;
    }
}