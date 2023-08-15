using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVNNhaNam
{
    public partial class ThaoTacHuyDon : Form
    {
        public delegate void DataSavedHandler();
        public event DataSavedHandler OnDataSaved;
        QLVC_NhaNamv2Entities conectionDB = new QLVC_NhaNamv2Entities();

        public string maDH { get; set; }
        public string tinhTrang { get; set; }
        public ThaoTacHuyDon()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            }
    }
}
