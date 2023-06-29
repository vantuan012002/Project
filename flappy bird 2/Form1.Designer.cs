namespace flappy_bird_2
{
    partial class Form1
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
            this.bntchoidon = new System.Windows.Forms.Button();
            this.bntchoiolline = new System.Windows.Forms.Button();
            this.bntcachchoi = new System.Windows.Forms.Button();
            this.bntthoat = new System.Windows.Forms.Button();
            this.bntdiem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntchoidon
            // 
            this.bntchoidon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntchoidon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bntchoidon.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntchoidon.ForeColor = System.Drawing.Color.White;
            this.bntchoidon.Location = new System.Drawing.Point(193, 135);
            this.bntchoidon.Name = "bntchoidon";
            this.bntchoidon.Size = new System.Drawing.Size(225, 48);
            this.bntchoidon.TabIndex = 0;
            this.bntchoidon.Text = "chơi";
            this.bntchoidon.UseVisualStyleBackColor = false;
            this.bntchoidon.Click += new System.EventHandler(this.bntchoidon_Click);
            // 
            // bntchoiolline
            // 
            this.bntchoiolline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntchoiolline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bntchoiolline.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntchoiolline.Location = new System.Drawing.Point(193, 218);
            this.bntchoiolline.Name = "bntchoiolline";
            this.bntchoiolline.Size = new System.Drawing.Size(225, 47);
            this.bntchoiolline.TabIndex = 1;
            this.bntchoiolline.Text = "chơi online";
            this.bntchoiolline.UseVisualStyleBackColor = false;
            this.bntchoiolline.Click += new System.EventHandler(this.bntchoiolline_Click);
            // 
            // bntcachchoi
            // 
            this.bntcachchoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntcachchoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bntcachchoi.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntcachchoi.Location = new System.Drawing.Point(193, 289);
            this.bntcachchoi.Name = "bntcachchoi";
            this.bntcachchoi.Size = new System.Drawing.Size(225, 47);
            this.bntcachchoi.TabIndex = 2;
            this.bntcachchoi.Text = "cách chơi";
            this.bntcachchoi.UseVisualStyleBackColor = false;
            this.bntcachchoi.Click += new System.EventHandler(this.bntcachchoi_Click);
            // 
            // bntthoat
            // 
            this.bntthoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntthoat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bntthoat.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntthoat.Location = new System.Drawing.Point(193, 428);
            this.bntthoat.Name = "bntthoat";
            this.bntthoat.Size = new System.Drawing.Size(225, 47);
            this.bntthoat.TabIndex = 3;
            this.bntthoat.Text = "Thoát";
            this.bntthoat.UseVisualStyleBackColor = false;
            this.bntthoat.Click += new System.EventHandler(this.bntthoat_Click);
            // 
            // bntdiem
            // 
            this.bntdiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntdiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bntdiem.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntdiem.Location = new System.Drawing.Point(193, 360);
            this.bntdiem.Name = "bntdiem";
            this.bntdiem.Size = new System.Drawing.Size(225, 47);
            this.bntdiem.TabIndex = 4;
            this.bntdiem.Text = "lịch sử chơi";
            this.bntdiem.UseVisualStyleBackColor = false;
            this.bntdiem.Click += new System.EventHandler(this.bntdiem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flappy_bird_2.Properties.Resources.wp6956880_flappy_bird_wallpapers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 509);
            this.Controls.Add(this.bntdiem);
            this.Controls.Add(this.bntthoat);
            this.Controls.Add(this.bntcachchoi);
            this.Controls.Add(this.bntchoiolline);
            this.Controls.Add(this.bntchoidon);
            this.Name = "Form1";
            this.Text = "Flappy bird 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntchoidon;
        private System.Windows.Forms.Button bntchoiolline;
        private System.Windows.Forms.Button bntcachchoi;
        private System.Windows.Forms.Button bntthoat;
        private System.Windows.Forms.Button bntdiem;
    }
}

