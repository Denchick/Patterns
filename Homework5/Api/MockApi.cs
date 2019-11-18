using System.Collections.Generic;

namespace Homework5.Api
{
    public class MockApi: IApi
    {
        private Message _message;

        public void Send(Message message)
        {
            _message = message;
        }

        public IEnumerable<Message> Get()
        {
            var message = _message;
            _message = null;
            yield return message;
        }
    }
}