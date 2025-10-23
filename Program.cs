// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Variables and Data Types
int age = 20;
string name = "Mojeed";
Console.WriteLine($"My name is {name} and I am {age} years old.");

// Taking User Inputs
Console.Write("Enter your name: ");
string userName = Console.ReadLine();
Console.Write("Enter your age: ");
int userAge = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Hello, {userName}! You are {userAge} years old.");

// Assignment 1
Console.Write("Enter your name: ");
string myname = Console.ReadLine();
Console.Write("Enter your age: ");
int myage = Convert.ToInt32(Console.ReadLine());
Console.Write("What is your hobby: ");
string hobby = Console.ReadLine();
Console.WriteLine($"Hello, {myname}! You are {myage} years old and your hobby is {hobby}.");

int num1 = 10;
int num2 = 15;
int sum = num1 + num2;
Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");

Console.Write("What is your name: ");
string yourname = Console.ReadLine();
Console.Write("What is your favorite food: ");
string food = Console.ReadLine();
Console.WriteLine($"Hello, {yourname}! Your favorite food is {food}.");