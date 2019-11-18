using System.Collections.Generic;

namespace Homework5.Api
{
    public interface IApi
    {
        void Send(Message message);
        IEnumerable<Message> Get();
    }
}