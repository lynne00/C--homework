namespace ks
{
    partial class StudentForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("退出登录");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("退出系统");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("系统管理", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("选择课程");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("查询课程");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("课程管理", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("修改密码");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeView1.Location = new System.Drawing.Point(34, 28);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "退出登录";
            treeNode1.Text = "退出登录";
            treeNode2.Name = "节点1";
            treeNode2.Text = "退出系统";
            treeNode3.Name = "节点0";
            treeNode3.Text = "系统管理";
            treeNode4.Name = "节点3";
            treeNode4.Text = "选择课程";
            treeNode5.Name = "节点4";
            treeNode5.Text = "查询课程";
            treeNode6.Name = "节点2";
            treeNode6.Text = "课程管理";
            treeNode7.Name = "节点8";
            treeNode7.Text = "修改密码";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(173, 511);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(250, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 511);
            this.panel1.TabIndex = 3;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 593);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生界面";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
    }
}