using System.Text;

namespace CSharp;

public static class ApplicationStart
{
    public static void Execute()
    {
        const string exitOpt = "Q";
        while (true)
        {
            try
            {
                Console.WriteLine(GetMenuText());
                var inputOpt = Console.ReadLine();

                if (inputOpt?.ToUpper() == exitOpt)
                {
                    break;
                }
                
                var client = MessageManagerFactory.GetClient(inputOpt.ToMessageClientOptEnum());
                
                Console.WriteLine("Type your message:");
                var inputMsg = Console.ReadLine();
                
                client.PostMessage($"My first post to {inputOpt}: {inputMsg}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    private static string GetMenuText()
    {
        var sb = new StringBuilder();

        sb.AppendLine("");
        sb.AppendLine("Welcome!");
        sb.AppendLine("Type one of the following options:");
        sb.AppendLine($"{(int)MessageClientOpt.Facebook} -> to post a message in Facebook;");
        sb.AppendLine($"{(int)MessageClientOpt.Twitter} -> to post a message in Twitter;");
        sb.AppendLine("Q to exit the application;");

        return sb.ToString();
    }
}