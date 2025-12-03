using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using static Week6workshop.Program;

namespace Week6workshop
{
    public class Program
    {

        ////  Task 2: Delegate for arithmetic operations
        public delegate int Calculate(int num1, int num2);
        // Methods for arithmetic operations
        public static int Add(int num1, int num2) => num1 + num2;
        public static int Subtract(int num1, int num2) => num1 - num2;
        

        // Delegate for discount strategies
        public delegate double DiscountStrategy(double price);
        // Methods for discount strategies
        public static double SeasonalDiscount(double price) => price * 0.8;
        public static double FestivalDiscount(double price) => price * 0.9;
        public static double NoDiscount(double price) => price;



        //Task 2.1: Method to calculate final selling price using a discount strategy
        public static double CalculateFinalPrice(double originalPrice, DiscountStrategy ds) => ds(originalPrice);



        //// Task 3: Built-in Delegates
        public static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            foreach (var n in numbers)
            {
                if (condition(n))
                {
                    Console.WriteLine(n);
                }
            }
        }



        public static void Main(string[] args)
        {

            ////Task 1: Expression Bodied Members
            //Rectangle rect = new Rectangle();
            //rect.Length = 5.0;
            //rect.Breadth = 3.0;
            //Console.WriteLine($"Area: {rect.Area()}");
            //Console.WriteLine($"Perimeter: {rect.Perimeter()}");


            ////Task 2: Custom Delegate
            //// Using Calculate delegate for arithmetic operations
            //// object of delegate
            //Calculate cal;
            //cal = Add;
            //Console.WriteLine($"Addition: {cal(10, 5)}");
            //cal = Subtract;
            //Console.WriteLine($"Subtraction: {cal(10, 5)}");


            //// Using DicountStrategy delegate for discount strategies
            //// object of delegate
            //DicountStrategy discount;
            //discount = SeasonalDiscount;
            //Console.WriteLine("Seasonal Discount on Rs100 " + discount(100));
            //discount = FestivalDiscount;
            //Console.WriteLine("Festival Discount on Rs100 " + discount(100));
            //discount = NoDiscount;
            //Console.WriteLine("No Discount on Rs100 " + discount(100));



            //// Task 2.1: Custom Delegate
            //Calculate a = Add;
            //Console.WriteLine(a(1, 2));
            //Calculate b = Subtract;
            //Console.WriteLine(b(2, 3));

            //double FestivalPrice = CalculateFinalPrice(1200, FestivalDiscount);
            //Console.WriteLine(FestivalPrice);

            //double SeasonalPrice = CalculateFinalPrice(1200, SeasonalDiscount);
            //Console.WriteLine(SeasonalPrice);

            //double realPrice = CalculateFinalPrice(1200, NoDiscount);
            //Console.WriteLine(realPrice);


            //// Task 3: Built-in Delegates
            //int[] nums = { 2, 5, 12, 8, 15, 20 };

            //ProcessNumbers(nums, n => n % 2 == 0);
            //Console.WriteLine("num 2");

            //ProcessNumbers(nums, n => n > 10);


            //// Task 4: LINQ Basics 
            //var numbers = new List<int> { 2, 4, 6, 8, 10 };
            //var squaredNumbers = numbers.Select(n => n * n).ToList();

            //Console.WriteLine("Squared Numbers:");
            //squaredNumbers.ForEach(n => Console.WriteLine(n));

            //var books = new List<Book>
            //{
            //new Book { Title = "C# Ko Suruwat", Price = 900 },
            //new Book { Title = "Advanced C# Techniques", Price = 1800 },
            //new Book { Title = "LINQ Mahayatra", Price = 1400 },
            //new Book { Title = "SQL Ko Bhumika", Price = 700 }
            //};

            //var premiumBooks = books.Where(b => b.Price > 1000).ToList();

            //Console.WriteLine("\nPremium Books (Price > 1000):");
            //premiumBooks.ForEach(b => Console.WriteLine($"{b.Title} - Rs. {b.Price}"));

            //var students = new List<Student>
            //{
            //new Student { Name = "Aashish" },
            //new Student { Name = "Bimal" },
            //new Student { Name = "Chirag" },
            //new Student { Name = "Deepak" },
            //new Student { Name = "Elina" },
            //new Student { Name = "Gita" },
            //new Student { Name = "Hari" },
            //new Student { Name = "Ishwor" },
            //new Student { Name = "Jyoti" },
            //new Student { Name = "Kiran" }
            //};

            //var sortedStudents = students.OrderBy(s => s.Name).ToList();

            //Console.WriteLine("\nAAA Scholarship Students (Alphabetically Sorted):");
            //sortedStudents.ForEach(s => Console.WriteLine(s.Name));


            //// Task 5 : LINQ Continued.. 
            //var cashierSales = new List<CashierSales>
            //{
            //    new CashierSales { CashierName = "Ramesh", SalesAmount = 6500 },
            //    new CashierSales { CashierName = "Saraswati", SalesAmount = 8200 },
            //    new CashierSales { CashierName = "Hari Bahadur", SalesAmount = 5900 },
            //    new CashierSales { CashierName = "Goma", SalesAmount = 4700 }
            //};

            //int totalCashiers = cashierSales.Count();
            //double totalSales = cashierSales.Sum(c => c.SalesAmount);
            //double highestSale = cashierSales.Max(c => c.SalesAmount);
            //double lowestSale = cashierSales.Min(c => c.SalesAmount);
            //double averageSale = cashierSales.Average(c => c.SalesAmount);

            //Console.WriteLine("==== Aggregation Result ====");
            //Console.WriteLine($"Total Cashiers: {totalCashiers}");
            //Console.WriteLine($"Total Sales: Rs. {totalSales}");
            //Console.WriteLine($"Highest Sale: Rs. {highestSale}");
            //Console.WriteLine($"Lowest Sale: Rs. {lowestSale}");
            //Console.WriteLine($"Average Sale: Rs. {averageSale}");



            //var applicants = new List<Applicant>
            //{
            //    new Applicant { Name = "Prakash", Age = 22 },
            //    new Applicant { Name = "Sangita", Age = 17 },
            //    new Applicant { Name = "Kamal", Age = 19 },
            //    new Applicant { Name = "Bina", Age = 20 }
            //};

            //bool anyUnder18 = applicants.Any(a => a.Age < 18);
            //bool allAbove16 = applicants.All(a => a.Age > 16);

            //Console.WriteLine("\n==== Quantifier Result ====");
            //Console.WriteLine($"Any applicant under 18? {anyUnder18}");
            //Console.WriteLine($"Are all applicants above 16? {allAbove16}");



            //var songs = new List<Music>
            //{
            //    new Music { Title = "Suruwaat", DurationSeconds = 130 },
            //    new Music { Title = "Maya Ko Geet", DurationSeconds = 260 },
            //    new Music { Title = "Nepali Pop Beat", DurationSeconds = 310 },
            //    new Music { Title = "Antim Dhun", DurationSeconds = 520 }
            //};

            //var firstSong = songs.First();
            //var lastSong = songs.Last();

            //var firstAbove4Min = songs.First(s => s.DurationSeconds > 240);

            //var firstAbove10Min = songs.FirstOrDefault(s => s.DurationSeconds > 600);

            //Console.WriteLine($"First Song: {firstSong.Title}");
            //Console.WriteLine($"Last Song: {lastSong.Title}");
            //Console.WriteLine($"First Song > 4 min: {firstAbove4Min.Title}");

            //if (firstAbove10Min == null)
            //    Console.WriteLine("No song found longer than 10 minutes (Safe Result: null)");
            //else
            //    Console.WriteLine($"Song longer than 10 minutes: {firstAbove10Min.Title}");

            // Task 6 : LINQ Continued..    
            
            // Sample data: tour bookings
            var bookings = new List<TourBooking>
            {
                new TourBooking { CustomerName = "Anita", Destination = "Kathmandu - Lumbini", Price = 8500, DurationInDay = 3, IsInternational = false },
                new TourBooking { CustomerName = "Rohan", Destination = "Pokhara Adventure", Price = 12000, DurationInDay = 5, IsInternational = false },
                new TourBooking { CustomerName = "Mei", Destination = "Bhutan Cultural Tour", Price = 22000, DurationInDay = 7, IsInternational = true },
                new TourBooking { CustomerName = "Samir", Destination = "Chitwan Safari", Price = 15000, DurationInDay = 4, IsInternational = false },
                new TourBooking { CustomerName = "Laila", Destination = "Everest Base Camp", Price = 45000, DurationInDay = 12, IsInternational = true },
                new TourBooking { CustomerName = "Priya", Destination = "Pokhara Lakeside", Price = 10500, DurationInDay = 6, IsInternational = false }
            };

            // Filter requirement:
            // - Price > 10,000
            // - DurationInDay > 4

            // 1) Method syntax (fluent LINQ)
            var filteredMethod = bookings
                .Where(b => b.Price > 10000 && b.DurationInDay > 4)
                .ToList();

            Console.WriteLine("=== Filtered Tours (Method syntax) ===");
            foreach (var t in filteredMethod)
                Console.WriteLine(t);

            // Optional summary
            Console.WriteLine($"Count: {filteredMethod.Count}");
            if (filteredMethod.Any())
                Console.WriteLine($"Average Price: Rs. {filteredMethod.Average(b => b.Price):F2}");

            Console.WriteLine();

            // 2) Query expression syntax
            var filteredQuery = (from b in bookings
                                 where b.Price > 10000 && b.DurationInDay > 4
                                 select b).ToList();

            Console.WriteLine("=== Filtered Tours (Query expression syntax) ===");
            foreach (var t in filteredQuery)
                Console.WriteLine(t);

            Console.WriteLine($"Count: {filteredQuery.Count}");
            if (filteredQuery.Any())
                Console.WriteLine($"Average Price: Rs. {filteredQuery.Average(b => b.Price):F2}");


            Console.WriteLine();
            // --- New: project filtered list to summary DTO, sort by Category (Domestic first) then by Price ---

            var summaryList = filteredMethod
                .Select(b => new TourSummary
                {
                    CustomName = $"{b.CustomerName} ({b.DurationInDay}d)",
                    Destination = b.Destination,
                    Category = b.IsInternational ? "International" : "Domestic",
                    Price = b.Price
                })
                // Ensure Domestic appears first, then International; then sort by Price ascending
                .OrderBy(s => s.Category != "Domestic") // Domestic (false) comes before International (true)
                .ThenBy(s => s.Price)
                .ToList();

            Console.WriteLine("=== Projected & Sorted Tour Summaries ===");
            Console.WriteLine($"{"Name",-20} | {"Destination",-30} | {"Category",-11} | {"Price",12}");
            Console.WriteLine(new string('-', 82));
            foreach (var s in summaryList)
            {
                Console.WriteLine(s.ToString());
            }

            Console.WriteLine();
            Console.WriteLine($"Total summaries: {summaryList.Count}");
        }
    }
}
