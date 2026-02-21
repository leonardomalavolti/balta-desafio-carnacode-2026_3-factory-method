![CR-3](https://github.com/user-attachments/assets/485b7ff1-c098-40bf-93b4-00058c8729a9)

# 🥁 CarnaCode 2026 - Desafio 03 - Factory Method

Olá! Eu sou **Leonardo Malavolti Monteiro** 👋\
Este projeto faz parte da minha jornada no **CarnaCode 2026**, promovido
pelo balta.io.

Neste desafio implementei o **Factory Method** para resolver um problema
real de arquitetura em um sistema de notificações.

------------------------------------------------------------------------

## 📌 Sobre o Desafio

Uma aplicação de e-commerce precisava enviar notificações por diferentes
canais:

-   📧 Email\
-   📱 SMS\
-   🔔 Push\
-   💬 WhatsApp

A implementação inicial utilizava múltiplos `if/else` para decidir qual
classe instanciar, o que causava:

-   ❌ Violação do Open/Closed Principle\
-   ❌ Alto acoplamento\
-   ❌ Código duplicado\
-   ❌ Dificuldade para adicionar novos canais

------------------------------------------------------------------------

## 🛠️ Solução Aplicada

Foi implementado o **Factory Method** para:

-   ✅ Centralizar a criação das notificações\
-   ✅ Remover condicionais espalhadas pelo código\
-   ✅ Desacoplar o NotificationManager das classes concretas\
-   ✅ Melhorar escalabilidade\
-   ✅ Facilitar a adição de novos canais (ex: Telegram, Slack)

### Estrutura aplicada

-   INotification → Interface comum\
-   EmailNotification\
-   SmsNotification\
-   PushNotification\
-   WhatsAppNotification\
-   NotificationFactory\
-   NotificationManager

------------------------------------------------------------------------

## 📚 Aprendizados

Durante esse desafio aprimorei:

-   Aplicação prática do Factory Method\
-   Separação de responsabilidades\
-   Redução de acoplamento\
-   Aderência ao Open/Closed Principle\
-   Organização de estrutura em camadas\
-   Uso de enum para maior segurança de tipos

------------------------------------------------------------------------

## 🎭 Sobre o CarnaCode 2026

O CarnaCode 2026 consiste na implementação prática dos 23 Design
Patterns em cenários reais, com foco em escalabilidade e arquitetura de
software.

Cada desafio reforça o pensamento arquitetural e a capacidade de
identificar problemas de design antes que eles cresçam.

------------------------------------------------------------------------

## 📘 Fonte de Estudo

Fundamentos dos Design Patterns (balta.io)

------------------------------------------------------------------------

🚀 Seguimos evoluindo na jornada dos Design Patterns!
