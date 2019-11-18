using Homework5.Api;

namespace Homework5.ApiDecorators
{
    public class DecoratorsBuilder
    {
        private IApi _api;

        public DecoratorsBuilder(IApi api)
        {
            _api = api;
        }

        public DecoratorsBuilder WithEncryption()
        {
            _api = new EncryptionDecorator(_api);
            return this;
        }

        public DecoratorsBuilder WithHidingNames()
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
