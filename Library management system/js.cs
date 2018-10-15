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
    public partial class js : Form
    {
        public js()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        SqlDataAdapter sda = null;
        DataSet ds = null;
        DataTable dt = null;

        private void js_Load(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["ghr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string sqlString = "select * from Book where ISBN='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlString, conn);
            SqlDataReader aa = cmd.ExecuteReader();
            if (aa.Read() == false)
            {
                MessageBox.Show("不可借阅图书！");
                aa.Close();
                conn.Close();
            }
            else
            {
                string connString1 = ConfigurationManager.ConnectionStrings["ghr"].ConnectionString;
                SqlConnection conn1 = new SqlConnection(connString);
                conn1.Open();
                string sqlString1 = "select * from iRead where ReadID='" + textBox2.Text + "'";
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
                    string sqlString2 = "select NumberBook from Book where ISBN='" + textBox1.Text + "'"; ;
                    SqlCommand cmd2 = new SqlCommand(sqlString2, conn2);
                    SqlDataReader aa2 = cmd2.ExecuteReader();
                    if (aa2.Read() == true && Convert.ToInt32(aa2["NumberBook"]) > 0)
                    {
                        string connString3 = ConfigurationManager.ConnectionStrings["ghr"].ConnectionString;
                        SqlConnection conn3 = new SqlConnection(connString);
                        conn3.Open();
                        string sqlString3 = "select NBBooks from iRead where ReadID='" + textBox2.Text + "'"; ;
                        SqlCommand cmd3 = new SqlCommand(sqlString3, conn3);
                        SqlDataReader aa3 = cmd3.ExecuteReader();
                        if (aa3.Read() == true && Convert.ToInt32(aa3["NBBooks"]) > 0)
                        {
                            string connString4 = ConfigurationManager.ConnectionStrings["ghr"].ConnectionString;
                            SqlConnection conn4 = new SqlConnection(connString);
                            conn4.Open();
                            string sqlString4 = "update iRead set NBBooks = NBBooks - 1 , CBBooks = CBBooks + 1 where ReadID='" + textBox2.Text + "'";
                            SqlCommand cmd4 = new SqlCommand(sqlString4, conn4);
                            SqlDataReader aa4 = cmd4.ExecuteReader();
                            conn4.Close();
                            string connString5 = ConfigurationManager.ConnectionStrings["ghr"].ConnectionString;
                            SqlConnection conn5 = new SqlConnection(connString);
                            conn5.Open();
                            string sqlString5 = "update Book set NumberBook = NumberBook - 1 , SurplusBook = SurplusBook + 1 where ISBN='" + textBox1.Text + "'";
                            SqlCommand cmd5 = new SqlCommand(sqlString5, conn5);
                            SqlDataReader aa5 = cmd5.ExecuteReader();
                            MessageBox.Show("借书成功！");
                            conn5.Close();





                            if ((textBox1. Text.Trim() != "") || (textBox2. Text.Trim() != ""))
                            {
                                string s = System.Configuration.ConfigurationManager.ConnectionStrings["ghr"].ConnectionString;

                                conn = new SqlConnection(s);
                                string sql = "select * from Borrow";
                                sda = new SqlDataAdapter(sql, conn);
                                ds = new DataSet();

                                sda.Fill(ds, "borrow");

                                DataRow dr = ds.Tables["borrow"].NewRow();
                                dt = ds.Tables["borrow"];
                                dr["ISBN"] = textBox1. Text;
                                dr["ReadID"] = textBox2. Text;
                                dr["JCtime"] = DateTime.Now.ToString("yyyy-MM-dd");
                                
                               

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
                                    MessageBox.Show("添加失败", "新书入库", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("请完善信息！", "新书入库", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            }

                        }
                        else
                        {
                            MessageBox.Show("无法借书！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("无法借书！");

                    }
                }
            }
        }
    }
}
