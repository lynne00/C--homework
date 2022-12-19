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
    public partial class LoginForm : Form
    {
        public static string name;
        public static string role;
        public LoginForm()
        {
            InitializeComponent();
          
        }



        private void button1_Click(object sender, EventArgs e)
        {
            name = textBoxname.Text.Trim();
            if (name == "" || textBoxpasswd.Text.Trim() == "")
            {
                MessageBox.Show("请将信息填写完整！");
            }
            else
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=localhost;Initial Catalog=c_dazuoye;Integrated Security=SSPI;";
                connection.Open();
                if (radioButton2.Checked)
                {
                    role = "管理员";
                    string sql = "select manname,manpasswd from manager where role='管理员'and manname='" + name +
                     "' and manpasswd='" + textBoxpasswd.Text.Trim() + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        connection.Close();
                        GuanliyuanForm form = new GuanliyuanForm();
                        form.BringToFront();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("用户名或者密码错误！");
                    }
                }
                else if (radioButton1.Checked)
                {
                    role = "学生";
                    string sql = "select stuxuehao,stupasswd from student where role='学生'and stuxuehao='" + name +
                     "' and stupasswd='" + textBoxpasswd.Text.Trim() + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        connection.Close();
                        StudentForm form = new StudentForm();
                        form.BringToFront();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("用户名或者密码错误！");
                    }
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static String getYhm()
        {
            String yonghuming = "";
            yonghuming = LoginForm.name;
            return yonghuming;
        }

        public static String getRole()
        {
            String role1 = "";
            role1 = role;
            return role1;
        }
    }
}
