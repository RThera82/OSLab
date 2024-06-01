namespace FinalProject
{
    partial class usercode1
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
            this.ID33 = new System.Windows.Forms.TextBox();
            this.ID3 = new System.Windows.Forms.Label();
            this.pass3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ID33
            // 
            this.ID33.Location = new System.Drawing.Point(379, 133);
            this.ID33.Name = "ID33";
            this.ID33.Size = new System.Drawing.Size(778, 31);
            this.ID33.TabIndex = 0;
            // 
            // ID3
            // 
            this.ID3.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID3.Location = new System.Drawing.Point(1218, 117);
            this.ID3.Name = "ID3";
            this.ID3.Size = new System.Drawing.Size(168, 49);
            this.ID3.TabIndex = 2;
            this.ID3.Text = "ID";
            this.ID3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ID3.Click += new System.EventHandler(this.username3_Click);
            // 
            // pass3
            // 
            this.pass3.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass3.Location = new System.Drawing.Point(1177, 294);
            this.pass3.Name = "pass3";
            this.pass3.Size = new System.Drawing.Size(209, 46);
            this.pass3.TabIndex = 3;
            this.pass3.Text = "کد تصادفی";
            this.pass3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("B Nazanin", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(681, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 72);
            this.button1.TabIndex = 4;
            this.button1.Text = "حذف";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGreen;
            this.button2.Font = new System.Drawing.Font("B Nazanin", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(681, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 74);
            this.button2.TabIndex = 5;
            this.button2.Text = "تولید کد تصادفی";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(379, 309);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(778, 31);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // usercode1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1934, 735);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pass3);
            this.Controls.Add(this.ID3);
            this.Controls.Add(this.ID33);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "usercode1";
            this.Text = "DeletePage";
            this.Load += new System.EventHandler(this.DeletePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID33;
        private System.Windows.Forms.Label ID3;
        private System.Windows.Forms.Label pass3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}