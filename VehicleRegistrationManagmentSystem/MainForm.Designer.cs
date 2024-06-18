namespace VehicleRegistrationManagmentSystem
{
    partial class MainForm
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
            btnSearch = new Button();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            btnCreate = new Button();
            button2 = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(616, 38);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(137, 31);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 38);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(297, 38);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 2;
            label2.Text = "Phone No";
            // 
            // txtName
            // 
            txtName.Location = new Point(118, 42);
            txtName.Name = "txtName";
            txtName.Size = new Size(131, 27);
            txtName.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(431, 39);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(131, 27);
            txtPhone.TabIndex = 4;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(43, 155);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(167, 45);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create New Record";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // button2
            // 
            button2.Location = new Point(235, 155);
            button2.Name = "button2";
            button2.Size = new Size(167, 45);
            button2.TabIndex = 6;
            button2.Text = "Update Owner Info";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(676, 400);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 38);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(button2);
            Controls.Add(btnCreate);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtPhone;
        private Button btnCreate;
        private Button button2;
        private Button btnExit;
    }
}