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
    public partial class GuanliyuanForm : Form
    {
        public GuanliyuanForm()
        {
            InitializeComponent();
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (this.treeView2.SelectedNode.Text)
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
                case "添加学生信息":
                    AddStuForm form2 = new AddStuForm();
                    form2.TopLevel = false;
                    form2.FormBorderStyle = FormBorderStyle.None;
                    form2.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(form2);
                    form2.Show();
                    break;
                case "修改学生信息":
                    UpdateStuForm form3 = new UpdateStuForm();
                    form3.TopLevel = false;
                    form3.FormBorderStyle = FormBorderStyle.None;
                    form3.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(form3);
                    form3.Show();
                    break;
                case "添加管理员信息":
                    AddManForm form4 = new AddManForm();
                    form4.TopLevel = false;
                    form4.FormBorderStyle = FormBorderStyle.None;
                    form4.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(form4);
                    form4.Show();
                    break;
                case "开设课程":
                    KaikeForm form5 = new KaikeForm();
                    form5.TopLevel = false;
                    form5.FormBorderStyle = FormBorderStyle.None;
                    form5.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(form5);
                    form5.Show();
                    break;
                case "课程设置":
                    KesheForm form6 = new KesheForm();
                    form6.TopLevel = false;
                    form6.FormBorderStyle = FormBorderStyle.None;
                    form6.WindowState = FormWindowState.Maximized;
                    panel1.Controls.Add(form6);
                    form6.Show();
                    break;
            }
        }
    }
}
