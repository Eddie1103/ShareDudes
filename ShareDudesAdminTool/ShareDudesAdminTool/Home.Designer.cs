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
            this.dgv_reports = new System.Windows.Forms.DataGridView();
            this.tp_offers = new System.Windows.Forms.TabPage();
            this.dgv_offer = new System.Windows.Forms.DataGridView();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp_user = new System.Windows.Forms.TabPage();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_search = new System.Windows.Forms.TextBox();
            this.tc_home = new System.Windows.Forms.TabControl();
            this.tp_reports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reports)).BeginInit();
            this.tp_offers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_offer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            this.tp_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
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
            this.tp_reports.Controls.Add(this.dgv_reports);
            this.tp_reports.Location = new System.Drawing.Point(4, 32);
            this.tp_reports.Margin = new System.Windows.Forms.Padding(4);
            this.tp_reports.Name = "tp_reports";
            this.tp_reports.Padding = new System.Windows.Forms.Padding(4);
            this.tp_reports.Size = new System.Drawing.Size(1178, 872);
            this.tp_reports.TabIndex = 1;
            this.tp_reports.Text = "Reports";
            this.tp_reports.UseVisualStyleBackColor = true;
            // 
            // dgv_reports
            // 
            this.dgv_reports.AllowUserToAddRows = false;
            this.dgv_reports.AllowUserToDeleteRows = false;
            this.dgv_reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reports.Location = new System.Drawing.Point(7, 7);
            this.dgv_reports.Name = "dgv_reports";
            this.dgv_reports.ReadOnly = true;
            this.dgv_reports.RowTemplate.Height = 25;
            this.dgv_reports.Size = new System.Drawing.Size(1164, 620);
            this.dgv_reports.TabIndex = 0;
            // 
            // tp_offers
            // 
            this.tp_offers.Controls.Add(this.dgv_offer);
            this.tp_offers.Location = new System.Drawing.Point(4, 32);
            this.tp_offers.Margin = new System.Windows.Forms.Padding(4);
            this.tp_offers.Name = "tp_offers";
            this.tp_offers.Padding = new System.Windows.Forms.Padding(4);
            this.tp_offers.Size = new System.Drawing.Size(1178, 872);
            this.tp_offers.TabIndex = 0;
            this.tp_offers.Text = "Angebote";
            this.tp_offers.UseVisualStyleBackColor = true;
            // 
            // dgv_offer
            // 
            this.dgv_offer.AllowUserToOrderColumns = true;
            this.dgv_offer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_offer.Location = new System.Drawing.Point(7, 7);
            this.dgv_offer.Name = "dgv_offer";
            this.dgv_offer.RowTemplate.Height = 25;
            this.dgv_offer.Size = new System.Drawing.Size(1164, 620);
            this.dgv_offer.TabIndex = 0;
            // 
            // tp_user
            // 
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
            // dgv_user
            // 
            this.dgv_user.AllowUserToAddRows = false;
            this.dgv_user.AllowUserToDeleteRows = false;
            this.dgv_user.AllowUserToOrderColumns = true;
            this.dgv_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_user.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Location = new System.Drawing.Point(7, 7);
            this.dgv_user.MultiSelect = false;
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.RowHeadersWidth = 10;
            this.dgv_user.RowTemplate.Height = 25;
            this.dgv_user.ShowEditingIcon = false;
            this.dgv_user.Size = new System.Drawing.Size(1164, 620);
            this.dgv_user.TabIndex = 1;
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
            this.tc_home.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_home.Controls.Add(this.tp_user);
            this.tc_home.Controls.Add(this.tp_offers);
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
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.tc_home);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.tp_reports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reports)).EndInit();
            this.tp_offers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_offer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            this.tp_user.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.tc_home.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_logout;
        private TabPage tp_reports;
        private TabPage tp_offers;
        private TabPage tp_user;
        private TabControl tc_home;
        private TextBox tb_search;
        private DataGridView dgv_user;
        private BindingSource userBindingSource;
        private Button button1;
        private DataGridView dgv_offer;
        private BindingSource postsBindingSource;
        private DataGridView dgv_reports;
    }
}