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
    public partial class FormHVT : Form
    {
        int i;
        int trangdau;
        int trangcuoi;
        int daichuoi;
        bool demdc;
        string txtHT;
        public FormHVT()
        {
            InitializeComponent();

           string  txtHT = this.txtht.Text.Trim();
            trangdau = 0;
             trangcuoi = 0;
             daichuoi = this.txtht.TextLength;
             demdc = false;
         
        }
        void laytrangdau()
        {
            int i;
            for (i = 1; i < txtHT.Length; i++)
            {
                if(txtHT.IndexOf(" ") ==  i )
                {
                    this.txtHT = txtHT.Substring(i - 1, i - 1);
                }
              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            laytrangdau();
                
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
                    this.txth.Text = txtHT.Substring(0, trangdau).ToString();
                else
                    this.txth.Text = "";
                if (trangcuoi - trangdau - 1 > 0)
                    this.txtd.Text = txtHT.Substring(trangdau + 1, trangcuoi - trangdau - 1);
                else
                    this.txtd.Text = "";
                if (trangcuoi > 0)
                    this.txtt.Text = txtHT.Substring(trangcuoi +1, daichuoi - trangcuoi - 1).ToString();
                else
                    this.txtt.Text = "";
            
        }
    }
}
