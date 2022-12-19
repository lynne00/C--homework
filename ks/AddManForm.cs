using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ks
{
    public partial class AddManForm : Form
    {
        public AddManForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == ""|| textBox3.Text.Trim() == "")
            {
                MessageBox.Show("请将信息填写完整!");
            }
            else
            {
                if (textBox2.Text.Trim() != textBox3.Text.Trim())
                {
                    MessageBox.Show("两次输入的密码不一致,请重新输入!");
                }
                else
                {
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = "Data Source=localhost;Initial Catalog=c_dazuoye;Integrated Security=SSPI;";
                    connection.Open();
                    string sql = "select * from manager where manname = '" + textBox1.Text + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("该管理员名称已存在！");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        sql = "insert into manager (manname,manpasswd) values ('"+ textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "')";
                        cmd.CommandText = sql;
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("添加用户成功！");
                        }
                        this.getRusult();
                    }
                    connection.Close();
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void getRusult()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=localhost;Initial Catalog=c_dazuoye;Integrated Security=SSPI;";
            connection.Open();
            string sql = "select manid as 用户id, manname as 用户名,manpasswd as 密码 from manager";
            SqlDataAdapter adp = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            //载入基本信息
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            connection.Close();
        }

        private void AddManForm_Load(object sender, EventArgs e)
        {
            this.getRusult();
        }
    }
}
