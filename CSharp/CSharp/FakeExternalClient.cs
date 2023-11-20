using Bogus;

namespace CSharp;

public static class FakeExternalClient
{
    private static readonly Faker _faker = new("en");

    public static string GetMessage(int messageId)
    {
        return $"MessageId: {messageId} -> {_faker.Lorem.Sentence()}";
    }
}