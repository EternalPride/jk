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
    public partial class sbxg : Form
    {
        public sbxg()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        SqlDataAdapter sda = null;
        DataSet ds = null;
        DataTable dt = null;
        private void sbxg_Load(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["ghr"].ConnectionString;
         
            conn = new SqlConnection(s);
            string sql = "select * from Book";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();

            sda.Fill(ds, "book");
            dt=ds.Tables["book"];
            dgvStudent.DataSource = dt;
            dt.PrimaryKey = new DataColumn[] { dt.Columns["ISBN"] };
        }

        private void btnxg_Click(object sender, EventArgs e)
        {
            //定位要修改的行
            DataRow dr = dt.Rows.Find(dgvStudent.CurrentRow.Cells[0].Value.ToString());
            //修改
            dr["ISBN"] =txtisbn. Text;
            dr["BookName"] = txtbookname.Text;
            dr["Author"] = txtzz.Text;
            dr["BookPress"] = txtcbs.Text;
            dr["Outtime"] = txtcbdata.Text;
            dr["Price"] = txtjg.Text;
            dr["NumberPages"] = txtys.Text;
            dr["NumberBook"] = txtsbsl.Text;
          
            //更新到数据哭肿
            SqlCommandBuilder scd = new SqlCommandBuilder(sda);
            sda.UpdateCommand = scd.GetUpdateCommand();
            sda.Update(dt);
            ds.AcceptChanges();
        }

        private void dgvStudent_Click(object sender, EventArgs e)

        {   
            string id = dgvStudent.CurrentRow.Cells[0].Value.ToString();
            //dt.PrimaryKey = new DataColumn[] { dt.Columns["ISBN"] };
            DataRow dr = dt.Rows.Find(id);
           
            txtisbn.Text = dr["ISBN"].ToString();
            txtbookname.Text = dr["BookName"].ToString();
           txtzz. Text = dr["Author"].ToString();
          txtcbs. Text = dr["BookPress"].ToString();
         txtcbdata. Text = dr["Outtime"].ToString();
       txtjg. Text = dr["Price"].ToString();
      txtys. Text = dr["NumberPages"].ToString();
     txtsbsl. Text = dr["NumberBook"].ToString();
    
         
        }
    }
}
