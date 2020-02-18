using Entities;
using System;

namespace Services
{
    public class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private BrazilTexService _brazilTexService = new BrazilTexService();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basciPayment = 0.0;

            if (duration.TotalHours <= 12.0)
            {
                basciPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basciPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTexService.Tax(basciPayment);

            carRental.Invoice = new Invoice(basciPayment, tax);
        }
    }
}
