using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace VehicleRegistrationManagmentSystem
{
    public partial class MainForm : Form
    {
        private readonly string txtname = @"^[a-zA-Z ]+$";
        private readonly string txtphone = @"^\d{4}-\d{7}$";
        private readonly string txtaid = @"^\d{1}\d{0,9}$";
        string connectionString = "Data Source=DESKTOP-P469VTF;Initial Catalog=VehicleOwnerData;Integrated Security=True;Encrypt=False";
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool IsCheck()
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

            if (!Regex.IsMatch(txtPhone.Text, txtphone))
            {
                errorPhone.SetError(txtPhone, "Please Enter Valid Phone Number");
                IsValid = false;
            }
            else
            {
                errorPhone.Clear();
            }
            if (!Regex.IsMatch(txtAID.Text, txtaid))
            {
                errorAID.SetError(txtAID, "Please Enter Valid AID");
                IsValid = false;
            }
            return IsValid;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            AddNewData Form1 = new AddNewData();
            Form1.Show();
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtName.Text == null)
            {
                errorName.SetError(txtName, "Name field can't be empty");
                return;

            }
            else if (txtPhone.Text == null)
            {
                errorPhone.SetError(txtPhone, "Phone Number field can't be empty");
                return;
            }
            else
            {
                errorName.Clear();
                errorPhone.Clear();
                errorAID.Clear();


                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Owner_Info WHERE AID = @AID AND OwnerName = @OwnerName AND PhoneNo = @PhoneNo", conn);

                    sqlCommand.Parameters.AddWithValue("@AID", txtAID.Text);
                    sqlCommand.Parameters.AddWithValue("@OwnerName", txtName.Text);
                    sqlCommand.Parameters.AddWithValue("@PhoneNo", txtPhone.Text);
                    conn.Open();

                    using (SqlDataReader data = sqlCommand.ExecuteReader())
                    {
                        if (data.HasRows)
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(data);
                            xGrid.DataSource = dataTable;
                            xGrid.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Record Not Found");
                        }
                    }
                }
            }

        }


        private void xGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                var answer = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    int AID = Convert.ToInt32(xGrid.Rows[e.RowIndex].Cells[0].Value);
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM Owner_Info WHERE AID = @AID", connection))
                        {
                            sqlCommand.Parameters.AddWithValue("@AID", AID);
                            int RowsAffected = sqlCommand.ExecuteNonQuery();
                            if (RowsAffected > 0)
                            {
                                MessageBox.Show("Record Deleted Successfully");
                                xGrid.Rows.RemoveAt(e.RowIndex);
                            }
                            else
                            {
                                MessageBox.Show("There was a trouble deleted the record");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You cancelled the operation");
                }
            }
            else
            {
                MessageBox.Show("Incorrect row Selected");
            }


        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Owner_Info", conn))
                {
                    conn.Open();
                    using (SqlDataReader data = sqlCommand.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(data);
                        xGrid.DataSource = dataTable;
                        xGrid.Visible = true;
                    }

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateOwnerData updateOwnerData = new UpdateOwnerData();
            updateOwnerData.Show();
        }
    }
}
