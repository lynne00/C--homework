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
    public partial class XuankeForm : Form
    {
        public XuankeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxstuid.Text.Trim() == "" || textBoxclass.Text.Trim() == "")
            {
                MessageBox.Show("请将信息填写完整!");
            }
            else
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=localhost;Initial Catalog=c_dazuoye;Integrated Security=SSPI;";
                connection.Open();
                string sql = "insert into sc (stuxuehao,claid) values ('" + textBoxstuid.Text.Trim() + "','" + textBoxclaid.Text.Trim() + "')"; ;
                SqlCommand cmd = new SqlCommand(sql, connection);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("选课成功！");
                    this.getRusult();
                }
                connection.Close();
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
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            connection.Close();
        }
        private void sjk_click(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxclass.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxclaid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void XuankeForm_Load(object sender, EventArgs e)
        {
            this.getRusult();
            textBoxstuid.Text = LoginForm.getYhm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
