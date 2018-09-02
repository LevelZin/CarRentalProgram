using System;
using System.Collections.Generic;

namespace CarRentalProgram
{
    public class Register
    {
        public static List<Registration> Registrations = new List<Registration>();

        public static void CreateNewRegistration(string category, DateTime rentalDate, DateTime dateOfBirth, int mileage)
        {
            Car car = new Car();
            car.Category = category;
            car.RentalDate = rentalDate;
            car.Milage = mileage;

            Registration newRegistration = new Registration()
            {
                Bookingnumber = CreateNewBookingNumber(),
                DateOfBirth = dateOfBirth,
                RegisteredCar = car
            };

            Registrations.Add(newRegistration);
        }

        public static int GetCarMileage(string value)
        {
            return Convert.ToInt32(value);
        }

        public static string CreateNewBookingNumber()
        {
            return (1 + Registrations.Count).ToString();
        }
    }
}
