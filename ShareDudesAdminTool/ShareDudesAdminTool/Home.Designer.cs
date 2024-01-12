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
            this.btn_logout = new System.Windows.Forms.Button();
            this.tp_reports = new System.Windows.Forms.TabPage();
            this.tb_search_reports = new System.Windows.Forms.TextBox();
            this.tp_posts = new System.Windows.Forms.TabPage();
            this.tb_search_posts = new System.Windows.Forms.TextBox();
            this.tp_user = new System.Windows.Forms.TabPage();
            this.tb_search_user = new System.Windows.Forms.TextBox();
            this.tc_home = new System.Windows.Forms.TabControl();
            this.tp_reports.SuspendLayout();
            this.tp_posts.SuspendLayout();
            this.tp_user.SuspendLayout();
            this.tc_home.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.Location = new System.Drawing.Point(1090, 13);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(109, 48);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // tp_reports
            // 
            this.tp_reports.Controls.Add(this.tb_search_reports);
            this.tp_reports.Location = new System.Drawing.Point(4, 32);
            this.tp_reports.Margin = new System.Windows.Forms.Padding(4);
            this.tp_reports.Name = "tp_reports";
            this.tp_reports.Padding = new System.Windows.Forms.Padding(4);
            this.tp_reports.Size = new System.Drawing.Size(1178, 872);
            this.tp_reports.TabIndex = 1;
            this.tp_reports.Text = "Reports";
            this.tp_reports.UseVisualStyleBackColor = true;
            // 
            // tb_search_reports
            // 
            this.tb_search_reports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_search_reports.Location = new System.Drawing.Point(910, 8);
            this.tb_search_reports.Margin = new System.Windows.Forms.Padding(4);
            this.tb_search_reports.Name = "tb_search_reports";
            this.tb_search_reports.PlaceholderText = "Suche...";
            this.tb_search_reports.Size = new System.Drawing.Size(260, 31);
            this.tb_search_reports.TabIndex = 0;
            // 
            // tp_posts
            // 
            this.tp_posts.Controls.Add(this.tb_search_posts);
            this.tp_posts.Location = new System.Drawing.Point(4, 32);
            this.tp_posts.Margin = new System.Windows.Forms.Padding(4);
            this.tp_posts.Name = "tp_posts";
            this.tp_posts.Padding = new System.Windows.Forms.Padding(4);
            this.tp_posts.Size = new System.Drawing.Size(1178, 872);
            this.tp_posts.TabIndex = 0;
            this.tp_posts.Text = "Posts";
            this.tp_posts.UseVisualStyleBackColor = true;
            // 
            // tb_search_posts
            // 
            this.tb_search_posts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_search_posts.Location = new System.Drawing.Point(910, 8);
            this.tb_search_posts.Margin = new System.Windows.Forms.Padding(4);
            this.tb_search_posts.Name = "tb_search_posts";
            this.tb_search_posts.PlaceholderText = "Suche...";
            this.tb_search_posts.Size = new System.Drawing.Size(260, 31);
            this.tb_search_posts.TabIndex = 0;
            // 
            // tp_user
            // 
            this.tp_user.Controls.Add(this.tb_search_user);
            this.tp_user.Location = new System.Drawing.Point(4, 32);
            this.tp_user.Margin = new System.Windows.Forms.Padding(4);
            this.tp_user.Name = "tp_user";
            this.tp_user.Padding = new System.Windows.Forms.Padding(4);
            this.tp_user.Size = new System.Drawing.Size(1178, 872);
            this.tp_user.TabIndex = 2;
            this.tp_user.Text = "User";
            this.tp_user.UseVisualStyleBackColor = true;
            // 
            // tb_search_user
            // 
            this.tb_search_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_search_user.Location = new System.Drawing.Point(910, 8);
            this.tb_search_user.Margin = new System.Windows.Forms.Padding(4);
            this.tb_search_user.Name = "tb_search_user";
            this.tb_search_user.PlaceholderText = "Suche...";
            this.tb_search_user.Size = new System.Drawing.Size(260, 31);
            this.tb_search_user.TabIndex = 0;
            // 
            // tc_home
            // 
            this.tc_home.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_home.Controls.Add(this.tp_user);
            this.tc_home.Controls.Add(this.tp_posts);
            this.tc_home.Controls.Add(this.tp_reports);
            this.tc_home.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tc_home.Location = new System.Drawing.Point(13, 69);
            this.tc_home.Margin = new System.Windows.Forms.Padding(4);
            this.tc_home.Name = "tc_home";
            this.tc_home.SelectedIndex = 0;
            this.tc_home.Size = new System.Drawing.Size(1186, 908);
            this.tc_home.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 740);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.tc_home);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tp_reports.ResumeLayout(false);
            this.tp_reports.PerformLayout();
            this.tp_posts.ResumeLayout(false);
            this.tp_posts.PerformLayout();
            this.tp_user.ResumeLayout(false);
            this.tp_user.PerformLayout();
            this.tc_home.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_logout;
        private TabPage tp_reports;
        private TabPage tp_posts;
        private TabPage tp_user;
        private TabControl tc_home;
        private TextBox tb_search_user;
        private TextBox tb_search_posts;
        private TextBox tb_search_reports;
    }
}