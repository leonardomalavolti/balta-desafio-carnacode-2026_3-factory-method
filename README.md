![CR-3](https://github.com/user-attachments/assets/485b7ff1-c098-40bf-93b4-00058c8729a9)

## 🥁 CarnaCode 2026 - Desafio 03 - Factory Method

Oi, eu sou o **Leonardo Malavolti Monteiro** 👋 e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo [balta.io](https://balta.io). 👻

Aqui você vai encontrar projetos, exercícios e códigos que estou desenvolvendo durante o desafio. O objetivo é colocar a mão na massa, testar ideias e registrar minha evolução no mundo da tecnologia.

### Sobre este desafio
No desafio **Factory Method** eu tive que resolver um problema real implementando o **Design Pattern** em questão.
Neste processo eu aprendi:
* ✅ Boas Práticas de Software
* ✅ Código Limpo
* ✅ SOLID
* ✅ Design Patterns (Padrões de Projeto)

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

## Problema
Uma aplicação de e-commerce precisa enviar notificações por diferentes canais (Email, SMS, Push, WhatsApp) dependendo da preferência do cliente e tipo de notificação.
O código atual viola o Open/Closed Principle ao usar condicionais para criar notificações.

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

## 📚 Aprendizados

Durante esse desafio aprimorei:

-   Aplicação prática do Factory Method\
-   Separação de responsabilidades\
-   Redução de acoplamento\
-   Aderência ao Open/Closed Principle\
-   Organização de estrutura em camadas\
-   Uso de enum para maior segurança de tipos

## Sobre o CarnaCode 2026
O desafio **CarnaCode 2026** consiste em implementar todos os 23 padrões de projeto (Design Patterns) em cenários reais. Durante os 23 desafios desta jornada, os participantes são submetidos ao aprendizado e prática na idetinficação de códigos não escaláveis e na solução de problemas utilizando padrões de mercado.

### eBook - Fundamentos dos Design Patterns
Minha principal fonte de conhecimento durante o desafio foi o eBook gratuito [Fundamentos dos Design Patterns](https://lp.balta.io/ebook-fundamentos-design-patterns).

### Veja meu progresso no desafio
[Incluir link para o repositório central]

## 📘 Fonte de Estudo

Fundamentos dos Design Patterns (balta.io)

🚀 Seguimos evoluindo na jornada dos Design Patterns!
