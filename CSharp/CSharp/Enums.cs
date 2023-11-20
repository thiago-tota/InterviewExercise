namespace CSharp;

public enum MessageTypeOpt
{
    Post = 1,
    Retrieve = 2
}

public enum MessageClientOpt
{
    Facebook = 1,
    Twitter = 2
}

public static class EnumsExtension
{
    public static MessageClientOpt ToMessageClientOptEnum(this string? value)
    {
        if (!Enum.TryParse<MessageClientOpt>(value, true, out var outputResult))
        {
            throw new ArgumentOutOfRangeException($"Invalid option {value} typed.");
        }

        return outputResult;
    }

    public static MessageTypeOpt ToMessageTypeOptEnum(this string? value)
    {
        if (!Enum.TryParse<MessageTypeOpt>(value, true, out var outputResult))
        {
            throw new ArgumentOutOfRangeException($"Invalid option {value} typed.");
        }

        return outputResult;
    }
}