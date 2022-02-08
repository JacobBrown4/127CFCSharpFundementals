using Classes;

Donut doug = new Donut("Jelly Filled", true, false);
doug.SetDonutType("Glazed");
doug.Filling = "Strawberry Jam";
doug.Price = 2.99;
Console.WriteLine(doug.GetDonutType());
Console.WriteLine(doug.Filling);

Donut derrick = new Donut("Chocolate Eclair", false, true, 3.99);
Console.WriteLine(derrick.Price);

Greeter greet = new Greeter();
Console.WriteLine(greet.SayHello("Jacob"));
Console.WriteLine(greet.SayHello());


greet.PrintHello("Alex");
greet.PrintHello("Tony");

greet.PrintRandomGreeting();

Calculator calculator = new Calculator();
Console.WriteLine(calculator.Age(new DateTime(1991,05,04)));

namespace Classes
{
    class Donut
    {
        // Field
        private string donutType;
        // Constructors
        // public Donut(){} <- Implicit constructor
        // v Defined constructor, implicit constructor removed
        public Donut(string type, bool sprinkles, bool icing)
        {
            donutType = type;
            IsSprinkled = sprinkles;
            HasIcing = icing;
        }
        // Same as above but a different order, so it's a different signature
        public Donut(bool sprinkles, string type, bool icing)
        {
            donutType = type;
            IsSprinkled = sprinkles;
            HasIcing = icing;
        }
        public Donut(string type, bool sprinkles, bool icing, double price)
        {
            donutType = type;
            IsSprinkled = sprinkles;
            HasIcing = icing;
            Price = price;
        }

        // Methods V
        // 1    2       3
        public string GetDonutType()
        {
            // 4
            return donutType;
        }

        // 1 Access modifier, private (only accessible within the class),public (available everywhere) etc 
        // 2 Return type, when I run the method, what I get back
        // 3 Method signature, Name(Parameters)
        // 4 The body and the return
        public void SetDonutType(string type)
        {
            donutType = type;
        }
        // Properties
        public string Filling { get; set; }
        public bool IsSprinkled { get; set; }
        public bool HasIcing { get; set; }
        public double Price { get; set; }
    }

    class Greeter
    {
        Random _random = new Random();
        public string SayHello()
        {
            return "Hello!";
        }
        // Overloaded methods, same names but different parameters, SO: different signatures
        public string SayHello(string name)
        {
            return $"Hello {name}!";
        }

        public void PrintHello(string name)
        {
            Console.WriteLine($"Greetings {name}!");
        }

        public void PrintRandomGreeting()
        {
            // Lists/arrays/eunumerable  index at zero   0      1       2    3     4                  5
            string[] availableGreeting = new string[] { "Hello", "Howdy", "Sup", "Yo", "Good day to yous", "Wazzzup" };
            int randomNumber = _random.Next(0, availableGreeting.Length);
            string randomGreeting = availableGreeting.ElementAt(randomNumber);
            Console.WriteLine(randomGreeting);
        }
    }

    class Calculator
    {
        public int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
        public int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }
        public int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }
        public int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public int Remainder(int numOne, int numTwo)
        {
            return numOne % numTwo;
        }

        public int Age(DateTime birthdate)
        {
            TimeSpan ageSpan = DateTime.Now - birthdate;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }
    }

}





