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
    public partial class addread : Form
    {
        public addread()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        SqlDataAdapter sda = null;
        DataSet ds = null;
        DataTable dt = null;

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtid. Text.Trim() != "") || (txtname. Text.Trim() != "") || (cbgender. Text.Trim() != "") || (txtyx. Text.Trim() != "") || (txtzy. Text.Trim() != "") || (txtclass. Text.Trim() != "") || (txtiPhone. Text.Trim() != ""))
            {
                string s = System.Configuration.ConfigurationManager.ConnectionStrings["ghr"].ConnectionString;

                conn = new SqlConnection(s);
                string sql = "select * from iRead";
                sda = new SqlDataAdapter(sql, conn);
                ds = new DataSet();

                sda.Fill(ds, "read");

                DataRow dr = ds.Tables["read"].NewRow();
                dt = ds.Tables["read"];
                dr["ReadID"] = txtid. Text;
                dr["ReadName"] =txtname. Text;
                dr["Readschool"] = txtyx. Text;
                dr["ReadPrgram"] =txtzy. Text;
                dr["ReadClass"] = txtclass. Text;
                dr["ReadIphone"] = txtiPhone. Text;
                dr["Gender"] = cbgender.Text;
              

                if (dt != null)
                {
                    dt.Rows.Add(dr);

                    SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                    sda.InsertCommand = scb.GetInsertCommand();
                    sda.Update(dt);
                    ds.AcceptChanges();
                    MessageBox.Show("添加成功", "信息入库", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("添加失败", "信息入库", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("请完善信息！", "信息入库", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

        }
    }
}
