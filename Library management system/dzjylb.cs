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
    public partial class dzjylb : Form
    {
        public dzjylb()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        SqlDataAdapter sda = null;
        DataSet ds = null;
        DataTable dt = null;

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
   
        }

        private void dzjylb_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["ghr"].ConnectionString;

            conn = new SqlConnection(s);
            string sql = "select * from iRead order by  CBBooks  ";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();

            sda.Fill(ds, "read");
            dt = ds.Tables["read"];
            dgvStudent.DataSource = dt;
            dt.PrimaryKey = new DataColumn[] { dt.Columns["ReadID"] };
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvStudent.CurrentRow.Cells[0].Value.ToString();
            //dt.PrimaryKey = new DataColumn[] { dt.Columns["ISBN"] };
            DataRow dr = dt.Rows.Find(id);

            lbxh.Text = dr["ReadID"].ToString();
            lbxm.Text = dr["ReadName"].ToString();
            lbyx.Text = dr["Readschool"].ToString();
            lbzy.Text = dr["ReadPrgram"].ToString();
            lbbj.Text = dr["ReadClass"].ToString();
            lbdh.Text = dr["ReadIphone"].ToString();

            lbxb.Text = dr["Gender"].ToString();
            lbjymx.Text = dr["CBBooks"].ToString() + "/5";

        }
    }
}
