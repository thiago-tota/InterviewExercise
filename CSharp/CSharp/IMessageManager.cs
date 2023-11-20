namespace CSharp;

public interface IMessageManager
{
    void PostMessage(string message);
    string GetMessage(int messageId);
}