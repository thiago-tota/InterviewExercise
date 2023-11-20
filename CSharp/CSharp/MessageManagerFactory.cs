namespace CSharp;

public static class MessageManagerFactory
{
    public static IMessageManager GetClient(MessageClientOpt messageManagerClient)
    {
        return messageManagerClient switch
        {
            MessageClientOpt.Facebook => new FacebookFeed(),
            MessageClientOpt.Twitter => new TwitterFeed(),
            _ => throw new ArgumentOutOfRangeException(nameof(messageManagerClient), messageManagerClient, "Invalid option.")
        };
    }
}