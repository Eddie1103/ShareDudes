namespace ShareDudesAdminTool
{
    partial class UserEdit
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
            this.tb_username = new System.Windows.Forms.TextBox();
            this.cb_isAdmin = new System.Windows.Forms.CheckBox();
            this.cb_isBanned = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(153, 36);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(242, 23);
            this.tb_username.TabIndex = 0;
            // 
            // cb_isAdmin
            // 
            this.cb_isAdmin.AutoSize = true;
            this.cb_isAdmin.Location = new System.Drawing.Point(218, 112);
            this.cb_isAdmin.Name = "cb_isAdmin";
            this.cb_isAdmin.Size = new System.Drawing.Size(62, 19);
            this.cb_isAdmin.TabIndex = 1;
            this.cb_isAdmin.Text = "Admin";
            this.cb_isAdmin.UseVisualStyleBackColor = true;
            // 
            // cb_isBanned
            // 
            this.cb_isBanned.AutoSize = true;
            this.cb_isBanned.Location = new System.Drawing.Point(218, 87);
            this.cb_isBanned.Name = "cb_isBanned";
            this.cb_isBanned.Size = new System.Drawing.Size(71, 19);
            this.cb_isBanned.TabIndex = 2;
            this.cb_isBanned.Text = "Gebannt";
            this.cb_isBanned.UseVisualStyleBackColor = true;
            this.cb_isBanned.CheckedChanged += new System.EventHandler(this.cb_isBanned_CheckedChanged);
            // 
            // UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 267);
            this.Controls.Add(this.cb_isBanned);
            this.Controls.Add(this.cb_isAdmin);
            this.Controls.Add(this.tb_username);
            this.Name = "UserEdit";
            this.Text = "UserEdit";
            this.Load += new System.EventHandler(this.UserEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_username;
        private CheckBox cb_isAdmin;
        private CheckBox cb_isBanned;
    }
}