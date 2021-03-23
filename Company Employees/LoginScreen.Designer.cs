
namespace Company_Employees
{
    partial class LoginScreen
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
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.label_warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(117, 62);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(70, 13);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Kullanıcı Adı: ";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(120, 118);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(43, 13);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Parola: ";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(193, 62);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(194, 20);
            this.tb_username.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(193, 118);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(194, 20);
            this.tb_password.TabIndex = 3;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(210, 220);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(143, 44);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "Giriş Yap";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label_warning
            // 
            this.label_warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_warning.ForeColor = System.Drawing.Color.Red;
            this.label_warning.Location = new System.Drawing.Point(79, 176);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(381, 23);
            this.label_warning.TabIndex = 5;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 318);
            this.Controls.Add(this.label_warning);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label_warning;
    }
}

