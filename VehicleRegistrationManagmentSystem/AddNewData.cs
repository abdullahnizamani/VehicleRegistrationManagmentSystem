using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRegistrationManagmentSystem
{
    public partial class AddNewData : Form
    {
        private readonly string txtvehiclename = @"^[a-zA-Z]+$";
        private readonly string txtnic = @"^\d{5}-\d{7}-\d{1}$";
        private readonly string txtname = @"^[a-zA-Z ]+$";
        private readonly string txtphone = @"^\d{4}-\d{7}$";
        private readonly string txtengine = @"^ENG-\d{9}$";
        private readonly string txtchasis = @"^CHA-\d{9}$";
        private readonly string noplate = @"^[A-Z]{2}[A-Z]?-?\d{3}\d?$";
        public int AID;
     

        public AddNewData()
        {
            InitializeComponent();
            ComboYear();


        }
        bool CheckData()
        {
            bool IsValid = true;
            if (!Regex.IsMatch(txtName.Text, txtname))
            {
                errorName.SetError(txtName, "Please Enter Valid Name");
                IsValid = false;
            }
            else
            {
                errorName.Clear();
            }

            if (!Regex.IsMatch(txtNIC.Text, txtnic))
            {
                errorNIC.SetError(txtNIC, "Please Enter Valid NIC");
                IsValid = false;
            }
            else
            {
                errorNIC.Clear();
            }

            if (!Regex.IsMatch(txtPhone.Text, txtphone))
            {
                errorPhone.SetError(txtPhone, "Please Enter Valid Phone Number");
                IsValid = false;
            }
            else
            {
                errorPhone.Clear();
            }

            if (!Regex.IsMatch(txtEngine.Text, txtengine))
            {
                errorEngine.SetError(txtEngine, "Please Enter Valid Engine Number");
                IsValid = false;
            }
            else
            {
                errorEngine.Clear();
            }

            if (!Regex.IsMatch(txtChasis.Text, txtchasis))
            {
                errorChasis.SetError(txtChasis, "Please Enter Valid Chasis Number");
                IsValid = false;
            }
            else
            {
                errorChasis.Clear();
            }

            if (!Regex.IsMatch(txtVehicleName.Text, txtvehiclename))
            {
                errorVehicleName.SetError(txtVehicleName, "Please Enter Vehicle Name");
                IsValid = false;
            }
            else
            {
                errorVehicleName.Clear();
            }

            if (comboBrand.SelectedItem == null)
            {
                errorBrand.SetError(comboBrand, "Please Select Brand");
                IsValid = false;
            }
            else
            {
                errorBrand.Clear();
            }

            if (comboColor.SelectedItem == null)
            {
                errorColor.SetError(comboColor, "Please Select Color");
                IsValid = false;
            }
            else
            {
                errorColor.Clear();
            }

            if (comboYear.SelectedItem == null)
            {
                errorYear.SetError(comboYear, "Please Select Year");
                IsValid = false;
            }
            else
            {
                errorYear.Clear();
            }

            if (!Regex.IsMatch(txtPlate.Text, noplate))
            {
                errorPlate.SetError(txtPlate, "Please Enter Number Plate");
                IsValid = false;
            }
            else
            {
                errorPlate.Clear();
            }

            if (txtReg.Text == "")
            {
                errorReg.SetError(txtReg, "Please Enter Registration Fees");
                IsValid = false;
            }
            else
            {
                errorReg.Clear();
            }




            return IsValid;



        }

        void ComboYear()
        {
            int StartYear = 1970;
            int CurrentYear = DateTime.Now.Year;
            for (int i = StartYear; i <= CurrentYear; i++)
            {
                comboYear.Items.Add(i);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {


                int current_AID;

                string connectionString = "Data Source=DESKTOP-P469VTF;Initial Catalog=VehicleOwnerData;Integrated Security=True;Encrypt=False";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Owner_Info WHERE EngineNo = @EngineNo", conn))
                    {
                        cmd.Parameters.AddWithValue("@EngineNo", txtEngine.Text);
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Engine Number Already Exists");
                            return;
                        }
                    }


                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Owner_Info WHERE ChasisNo = @ChasisNo", conn))
                    {
                        cmd.Parameters.AddWithValue("@ChasisNo", txtChasis.Text);
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Chasis Number Already Exists");
                            return;
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Owner_Info WHERE NoPlate = @NoPlate", conn))
                    {
                        cmd.Parameters.AddWithValue("@NoPlate", txtPlate.Text);
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Number Plate Already Exists");
                            return;
                        }
                    }

                }

                /* using (SqlConnection connection = new SqlConnection(connectionString))
                 {
                     string query = "SELECT COUNT(*) FROM Owner_Info";

                     using (SqlCommand command = new SqlCommand(query, connection))
                     {
                         connection.Open();
                         current_AID = (int)command.ExecuteScalar();

                     }
                 }*/
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT MAX(AID) FROM Owner_Info";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            current_AID = (int)result;
                        }
                        else
                        {
                            current_AID = 0; 
                        }
                    }
                }




                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO Owner_Info (AID, OwnerName, OwnerNIC, PhoneNo, VehicleName, Color, EngineNo, ChasisNo, NoPlate, RegFees) VALUES (@AID, @OwnerName, @OwnerNIC, @PhoneNo, @VehicleName, @Color, @EngineNo, @ChasisNo, @NoPlate, @RegFees)", connection);
                    AID = current_AID + 1;
                    sqlCommand.Parameters.AddWithValue("@AID", AID);
                    sqlCommand.Parameters.AddWithValue("@OwnerName", txtName.Text);
                    sqlCommand.Parameters.AddWithValue("@OwnerNIC", txtNIC.Text);
                    sqlCommand.Parameters.AddWithValue("@PhoneNo", txtPhone.Text);
                    string vehicleName = comboBrand.SelectedItem.ToString() + " " + txtVehicleName.Text + "-" + comboYear.SelectedItem.ToString();
                    sqlCommand.Parameters.AddWithValue("@VehicleName", vehicleName);
                    sqlCommand.Parameters.AddWithValue("@Color", comboColor.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@EngineNo", txtEngine.Text);
                    sqlCommand.Parameters.AddWithValue("@ChasisNo", txtChasis.Text);
                    string NoPlate = txtPlate.Text.Replace(" ", "");
                    sqlCommand.Parameters.AddWithValue("@NoPlate", NoPlate);
                    sqlCommand.Parameters.AddWithValue("@RegFees", txtReg.Text);
                    sqlCommand.ExecuteNonQuery();


                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Owner_Info WHERE AID = @AID", connection);
                    sqlCommand.Parameters.AddWithValue("@AID", AID);
                    connection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

            
                    xGrid.DataSource = dataTable;

                }
                xGrid.Visible = true;

            }
            else
            {
                MessageBox.Show("Invalid Data in one or more fields. Please check and try again.");
            }
        }



        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Focus();
            this.Close();


        }

    }
}