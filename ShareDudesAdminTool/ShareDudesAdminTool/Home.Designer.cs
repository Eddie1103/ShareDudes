namespace ShareDudesAdminTool
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.tc_home = new System.Windows.Forms.TabControl();
            this.tp_posts = new System.Windows.Forms.TabPage();
            this.tp_reports = new System.Windows.Forms.TabPage();
            this.tp_user = new System.Windows.Forms.TabPage();
            this.tc_home.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_home
            // 
            this.tc_home.Controls.Add(this.tp_user);
            this.tc_home.Controls.Add(this.tp_posts);
            this.tc_home.Controls.Add(this.tp_reports);
            this.tc_home.Location = new System.Drawing.Point(12, 12);
            this.tc_home.Name = "tc_home";
            this.tc_home.SelectedIndex = 0;
            this.tc_home.Size = new System.Drawing.Size(874, 501);
            this.tc_home.TabIndex = 0;
            // 
            // tp_posts
            // 
            this.tp_posts.Location = new System.Drawing.Point(4, 24);
            this.tp_posts.Name = "tp_posts";
            this.tp_posts.Padding = new System.Windows.Forms.Padding(3);
            this.tp_posts.Size = new System.Drawing.Size(866, 473);
            this.tp_posts.TabIndex = 0;
            this.tp_posts.Text = "Posts";
            this.tp_posts.UseVisualStyleBackColor = true;
            // 
            // tp_reports
            // 
            this.tp_reports.Location = new System.Drawing.Point(4, 24);
            this.tp_reports.Name = "tp_reports";
            this.tp_reports.Padding = new System.Windows.Forms.Padding(3);
            this.tp_reports.Size = new System.Drawing.Size(866, 473);
            this.tp_reports.TabIndex = 1;
            this.tp_reports.Text = "Reports";
            this.tp_reports.UseVisualStyleBackColor = true;
            // 
            // tp_user
            // 
            this.tp_user.Location = new System.Drawing.Point(4, 24);
            this.tp_user.Name = "tp_user";
            this.tp_user.Padding = new System.Windows.Forms.Padding(3);
            this.tp_user.Size = new System.Drawing.Size(866, 473);
            this.tp_user.TabIndex = 2;
            this.tp_user.Text = "User";
            this.tp_user.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 525);
            this.Controls.Add(this.tc_home);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.Text = "Home";
            this.tc_home.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tc_home;
        private TabPage tp_posts;
        private TabPage tp_reports;
        private TabPage tp_user;
    }
}