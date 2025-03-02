using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chiayin_Yang_Truck
{
    public partial class Truck : Form
    {
        private List<TruckWeightRecord> records = new List<TruckWeightRecord>();
        public Truck()
        {
            InitializeComponent();
        }

        private void Truck_Load(object sender, EventArgs e)
        {
            // Initialize form components and load records if needed
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate and add record
            if (ValidateInput())
            {
                AddRecord();
                DisplayRecords();
                lblError.ForeColor = Color.Green;
                lblError.Text = "Record added successfully.";
            }
        }
        private void btnShowOverWeight_Click(object sender, EventArgs e)
        {
            // Display overweight trucks (gross weight > 65000 kg)
            DisplayOverweightTrucks();
        }
        private bool ValidateInput()
        {
            lblError.ForeColor = Color.Red;

            // Validation logic
            int recordId;
            int truckId;
            DateTime dateMeasured;
            decimal grossWeight;
            decimal tareWeight;

            bool isValid = true;
            List<string> errorMessages = new List<string>();

            // Validate Record ID
            if (!int.TryParse(txtRecordID.Text, out recordId))
            {
                errorMessages.Add("Record ID must be a valid integer.");
                isValid = false;
            }
            else if (records.Any(r => r.RecordId == recordId))
            {
                errorMessages.Add("Record ID must be unique.");
                isValid = false;
            }

            // Validate Truck ID
            if (!int.TryParse(txtTruckID.Text, out truckId) || truckId <= 0)
            {
                errorMessages.Add("Truck ID must be a valid integer greater than zero.");
                isValid = false;
            }

            // Validate Date Measured
            if (!DateTime.TryParse(dateTimePicker1.Text, out dateMeasured) || dateMeasured > DateTime.Now)
            {
                errorMessages.Add("Date measured must be a valid date and cannot be in the future.");
                isValid = false;
            }

            // Validate Gross Weight
            if (!decimal.TryParse(txtGrossWeight.Text, out grossWeight) || grossWeight <= 0)
            {
                errorMessages.Add("Gross weight must be a valid positive number.");
                isValid = false;
            }

            // Validate Tare Weight
            if (!decimal.TryParse(txtTareWeight.Text, out tareWeight) || tareWeight <= 0)
            {
                errorMessages.Add("Tare weight must be a valid positive number.");
                isValid = false;
            }
            else if (tareWeight > grossWeight)
            {
                errorMessages.Add("Tare weight cannot be more than gross weight.");
                isValid = false;
            }

            // Display error messages
            if (!isValid)
            {
                lblError.Text = string.Join("\n", errorMessages);
            }

            return isValid;
        }
        private void AddRecord()
        {
            // Add validated record to list
            int recordId = int.Parse(txtRecordID.Text);
            int truckId = int.Parse(txtTruckID.Text);
            DateTime dateMeasured = DateTime.Parse(dateTimePicker1.Text);
            decimal grossWeight = decimal.Parse(txtGrossWeight.Text);
            decimal tareWeight = decimal.Parse(txtTareWeight.Text);

            TruckWeightRecord record = new TruckWeightRecord(recordId, truckId, dateMeasured, grossWeight, tareWeight);
            records.Add(record);

            // Clear input fields
            ClearInputFields();
        }

        private void DisplayRecords()
        {
            // Display records in rich text box
            richTextBoxRecords.Clear();
            foreach (var record in records)
            {
                richTextBoxRecords.AppendText($"{record.RecordId}, {record.TruckId}, {record.DateMeasured}, {record.GrossWeight}, {record.TareWeight}\n");
            }
        }

        private void DisplayOverweightTrucks()
        {
            // Display trucks with gross weight > 65000 kg
            richTextBoxRecords.Clear();
            foreach (var record in records)
            {
                if (record.GrossWeight > 65000)
                {
                    richTextBoxRecords.AppendText($"{record.RecordId}, {record.TruckId}, {record.DateMeasured}, {record.GrossWeight}, {record.TareWeight}\n");
                }
            }
        }

        private void ClearInputFields()
        {
            // Clear input fields after adding record
            txtRecordID.Clear();
            txtTruckID.Clear();
            dateTimePicker1.Value = DateTime.Now;
            txtGrossWeight.Clear();
            txtTareWeight.Clear();
        }
    }
}