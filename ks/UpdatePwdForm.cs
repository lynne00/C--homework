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
    public partial class UpdatePwdForm : Form
    {
        public UpdatePwdForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=localhost;Initial Catalog=c_dazuoye;Integrated Security=SSPI;";
            connection.Open();
            string passwd = textBox2.Text;
            string passwded = textBox3.Text;
            if (passwd == "" || passwded == "")
            {
                MessageBox.Show("请将信息填写完整!");
            }
            else
            {
                if (passwd != passwded)
                {
                    MessageBox.Show("两次输入的密码不一致,请重新输入！");
                }
                else
                {
                    if (LoginForm.getRole() == "学生")
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        string sql = "update student set stupasswd ='" + passwd + "' where stuxuehao = '" + textBox1.Text + "'";
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("密码修改成功！");

                    }
                    else if (LoginForm.getRole() == "管理员")
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        string sql = "update manager set manpasswd ='" + passwd + "' where manname = '" + textBox1.Text + "'";
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("修改密码成功！");

                    }
                    this.Close();
                }
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdatePwdManForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = LoginForm.getYhm();
        }
    }
}
