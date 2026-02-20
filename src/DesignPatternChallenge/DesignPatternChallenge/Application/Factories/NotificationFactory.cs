using DesignPatternChallenge.Domain.Enums;
using DesignPatternChallenge.Domain.Interfaces;
using DesignPatternChallenge.Domain.Notifications;

namespace DesignPatternChallenge.Application.Factories;

public static class NotificationFactory
{
    public static INotification Create(NotificationType type)
    {
        return type switch
        {
            NotificationType.Email => new EmailNotification(),
            NotificationType.Sms => new SmsNotification(),
            NotificationType.Push => new PushNotification(),
            NotificationType.WhatsApp => new WhatsAppNotification(),
            _ => throw new ArgumentException("Tipo não suportado")
        };
    }
}
