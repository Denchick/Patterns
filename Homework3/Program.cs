using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            var letter1 = new LetterBuilder("admin@admin.ru", "This is very useful message!")
                .AddSubject("Spam :)")
                .AddCopyRecipient("notadmin@admin.ru")
                .AddCopyRecipients(new[] {"thisisdefenetelynot@admin.ru", "ad@min.ru"})
                .Build();
            Console.WriteLine(letter1);

            var letter2 = new LetterBuilder("death@no.te", "You shouldn't have read it. Now you are going to die!")
                .AddCopyRecipient("all@world.org")
                .Build();
            Console.WriteLine(letter2);
        }
    }
}
