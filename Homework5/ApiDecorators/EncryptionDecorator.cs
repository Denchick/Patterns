using Homework5.Api;

namespace Homework5.ApiDecorators
{
    public class EncryptionDecorator : ApiDecoratorBase
    {
        public EncryptionDecorator(IApi api) : base(api)
        {
        }

        protected override Message OnBeforeSending(Message message)
        {
            message.Text = Encrypt(message.Text);
            return message;
        }

        protected override Message OnAfterGetting(Message message)
        {
            message.Text = Decrypt(message.Text);
            return message;
        }

        private string Encrypt(string text) => $"<enctypted>{text}</encrypted>";
        private string Decrypt(string text) => text.Substring(11, text.Length - 23);
    }
}