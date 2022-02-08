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
Console.WriteLine(calculator.Age(new DateTime(1991, 05, 04)));

Person me = new Person();
me.FirstName = "Jacob";
me.LastName = "Brown";
me.DateOfBirth = new DateTime(1991, 05, 04);

me.Introduction();

Person luke = new Person("Luke", "Skywalker", new DateTime(1977, 05, 25));
luke.Introduction();

// Accessing the donut property that holds an entire donut object on the luke variable
luke.Donut = derrick;

// Using the Donut classes built in methods
Console.WriteLine($"{luke.FullName} has a {luke.Donut.GetDonutType()}");

// Updating the donut in the luke Person class to have sprinkles
luke.Donut.IsSprinkled = true;


// Making a person and a donut at the same time.
Person homer = new Person("Homer","Simpson",new DateTime(1980,07,04),"Glazed donut",true,true);
homer.Introduction();
Console.WriteLine($"He loves {homer.Donut.GetDonutType()}");


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
        public string RandomGreeting()
        {
            string[] availableGreeting = new string[] { "Hello", "Howdy", "Sup", "Yo", "Good day to yous", "Wazzzup" };
            int randomNumber = _random.Next(0, availableGreeting.Length);
            string randomGreeting = availableGreeting.ElementAt(randomNumber);
            return randomGreeting;
        }
    }

    class Calculator
    {
        public int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
        public double Add(double numOne, double numTwo)
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

    class Person
    {
        public Person() { }
        public Person(string firstName, string lastName, DateTime dOB)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dOB;
        }
        // Chaining the constructors together, looks for a matching constructor for those variables, then uses it
        public Person(string firstName, string lastName, DateTime dOB, string donutType, bool isSprinkled, bool hasIcing) : this(firstName, lastName, dOB)
        {
            Donut = new Donut(donutType, isSprinkled, hasIcing, 2.99);
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Readonly property
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                // DRY style
                Calculator calc = new Calculator();
                return calc.Age(DateOfBirth);
            }
        }

        public Donut Donut { get; set; }

        public void Greet()
        {
            Greeter greeter = new Greeter();
            // semantic satiation
            greeter.PrintHello(FullName);
        }

        public void Introduction()
        {
            Greeter greeter = new Greeter();
            Console.WriteLine($"{greeter.RandomGreeting()}, my name is {FullName} and I am {Age} years old!");
        }
    }
}





