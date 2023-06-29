namespace flappy_bird_2
{
    partial class showdiem
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
            this.paneldiem = new System.Windows.Forms.Panel();
            this.datadiem = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbdiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.paneldiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datadiem)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldiem
            // 
            this.paneldiem.Controls.Add(this.datadiem);
            this.paneldiem.Location = new System.Drawing.Point(73, 157);
            this.paneldiem.Name = "paneldiem";
            this.paneldiem.Size = new System.Drawing.Size(469, 249);
            this.paneldiem.TabIndex = 0;
            // 
            // datadiem
            // 
            this.datadiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datadiem.Location = new System.Drawing.Point(0, 0);
            this.datadiem.Name = "datadiem";
            this.datadiem.RowTemplate.Height = 24;
            this.datadiem.Size = new System.Drawing.Size(469, 249);
            this.datadiem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(67, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Điểm cao nhất";
            // 
            // txbdiem
            // 
            this.txbdiem.Enabled = false;
            this.txbdiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbdiem.Location = new System.Drawing.Point(341, 33);
            this.txbdiem.Name = "txbdiem";
            this.txbdiem.Size = new System.Drawing.Size(89, 41);
            this.txbdiem.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(70, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "10 lần chơi gần nhất";
            // 
            // showdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flappy_bird_2.Properties.Resources.wp6956880_flappy_bird_wallpapers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbdiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paneldiem);
            this.Name = "showdiem";
            this.Text = "showdiem";
            this.paneldiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datadiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneldiem;
        private System.Windows.Forms.DataGridView datadiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbdiem;
        private System.Windows.Forms.Label label2;
    }
}