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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btn_logout = new System.Windows.Forms.Button();
            this.tp_reports = new System.Windows.Forms.TabPage();
            this.tp_posts = new System.Windows.Forms.TabPage();
            this.tp_user = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isBanDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hasPostsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_search = new System.Windows.Forms.TextBox();
            this.tc_home = new System.Windows.Forms.TabControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDeactivatedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tp_posts.SuspendLayout();
            this.tp_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.tc_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
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
            this.tp_reports.Location = new System.Drawing.Point(4, 32);
            this.tp_reports.Margin = new System.Windows.Forms.Padding(4);
            this.tp_reports.Name = "tp_reports";
            this.tp_reports.Padding = new System.Windows.Forms.Padding(4);
            this.tp_reports.Size = new System.Drawing.Size(1178, 872);
            this.tp_reports.TabIndex = 1;
            this.tp_reports.Text = "Reports";
            this.tp_reports.UseVisualStyleBackColor = true;
            // 
            // tp_posts
            // 
            this.tp_posts.Controls.Add(this.dataGridView1);
            this.tp_posts.Location = new System.Drawing.Point(4, 32);
            this.tp_posts.Margin = new System.Windows.Forms.Padding(4);
            this.tp_posts.Name = "tp_posts";
            this.tp_posts.Padding = new System.Windows.Forms.Padding(4);
            this.tp_posts.Size = new System.Drawing.Size(1178, 872);
            this.tp_posts.TabIndex = 0;
            this.tp_posts.Text = "Posts";
            this.tp_posts.UseVisualStyleBackColor = true;
            // 
            // tp_user
            // 
            this.tp_user.Controls.Add(this.button1);
            this.tp_user.Controls.Add(this.dgv_user);
            this.tp_user.Location = new System.Drawing.Point(4, 32);
            this.tp_user.Margin = new System.Windows.Forms.Padding(4);
            this.tp_user.Name = "tp_user";
            this.tp_user.Padding = new System.Windows.Forms.Padding(4);
            this.tp_user.Size = new System.Drawing.Size(1178, 872);
            this.tp_user.TabIndex = 2;
            this.tp_user.Text = "User";
            this.tp_user.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1049, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_user
            // 
            this.dgv_user.AllowUserToDeleteRows = false;
            this.dgv_user.AllowUserToOrderColumns = true;
            this.dgv_user.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_user.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.isAdminDataGridViewCheckBoxColumn,
            this.isBanDataGridViewCheckBoxColumn,
            this.hasPostsDataGridViewCheckBoxColumn});
            this.dgv_user.DataSource = this.userBindingSource;
            this.dgv_user.Location = new System.Drawing.Point(7, 7);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.RowTemplate.Height = 25;
            this.dgv_user.Size = new System.Drawing.Size(914, 491);
            this.dgv_user.TabIndex = 1;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // isAdminDataGridViewCheckBoxColumn
            // 
            this.isAdminDataGridViewCheckBoxColumn.DataPropertyName = "IsAdmin";
            this.isAdminDataGridViewCheckBoxColumn.HeaderText = "IsAdmin";
            this.isAdminDataGridViewCheckBoxColumn.Name = "isAdminDataGridViewCheckBoxColumn";
            // 
            // isBanDataGridViewCheckBoxColumn
            // 
            this.isBanDataGridViewCheckBoxColumn.DataPropertyName = "IsBan";
            this.isBanDataGridViewCheckBoxColumn.HeaderText = "IsBan";
            this.isBanDataGridViewCheckBoxColumn.Name = "isBanDataGridViewCheckBoxColumn";
            // 
            // hasPostsDataGridViewCheckBoxColumn
            // 
            this.hasPostsDataGridViewCheckBoxColumn.DataPropertyName = "HasPosts";
            this.hasPostsDataGridViewCheckBoxColumn.HeaderText = "HasPosts";
            this.hasPostsDataGridViewCheckBoxColumn.Name = "hasPostsDataGridViewCheckBoxColumn";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ShareDudesAdminTool.User);
            // 
            // tb_search
            // 
            this.tb_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_search.Location = new System.Drawing.Point(822, 30);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4);
            this.tb_search.Name = "tb_search";
            this.tb_search.PlaceholderText = "Suche...";
            this.tb_search.Size = new System.Drawing.Size(260, 31);
            this.tb_search.TabIndex = 0;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.isDeactivatedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.postsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(969, 433);
            this.dataGridView1.TabIndex = 0;
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataSource = typeof(ShareDudesAdminTool.Posts);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // isDeactivatedDataGridViewCheckBoxColumn
            // 
            this.isDeactivatedDataGridViewCheckBoxColumn.DataPropertyName = "IsDeactivated";
            this.isDeactivatedDataGridViewCheckBoxColumn.HeaderText = "IsDeactivated";
            this.isDeactivatedDataGridViewCheckBoxColumn.Name = "isDeactivatedDataGridViewCheckBoxColumn";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 740);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.tc_home);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tp_posts.ResumeLayout(false);
            this.tp_user.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.tc_home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_logout;
        private TabPage tp_reports;
        private TabPage tp_posts;
        private TabPage tp_user;
        private TabControl tc_home;
        private TextBox tb_search;
        private DataGridView dgv_user;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isAdminDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isBanDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn hasPostsDataGridViewCheckBoxColumn;
        private BindingSource userBindingSource;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isDeactivatedDataGridViewCheckBoxColumn;
        private BindingSource postsBindingSource;
    }
}