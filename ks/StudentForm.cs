using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ks
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (this.treeView1.SelectedNode.Text)
            {
                case "退出系统":
                    Application.Exit();
                    break;

                case "退出登录":
                    LoginForm form = new LoginForm();
                    form.BringToFront();
                    form.Show();
                    this.Hide();
                    break;
                case "修改密码":
                    UpdatePwdForm form1 = new UpdatePwdForm();
                    form1.TopLevel = false;
                    form1.FormBorderStyle = FormBorderStyle.None;
                    form1.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(form1);
                    form1.Show();
                    break;
                case "选择课程":
                    XuankeForm form2 = new XuankeForm();
                    form2.TopLevel = false;
                    form2.FormBorderStyle = FormBorderStyle.None;
                    form2.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(form2);
                    form2.Show();
                    break;
                case "查询课程":
                    ChakeForm form3 = new ChakeForm();
                    form3.TopLevel = false;
                    form3.FormBorderStyle = FormBorderStyle.None;
                    form3.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(form3);
                    form3.Show();
                    break;
            }
        }
    }
}
