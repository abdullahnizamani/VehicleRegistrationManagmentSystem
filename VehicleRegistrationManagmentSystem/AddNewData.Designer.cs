namespace VehicleRegistrationManagmentSystem
{
    partial class AddNewData
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
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            groupBox1 = new GroupBox();
            txtEngine = new MaskedTextBox();
            txtChasis = new MaskedTextBox();
            label12 = new Label();
            comboColor = new ComboBox();
            txtPlate = new MaskedTextBox();
            txtReg = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtVehicleName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            comboYear = new ComboBox();
            label4 = new Label();
            comboBrand = new ComboBox();
            groupBox2 = new GroupBox();
            txtPhone = new MaskedTextBox();
            txtNIC = new MaskedTextBox();
            xGrid = new DataGridView();
            btnConfirm = new Button();
            errorName = new ErrorProvider(components);
            errorNIC = new ErrorProvider(components);
            errorPhone = new ErrorProvider(components);
            errorEngine = new ErrorProvider(components);
            errorChasis = new ErrorProvider(components);
            errorVehicleName = new ErrorProvider(components);
            errorBrand = new ErrorProvider(components);
            errorReg = new ErrorProvider(components);
            errorColor = new ErrorProvider(components);
            errorPlate = new ErrorProvider(components);
            errorYear = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)xGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNIC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorEngine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorChasis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorVehicleName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorBrand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorReg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorPlate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorYear).BeginInit();
            SuspendLayout();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 191);
            label3.Name = "label3";
            label3.Size = new Size(105, 28);
            label3.TabIndex = 4;
            label3.Text = "Phone No";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LimeGreen;
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(985, 327);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 39);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Desktop;
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.Location = new Point(1094, 327);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 39);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEngine);
            groupBox1.Controls.Add(txtChasis);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(comboColor);
            groupBox1.Controls.Add(txtPlate);
            groupBox1.Controls.Add(txtReg);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtVehicleName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboYear);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBrand);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(490, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(698, 293);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "VehicleData";
            // 
            // txtEngine
            // 
            txtEngine.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEngine.Location = new Point(491, 35);
            txtEngine.Mask = ">ENG-000000000";
            txtEngine.Name = "txtEngine";
            txtEngine.Size = new Size(162, 34);
            txtEngine.TabIndex = 21;
            // 
            // txtChasis
            // 
            txtChasis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtChasis.Location = new Point(493, 140);
            txtChasis.Mask = ">\\CH\\A-000000000";
            txtChasis.Name = "txtChasis";
            txtChasis.Size = new Size(160, 34);
            txtChasis.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(346, 87);
            label12.Name = "label12";
            label12.Size = new Size(62, 28);
            label12.TabIndex = 19;
            label12.Text = "Color";
            // 
            // comboColor
            // 
            comboColor.Font = new Font("Segoe UI", 12F);
            comboColor.FormattingEnabled = true;
            comboColor.Items.AddRange(new object[] { "White", "Black", "Gray", "Silver", "Blue", "Red", "Brown", "Green", "Beige", "Yellow" });
            comboColor.Location = new Point(493, 91);
            comboColor.Name = "comboColor";
            comboColor.RightToLeft = RightToLeft.No;
            comboColor.Size = new Size(160, 36);
            comboColor.TabIndex = 18;
            // 
            // txtPlate
            // 
            txtPlate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPlate.Location = new Point(491, 199);
            txtPlate.Mask = ">LL?-0009";
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(162, 34);
            txtPlate.TabIndex = 12;
            // 
            // txtReg
            // 
            txtReg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReg.Location = new Point(154, 199);
            txtReg.Name = "txtReg";
            txtReg.Size = new Size(151, 34);
            txtReg.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(6, 199);
            label10.Name = "label10";
            label10.Size = new Size(95, 28);
            label10.TabIndex = 15;
            label10.Text = "Reg Fees";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(346, 202);
            label9.Name = "label9";
            label9.Size = new Size(94, 28);
            label9.TabIndex = 11;
            label9.Text = "No Plate";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(346, 139);
            label8.Name = "label8";
            label8.Size = new Size(105, 28);
            label8.TabIndex = 10;
            label8.Text = "Chasis No";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(346, 38);
            label7.Name = "label7";
            label7.Size = new Size(110, 28);
            label7.TabIndex = 9;
            label7.Text = "Engine No";
            // 
            // txtVehicleName
            // 
            txtVehicleName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVehicleName.Location = new Point(154, 84);
            txtVehicleName.Name = "txtVehicleName";
            txtVehicleName.Size = new Size(151, 34);
            txtVehicleName.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 87);
            label6.Name = "label6";
            label6.Size = new Size(68, 28);
            label6.TabIndex = 9;
            label6.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 143);
            label5.Name = "label5";
            label5.Size = new Size(52, 28);
            label5.TabIndex = 3;
            label5.Text = "Year";
            // 
            // comboYear
            // 
            comboYear.Font = new Font("Segoe UI", 12F);
            comboYear.FormattingEnabled = true;
            comboYear.Location = new Point(154, 143);
            comboYear.Name = "comboYear";
            comboYear.RightToLeft = RightToLeft.No;
            comboYear.Size = new Size(151, 36);
            comboYear.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 38);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 1;
            label4.Text = "Brand";
            // 
            // comboBrand
            // 
            comboBrand.Font = new Font("Segoe UI", 12F);
            comboBrand.FormattingEnabled = true;
            comboBrand.Items.AddRange(new object[] { "Toyota", "Honda", "Kia", "Suzuki", "Daihatsu" });
            comboBrand.Location = new Point(154, 38);
            comboBrand.Name = "comboBrand";
            comboBrand.RightToLeft = RightToLeft.No;
            comboBrand.Size = new Size(151, 36);
            comboBrand.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPhone);
            groupBox2.Controls.Add(txtNIC);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(472, 293);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "OwnerData";
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
            // xGrid
            // 
            xGrid.BackgroundColor = SystemColors.HighlightText;
            xGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            xGrid.DefaultCellStyle = dataGridViewCellStyle1;
            xGrid.GridColor = SystemColors.HotTrack;
            xGrid.Location = new Point(12, 397);
            xGrid.Name = "xGrid";
            xGrid.ReadOnly = true;
            xGrid.RowHeadersWidth = 51;
            xGrid.Size = new Size(1176, 91);
            xGrid.TabIndex = 10;
            xGrid.Visible = false;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.LimeGreen;
            btnConfirm.ForeColor = SystemColors.Control;
            btnConfirm.Location = new Point(1094, 511);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 41);
            btnConfirm.TabIndex = 11;
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
            // errorEngine
            // 
            errorEngine.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorEngine.ContainerControl = this;
            // 
            // errorChasis
            // 
            errorChasis.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorChasis.ContainerControl = this;
            // 
            // errorVehicleName
            // 
            errorVehicleName.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorVehicleName.ContainerControl = this;
            // 
            // errorBrand
            // 
            errorBrand.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorBrand.ContainerControl = this;
            // 
            // errorReg
            // 
            errorReg.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorReg.ContainerControl = this;
            // 
            // errorColor
            // 
            errorColor.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorColor.ContainerControl = this;
            // 
            // errorPlate
            // 
            errorPlate.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorPlate.ContainerControl = this;
            // 
            // errorYear
            // 
            errorYear.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorYear.ContainerControl = this;
            // 
            // AddNewData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 566);
            Controls.Add(btnConfirm);
            Controls.Add(xGrid);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddNewData";
            Text = "Create a New Record";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)xGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNIC).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorEngine).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorChasis).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorVehicleName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorBrand).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorReg).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorPlate).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorYear).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Button btnSave;
        private Button btnCancel;
        private GroupBox groupBox1;
        private ComboBox comboBrand;
        private Label label5;
        private ComboBox comboYear;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtVehicleName;
        private Label label6;
        private TextBox txtReg;
        private Label label10;
        private GroupBox groupBox2;
        private DataGridView xGrid;
        private Button btnConfirm;
        private MaskedTextBox txtNIC;
        private MaskedTextBox txtPhone;
        private MaskedTextBox txtPlate;
        private Label label12;
        private ComboBox comboColor;
        private MaskedTextBox txtChasis;
        private MaskedTextBox txtEngine;
        private ErrorProvider errorName;
        private ErrorProvider errorNIC;
        private ErrorProvider errorPhone;
        private ErrorProvider errorEngine;
        private ErrorProvider errorChasis;
        private ErrorProvider errorVehicleName;
        private ErrorProvider errorBrand;
        private ErrorProvider errorReg;
        private ErrorProvider errorColor;
        private ErrorProvider errorPlate;
        private ErrorProvider errorYear;
        private Button btnBrowse;
    }
}