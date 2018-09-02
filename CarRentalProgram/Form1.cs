using System;
using System.Linq;
using System.Windows.Forms;

namespace CarRentalProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SetTimeFormat();
        }

        private void SetTimeFormat()
        {
            TimeOfRentalPicker.Format = DateTimePickerFormat.Custom;
            TimeOfRentalPicker.CustomFormat = "dd-MM-yyyy HH:mm";

            TimeOfReturnPicker.Format = DateTimePickerFormat.Custom;
            TimeOfReturnPicker.CustomFormat = "dd-MM-yyyy HH:mm";

            DateOfBirthPicker.Format = DateTimePickerFormat.Custom;
            DateOfBirthPicker.CustomFormat = "yyyy-MM-dd";            
        }

        private void RentCarButton_Click(object sender, EventArgs e)
        {
            if(CarTypePicker.SelectedItem == null)
            {
                MessageBox.Show("Please select a cartype!");
            }
            int mileage = Register.GetCarMileage(RentCarMileage.Text);
            Register.CreateNewRegistration(CarTypePicker.SelectedItem.ToString(), TimeOfRentalPicker.Value, DateOfBirthPicker.Value, mileage);
            string bookingNumber = Register.Registrations.Last().Bookingnumber;
        }

        private void TurnInCarButton_Click(object sender, EventArgs e)
        {
            string bookingNumber = BookingNumberTextBox.Text;
            DateTime returnDate = TimeOfReturnPicker.Value;
            int mileage = Register.GetCarMileage(RentCarMileage.Text);
            Return.ReturnCar(bookingNumber, returnDate, mileage);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }



        private void BookingNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RentedCarsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
