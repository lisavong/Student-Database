bool again=true;

string[] name = new string[] {"Lisa", "John", "Jack", "Lucy"};
string[] hometown = new string[] {"Chicago", "Atlanta", "Grand Rapids", "Holland"};
string[] food = new string[] {"spaghetti", "pizza", "tacos", "cheetos"};

Console.WriteLine("Hello! I have 4 students in the room");

do
{
    Console.WriteLine("Pick a number I'll tell you which student that's assigned to.");

    int index = Convert.ToInt32(Console.ReadLine());

    if (index > name.Length)
    {
        Console.WriteLine("Sorry, we don't have that many students at the moment");
        Console.WriteLine("Let's try this again");
    }// how do i get this to loop back?

    Console.WriteLine("That student is named " +name[index-1]);

    Console.WriteLine($"Would you like to know {name[index-1]}'s favorite food or hometown? ");

    string userInput = Console.ReadLine().ToLower();

    string lastFour = userInput.Substring(userInput.Length-4);
    if (lastFour=="town")
    {
        Console.WriteLine($"{name[index - 1]}'s hometown is {hometown[index - 1]}");

    }
    else if (lastFour == "food")
    {
        Console.WriteLine($"{name[index - 1]}'s favorite food is {food[index - 1]}");
    }
    else
    {
        Console.WriteLine("Sorry that isn't a valid entry");
    }

    Console.WriteLine("Would you like to know about another student (y/n)?");
    string input = Console.ReadLine();
    again=input.ToLower()=="y";
} while (again==true);

Console.WriteLine("Thanks for hanging out!");
Console.WriteLine("hit any key to exit");
Console.ReadKey();

