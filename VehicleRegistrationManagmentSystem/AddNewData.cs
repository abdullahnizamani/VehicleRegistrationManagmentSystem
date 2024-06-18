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
            xGrid.Visible = true;
        }
    }
}