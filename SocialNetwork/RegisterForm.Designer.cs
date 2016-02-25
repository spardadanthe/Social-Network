namespace SocialNetwork
{
    partial class RegisterForm
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
            this.label_Username = new System.Windows.Forms.Label();
            this.button_Register = new System.Windows.Forms.Button();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label_RepeatPassword = new System.Windows.Forms.Label();
            this.textBox_RepeatPassword = new System.Windows.Forms.TextBox();
            this.label_PasswordMatch = new System.Windows.Forms.Label();
            this.label_Register = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Username.Location = new System.Drawing.Point(91, 116);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(147, 31);
            this.label_Username.TabIndex = 0;
            this.label_Username.Text = "Username:";
            // 
            // button_Register
            // 
            this.button_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Register.Location = new System.Drawing.Point(127, 447);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(218, 60);
            this.button_Register.TabIndex = 6;
            this.button_Register.Text = "Register";
            this.button_Register.UseVisualStyleBackColor = true;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(267, 128);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(136, 20);
            this.textBox_Username.TabIndex = 1;
            this.textBox_Username.TextChanged += new System.EventHandler(this.textBox_Username_TextChanged);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Password.Location = new System.Drawing.Point(96, 190);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(142, 31);
            this.label_Password.TabIndex = 3;
            this.label_Password.Text = "Password:";
            this.label_Password.Click += new System.EventHandler(this.label_Password_Click);
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_FirstName.Location = new System.Drawing.Point(91, 306);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(155, 31);
            this.label_FirstName.TabIndex = 3;
            this.label_FirstName.Text = "First Name:";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_LastName.Location = new System.Drawing.Point(96, 376);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(153, 31);
            this.label_LastName.TabIndex = 3;
            this.label_LastName.Text = "Last Name:";
            this.label_LastName.Click += new System.EventHandler(this.label_LastName_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(267, 201);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(136, 20);
            this.textBox_Password.TabIndex = 2;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(267, 318);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(136, 20);
            this.textBox_FirstName.TabIndex = 4;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(267, 384);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(136, 20);
            this.textBox_LastName.TabIndex = 5;
            // 
            // label_RepeatPassword
            // 
            this.label_RepeatPassword.AutoSize = true;
            this.label_RepeatPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_RepeatPassword.Location = new System.Drawing.Point(96, 251);
            this.label_RepeatPassword.Name = "label_RepeatPassword";
            this.label_RepeatPassword.Size = new System.Drawing.Size(142, 31);
            this.label_RepeatPassword.TabIndex = 3;
            this.label_RepeatPassword.Text = "Password:";
            // 
            // textBox_RepeatPassword
            // 
            this.textBox_RepeatPassword.Location = new System.Drawing.Point(267, 263);
            this.textBox_RepeatPassword.Name = "textBox_RepeatPassword";
            this.textBox_RepeatPassword.PasswordChar = '*';
            this.textBox_RepeatPassword.Size = new System.Drawing.Size(136, 20);
            this.textBox_RepeatPassword.TabIndex = 3;
            this.textBox_RepeatPassword.TextChanged += new System.EventHandler(this.textBox_RepeatPassword_TextChanged);
            // 
            // label_PasswordMatch
            // 
            this.label_PasswordMatch.AutoSize = true;
            this.label_PasswordMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_PasswordMatch.ForeColor = System.Drawing.Color.Red;
            this.label_PasswordMatch.Location = new System.Drawing.Point(170, 407);
            this.label_PasswordMatch.Name = "label_PasswordMatch";
            this.label_PasswordMatch.Size = new System.Drawing.Size(175, 16);
            this.label_PasswordMatch.TabIndex = 4;
            this.label_PasswordMatch.Text = "The passwords don\'t match!";
            this.label_PasswordMatch.Visible = false;
            // 
            // label_Register
            // 
            this.label_Register.AutoSize = true;
            this.label_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Register.ForeColor = System.Drawing.Color.Red;
            this.label_Register.Location = new System.Drawing.Point(154, 36);
            this.label_Register.Name = "label_Register";
            this.label_Register.Size = new System.Drawing.Size(203, 55);
            this.label_Register.TabIndex = 5;
            this.label_Register.Text = "Register";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(497, 563);
            this.Controls.Add(this.label_Register);
            this.Controls.Add(this.label_PasswordMatch);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.label_RepeatPassword);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.textBox_RepeatPassword);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.label_Username);
            this.Name = "RegisterForm";
            this.Text = "Social Network v1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label_RepeatPassword;
        private System.Windows.Forms.TextBox textBox_RepeatPassword;
        private System.Windows.Forms.Label label_PasswordMatch;
        private System.Windows.Forms.Label label_Register;
    }
}

