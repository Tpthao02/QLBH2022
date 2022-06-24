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
    public partial class FrmDMKH : Form {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
    
        public FrmDMKH()
        {
            InitializeComponent();
        }

        private void FrmDMKH_Load(object sender, EventArgs e)
        {
            constr = "Data Source = DESKTOP-IEGRD2D\\SQLEXPRESS; Initial Catalog = QLBH; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " Select MaKH,TenKH,DiaChi,Tel,Email  from tblDMKH";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);//du lieu do vao data
            grdData.DataSource = dt;// gan du lieu cho o luoi

        }
    }
}
