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
                    });;
                    Console.WriteLine("Set status to " + userstatus);
                    Thread.Sleep(wait);
                }
            }




            try 
            {

            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("Discord Token Is INVALID");
                string invalid = "";
                Console.Write("Please Restart The App And Try Agian");
                Thread.Sleep(-1);
            }
        }
    }
}
