using DesignPatternChallenge.Application.Factories;
using DesignPatternChallenge.Domain.Enums;

namespace DesignPatternChallenge.Application.Services;

public class NotificationManager
{
    public void SendOrderConfirmation(string recipient, string orderNumber, NotificationType type)
    {
        var notification = NotificationFactory.Create(type);

        var title = "Confirmação de Pedido";
        var message = $"Seu pedido {orderNumber} foi confirmado!";

        notification.Send(recipient, title, message);
    }

    public void SendShippingUpdate(string recipient, string trackingCode, NotificationType type)
    {
        var notification = NotificationFactory.Create(type);

        var title = "Pedido Enviado";
        var message = $"Código de rastreamento: {trackingCode}";

        notification.Send(recipient, title, message);
    }

    public void SendPaymentReminder(string recipient, decimal amount, NotificationType type)
    {
        var notification = NotificationFactory.Create(type);

        var title = "Lembrete de Pagamento";
        var message = $"Pagamento pendente: R$ {amount:N2}";

        notification.Send(recipient, title, message);
    }
}