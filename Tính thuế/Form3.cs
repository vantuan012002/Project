using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tính_thuế
{
    public partial class Form3 : Form
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
        int bac1nam = 60000000;
        int bac2nam = 120000000;
        int bac3nam = 216000000;
        int bac4nam = 384000000;
        int bac5nam = 624000000;
        int bac6nam = 960000000;
        public Form3()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBHXH = true;
        }
        private int TrongKhoang(int so, int dauKhoang, int cuoiKhoang)
        {
            // hàm dùng để tính xem một số có bao nhiêu phần của nó lọt vào giữa đầu và cuối khoảng
            // nếu số nhỏ hơn đầu khoảng thì hàm trả về giê rô

            if (so <= dauKhoang) return 0;
            if (so > cuoiKhoang) return cuoiKhoang - dauKhoang;
            return so - dauKhoang;
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
            int tongthue = 0;
            int thuethang = 0;
            int tongtienphaidongthue = 0;
            foreach(Control x in this.Controls)
            {
                if(x is TextBox)
                {
                    if((string)x.Tag == "ThueCuaThang")
                    {
                        if(x.Text != "")
                        {
                            thuethang = int.Parse(x.Text);
                            tongtienphaidongthue += TienThuePhaiDongTheoThang(thuethang); 
                        }
                        else
                        {
                            thuethang = 0;
                        }
                        tongthue += TinhThue(thuethang);
                    }

                }    
            }
            
            //Thuế Dự Đóng
            lblThue.Text = tongthue.ToString() ;
            var thuestring = Tính_thuế.Utils.NumberToText(tongthue);
            lblThue.Text += "\n" + thuestring ;
            
            //Tổng Tiền Phải Đóng Thuế
            lblTongTienDongThue.Text =tongtienphaidongthue.ToString() + "\n" + Tính_thuế.Utils.NumberToText(tongtienphaidongthue);
            
            //Quyết Toán Thuế Cả Năm
            lblquyettoan.Text = QuyetToanThue(tongtienphaidongthue).ToString() + "\n" + Tính_thuế.Utils.NumberToText(QuyetToanThue(tongtienphaidongthue));

            //Tiền Thuế Nhận Lại
            lblNhanLai.Text = (tongthue - QuyetToanThue(tongtienphaidongthue)).ToString();
        }

        private void lblThue_Click(object sender, EventArgs e)
        {

        }
        private int QuyetToanThue(int lct)

        {
            int thue = 5 * TrongKhoang(lct, 0, bac1nam) / 100
            + 10 * TrongKhoang(lct, bac1nam, bac2nam) / 100
            + 15 * TrongKhoang(lct, bac2nam, bac3nam) / 100
            + 20 * TrongKhoang(lct, bac3nam, bac4nam) / 100
            + 25 * TrongKhoang(lct, bac4nam, bac5nam) / 100
            + 30 * TrongKhoang(lct, bac5nam, bac6nam) / 100
            + 35 * TrongKhoang(lct, bac6nam, 999999999) / 100;

            return thue;

        }
        private int TienThuePhaiDongTheoThang(int a)
        {
            int soluongphuthuoc = 0;
            if (txtPhuthuoc.Text == "")
                soluongphuthuoc = 0;
            else
            {
                soluongphuthuoc = int.Parse(txtPhuthuoc.Text);
            }
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
            return lct;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
