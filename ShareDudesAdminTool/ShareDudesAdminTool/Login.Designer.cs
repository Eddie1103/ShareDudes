namespace ShareDudesAdminTool
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tb_benutzer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_headline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_benutzer
            // 
            this.tb_benutzer.Location = new System.Drawing.Point(44, 100);
            this.tb_benutzer.Name = "tb_benutzer";
            this.tb_benutzer.PlaceholderText = "Benutzer...";
            this.tb_benutzer.Size = new System.Drawing.Size(335, 24);
            this.tb_benutzer.TabIndex = 1;
            this.tb_benutzer.TextChanged += new System.EventHandler(this.tb_benutzer_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(137, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(44, 153);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.PlaceholderText = "Passwort...";
            this.tb_password.Size = new System.Drawing.Size(335, 24);
            this.tb_password.TabIndex = 3;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // lb_headline
            // 
            this.lb_headline.AutoSize = true;
            this.lb_headline.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_headline.Location = new System.Drawing.Point(114, 36);
            this.lb_headline.Name = "lb_headline";
            this.lb_headline.Size = new System.Drawing.Size(178, 29);
            this.lb_headline.TabIndex = 5;
            this.lb_headline.Text = "Admintool Login";
            this.lb_headline.Click += new System.EventHandler(this.lb_headline_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 293);
            this.Controls.Add(this.lb_headline);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_benutzer);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Sharedudes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tb_benutzer;
        private Button button1;
        private TextBox tb_password;
        private Label lb_headline;
    }
}