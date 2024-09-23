using System.Numerics;
using System.Runtime.InteropServices;

Console.WriteLine("You walk down a dirt path, hungry and tired");
Console.WriteLine("you look up at rustic orange sunset and see billowing smoke in the distance");
Console.WriteLine("\"There must be civilization near, just a bit further\"");
Console.WriteLine("you think to yourself");
Console.WriteLine("finally after lord knows how long you make it to the orgin of the smoke, it's a random fire?");

string username = "Player1";

// Prompt for user input
Console.WriteLine("???:\"Hey you there! Do you know where you are?!\"");

// Console.ReadLine lets us read the user's text input from the console
string input = Console.ReadLine();

// Repeat what was said to the user
Console.Write("???: Did you really just say \"");
Console.Write(input);
Console.Write("\"");

string input2 = Console.ReadLine();

Console.ReadLine();
Console.Write(input2);
Console.Write("\"");
Console.WriteLine("???:\"Well I'll be darned, I never would've expected a tourist around these parts\"");

//im not a tourist here
Console.WriteLine("You:\"I'm not a tourist, I'm just lost\"");

// Here is a more practical example using parsing
// Let's ask the user their age and deduce their birth year
// We need to convert the input string as a number to do math with it
Console.Write("???:\"lost? since when? (month)\"");
// Directly convert the user input string into an int
string input3 = Console.ReadLine();
int january = 1;
int febuary = 2;
int march = 3;
int april = 4;
int may = 5;
int june = 6;
int july = 7;
int august = 8;
int september = 9;
int october = 10;
int november = 11;
int december = 12;

int usertime = int.Parse(Console.ReadLine());

// Let's get the current day
int currentday = DateTime.Now.Month;
// Let's do some math to figure out the user's birth year
int arrival = currentday - usertime;

// Finally, we can output a response
Console.WriteLine($"So you've been here for {arrival} months?");