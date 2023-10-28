// Se
// e https://aka.ms/new-console-template for more information



using Microsoft.VisualBasic;

DateTime today = DateTime.Today;
string userDate = "";
do
{
    Console.WriteLine("Which Date? (or 'exit')");
    userDate = Console.ReadLine();
    if (userDate == "exit")
    {
        break;
    }
    DateTime parsedDate;
    TimeSpan timeSpan;
    if (DateTime.TryParse(userDate, out parsedDate))
    {
        if (parsedDate < today)
        {
            timeSpan = today - parsedDate;
            Console.WriteLine($"That date went by {timeSpan} days ago!");
        }
        else if (parsedDate > today)
        {
            timeSpan = parsedDate - today;
            Console.WriteLine($"That date will be in {timeSpan} days!");
        }
        else
        {
            Console.WriteLine("That date is today!");
        }
    }
    else
    {
        Console.WriteLine("That doesn't seem to be a valid date");
    }
} while (userDate != "exit");
