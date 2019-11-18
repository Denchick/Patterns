using System.Collections.Generic;
using System.Linq;
using Homework5.Api;

namespace Homework5.ApiDecorators
{
    public class ApiDecoratorBase : IApi
    {
        protected readonly IApi Decoratee;

        protected ApiDecoratorBase(IApi api)
        {
            Decoratee = api;
        }

        protected virtual Message OnBeforeSending(Message message)
        {
            return message;
        }

        protected virtual Message OnAfterGetting(Message message)
        {
            return message;
        }

        public void Send(Message message)
        {
            Decoratee.Send(OnBeforeSending(message));
            
        }

        public IEnumerable<Message> Get()
        {
            return Decoratee.Get().Select(m => OnAfterGetting(m));
        }
    }
}