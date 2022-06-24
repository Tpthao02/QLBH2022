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
    public partial class FormTienDien : Form
    {
        int csd;
        int csc;
        double td;
        int hs;
        public FormTienDien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
                csd = Convert.ToInt16(txtd.Text);
                csc = Convert.ToInt16(txtc.Text);

                hs = csc - csd;

                if (hs <= 80)
                {
                    td = 500 * hs;
                }
                else if (hs > 80 && hs <= 200)
                {
                    td = 500 * 80 + 1500 * (hs - 80);
                }
                else
                { td = (500 * 80 + 1500 * 120 + (hs - 200) * 3000); }

                lblKQ.Text = td.ToString();
            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

