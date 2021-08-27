using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using System.Threading;

namespace Animated_Status_Tainted06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Animated Status Discord Selfbot | Made By Tainted06 | https://github.com/Tainted06";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Animated Discord Status Selfbot" +
                "\n" +
                "Created by Tainted" +
                "\n" +
                "https://github.com/Tainted06" +
                "\n" +
                "https://github.com/Tainted06/Animated-Status-Selfbot" +
                "\n");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\n" +
                "Warning!!" +
                "\n" +
                "This can get your discord account banned!" +
                "\n" +
                "Selfbots are not allowed by discords Terms Of Service" +
                "\n" +
                "\n" +
                "When you run this program all your server folders will be deleted and the order of your servers will be changed" +
                "\n" +
                "I'm not sure why this happens, probably a bug in the api" +
                "\n" +
                "\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Have you read the preceding text? (y/n)");
            string answer = Console.ReadLine();
            if (answer.Equals("y"))
            {
                Thread.Sleep(1);
                Console.Clear();
            }
            else if (answer.Equals("N"))
            {
                Console.WriteLine("\n" +
                    "\n" +
                    "Please restart the program after reading the warnings and information.");
                Thread.Sleep(-1);
            }
            else
            {
                Console.WriteLine("\n" +
                    "\n" +
                    "Please restart the program and only type y or n");
                Thread.Sleep(-1);
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Enter Discord Token: ");
            Console.ForegroundColor = ConsoleColor.White;
            string token = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter Status Text: ");
            Console.ForegroundColor = ConsoleColor.White;
            string status = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter Wait Time (In milliseconds): ");
            Console.ForegroundColor = ConsoleColor.White;
            int wait = Int32.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();

            try 
            {
                DiscordClient client = new DiscordClient(token);
                while (true)
                {
                    string userstatus = "";
                    for (int i = 0; i < status.Length; i++)
                    {
                        userstatus += status[i];
                        client.User.ChangeSettings(new UserSettingsProperties()
                        {
                            Theme = DiscordTheme.Dark,
                            CustomStatus = new CustomStatus()
                            {
                                Text = userstatus,
                            }
                        }); ;
                        Console.WriteLine("Set status to " + userstatus);
                        Thread.Sleep(wait);
                    }
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("Discord Token Is INVALID");
                Console.WriteLine("");
                Console.Write("Please Restart The App And Try Agian");
                Thread.Sleep(-1);
            }
        }
    }
}
