namespace Homework5
{
    public class Message
    {
        public string Author { get;set; }
        public string To { get; set; }
        public string Text { get;set; }

        public override string ToString() => $"From: {Author}\nTo: {To}\n\n{Text}";
    }
}