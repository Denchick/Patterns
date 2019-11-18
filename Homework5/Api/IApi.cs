using System.Collections.Generic;

namespace Homework5
{
    public interface IApi
    {
        void Send(Message message);
        IEnumerable<Message> Get();
    }
}