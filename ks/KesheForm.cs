using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ks
{
    public partial class KesheForm : Form
    {
        public KesheForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxteacher.Text.Trim() == "" || textBoxclass.Text.Trim() == "")
            {
                MessageBox.Show("请将信息填写完整!");
            }
            else
            {
                int id = Convert.ToInt32(textBoxid.Text);
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=localhost;Initial Catalog=c_dazuoye;Integrated Security=SSPI;";
                connection.Open();
                string sql = "update class set claname = '" + textBoxclass.Text + "',teacher = '" + textBoxteacher.Text + "'where claid = " + id;
                SqlCommand cmd = new SqlCommand(sql, connection);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("修改成功！");
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
            //载入基本信息
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Keshe_Load(object sender, EventArgs e)
        {
            this.getRusult();
        }
        private void sjk_click(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxteacher.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBoxclass.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxid.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
