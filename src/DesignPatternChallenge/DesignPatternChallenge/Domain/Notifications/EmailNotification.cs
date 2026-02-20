using DesignPatternChallenge.Domain.Interfaces;

namespace DesignPatternChallenge.Domain.Notifications;

public class EmailNotification : INotification
{
    public bool IsHtml { get; set; }

    public void Send(string recipient, string title, string message)
    {
        this.IsHtml = true;

        Console.WriteLine($"📧 Email enviado para {recipient}");
        Console.WriteLine($"   Assunto: {title}");
        Console.WriteLine($"   Mensagem: {message}");
    }
}
