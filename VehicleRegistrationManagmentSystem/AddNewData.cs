using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRegistrationManagmentSystem
{
    public partial class AddNewData : Form
    {
        public AddNewData()
        {
            InitializeComponent();
            ComboYear();


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
            int current_AID;
            int AID;
            string connectionString = "Data Source=DESKTOP-P469VTF;Initial Catalog=VehicleOwnerData;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Owner_Info";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    current_AID = (int)command.ExecuteScalar();
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
                string vehicleName = comboBrand.SelectedItem.ToString() + txtVehicleName.Text + "-" + comboYear.SelectedItem.ToString();
                sqlCommand.Parameters.AddWithValue("@VehicleName", vehicleName);
                sqlCommand.Parameters.AddWithValue("@Color", comboColor.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@EngineNo", txtEngine.Text);
                sqlCommand.Parameters.AddWithValue("@ChasisNo", txtChasis.Text);
                string NoPlate = txtPlate.Text.Replace(" ", "");
                sqlCommand.Parameters.AddWithValue("@NoPlate", NoPlate);
                sqlCommand.Parameters.AddWithValue("@RegFees", txtReg.Text);
                sqlCommand.ExecuteNonQuery();


            }
            xGrid.Visible = true;
           
        }
    }
}