
Console.WriteLine("INFO: If you want to quit the program type the letter Q at any possible time.");

Console.WriteLine("####################");
Console.WriteLine("Who are you?");
Console.WriteLine("#1 John Smith");
Console.WriteLine("#2 Alice Johnson");
Console.WriteLine("#3 Robert Williams");
Console.WriteLine("#4 Emily Davis");
Console.WriteLine("####################");
Console.WriteLine("Please type only the position (number).");

var input = Console.ReadLine();
if (input == "Q")
{
    return;
}

Console.WriteLine("Hello John Smith");
Console.WriteLine(
    """
            ####################
            The following tasks are assigned to you:
        
            To Do: [Task A(#1), ...]
            In Progress: [Task D(#10), ...]
            Done: [Task D(#3), ...]
            ####################
        """.Trim()
);