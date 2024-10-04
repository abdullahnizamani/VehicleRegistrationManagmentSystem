namespace VehicleRegistrationManagmentSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnLogin = new Button();
            txtPass = new TextBox();
            txtUser = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            checkBoxPass = new CheckBox();
            lblExit = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LimeGreen;
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(485, 279);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(248, 35);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(485, 222);
            txtPass.Margin = new Padding(3, 2, 3, 2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(248, 23);
            txtPass.TabIndex = 10;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(485, 156);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(248, 23);
            txtUser.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(485, 196);
            label3.Name = "label3";
            label3.Size = new Size(70, 19);
            label3.TabIndex = 8;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(485, 130);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 7;
            label2.Text = "User Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(519, 66);
            label1.Name = "label1";
            label1.Size = new Size(187, 37);
            label1.TabIndex = 6;
            label1.Text = "Login Account";
            // 
            // checkBoxPass
            // 
            checkBoxPass.AutoSize = true;
            checkBoxPass.ForeColor = SystemColors.ControlText;
            checkBoxPass.Location = new Point(617, 256);
            checkBoxPass.Margin = new Padding(3, 2, 3, 2);
            checkBoxPass.Name = "checkBoxPass";
            checkBoxPass.Size = new Size(108, 19);
            checkBoxPass.TabIndex = 12;
            checkBoxPass.Text = "Show Password";
            checkBoxPass.UseVisualStyleBackColor = true;
            checkBoxPass.CheckedChanged += checkBoxPass_CheckedChanged;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Cursor = Cursors.Hand;
            lblExit.Font = new Font("Tahoma", 11F);
            lblExit.Location = new Point(806, 7);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(17, 18);
            lblExit.TabIndex = 13;
            lblExit.Text = "X";
            lblExit.Click += lblExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(441, 390);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 390);
            Controls.Add(pictureBox1);
            Controls.Add(lblExit);
            Controls.Add(checkBoxPass);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtPass;
        private TextBox txtUser;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox checkBoxPass;
        private Label lblExit;
        private PictureBox pictureBox1;
    }
}