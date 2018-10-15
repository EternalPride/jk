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
    public partial class tjts : Form
    {
        public tjts()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        SqlDataAdapter sda = null;
        DataSet ds = null;
        DataTable dt = null;
        private void btntiajia_Click(object sender, EventArgs e)
        {   if((txtisbn.Text.Trim()!="")||(txtbookname. Text.Trim()!="")||( txtzz. Text.Trim()!="")||(txtcbs.Text.Trim()!="")||(txtcbdata. Text.Trim()!="")||(txtjg. Text.Trim()!="")||(txtys. Text.Trim()!="")||(txtsbsl. Text.Trim()!="")){
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["ghr"].ConnectionString;
         
            conn = new SqlConnection(s);
            string sql = "select * from Book";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();

            sda.Fill(ds, "book");

         DataRow dr=ds.Tables["book"].NewRow();
         dt = ds.Tables["book"];
         dr["ISBN"] = txtisbn. Text;
         dr["BookName"] =txtbookname. Text;
         dr["Author"] = txtzz. Text;
         dr["BookPress"] =txtcbs.Text;
         dr["Outtime"] = txtcbdata. Text;
         dr["Price"] = txtjg. Text;
         dr["NumberPages"] =txtys. Text;
         dr["NumberBook"] =txtsbsl. Text;

         if (dt != null)
         {
             dt.Rows.Add(dr);

             SqlCommandBuilder scb = new SqlCommandBuilder(sda);
             sda.InsertCommand = scb.GetInsertCommand();
             sda.Update(dt);
             ds.AcceptChanges();
             MessageBox.Show("添加成功", "新书入库", MessageBoxButtons.OK, MessageBoxIcon.None);
         }
         else
         {
             MessageBox.Show("添加失败","新书入库", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         }
        }else
        {
            MessageBox.Show("请完善信息！", "新书入库", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
        }
    

        private void tjts_Load(object sender, EventArgs e)
        {
            


        }
    }
}
