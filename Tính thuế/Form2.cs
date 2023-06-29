using System;
using System.Windows.Forms;

namespace Tính_thuế
{


    public partial class Form2 : Form
    {
        bool checkBHXH = false;
        int bac1 = 5000000;
        int bac2 = 10000000;
        int bac3 = 18000000;
        int bac4 = 32000000;
        int bac5 = 52000000;
        int bac6 = 80000000;
        int canhan = 11000000;
        int phuthuoc = 4400000;
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBHXH = true;
        }
        private int TinhThue(int a)

        {
            //Số lượng người phụ thuộc
            int soluongphuthuoc = 0;
            if (txtPhuthuoc.Text == "")
                soluongphuthuoc = 0;
            else
            {
                soluongphuthuoc = int.Parse(txtPhuthuoc.Text);
            }

            //Tính thuế TNCN
            int lct = 0;
            if (checkBHXH == false)
            {
                lct = a - a * 8 / 100 - canhan - phuthuoc * soluongphuthuoc;
            }
            else
            {
                lct = a - canhan - phuthuoc * soluongphuthuoc;
            }
            if (lct < 0)
                lct = 0;
            int thue = 5 * TrongKhoang(lct, 0, bac1) / 100
            + 10 * TrongKhoang(lct, bac1, bac2) / 100
            + 15 * TrongKhoang(lct, bac2, bac3) / 100
            + 20 * TrongKhoang(lct, bac3, bac4) / 100
            + 25 * TrongKhoang(lct, bac4, bac5) / 100
            + 30 * TrongKhoang(lct, bac5, bac6) / 100
            + 35 * TrongKhoang(lct, bac6, 999999999) / 100;

            return thue;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            int thue = int.Parse(txtThuNhap.Text);
            thue = TinhThue(thue);
            lblThue.Text = thue.ToString();
            var snumber = Tính_thuế.Utils.NumberToText(thue);
            lblThuestring.Text = snumber + " đồng";

        }
        private int TrongKhoang(int so, int dauKhoang, int cuoiKhoang)
        {
            // hàm dùng để tính xem một số có bao nhiêu phần của nó lọt vào giữa đầu và cuối khoảng
            // nếu số nhỏ hơn đầu khoảng thì hàm trả về giê rô

            if (so <= dauKhoang) return 0;
            if (so > cuoiKhoang) return cuoiKhoang - dauKhoang;
            return so - dauKhoang;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
