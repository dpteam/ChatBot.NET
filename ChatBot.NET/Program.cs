using System;

namespace ChatBot.NET
{
    class Program
    {
#if DEBUG
        public static bool DebugEnabled = true;
#else
        public static bool DebugEnabled = false;
#endif
        public static string ChatMode = "Normal"; // Gopnick, ToxicAmoral;
        public static string UserName;
        public static string BotName = "Sharpy";
        public static string question;

        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            UserName = Console.ReadLine();

            Console.Clear();

            Console.WriteLine(UserName + " > ");
            question = Console.ReadLine();

            // Hello Yandere Employee!
            if (question == "Hi")
            {
                if (ChatMode == "Normal")
                {
                    Console.Write(BotName + " > " + "Hi!");
                }
            }

            Console.ReadKey();

            if(!DebugEnabled)
            Environment.Exit(0);
        }
    }
}
