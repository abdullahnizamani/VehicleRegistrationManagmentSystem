using System;
using System.Data;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
namespace VehicleRegistrationManagmentSystem
{
    public partial class UpdateOwnerData : Form
    {
        private readonly string txtaid = @"^\d{1}\d{0,9}$";
        private readonly string txtnic = @"^\d{5}-\d{7}-\d{1}$";
        private readonly string txtname = @"^[a-zA-Z ]+$";
        private readonly string txtphone = @"^\d{4}-\d{7}$";

        string connectionString = "Data Source=DESKTOP-P469VTF;Initial Catalog=VehicleOwnerData;Integrated Security=True;Encrypt=False";
        public UpdateOwnerData()
        {
            InitializeComponent();
        }
        bool AID_Check()
        {
            if (!Regex.IsMatch(txtAID.Text, txtaid))
            {
                errorAID.SetError(txtAID, "Please Enter Valid AID");
                return false;
            }
            else
            {
                errorAID.Clear();
                return true;
            }

        }
        bool input_Check()
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
            return IsValid;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (AID_Check())
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Owner_Info WHERE AID = @AID", conn);
                    sqlCommand.Parameters.AddWithValue("@AID", txtAID.Text);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtName.Text = reader["OwnerName"].ToString();
                            txtNIC.Text = reader["OwnerNIC"].ToString();
                            txtPhone.Text = reader["PhoneNo"].ToString();

                        }
                    }
                    using (SqlDataReader read = sqlCommand.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(read);
                        GridOld.DataSource = dataTable;
                        GridOld.Visible = true;

                    }



                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand sqlCommand = new SqlCommand("UPDATE Owner_Info SET OwnerName = @OwnerName, OwnerNIC = @OwnerNIC, PhoneNo = @PhoneNo WHERE AID = @AID", conn))
                {
                    sqlCommand.Parameters.AddWithValue("@AID", txtAID.Text);
                    sqlCommand.Parameters.AddWithValue("@OwnerName", txtName.Text);
                    sqlCommand.Parameters.AddWithValue("@OwnerNIC", txtNIC.Text);
                    sqlCommand.Parameters.AddWithValue("@PhoneNo", txtPhone.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                using (SqlCommand sqlCommand1 = new SqlCommand("SELECT * FROM Owner_Info WHERE AID = @AID", conn))
                {
                    sqlCommand1.Parameters.AddWithValue("@AID", txtAID.Text);
                    using (SqlDataReader read = sqlCommand1.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(read);
                        GridOld.DataSource = dataTable;
                        GridOld.Visible = true;
                    }
                    MessageBox.Show("Data is Updated Successfully!");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
 

