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
    public partial class ChakeForm : Form
    {
        public ChakeForm()
        {
            InitializeComponent();
        }

        private void ChakeForm_Load(object sender, EventArgs e)
        {
            this.getRusult();
        }
        private void getRusult()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=localhost;Initial Catalog=c_dazuoye;Integrated Security=SSPI;";
            connection.Open();
            string sql = "select class.claname as 课程名,class.teacher as 老师 from class , sc where class.claid = sc.claid AND sc.stuxuehao  ='" + LoginForm.getYhm() + "'";
            SqlDataAdapter adp = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            connection.Close();
        }
    }
}
