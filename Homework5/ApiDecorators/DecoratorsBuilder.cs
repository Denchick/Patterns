using Homework5.ChatClient;

namespace Homework5.ChatClientDecorators
{
    public class DecoratorBuilder
    {
        private IApi _api;

        public DecoratorBuilder(IApi api)
        {
            _api = api;
        }

        public DecoratorBuilder WithEncryption()
        {
            _api = new EncryptionDecorator(_api);
            return this;
        }

        public DecoratorBuilder WithHidingNames()
        {
            _api = new HidingNamesDecorator(_api);
            return this;
        }

        public IApi Build()
        {
            return _api;
        }

    }
}
