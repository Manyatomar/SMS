namespace WindowFormsApp1
{
    partial class Formlogin
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblLoginwindow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(222, 136);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(253, 27);
            this.txtusername.TabIndex = 0;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(222, 169);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(253, 27);
            this.txtpassword.TabIndex = 1;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(125, 139);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(78, 20);
            this.lbluser.TabIndex = 2;
            this.lbluser.Text = "UserName";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(125, 172);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(70, 20);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblLoginwindow
            // 
            this.lblLoginwindow.AutoSize = true;
            this.lblLoginwindow.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblLoginwindow.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoginwindow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLoginwindow.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblLoginwindow.Location = new System.Drawing.Point(239, 47);
            this.lblLoginwindow.Name = "lblLoginwindow";
            this.lblLoginwindow.Size = new System.Drawing.Size(219, 38);
            this.lblLoginwindow.TabIndex = 6;
            this.lblLoginwindow.Text = "Login Window";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(697, 364);
            this.Controls.Add(this.lblLoginwindow);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtusername;
        private TextBox txtpassword;
        private Label lbluser;
        private Label lblpassword;
        private Button button1;
        private Button button2;
        private Label lblLoginwindow;
    }
}