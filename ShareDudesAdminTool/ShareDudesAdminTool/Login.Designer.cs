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
            this.tb_benutzer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_benutzer
            // 
            this.tb_benutzer.Location = new System.Drawing.Point(248, 205);
            this.tb_benutzer.Name = "tb_benutzer";
            this.tb_benutzer.Size = new System.Drawing.Size(298, 27);
            this.tb_benutzer.TabIndex = 1;
            this.tb_benutzer.TextChanged += new System.EventHandler(this.tb_benutzer_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(248, 273);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(298, 27);
            this.tb_password.TabIndex = 3;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_benutzer);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tb_benutzer;
        private Button button1;
        private TextBox tb_password;
    }
}