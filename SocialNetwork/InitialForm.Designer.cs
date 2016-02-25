namespace SocialNetwork
{
    partial class InitialForm
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
            this.label_Heading = new System.Windows.Forms.Label();
            this.button_Register = new System.Windows.Forms.Button();
            this.button_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Heading
            // 
            this.label_Heading.AutoSize = true;
            this.label_Heading.Font = new System.Drawing.Font("Arial", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Heading.Location = new System.Drawing.Point(128, 61);
            this.label_Heading.Name = "label_Heading";
            this.label_Heading.Size = new System.Drawing.Size(528, 82);
            this.label_Heading.TabIndex = 0;
            this.label_Heading.Text = "Social Network";
            // 
            // button_Register
            // 
            this.button_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Register.Location = new System.Drawing.Point(141, 235);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(211, 68);
            this.button_Register.TabIndex = 1;
            this.button_Register.Text = "Register";
            this.button_Register.UseVisualStyleBackColor = true;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // button_Login
            // 
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Login.Location = new System.Drawing.Point(400, 235);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(211, 68);
            this.button_Login.TabIndex = 1;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.label_Heading);
            this.Name = "InitialForm";
            this.Text = "Social Network v1.0";
            this.Load += new System.EventHandler(this.InitialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Heading;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.Button button_Login;
    }
}