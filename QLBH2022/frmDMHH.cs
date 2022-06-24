using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBH2022
{
    public partial class frmDMHH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
        public frmDMHH()
        {
            InitializeComponent();
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDMHH_Load(object sender, EventArgs e)
        {
            constr = "Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = QLBH; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " Select Manhom,MaHH,TenHH,Dvt,DGvnd,SanXuat from tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);//du lieu do vao data
            grdData.DataSource = dt;// gan du lieu cho o luoi
            NapCT();

        }

        private void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, 0];//
            NapCT();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, grdData.RowCount - 1];
            NapCT();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;//ban ghi hien thoi
            if (i > 0)
            {
                grdData.CurrentCell = grdData[0, i - 1];
                NapCT();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i < grdData.RowCount - 1)
            {
                grdData.CurrentCell = grdData[0, i + 1];
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "Select Distinct " + comTruong.Text + " From tblDmHH ";

            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comboGT.DataSource = comdt;//dan du lieu cho combo 
            comboGT.DisplayMember = comTruong.Text;
        
        }

        private void btlloc_Click(object sender, EventArgs e)
        {
            
            if (comTruong.Text == "")
            {
                MessageBox.Show("Bạn cần thiết lập điều kiện lọc trước");
            }
            else
            {
                sql = "Select MaNhom, MaHH, TenHH, dvt, dgVnd, sanxuat From tblDMHH" +
                    " where " + comTruong.Text + " ='" + comboGT.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
                da.Fill(dt); //cmt
                grdData.DataSource = dt;
                grdData.Refresh();
                //tạo grid table -> tạo column -> sửa name, text và name = data property name, sửa align ...
                NapCT();


            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            sql = "Select MaNhom, MaHH, TenHH, dvt, dgVnd, sanxuat From tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt); //cmt
            grdData.DataSource = dt;
            grdData.Refresh();
            //tạo grid table -> tạo column -> sửa name, text và name = data property name, sửa align ...
            NapCT();
            

        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index;// so thu tu cua dong hien thoi trong o luoi
            txtMaNhom.Text = grdData.Rows[i].Cells["manhom"].Value.ToString();// lay ra gt dong y va cot manhom
            txtMaHH.Text = grdData.Rows[i].Cells["mahh"].Value.ToString();// lay ra gt dong y va cot manhom
            txtTenH.Text = grdData.Rows[i].Cells["TenHH"].Value.ToString();// lay ra gt dong y va cot manhom
            txtDvt.Text = grdData.Rows[i].Cells["dvt"].Value.ToString();
            txtDG.Text = grdData.Rows[i].Cells["dgvnd"].Value.ToString();
            txtSX.Text = grdData.Rows[i].Cells["sanxuat"].Value.ToString();
        }
    }
}
