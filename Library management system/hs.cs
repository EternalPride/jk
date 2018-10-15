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
    public partial class hs : Form
    {
        public hs()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        SqlDataAdapter sda = null;
        DataSet ds = null;
        DataTable dt = null;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtisbn.Text == "")
            {
                MessageBox.Show("还没有选择图书哦！请选好图书再借阅");
            }
            else
            {
                string connString = ConfigurationManager.ConnectionStrings["ghr"].ConnectionString;
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                string sqlString = "select * from Book where ISBN='" + txtisbn.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                SqlDataReader aa = cmd.ExecuteReader();
                if (aa.Read() == false)
                {
                    MessageBox.Show("没有该图书图书！");
                    aa.Close();
                    conn.Close();
                }
                else
                {
                    string connString1 = ConfigurationManager.ConnectionStrings["ghr"].ConnectionString;
                    SqlConnection conn1 = new SqlConnection(connString);
                    conn1.Open();
                    string sqlString1 = "select * from iRead where ReadID='" + txtid.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(sqlString1, conn1);
                    SqlDataReader aa1 = cmd1.ExecuteReader();
                    if (aa1.Read() == false)
                    {
                        MessageBox.Show("没有该人员！");
                        conn1.Close();

                    }
                    else
                    {
                        string connString2 = ConfigurationManager.ConnectionStrings["ghr"].ConnectionString;
                        SqlConnection conn2 = new SqlConnection(connString);
                        conn2.Open();
                        string sqlString2 = "select ReadID from Borrow where ReadID='" + txtid.Text + "'"; ;
                        SqlCommand cmd2 = new SqlCommand(sqlString2, conn2);
                        SqlDataReader aa2 = cmd2.ExecuteReader();
                        if (aa2.Read() == true)
                        {
                            string connString4 = ConfigurationManager.ConnectionStrings["ghr"].ConnectionString;
                            SqlConnection conn4 = new SqlConnection(connString);
                            conn4.Open();
                            string sqlString4 = "update iRead set  NBBooks = NBBooks + 1 , CBBooks = CBBooks - 1 where ReadID='" + txtid.Text + "'";
                            SqlCommand cmd4 = new SqlCommand(sqlString4, conn4);
                            SqlDataReader aa4 = cmd4.ExecuteReader();
                            conn4.Close();
                            string connString5 = ConfigurationManager.ConnectionStrings["ghr"].ConnectionString;
                            SqlConnection conn5 = new SqlConnection(connString);
                            conn5.Open();
                            string sqlString5 = "update Book set NumberBook = NumberBook + 1 , SurplusBook = SurplusBook - 1 where ISBN='" + txtisbn.Text + "'";
                            SqlCommand cmd5 = new SqlCommand(sqlString5, conn5);
                            SqlDataReader aa5 = cmd5.ExecuteReader();
                            conn5.Close();


                            string s = System.Configuration.ConfigurationManager.ConnectionStrings["ghr"].ConnectionString;

                            conn = new SqlConnection(s);
                            string sql = "select * from Borrow  where Gjtime='" + DateTime.Now.ToString("yyyy-MM-dd") + "' ";
                            sda = new SqlDataAdapter(sql, conn);
                            ds = new DataSet();

                            sda.Fill(ds, "book");

                            DataRow dr = ds.Tables["book"].NewRow();
                            dt = ds.Tables["book"];
                            if (dt != null)
                            {



                                
                                MessageBox.Show("该图书前段时间已还成功！");
                            }
                            else
                            {
                                string connString6 = ConfigurationManager.ConnectionStrings["ghr"].ConnectionString;
                                SqlConnection conn6 = new SqlConnection(connString);
                                conn6.Open();
                                string sqlString6 = "update Borrow set Gjtime='" + DateTime.Now.ToString("yyyy-MM-dd") + "' where ReadID='" + txtid.Text + "'";
                                SqlCommand cmd6 = new SqlCommand(sqlString6, conn6);
                                SqlDataReader aa6 = cmd6.ExecuteReader();
                                conn6.Close();
                                MessageBox.Show("还书成功！");
                            }

                        }
                        else
                        {
                            MessageBox.Show("无法还书！");
                        }
                    }





                }
            }
        }
        private void ShowBorrowList()
        {
           //DateTime.Now.ToString("yyyy-MM-dd")
            //
            //System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)); // 当地时区
            //long timeStamp = (long)(DateTime.Now - startTime).TotalMilliseconds; 
        }
    }
}
