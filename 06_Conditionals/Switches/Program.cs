Console.WriteLine("Please give us your name!");
string name = Console.ReadLine();

string greeting = name switch 
{
    "Adam" => "Hello Adam",
    _ => "Who are you?"
};
Console.WriteLine(greeting);

switch(name)
{
    case "Adam":
    Console.WriteLine("Nice to meet you " + name);
    break;
    default:
    break;
}


Console.WriteLine("How are you feeling today on a scale or 1-5?");
string feelingRating = Console.ReadLine();

switch(feelingRating)
{
    case "5":
    Console.WriteLine("That is great to hear");
    break;
    case "4":
    Console.WriteLine("Good Stuff!!");
    break;
    case "3":
    Console.WriteLine("Hope things improve.");
    break;
    case "2":
    Console.WriteLine("Oh no, Sorry to hear that!!");
    break;
    case "1":
    Console.WriteLine("Dang, hope your days can get better soon or there is always tomorrow!");
    break;
    default:
    Console.WriteLine("Sorry, what you put in is not what we asked for trying again");
    break;
}


Console.WriteLine("How were you feeling yesterday on a scale of 1-5?");
string ratingInput = Console.ReadLine();
int yesterdayRating = int.Parse(ratingInput);

string response = yesterdayRating switch
{
    1 => "Dang. Maybe today will be better",
    2 => "Oh, Sorry to hear that.",
    3 => "Nice, sounds like a good day",
    4 => "Good stuff",
    5 => "That is wonderful to hear",
    _ => "Man you are off the charts!"

};

Console.WriteLine(response);
