using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_bird_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntchoidon_Click(object sender, EventArgs e)
        {
            choidon f = new choidon();
            f.ShowDialog();
        }

        private void bntcachchoi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ấn phím SPACE  để điều khiển con chim sao cho vượt qua chướng ngại vật , không bay quá cao và không rơi xuống đất  ");
        }

        private void bntthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntdiem_Click(object sender, EventArgs e)
        {
            showdiem f = new showdiem();
            f.Show();
        }

        private void bntchoiolline_Click(object sender, EventArgs e)
        {
            FormLANcs a= new FormLANcs();
            a.ShowDialog();
        }
    }
}
