using System;

namespace BuildermanBot
{
    class Program
    {
        static void Main()
        {
            Bot bot = new Bot();
            bot.RunAsync().GetAwaiter().GetResult();

        }
    }
}
