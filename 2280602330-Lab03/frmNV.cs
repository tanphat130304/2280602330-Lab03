using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2280602330_Lab03
{
    public partial class frmNV : Form
    {
        public string MSNV { get; set; }
        public string Ten { get; set; }
        public string Luong { get; set; }
        public frmNV(string msnv, string ten, string luong)
        {
            InitializeComponent();
            MSNV = msnv;
            Ten = ten;
            Luong = luong;
            txbmsnv.Text = MSNV;
            txbtennhanvien.Text = Ten;
            txbluong.Text = Luong;
        }

        private void frmNV_Load(object sender, EventArgs e)
        {


        }


        private void txbmsnv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbtennhanvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            MSNV = txbmsnv.Text;
            Ten = txbtennhanvien.Text;
            Luong = txbluong.Text;

            DialogResult = DialogResult.OK;
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}