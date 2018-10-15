using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Library_management_system
{
    public partial class xgyhxx : Form
    {
        public xgyhxx()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        SqlDataAdapter sda = null;
        DataSet ds = null;
        DataTable dt = null;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnxg_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(dgvStudent.CurrentRow.Cells[0].Value.ToString());
            //修改
            dr["ReadID"] = txtid.Text;
            dr["ReadName"] = txtname.Text;
            dr["Readschool"] = txtyx.Text;
            dr["ReadPrgram"] = txtzy.Text;
            dr["ReadClass"] = txtclass.Text;
            dr["ReadIphone"] = txtiPhone.Text;
            dr["Gender"] = cbgender.Text;
            dr["CBBooks"] = txtyj.Text;
            dr["NBBooks"] = txtwj.Text;

            //更新到数据哭肿
            SqlCommandBuilder scd = new SqlCommandBuilder(sda);
            sda.UpdateCommand = scd.GetUpdateCommand();
            sda.Update(dt);
            ds.AcceptChanges();
        }

        private void xgyhxx_Load(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["ghr"].ConnectionString;

            conn = new SqlConnection(s);
            string sql = "select * from iRead";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();

            sda.Fill(ds, "read");
            dt = ds.Tables["read"];
            dgvStudent.DataSource = dt;
            dt.PrimaryKey = new DataColumn[] { dt.Columns["ReadID"] };
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // string id = dgvStudent.CurrentRow.Cells[0].Value.ToString();
           // //dt.PrimaryKey = new DataColumn[] { dt.Columns["ISBN"] };
           // DataRow dr = dt.Rows.Find(id);

           // txtid.Text = dr["ReadID"].ToString();
           // txtname.Text = dr["ReadName"].ToString();
           // txtyx.Text = dr["Readschool"].ToString();
           // txtzy.Text = dr["ReadPrgram"].ToString();
           // txtclass.Text = dr["ReadClass"].ToString();
           // txtiPhone.Text = dr["ReadIphone"].ToString();
           // txtwj.Text = dr["CBBooks"].ToString();
           // txtyj.Text = dr["NBBooks"].ToString();
           //cbgender.Text = dr["Gender"].ToString();
    
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvStudent.CurrentRow.Cells[0].Value.ToString();
            //dt.PrimaryKey = new DataColumn[] { dt.Columns["ISBN"] };
            DataRow dr = dt.Rows.Find(id);

            txtid.Text = dr["ReadID"].ToString();
            txtname.Text = dr["ReadName"].ToString();
            txtyx.Text = dr["Readschool"].ToString();
            txtzy.Text = dr["ReadPrgram"].ToString();
            txtclass.Text = dr["ReadClass"].ToString();
            txtiPhone.Text = dr["ReadIphone"].ToString();
            txtwj.Text = dr["CBBooks"].ToString();
            txtyj.Text = dr["NBBooks"].ToString();
            cbgender.Text = dr["Gender"].ToString();

        }
    }
}
