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
    public partial class FrmHVT : Form
    {
        public FrmHVT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtHT = this.txtHT.Text.Trim();
            int i;
            int trangdau = 0;
            int trangcuoi = 0;
            int daichuoi = this.txtHT.TextLength;
            for (i = 1; i < txtHT.Length; i++)
            {
                if (txtHT.Substring(i, 1) == " ")
                {
                    trangdau = i;
                    break;
                }

            }


            for (i = txtHT.Length; i > 0; i--)
            {
                if (txtHT.Substring(i - 1, 1) == " ")
                {
                    trangcuoi = i - 1;
                    break;
                }

            }

            if (trangdau > 0)
                this.txtH.Text = txtHT.Substring(0, trangdau).ToString();
            else
                this.txtH.Text = "";
            if (trangcuoi - trangdau - 1 > 0)
                this.txtD.Text = txtHT.Substring(trangdau + 1, trangcuoi - trangdau - 1);
            else
                this.txtD.Text = "";
            if (trangcuoi > 0)
                this.txtT.Text = txtHT.Substring(trangcuoi +1, daichuoi - trangcuoi - 1).ToString();
            else
                this.txtT.Text = "";
        }

        private void txtHT_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

