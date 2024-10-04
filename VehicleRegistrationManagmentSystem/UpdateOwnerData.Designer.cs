namespace VehicleRegistrationManagmentSystem
{
    partial class UpdateOwnerData
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
            label3 = new Label();
            txtAID = new TextBox();
            btnSearch = new Button();
            errorAID = new ErrorProvider(components);
            groupBox2 = new GroupBox();
            btnUpdate = new Button();
            txtPhone = new MaskedTextBox();
            txtNIC = new MaskedTextBox();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label4 = new Label();
            GridOld = new DataGridView();
            btnCancel = new Button();
            btnConfirm = new Button();
            errorName = new ErrorProvider(components);
            errorNIC = new ErrorProvider(components);
            errorPhone = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorAID).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridOld).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNIC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorPhone).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 41);
            label3.Name = "label3";
            label3.Size = new Size(47, 28);
            label3.TabIndex = 12;
            label3.Text = "AID";
            // 
            // txtAID
            // 
            txtAID.Location = new Point(120, 45);
            txtAID.Name = "txtAID";
            txtAID.Size = new Size(132, 27);
            txtAID.TabIndex = 13;
            txtAID.Text = "1";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.SteelBlue;
            btnSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Location = new Point(311, 41);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(137, 38);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // errorAID
            // 
            errorAID.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorAID.ContainerControl = this;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(txtPhone);
            groupBox2.Controls.Add(txtNIC);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 112);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(468, 310);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "OwnerData";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.CadetBlue;
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(20, 256);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(407, 48);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(183, 193);
            txtPhone.Mask = "\\0300-0000000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(244, 34);
            txtPhone.TabIndex = 12;
            // 
            // txtNIC
            // 
            txtNIC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNIC.Location = new Point(183, 118);
            txtNIC.Mask = "00000-0000000-0";
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(244, 34);
            txtNIC.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 44);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 0;
            label1.Text = "Owner Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(183, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(244, 34);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 118);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 2;
            label2.Text = "Owner NIC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 191);
            label4.Name = "label4";
            label4.Size = new Size(105, 28);
            label4.TabIndex = 4;
            label4.Text = "Phone No";
            // 
            // GridOld
            // 
            GridOld.BackgroundColor = SystemColors.HighlightText;
            GridOld.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            GridOld.DefaultCellStyle = dataGridViewCellStyle1;
            GridOld.Location = new Point(12, 445);
            GridOld.Name = "GridOld";
            GridOld.ReadOnly = true;
            GridOld.RowHeadersWidth = 51;
            GridOld.Size = new Size(1305, 89);
            GridOld.TabIndex = 16;
            GridOld.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.SteelBlue;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.Location = new Point(468, 42);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 37);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.CadetBlue;
            btnConfirm.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnConfirm.ForeColor = SystemColors.Control;
            btnConfirm.Location = new Point(486, 368);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(137, 55);
            btnConfirm.TabIndex = 18;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // errorName
            // 
            errorName.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorName.ContainerControl = this;
            // 
            // errorNIC
            // 
            errorNIC.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorNIC.ContainerControl = this;
            // 
            // errorPhone
            // 
            errorPhone.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorPhone.ContainerControl = this;
            // 
            // UpdateOwnerData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 579);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Controls.Add(GridOld);
            Controls.Add(groupBox2);
            Controls.Add(btnSearch);
            Controls.Add(txtAID);
            Controls.Add(label3);
            Name = "UpdateOwnerData";
            Text = "UpdateOwnerData";
            ((System.ComponentModel.ISupportInitialize)errorAID).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridOld).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNIC).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorPhone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox txtAID;
        private Button btnSearch;
        private ErrorProvider errorAID;
        private GroupBox groupBox2;
        private MaskedTextBox txtPhone;
        private MaskedTextBox txtNIC;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label4;
        private DataGridView GridOld;
        private Button btnUpdate;
        private Button btnConfirm;
        private Button btnCancel;
        private ErrorProvider errorName;
        private ErrorProvider errorNIC;
        private ErrorProvider errorPhone;
    }
}