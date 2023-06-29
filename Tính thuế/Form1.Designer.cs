namespace Tính_thuế
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnThueThang = new System.Windows.Forms.Button();
            this.btnThueNam = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(423, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tính Thuế Cá Nhân";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnThueThang
            // 
            this.btnThueThang.Location = new System.Drawing.Point(256, 96);
            this.btnThueThang.Name = "btnThueThang";
            this.btnThueThang.Size = new System.Drawing.Size(144, 51);
            this.btnThueThang.TabIndex = 3;
            this.btnThueThang.Text = "Tính Theo Tháng";
            this.btnThueThang.UseVisualStyleBackColor = true;
            this.btnThueThang.Click += new System.EventHandler(this.btnThueThang_Click);
            // 
            // btnThueNam
            // 
            this.btnThueNam.Location = new System.Drawing.Point(616, 96);
            this.btnThueNam.Name = "btnThueNam";
            this.btnThueNam.Size = new System.Drawing.Size(144, 51);
            this.btnThueNam.TabIndex = 4;
            this.btnThueNam.Text = "Tính Cả Năm";
            this.btnThueNam.UseVisualStyleBackColor = true;
            this.btnThueNam.Click += new System.EventHandler(this.btnThueNam_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tính_thuế.Properties.Resources.Screenshot_2022_04_16_210134;
            this.pictureBox1.Location = new System.Drawing.Point(177, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 431);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 649);
            this.Controls.Add(this.btnThueNam);
            this.Controls.Add(this.btnThueThang);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThueThang;
        private System.Windows.Forms.Button btnThueNam;
    }
}

