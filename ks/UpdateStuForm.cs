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
    public partial class UpdateStuForm : Form
    {
        public UpdateStuForm()
        {
            InitializeComponent();
        }
        private void UpdateStuForm_Load(object sender, EventArgs e)
        {
            this.getRusult();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxname.Text.Trim() == "" || textBoxpasswd.Text.Trim() == "" || textBoxxuehao.Text.Trim() == "" || comboBoxgrade.Text.Trim() == "" || comboBoxmajor.Text.Trim() == "" || dateTimePicker1.Text.Trim() == "")
            {
                MessageBox.Show("请将信息填写完整!");
            }
            else
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=localhost;Initial Catalog=c_dazuoye;Integrated Security=SSPI;";
                connection.Open();
                string sex = radioButton1.Checked ? "男" : "女";
                int id = Convert.ToInt32(textBoxid.Text);
                string major = comboBoxmajor.Text;
                string grade = comboBoxgrade.Text;
                string sql = "update student set stuname = '" + textBoxname.Text + "',stuborn = '" + dateTimePicker1.Text + "' ,stugrade = '" + grade + "' ,stumajor = '" + major + "',stupasswd = '" + textBoxpasswd.Text + "',stuxuehao = '" + textBoxxuehao.Text + "',stusex = '" + sex + "' where stuid = " + id;
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
            string sql = "select stuid as 用户id,stuname as 真实姓名,stuxuehao as 学号,stupasswd as 密码,stugrade as 年级,stumajor as 专业,stusex as 性别,stuborn as 出生日期  from student";
            SqlDataAdapter adp = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxname.Text == "" || textBoxpasswd.Text == "" || textBoxxuehao.Text == "" || comboBoxgrade.Text == "" || comboBoxmajor.Text == "" || dateTimePicker1.Text == "")
            {
                MessageBox.Show("请将信息填写完整!");
            }
            else
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=localhost;Initial Catalog=c_dazuoye;Integrated Security=SSPI;";
                connection.Open();
                int id = Convert.ToInt32(textBoxid.Text);
                string sql = "delete from  student  where  stuid = " + id;
                SqlCommand cmd = new SqlCommand(sql, connection);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("删除成功！");
                    this.getRusult();
                }
                connection.Close();
            }
        }
        private void sjk_click(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxname.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxgrade.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            comboBoxmajor.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            textBoxpasswd.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            textBoxxuehao.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            textBoxid.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            dateTimePicker1.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
            string sex = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();

            if (sex == "男")
            {
                radioButton1.Select();
            }
            else
            {
                radioButton2.Select();
            }
        }
    }
}
