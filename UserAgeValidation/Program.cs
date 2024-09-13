// See https://aka.ms/new-console-template for more information


//rakendus küsib kasutaja sugu
//rakendus küsib kasutaja perekonnanime
//lähtudes kasutaja valikust rakendus tervitab järgmiselt
//"Welcome, Mr [kasutaja perekonnanimi]" / "Welcome, Ms [kasutaja perekonnanimi]

Console.WriteLine("Please select your gender (m/f)");

char userGender = Char.Parse(Console.ReadLine());
Console.WriteLine("Please enter your last name:");

string userLastName = Console.ReadLine();

if(userGender == 'm')
{
    Console.WriteLine($"Welcome, MR {userLastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, MS {userLastName}!");
}
else
{
    Console.WriteLine("Welcome!");
}

Console.WriteLine($"Welcome, {userLastName}!");


