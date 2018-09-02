using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalProgram
{
    public class Return
    {
        private static readonly double baseDayRental = 200;
        private static readonly double kmPrice = 10.50;

        public static void ReturnCar(string bookingNumber, DateTime returnedAt, int currentMileage)
        {
            var registration = Register.Registrations.Find(r => r.Bookingnumber == bookingNumber);
            int numberOfDays = NumberOfDaysRented(registration.RegisteredCar.RentalDate, returnedAt);
            int numberOfKm = NumberOfKm(registration.RegisteredCar.Milage, currentMileage);
            double cost = CalculateRentalPrice(registration.RegisteredCar, numberOfDays, numberOfDays);
            Console.WriteLine("COST: " + cost);
        }

        public static int NumberOfDaysRented(DateTime rentAt, DateTime returnedAt)
        {
            var days = returnedAt - rentAt;
            return days.Days;
        }

        public static int NumberOfKm(int oldMileage, int newMileage)
        {
            return newMileage - oldMileage;
        }

        private static double CalculateRentalPrice(Car car, int days, int km)
        {
            switch (car.Category)
            {
                case "SmallCar":
                    return baseDayRental * days;
                case "Van":
                    return baseDayRental * days * 1.2 + (kmPrice * km);
                case "MiniBus":
                    return baseDayRental * days * 1.7 + (kmPrice * km * 1.5);
                default:
                    return 0;
            }
        }
    }
}
