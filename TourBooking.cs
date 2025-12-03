using System;

namespace Week6workshop
{
    internal class TourBooking
    {
        public string CustomerName { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
        public double Price { get; set; }
        public int DurationInDay { get; set; }
        public bool IsInternational { get; set; }

        public override string ToString()
            => $"{CustomerName} | {Destination} | Rs. {Price} | {DurationInDay} day(s) | {(IsInternational ? "International" : "Domestic")}";
    }
}