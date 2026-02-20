using DesignPatternChallenge.Domain.Interfaces;

namespace DesignPatternChallenge.Domain.Notifications;

public class SmsNotification : INotification
{
    public void Send(string recipient, string title, string message)
    {
        Console.WriteLine($"📱 SMS enviado para {recipient}");
        Console.WriteLine($"   Mensagem: {message}");
    }
}
