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
    public partial class jstt : Form
    {
        public jstt()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        SqlDataAdapter sda = null;
        DataSet ds = null;
        DataTable dt = null;
        private void btnsc_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(dgvStudent.CurrentRow.Cells[0].Value.ToString());
        
            dr.Delete();
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            sda.DeleteCommand = scb.GetDeleteCommand();
            sda.Update(dt);
            ds.AcceptChanges();
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void jstt_Load(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["ghr"].ConnectionString;

            conn = new SqlConnection(s);
            string sql = "select * from Book";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();

            sda.Fill(ds, "book");
            dt = ds.Tables["book"];
            dgvStudent.DataSource = dt;
            dt.PrimaryKey = new DataColumn[] { dt.Columns["ISBN"] };
        }
    }
}
