Console.Write("Enter your age:");
string response = System.Console.ReadLine();
int age = int.Parse(response);

string output = age >= 18 ? "You can vote!!" : "You're to young to vote!";

Console.WriteLine(output);
