// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//rakendus küsib kasutaja vanust
//kui noorem kui 13 siis pahasti
//muul juhul
//"you are too young to use instagram"
//konsoolis kuvatakse "welcome to instagram"

Console.WriteLine("Please enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

bool IsAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {IsAgeNumber}. user is {userAgeNum} old.");


if (IsAgeNumber)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram!");
    }

else
    {
        Console.WriteLine("You are too young to use Instagram.");
    }
}
else
{
    Console.WriteLine("Could not read your age.");
}
