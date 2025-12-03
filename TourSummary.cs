using System;

namespace Week6workshop
{
    internal class TourSummary
    {
        public string CustomName { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public double Price { get; set; }

        public override string ToString()
            => $"{CustomName,-20} | {Destination,-30} | {Category,-11} | Rs {Price,10:N2}";
    }
}