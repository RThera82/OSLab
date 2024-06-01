namespace FinalProject
{
    partial class SignUp
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
            this.nam = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nam
            // 
            this.nam.Location = new System.Drawing.Point(1108, 167);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(537, 31);
            this.nam.TabIndex = 0;
            this.nam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Lastname
            // 
            this.Lastname.Location = new System.Drawing.Point(1108, 263);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(537, 31);
            this.Lastname.TabIndex = 1;
            this.Lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(1810, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(1697, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام خانوادگی";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(1108, 377);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(537, 31);
            this.Username.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(1722, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 55);
            this.label4.TabIndex = 7;
            this.label4.Text = "نام کاربری";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(1108, 474);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(537, 31);
            this.Password.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(1743, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 55);
            this.label5.TabIndex = 9;
            this.label5.Text = "رمز عبور";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(1447, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(507, 76);
            this.label6.TabIndex = 10;
            this.label6.Text = "لطفا اطلاعات زیر را وارد کنید";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("B Nazanin", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(1258, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 101);
            this.button1.TabIndex = 11;
            this.button1.Text = "تایید";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1966, 873);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.nam);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nam;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}