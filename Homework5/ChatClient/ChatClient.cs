using System;
using System.Linq;
using Homework5.Api;

namespace Homework5.ChatClient
{
    public class ConsoleChatClient : IChatClient
    {
        private readonly IApi _api;
        public ConsoleChatClient(IApi api)
        {
            _api = api;
        }

        public void GetMessages()
        {
            var messages = _api.Get();
            Console.WriteLine("**Received new message**");
            Console.WriteLine(messages.First());
        }

        public void Send(Message message)
        {
            _api.Send(message);
            Console.WriteLine("**Message sent successfully**");
            Console.WriteLine(message);
        }
    }
}

