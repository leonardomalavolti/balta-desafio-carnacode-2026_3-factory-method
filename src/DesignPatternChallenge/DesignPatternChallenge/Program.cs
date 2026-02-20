using DesignPatternChallenge.Application.Services;
using DesignPatternChallenge.Domain.Enums;

Console.WriteLine("=== Sistema de Notificações ===\n");

var manager = new NotificationManager();

manager.SendOrderConfirmation("cliente@email.com", "12345", NotificationType.Email);
Console.WriteLine();

manager.SendOrderConfirmation("+5511999999999", "12346", NotificationType.Sms);
Console.WriteLine();

manager.SendShippingUpdate("device-token-abc123", "BR123456789", NotificationType.Push);
Console.WriteLine();

manager.SendPaymentReminder("+5511888888888", 150.00m, NotificationType.WhatsApp);

Console.ReadKey();