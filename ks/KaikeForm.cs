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
    public partial class KaikeForm : Form
    {
        public KaikeForm()
        {
            InitializeComponent();
        }

        private void KaisheForm_Load(object sender, EventArgs e)
        {
            this.getRusult();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxteacher.Text.Trim() == "" || textBoxclass.Text.Trim() == "")
            {
                MessageBox.Show("请将信息填写完整!");
            }
            else
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=localhost;Initial Catalog=c_dazuoye;Integrated Security=SSPI;";
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                string sql = "insert into class (claname,teacher) values ('" + textBoxclass.Text.Trim() + "','" + textBoxteacher.Text.Trim() + "')";
                cmd.CommandText = sql;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("开课成功！");
                }
                this.getRusult();
            }
        }
          private void getRusult()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=localhost;Initial Catalog=c_dazuoye;Integrated Security=SSPI;";
            connection.Open();
            string sql = "select claid as 课程id, claname as 课程名,teacher as 老师 from class";
            SqlDataAdapter adp = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            //载入基本信息
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
