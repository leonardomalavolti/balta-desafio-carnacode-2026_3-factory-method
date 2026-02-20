namespace DesignPatternChallenge.Domain.Interfaces;
public interface INotification
{
    void Send(string recipient, string title, string message);
}
