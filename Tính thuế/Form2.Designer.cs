namespace Tính_thuế
{
    partial class Form2
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
            this.txtHovaTen = new System.Windows.Forms.TextBox();
            this.txtThuNhap = new System.Windows.Forms.TextBox();
            this.txtPhuthuoc = new System.Windows.Forms.TextBox();
            this.lblThue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblThuestring = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(207, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập Tháng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHovaTen
            // 
            this.txtHovaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHovaTen.Location = new System.Drawing.Point(431, 111);
            this.txtHovaTen.Multiline = true;
            this.txtHovaTen.Name = "txtHovaTen";
            this.txtHovaTen.Size = new System.Drawing.Size(256, 35);
            this.txtHovaTen.TabIndex = 4;
            this.txtHovaTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtThuNhap
            // 
            this.txtThuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThuNhap.Location = new System.Drawing.Point(431, 184);
            this.txtThuNhap.Multiline = true;
            this.txtThuNhap.Name = "txtThuNhap";
            this.txtThuNhap.Size = new System.Drawing.Size(256, 42);
            this.txtThuNhap.TabIndex = 5;
            this.txtThuNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhuthuoc
            // 
            this.txtPhuthuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPhuthuoc.Location = new System.Drawing.Point(431, 278);
            this.txtPhuthuoc.Multiline = true;
            this.txtPhuthuoc.Name = "txtPhuthuoc";
            this.txtPhuthuoc.Size = new System.Drawing.Size(256, 42);
            this.txtPhuthuoc.TabIndex = 6;
            this.txtPhuthuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblThue
            // 
            this.lblThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThue.Location = new System.Drawing.Point(443, 376);
            this.lblThue.Name = "lblThue";
            this.lblThue.Size = new System.Drawing.Size(284, 34);
            this.lblThue.TabIndex = 7;
            this.lblThue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(278, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tính Thuế Theo Tháng";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBox1.Location = new System.Drawing.Point(159, 341);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 24);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Đã Đóng BHXH";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Tính_thuế.Properties.Resources.Screenshot_2022_04_17_165827;
            this.pictureBox3.Location = new System.Drawing.Point(159, 389);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(227, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Tính_thuế.Properties.Resources.Screenshot_2022_04_17_165740;
            this.pictureBox2.Location = new System.Drawing.Point(159, 260);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tính_thuế.Properties.Resources.Screenshot_2022_04_17_164845;
            this.pictureBox1.Location = new System.Drawing.Point(159, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblThuestring
            // 
            this.lblThuestring.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThuestring.Location = new System.Drawing.Point(443, 431);
            this.lblThuestring.Name = "lblThuestring";
            this.lblThuestring.Size = new System.Drawing.Size(303, 34);
            this.lblThuestring.TabIndex = 10;
            this.lblThuestring.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.lblThuestring);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblThue);
            this.Controls.Add(this.txtPhuthuoc);
            this.Controls.Add(this.txtThuNhap);
            this.Controls.Add(this.txtHovaTen);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtHovaTen;
        private System.Windows.Forms.TextBox txtThuNhap;
        private System.Windows.Forms.TextBox txtPhuthuoc;
        private System.Windows.Forms.Label lblThue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblThuestring;
    }
}