namespace Homework5.ChatClient
{
    public interface IChatClient
    {
        void Send(Message message);
        void GetMessages();
    }
}