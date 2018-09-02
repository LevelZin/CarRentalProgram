namespace CarRentalProgram
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RentCarButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CarTypePicker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.TimeOfRentalPicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TurnInCarButton = new System.Windows.Forms.Button();
            this.CurrentMileageTextBox = new System.Windows.Forms.TextBox();
            this.BookingNumberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TimeOfReturnPicker = new System.Windows.Forms.DateTimePicker();
            this.RentCarMileage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RentCarMileage);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.RentCarButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CarTypePicker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DateOfBirthPicker);
            this.groupBox1.Controls.Add(this.TimeOfRentalPicker);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 278);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rent A Car";
            // 
            // RentCarButton
            // 
            this.RentCarButton.Location = new System.Drawing.Point(215, 249);
            this.RentCarButton.Name = "RentCarButton";
            this.RentCarButton.Size = new System.Drawing.Size(75, 23);
            this.RentCarButton.TabIndex = 8;
            this.RentCarButton.Text = "Rent";
            this.RentCarButton.UseVisualStyleBackColor = true;
            this.RentCarButton.Click += new System.EventHandler(this.RentCarButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date of birth:";
            // 
            // CarTypePicker
            // 
            this.CarTypePicker.FormattingEnabled = true;
            this.CarTypePicker.Items.AddRange(new object[] {
            "SmallCar",
            "Van",
            "MiniBus"});
            this.CarTypePicker.Location = new System.Drawing.Point(51, 53);
            this.CarTypePicker.Name = "CarTypePicker";
            this.CarTypePicker.Size = new System.Drawing.Size(200, 21);
            this.CarTypePicker.TabIndex = 4;
            this.CarTypePicker.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select car type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Time of rental:";
            // 
            // DateOfBirthPicker
            // 
            this.DateOfBirthPicker.Location = new System.Drawing.Point(51, 197);
            this.DateOfBirthPicker.Name = "DateOfBirthPicker";
            this.DateOfBirthPicker.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirthPicker.TabIndex = 6;
            // 
            // TimeOfRentalPicker
            // 
            this.TimeOfRentalPicker.CustomFormat = "";
            this.TimeOfRentalPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeOfRentalPicker.Location = new System.Drawing.Point(51, 150);
            this.TimeOfRentalPicker.MaxDate = new System.DateTime(2018, 9, 2, 14, 13, 56, 0);
            this.TimeOfRentalPicker.Name = "TimeOfRentalPicker";
            this.TimeOfRentalPicker.Size = new System.Drawing.Size(200, 20);
            this.TimeOfRentalPicker.TabIndex = 1;
            this.TimeOfRentalPicker.Value = new System.DateTime(2018, 9, 2, 0, 0, 0, 0);
            this.TimeOfRentalPicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TurnInCarButton);
            this.groupBox2.Controls.Add(this.CurrentMileageTextBox);
            this.groupBox2.Controls.Add(this.BookingNumberTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TimeOfReturnPicker);
            this.groupBox2.Location = new System.Drawing.Point(409, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 278);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Return Car";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TurnInCarButton
            // 
            this.TurnInCarButton.Location = new System.Drawing.Point(215, 249);
            this.TurnInCarButton.Name = "TurnInCarButton";
            this.TurnInCarButton.Size = new System.Drawing.Size(75, 23);
            this.TurnInCarButton.TabIndex = 9;
            this.TurnInCarButton.Text = "Turn in";
            this.TurnInCarButton.UseVisualStyleBackColor = true;
            this.TurnInCarButton.Click += new System.EventHandler(this.TurnInCarButton_Click);
            // 
            // CurrentMileageTextBox
            // 
            this.CurrentMileageTextBox.Location = new System.Drawing.Point(51, 198);
            this.CurrentMileageTextBox.Name = "CurrentMileageTextBox";
            this.CurrentMileageTextBox.Size = new System.Drawing.Size(200, 20);
            this.CurrentMileageTextBox.TabIndex = 9;
            // 
            // BookingNumberTextBox
            // 
            this.BookingNumberTextBox.Location = new System.Drawing.Point(51, 69);
            this.BookingNumberTextBox.Name = "BookingNumberTextBox";
            this.BookingNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.BookingNumberTextBox.TabIndex = 8;
            this.BookingNumberTextBox.TextChanged += new System.EventHandler(this.BookingNumberTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Current mileage:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Booking number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Time of return:";
            // 
            // TimeOfReturnPicker
            // 
            this.TimeOfReturnPicker.CustomFormat = "";
            this.TimeOfReturnPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeOfReturnPicker.Location = new System.Drawing.Point(51, 128);
            this.TimeOfReturnPicker.MaxDate = new System.DateTime(2018, 9, 2, 14, 15, 7, 0);
            this.TimeOfReturnPicker.Name = "TimeOfReturnPicker";
            this.TimeOfReturnPicker.Size = new System.Drawing.Size(200, 20);
            this.TimeOfReturnPicker.TabIndex = 1;
            this.TimeOfReturnPicker.Value = new System.DateTime(2018, 9, 2, 0, 0, 0, 0);
            // 
            // RentCarMileage
            // 
            this.RentCarMileage.Location = new System.Drawing.Point(51, 104);
            this.RentCarMileage.Name = "RentCarMileage";
            this.RentCarMileage.Size = new System.Drawing.Size(200, 20);
            this.RentCarMileage.TabIndex = 11;
            this.RentCarMileage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Current mileage:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CarTypePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateOfBirthPicker;
        private System.Windows.Forms.DateTimePicker TimeOfRentalPicker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker TimeOfReturnPicker;
        private System.Windows.Forms.TextBox CurrentMileageTextBox;
        private System.Windows.Forms.TextBox BookingNumberTextBox;
        private System.Windows.Forms.Button RentCarButton;
        private System.Windows.Forms.Button TurnInCarButton;
        private System.Windows.Forms.TextBox RentCarMileage;
        private System.Windows.Forms.Label label7;
    }
}

