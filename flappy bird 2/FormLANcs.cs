using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace flappy_bird_2
{
    public partial class FormLANcs : Form
    {
        
        public FormLANcs()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            choionlline2 newGame = new choionlline2(false, textBox1.Text);
            Visible = false;
            if (!newGame.IsDisposed)
                newGame.ShowDialog();
            Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            choionlline2 newGame = new choionlline2(true);
            Visible = false;
            if (!newGame.IsDisposed)
                newGame.ShowDialog();
            Visible = true;
          
        }
    }
}
