/* Mini Project - Student Check
 * 
 * Plan and build a Console application that asks a user for their name and 
 * their age. If their name is Bob or Sue, address them as Professor. 
 * If the person is under 21, recommend they wait X years to start this class
 * 
 */

//Input Data
Console.WriteLine("Welcome to the Student Check Console Application");
Console.WriteLine("_________________________________________________");
Console.WriteLine();

Console.Write("What is your FIRST NAME ?: ");
string? firstName = Console.ReadLine();

Console.Write("How old are you?: ");
string? ageString = Console.ReadLine();

int age = int.Parse(ageString);

//Switch case
switch (firstName.ToLower())
{
    case "bob" or "sue":
        Console.WriteLine("Hello Professor!");
        break;
    default:
        Console.WriteLine("Hello Student!");
        break;
}

//If Age, else if
if (age >= 21)
{
    Console.WriteLine($"You are {age} years old!");
    Console.WriteLine("You are old enough to enroll in this class");
}
else if (age == 20)
{
    int newAge = 21 - age;
    Console.WriteLine($"You are only {age} years old!");
    Console.WriteLine($"We recommend you wait {newAge} year to enroll");
}
else
{
    int newAge = 21 - age;
    Console.WriteLine($"You are only {age} years old!");
    Console.WriteLine($"We recommend you wait {newAge} years to enroll");
}

//close application
Console.WriteLine();
Console.WriteLine();
Console.Write("Press ENTER to exit program: ");
Console.ReadLine()