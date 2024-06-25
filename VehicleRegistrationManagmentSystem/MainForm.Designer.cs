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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnSearch = new Button();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnExit = new Button();
            errorName = new ErrorProvider(components);
            errorPhone = new ErrorProvider(components);
            txtPhone = new MaskedTextBox();
            label3 = new Label();
            txtAID = new TextBox();
            errorAID = new ErrorProvider(components);
            xGrid = new DataGridView();
            btnLoadAll = new Button();
            ((System.ComponentModel.ISupportInitialize)errorName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorAID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xGrid).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSearch.Location = new Point(938, 59);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(137, 31);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(326, 59);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(619, 63);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 2;
            label2.Text = "Phone No";
            // 
            // txtName
            // 
            txtName.Location = new Point(427, 63);
            txtName.Name = "txtName";
            txtName.Size = new Size(131, 27);
            txtName.TabIndex = 3;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCreate.Location = new Point(27, 142);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(179, 45);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create New Record";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnUpdate.Location = new Point(226, 142);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(183, 45);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update Owner Info";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(981, 400);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 38);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // errorName
            // 
            errorName.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorName.ContainerControl = this;
            // 
            // errorPhone
            // 
            errorPhone.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorPhone.ContainerControl = this;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(769, 63);
            txtPhone.Mask = "\\0300-0000000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(132, 27);
            txtPhone.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 57);
            label3.Name = "label3";
            label3.Size = new Size(47, 28);
            label3.TabIndex = 11;
            label3.Text = "AID";
            // 
            // txtAID
            // 
            txtAID.Location = new Point(100, 57);
            txtAID.Name = "txtAID";
            txtAID.Size = new Size(132, 27);
            txtAID.TabIndex = 12;
            // 
            // errorAID
            // 
            errorAID.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorAID.ContainerControl = this;
            // 
            // xGrid
            // 
            xGrid.AccessibleRole = AccessibleRole.None;
            xGrid.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            xGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            xGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SkyBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            xGrid.DefaultCellStyle = dataGridViewCellStyle2;
            xGrid.Location = new Point(24, 255);
            xGrid.Name = "xGrid";
            xGrid.ReadOnly = true;
            xGrid.RowHeadersWidth = 51;
            xGrid.Size = new Size(1073, 133);
            xGrid.TabIndex = 13;
            xGrid.Visible = false;
            xGrid.CellDoubleClick += xGrid_CellDoubleClick;
            // 
            // btnLoadAll
            // 
            btnLoadAll.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLoadAll.Location = new Point(427, 142);
            btnLoadAll.Name = "btnLoadAll";
            btnLoadAll.Size = new Size(183, 45);
            btnLoadAll.TabIndex = 14;
            btnLoadAll.Text = "Load All";
            btnLoadAll.UseVisualStyleBackColor = true;
            btnLoadAll.Click += btnLoadAll_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1112, 450);
            Controls.Add(btnLoadAll);
            Controls.Add(xGrid);
            Controls.Add(txtAID);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)errorName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorAID).EndInit();
            ((System.ComponentModel.ISupportInitialize)xGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnExit;
        private ErrorProvider errorName;
        private ErrorProvider errorPhone;
        private MaskedTextBox txtPhone;
        private Label label3;
        private TextBox txtAID;
        private ErrorProvider errorAID;
        private DataGridView xGrid;
        private Button btnLoadAll;
    }
}