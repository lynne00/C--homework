namespace ks
{
    partial class GuanliyuanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("添加管理员信息");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("管理员信息管理", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("退出登录");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("退出系统");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("系统管理", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("开设课程");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("课程设置");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("课程管理", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("添加学生信息");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("修改学生信息");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("学生信息管理", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("修改密码");
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(251, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 511);
            this.panel1.TabIndex = 4;
            // 
            // treeView2
            // 
            this.treeView2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView2.LineColor = System.Drawing.Color.LightGray;
            this.treeView2.Location = new System.Drawing.Point(34, 34);
            this.treeView2.Margin = new System.Windows.Forms.Padding(4);
            this.treeView2.Name = "treeView2";
            treeNode1.Name = "addMan";
            treeNode1.Text = "添加管理员信息";
            treeNode2.Name = "manMan";
            treeNode2.Text = "管理员信息管理";
            treeNode3.Name = "节点1";
            treeNode3.Text = "退出登录";
            treeNode4.Name = "节点0";
            treeNode4.Text = "退出系统";
            treeNode5.Name = "userInfo";
            treeNode5.SelectedImageIndex = 2;
            treeNode5.Text = "系统管理";
            treeNode6.Name = "addCL";
            treeNode6.Text = "开设课程";
            treeNode7.Name = "节点1";
            treeNode7.Text = "课程设置";
            treeNode8.Name = "节点0";
            treeNode8.Text = "课程管理";
            treeNode9.Name = "addStu";
            treeNode9.Text = "添加学生信息";
            treeNode10.Name = "modifyStu";
            treeNode10.Text = "修改学生信息";
            treeNode11.Name = "studentMan";
            treeNode11.Text = "学生信息管理";
            treeNode12.Name = "节点0";
            treeNode12.Text = "修改密码";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8,
            treeNode11,
            treeNode12});
            this.treeView2.Size = new System.Drawing.Size(173, 511);
            this.treeView2.TabIndex = 5;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // GuanliyuanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 593);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.panel1);
            this.Name = "GuanliyuanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员界面";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView2;
    }
}