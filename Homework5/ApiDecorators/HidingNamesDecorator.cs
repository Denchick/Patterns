using Homework5.Api;

namespace Homework5.ApiDecorators
{
    public class HidingNamesDecorator : ApiDecoratorBase
    {
        public HidingNamesDecorator(IApi api) : base(api)
        {
        }

        private string HideName(string name) => $"{name.GetHashCode()} (name hide)";

        protected override Message OnBeforeSending(Message message)
        {
            message.Author = HideName(message.Author);
            message.To = HideName(message.To);
            return message;
        }
    }
}