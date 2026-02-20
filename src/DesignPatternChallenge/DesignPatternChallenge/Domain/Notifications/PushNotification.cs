using DesignPatternChallenge.Domain.Interfaces;

namespace DesignPatternChallenge.Domain.Notifications;

public class PushNotification : INotification
{
    public int Badge { get; set; }

    public void Send(string recipient, string title, string message)
    {
        this.Badge = 1;

        Console.WriteLine($"🔔 Push enviado para {recipient}");
        Console.WriteLine($"   Título: {title}");
        Console.WriteLine($"   Mensagem: {message}");
    }
}