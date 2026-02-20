using DesignPatternChallenge.Domain.Interfaces;
 
namespace DesignPatternChallenge.Domain.Notifications;

public class WhatsAppNotification : INotification
{
    public bool UseTemplate { get; set; }

    public void Send(string recipient, string title, string message)
    {
        this.UseTemplate = true;

        Console.WriteLine($"💬 WhatsApp enviado para {recipient}");
        Console.WriteLine($"   Mensagem: {message}");
    }
}