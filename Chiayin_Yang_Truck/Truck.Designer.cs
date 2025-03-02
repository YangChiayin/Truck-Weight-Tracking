namespace Chiayin_Yang_Truck
{
    partial class Truck
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
            this.lblError = new System.Windows.Forms.Label();
            this.txtTruckID = new System.Windows.Forms.TextBox();
            this.lblTruckID = new System.Windows.Forms.Label();
            this.txtRecordID = new System.Windows.Forms.TextBox();
            this.lblRecordID = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDateMeasured = new System.Windows.Forms.Label();
            this.txtGrossWeight = new System.Windows.Forms.TextBox();
            this.lblGrossWeight = new System.Windows.Forms.Label();
            this.txtTareWeight = new System.Windows.Forms.TextBox();
            this.lblTareWeight = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.richTextBoxRecords = new System.Windows.Forms.RichTextBox();
            this.btnShowOverWeight = new System.Windows.Forms.Button();
            this.lblRecords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(42, 467);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 25);
            this.lblError.TabIndex = 0;
            // 
            // txtTruckID
            // 
            this.txtTruckID.Location = new System.Drawing.Point(207, 97);
            this.txtTruckID.Name = "txtTruckID";
            this.txtTruckID.Size = new System.Drawing.Size(222, 31);
            this.txtTruckID.TabIndex = 1;
            // 
            // lblTruckID
            // 
            this.lblTruckID.AutoSize = true;
            this.lblTruckID.Location = new System.Drawing.Point(92, 100);
            this.lblTruckID.Name = "lblTruckID";
            this.lblTruckID.Size = new System.Drawing.Size(98, 25);
            this.lblTruckID.TabIndex = 2;
            this.lblTruckID.Text = "Truck ID:";
            // 
            // txtRecordID
            // 
            this.txtRecordID.Location = new System.Drawing.Point(207, 43);
            this.txtRecordID.Name = "txtRecordID";
            this.txtRecordID.Size = new System.Drawing.Size(222, 31);
            this.txtRecordID.TabIndex = 1;
            // 
            // lblRecordID
            // 
            this.lblRecordID.AutoSize = true;
            this.lblRecordID.Location = new System.Drawing.Point(77, 43);
            this.lblRecordID.Name = "lblRecordID";
            this.lblRecordID.Size = new System.Drawing.Size(113, 25);
            this.lblRecordID.TabIndex = 2;
            this.lblRecordID.Text = "Record ID:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(207, 153);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(358, 31);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lblDateMeasured
            // 
            this.lblDateMeasured.AutoSize = true;
            this.lblDateMeasured.Location = new System.Drawing.Point(25, 158);
            this.lblDateMeasured.Name = "lblDateMeasured";
            this.lblDateMeasured.Size = new System.Drawing.Size(165, 25);
            this.lblDateMeasured.TabIndex = 2;
            this.lblDateMeasured.Text = "Date Measured:";
            // 
            // txtGrossWeight
            // 
            this.txtGrossWeight.Location = new System.Drawing.Point(207, 218);
            this.txtGrossWeight.Name = "txtGrossWeight";
            this.txtGrossWeight.Size = new System.Drawing.Size(222, 31);
            this.txtGrossWeight.TabIndex = 1;
            // 
            // lblGrossWeight
            // 
            this.lblGrossWeight.AutoSize = true;
            this.lblGrossWeight.Location = new System.Drawing.Point(42, 224);
            this.lblGrossWeight.Name = "lblGrossWeight";
            this.lblGrossWeight.Size = new System.Drawing.Size(148, 25);
            this.lblGrossWeight.TabIndex = 2;
            this.lblGrossWeight.Text = "Gross Weight:";
            // 
            // txtTareWeight
            // 
            this.txtTareWeight.Location = new System.Drawing.Point(207, 274);
            this.txtTareWeight.Name = "txtTareWeight";
            this.txtTareWeight.Size = new System.Drawing.Size(222, 31);
            this.txtTareWeight.TabIndex = 1;
            // 
            // lblTareWeight
            // 
            this.lblTareWeight.AutoSize = true;
            this.lblTareWeight.Location = new System.Drawing.Point(51, 280);
            this.lblTareWeight.Name = "lblTareWeight";
            this.lblTareWeight.Size = new System.Drawing.Size(135, 25);
            this.lblTareWeight.TabIndex = 2;
            this.lblTareWeight.Text = "Tare Weight:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(64, 368);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 52);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // richTextBoxRecords
            // 
            this.richTextBoxRecords.Location = new System.Drawing.Point(643, 68);
            this.richTextBoxRecords.Name = "richTextBoxRecords";
            this.richTextBoxRecords.Size = new System.Drawing.Size(485, 424);
            this.richTextBoxRecords.TabIndex = 5;
            this.richTextBoxRecords.Text = "";
            // 
            // btnShowOverWeight
            // 
            this.btnShowOverWeight.Location = new System.Drawing.Point(207, 368);
            this.btnShowOverWeight.Name = "btnShowOverWeight";
            this.btnShowOverWeight.Size = new System.Drawing.Size(215, 52);
            this.btnShowOverWeight.TabIndex = 4;
            this.btnShowOverWeight.Text = "Show Over Weight";
            this.btnShowOverWeight.UseVisualStyleBackColor = true;
            this.btnShowOverWeight.Click += new System.EventHandler(this.btnShowOverWeight_Click);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Location = new System.Drawing.Point(638, 43);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(98, 25);
            this.lblRecords.TabIndex = 2;
            this.lblRecords.Text = "Records:";
            // 
            // Truck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 674);
            this.Controls.Add(this.richTextBoxRecords);
            this.Controls.Add(this.btnShowOverWeight);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblRecordID);
            this.Controls.Add(this.lblDateMeasured);
            this.Controls.Add(this.lblTareWeight);
            this.Controls.Add(this.lblGrossWeight);
            this.Controls.Add(this.lblTruckID);
            this.Controls.Add(this.txtRecordID);
            this.Controls.Add(this.txtTareWeight);
            this.Controls.Add(this.txtGrossWeight);
            this.Controls.Add(this.txtTruckID);
            this.Controls.Add(this.lblError);
            this.Name = "Truck";
            this.Text = "Truck";
            this.Load += new System.EventHandler(this.Truck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtTruckID;
        private System.Windows.Forms.Label lblTruckID;
        private System.Windows.Forms.TextBox txtRecordID;
        private System.Windows.Forms.Label lblRecordID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDateMeasured;
        private System.Windows.Forms.TextBox txtGrossWeight;
        private System.Windows.Forms.Label lblGrossWeight;
        private System.Windows.Forms.TextBox txtTareWeight;
        private System.Windows.Forms.Label lblTareWeight;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox richTextBoxRecords;
        private System.Windows.Forms.Button btnShowOverWeight;
        private System.Windows.Forms.Label lblRecords;
    }
}

