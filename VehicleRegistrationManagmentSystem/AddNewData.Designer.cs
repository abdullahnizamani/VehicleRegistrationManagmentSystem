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
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtNIC = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            groupBox1 = new GroupBox();
            txtReg = new TextBox();
            label10 = new Label();
            txtPlate = new TextBox();
            txtChasis = new TextBox();
            txtEngine = new TextBox();
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
            xGrid = new DataGridView();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)xGrid).BeginInit();
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
            txtName.Size = new Size(125, 34);
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
            // txtNIC
            // 
            txtNIC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNIC.Location = new Point(183, 118);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(125, 34);
            txtNIC.TabIndex = 3;
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
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(183, 195);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 34);
            txtPhone.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(874, 399);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(983, 399);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtReg);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtPlate);
            groupBox1.Controls.Add(txtChasis);
            groupBox1.Controls.Add(txtEngine);
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
            groupBox1.Location = new Point(379, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(698, 351);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "VehicleData";
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
            // txtPlate
            // 
            txtPlate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPlate.Location = new Point(491, 147);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(151, 34);
            txtPlate.TabIndex = 14;
            // 
            // txtChasis
            // 
            txtChasis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtChasis.Location = new Point(491, 90);
            txtChasis.Name = "txtChasis";
            txtChasis.Size = new Size(151, 34);
            txtChasis.TabIndex = 13;
            // 
            // txtEngine
            // 
            txtEngine.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEngine.Location = new Point(491, 39);
            txtEngine.Name = "txtEngine";
            txtEngine.Size = new Size(151, 34);
            txtEngine.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(346, 143);
            label9.Name = "label9";
            label9.Size = new Size(94, 28);
            label9.TabIndex = 11;
            label9.Text = "No Plate";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(346, 90);
            label8.Name = "label8";
            label8.Size = new Size(105, 28);
            label8.TabIndex = 10;
            label8.Text = "Chasis No";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(346, 39);
            label7.Name = "label7";
            label7.Size = new Size(110, 28);
            label7.TabIndex = 9;
            label7.Text = "Engine No";
            // 
            // txtVehicleName
            // 
            txtVehicleName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVehicleName.Location = new Point(154, 90);
            txtVehicleName.Name = "txtVehicleName";
            txtVehicleName.Size = new Size(151, 34);
            txtVehicleName.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 90);
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
            comboYear.FormattingEnabled = true;
            comboYear.Location = new Point(154, 143);
            comboYear.Name = "comboYear";
            comboYear.RightToLeft = RightToLeft.Yes;
            comboYear.Size = new Size(151, 28);
            comboYear.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 39);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 1;
            label4.Text = "Brand";
            // 
            // comboBrand
            // 
            comboBrand.FormattingEnabled = true;
            comboBrand.Items.AddRange(new object[] { "Toyota", "Honda", "Kia", "Suzuki", "Daihatsu" });
            comboBrand.Location = new Point(154, 39);
            comboBrand.Name = "comboBrand";
            comboBrand.RightToLeft = RightToLeft.Yes;
            comboBrand.Size = new Size(151, 28);
            comboBrand.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtNIC);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtPhone);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(344, 351);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "OwnerData";
            // 
            // xGrid
            // 
            xGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            xGrid.Location = new Point(12, 482);
            xGrid.Name = "xGrid";
            xGrid.RowHeadersWidth = 51;
            xGrid.Size = new Size(1065, 47);
            xGrid.TabIndex = 10;
            xGrid.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(983, 552);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            // 
            // AddNewData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 593);
            Controls.Add(button1);
            Controls.Add(xGrid);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "AddNewData";
            Text = "Create a New Record";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)xGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtNIC;
        private Label label3;
        private TextBox txtPhone;
        private Button btnSave;
        private Button btnCancel;
        private GroupBox groupBox1;
        private ComboBox comboBrand;
        private Label label5;
        private ComboBox comboYear;
        private Label label4;
        private TextBox txtChasis;
        private TextBox txtEngine;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtVehicleName;
        private Label label6;
        private TextBox txtReg;
        private Label label10;
        private TextBox txtPlate;
        private GroupBox groupBox2;
        private DataGridView xGrid;
        private Button button1;
    }
}