using System.Collections.Generic;

namespace Homework3
{
    public class LetterBuilder
    {
        private readonly string _from;
        private readonly string _to;
        private readonly string _body;

        public LetterBuilder(string to, string body)
        {
            _from = "admin@admin.ru"; // здесь должно быть получение реального адреса
            _to = to;
            _body = body;
        }

        public OptionalLetterBuilder AddSubject(string subject)
        {
            return new OptionalLetterBuilder(_from, _to, _body).AddSubject(subject);
        }

        public OptionalLetterBuilder AddCopyRecipient(string recipient)
        {
            return new OptionalLetterBuilder(_from, _to, _body).AddCopyRecipient(recipient);
        }

        public OptionalLetterBuilder AddCopyRecipients(IEnumerable<string> recipients)
        {
            return new OptionalLetterBuilder(_from, _to, _body).AddCopyRecipients(recipients);
        }

        public class OptionalLetterBuilder
        {
            private Letter _letter;

            public OptionalLetterBuilder(string from, string to, string body)
            {
                _letter = new Letter
                {
                    From = from,
                    To = new List<string> { to },
                    Body = body
                };
            }

            public OptionalLetterBuilder AddSubject(string subject)
            {
                _letter.Subject = subject;
                return this;
            }

            public OptionalLetterBuilder AddCopyRecipient(string recipient)
            {
                _letter.To.Add(recipient);
                return this;
            }

            public OptionalLetterBuilder AddCopyRecipients(IEnumerable<string> recipients)
            {
                _letter.To.AddRange(recipients);
                return this;
            }

            public string Build()
            {
                var letter = new[]
                {
                    $"From: {_letter.From}",
                    $"To: {string.Join(", ", _letter.To)}",
                    $"Subject: {_letter.Subject ?? "*empty*"}",
                    string.Empty,
                    $"{_letter.Body}",
                    "\n\r"
                };
                return string.Join("\n\r", letter);
            }
        }
    }
}
