using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_bird_2
{
    public partial class showdiem : Form
    {
        public showdiem()
        {
            InitializeComponent();
            Loaddiem();
        }

        private void Loaddiem()
        {
            dbdiemDataContext db = new dbdiemDataContext();
            var query = (from b in db.quanlidatas
                        orderby b.Lần_chơi descending
                        
                        select b).Take(10);
                       
            

            datadiem.DataSource = query;
            var maxvalue = db.quanlidatas.Max(x => x.điểm);
            var result = db.quanlidatas.First(x => x.điểm == maxvalue);
            txbdiem.Text = Convert.ToString(result.điểm);
        }
    }
}
