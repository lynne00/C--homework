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

namespace ks
{
    public partial class AddStuForm : Form
    {
        public AddStuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=localhost;Initial Catalog=c_dazuoye;Integrated Security=SSPI;";
            connection.Open();
            string sql = "select * from student where stuxuehao='" + textBoxxuehao.Text.Trim() + "'";
            SqlDataAdapter adp = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("该学号已存在！");
            }
            else if (textBoxname.Text.Trim() == "" || textBoxpasswd.Text.Trim() == ""||textBoxxuehao.Text.Trim() =="" || comboBoxgrade.Text.Trim() == "" || comboBoxmajor.Text.Trim() == ""|| dateTimePicker1.Text.Trim() == "")
            {
                MessageBox.Show("请将信息填写完整!");
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                string sex = radioButton1.Checked ? "男" : "女";
                sql = "insert into student(stuname,stuxuehao ,stupasswd,stugrade ,stumajor,stusex,stuborn)values('" + textBoxname.Text.Trim() + "','" + textBoxxuehao.Text.Trim() + "','" + textBoxpasswd.Text.Trim() + "','" + comboBoxgrade.SelectedItem.ToString() + "','" + comboBoxmajor.SelectedItem.ToString() + "','" + sex+ "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "')";
                cmd.CommandText = sql;
                if (cmd.ExecuteNonQuery() > 0) 
                {
                    MessageBox.Show("添加用户成功！");
                }      
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
