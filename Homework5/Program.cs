using System;
using Homework5.ChatClient;
using Homework5.ChatClientDecorators;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            // usual chat client, which send you last your message
            var api = new DecoratorBuilder(new MockApi()).Build();
            Demonstrate(api, "usual api");
            // chat client encrypted messages
            api = new DecoratorBuilder(new MockApi()).WithEncryption().Build();
            Demonstrate(api, "encrypted messages decorator");
            // chat client hiding user names
            api = new DecoratorBuilder(new MockApi()).WithHidingNames().Build();
            Demonstrate(api, "hiding user names decorator");
            // chat client with encrypting messages and hiding user names
            api = new DecoratorBuilder(new MockApi()).WithHidingNames().WithEncryption().Build();
            Demonstrate(api, "encrypting messages and hiding user names");
        }

        private static void Demonstrate(IApi api, string description)
        {
            Console.WriteLine($"=== {description.ToUpper()} ===");
            var message = new Message
            {
                Author = "Vasya",
                To = "Petya",
                Text = "just usual text"
            };

            var chatClient = new ConsoleChatClient(api);
            chatClient.Send(message);
            chatClient.GetMessages();
        }
    }
}