using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH2022
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helloWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTienDien f = new FormTienDien();
            f.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            TT1.Text = " Đăng nhập";
            FrmDangnhap f = new FrmDangnhap();
            f.ShowDialog();
            TT1.Text = " Sẵn sàng";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            TT1.Text = "Sẵn sàng nhận lệnh";
            TT2.Text = "Người dùng thực hiện : Admin";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //  lbl2.Text = (DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString()) + ":" + (DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString()) + ":" + (DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString());
            // lblDate.Text = DateTime.Now.DayOfWeek.ToString() + ", " + (DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString()) + "/" + (DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + "/" + DateTime.Now.Year;
            //lblGio.Text = DateTime.Now.Hour.ToString() + ":" + (DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString());
            //lblNgay.Text =  (DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString()) + "/" + (DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + "/" + DateTime.Now.Year;
            DateTime dt = DateTime.Now;
            lblGio.Text= String.Format("{0:hh:mm tt }", dt);
            lblNgay.Text = String.Format("{0:dd/MM/yyyy}", dt);
        }

        private void formĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangnhap f = new FrmDangnhap();
            f.Show();
        }

        private void formTáchHọVàTênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHVT f = new FrmHVT();
            f.Show(); 
        }

        private void lblGio_Click(object sender, EventArgs e)
        {

        }

        private void danhMucHangHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMHH f = new frmDMHH();
            f.Show();
        }

        private void danhMụcTừĐiểnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDMKH f = new FrmDMKH();
            f.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}


    



     
