namespace FinalProject
{
    partial class UserLogin
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
            this.Userlog = new System.Windows.Forms.TextBox();
            this.PassLogin = new System.Windows.Forms.TextBox();
            this.usernamelogin = new System.Windows.Forms.Label();
            this.passwordlogin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Userlog
            // 
            this.Userlog.Location = new System.Drawing.Point(419, 130);
            this.Userlog.Name = "Userlog";
            this.Userlog.Size = new System.Drawing.Size(1189, 31);
            this.Userlog.TabIndex = 0;
            this.Userlog.TextAlignChanged += new System.EventHandler(this.textBox1_TextAlignChanged);
            this.Userlog.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PassLogin
            // 
            this.PassLogin.Location = new System.Drawing.Point(419, 373);
            this.PassLogin.Name = "PassLogin";
            this.PassLogin.PasswordChar = '*';
            this.PassLogin.Size = new System.Drawing.Size(1189, 31);
            this.PassLogin.TabIndex = 1;
            this.PassLogin.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // usernamelogin
            // 
            this.usernamelogin.AutoSize = true;
            this.usernamelogin.Font = new System.Drawing.Font("B Nazanin", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.usernamelogin.Location = new System.Drawing.Point(1692, 111);
            this.usernamelogin.Name = "usernamelogin";
            this.usernamelogin.Size = new System.Drawing.Size(162, 64);
            this.usernamelogin.TabIndex = 2;
            this.usernamelogin.Text = "نام کاربری";
            this.usernamelogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usernamelogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordlogin
            // 
            this.passwordlogin.AutoSize = true;
            this.passwordlogin.Font = new System.Drawing.Font("B Nazanin", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.passwordlogin.Location = new System.Drawing.Point(1715, 354);
            this.passwordlogin.Name = "passwordlogin";
            this.passwordlogin.Size = new System.Drawing.Size(139, 64);
            this.passwordlogin.TabIndex = 3;
            this.passwordlogin.Text = "رمز عبور";
            this.passwordlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("B Nazanin", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(928, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 100);
            this.button1.TabIndex = 4;
            this.button1.Text = "ورود";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1972, 873);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordlogin);
            this.Controls.Add(this.usernamelogin);
            this.Controls.Add(this.PassLogin);
            this.Controls.Add(this.Userlog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Userlog;
        private System.Windows.Forms.TextBox PassLogin;
        private System.Windows.Forms.Label usernamelogin;
        private System.Windows.Forms.Label passwordlogin;
        private System.Windows.Forms.Button button1;
    }
}