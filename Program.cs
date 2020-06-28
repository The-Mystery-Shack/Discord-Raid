using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using System.Threading;
using Discord.WebSocket;
using System.Net;
using System.IO;
using System.Security.Policy;

namespace Discord_Raider_By_Stanley
{
    class Program
    {
        private static DiscordSocketClient _client;
        private static string _token;
        private static readonly object guildresult;

        static void Main(string[] args)
        {
            string token = "";
            Console.Title = "Stan Raider";



            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\r\n\t       ████████  ██████████  ██████  ██    ██      ████████  ██████  ██  ██████    ██████  ████████\r\n\t    ██              ██      ██  ██  ████  ██      ██    ██  ██  ██      ██   ██   ██      ██    ██\r\n\t     ██████        ██      ██████  ████████      ████████  ██████  ██  ██    ██  ████    ████████\r\n\t          ██      ██      ██  ██  ██  ████      ██  ██    ██  ██  ██  ██   ██   ██      ██  ██\r\n\t ████████        ██      ██  ██  ██    ██  ██  ██    ██  ██  ██  ██  ██████    ██████  ██    ██\r\n\t\t\t\tBy Stanley & Rataka");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("________________________________________________________________________________________________________________________");

            Console.ForegroundColor = ConsoleColor.Red;

            if ((Properties.Settings.Default.Token == "null") || (Properties.Settings.Default.Token == ""))
            {
                Console.Write("Bot Token: ");
                Console.ForegroundColor = ConsoleColor.Green;
                token = Console.ReadLine();
                Properties.Settings.Default.Token = _token;
                Properties.Settings.Default.Save();

            }
            else
            {
                token = Properties.Settings.Default.Token;
            }
            _token = token;

            Console.Clear();

            _client = new DiscordSocketClient();


            _client.LoginAsync(TokenType.Bot, token);
            _client.Ready += ReadyAsync;
            _client.Log += _client_Log;
            _client.StartAsync();



            Thread.Sleep(-1);
        }

        private static Task _client_Log(LogMessage arg)
        {
            Log(arg.Message, ConsoleColor.Red);
            return Task.CompletedTask;
        }
        private static void Log(string message, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Wait...");

        }
        private async static Task<Task> ReadyAsync()
        {
            Console.Clear();





            Console.Title = $" Discord Raider | {_client.CurrentUser.Username}#{_client.CurrentUser.Discriminator}";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Login succes : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator);

            System.Threading.Thread.Sleep(4700);

            Console.Clear();
            Console.WriteLine("Login succes : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\r\n\t       ████████  ██████████  ██████  ██    ██      ████████  ██████  ██  ██████    ██████  ████████\r\n\t    ██              ██      ██  ██  ████  ██      ██    ██  ██  ██      ██   ██   ██      ██    ██\r\n\t     ██████        ██      ██████  ████████      ████████  ██████  ██  ██    ██  ████    ████████\r\n\t          ██      ██      ██  ██  ██  ████      ██  ██    ██  ██  ██  ██   ██   ██      ██  ██\r\n\t ████████        ██      ██  ██  ██    ██  ██  ██    ██  ██  ██  ██  ██████    ██████  ██    ██\r\n\t\t\t\tBy Stanley & Rataka");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hi " + _client.CurrentUser.Username + " This is the raid option ! (more option, write : EasterEGG and press enter)");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("___________________________________________________________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[1] Unban All (1.1)       [4] Create mass text channel   [7] Create mass voice channel    [10] Unban Specific User  ");
            Console.WriteLine("[2] DMALL                 [5] Give admin to all (1.1)    [8] Rename all (1.1)             [11] Twitch settings      ");
            Console.WriteLine("[3] Delete all channel    [6] List server                [9] Ban all                      [12] Game settings        ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("____________________________________________________________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.Green;



            

            string mas = Console.ReadLine();
            
            

            if (mas == "EasterEGG")

            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("___________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Write : Credit");
                Console.WriteLine("Write : ByStan");
                Console.WriteLine("Write : ZelliDev");
                Console.WriteLine("Write : Kirua");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("____________________________________________________________________________________________________________________");
                Console.ReadKey();
                await Program.ReadyAsync();
            }

            if (mas == "Avaris")

            {
                await _client.SetGameAsync("A");

                System.Threading.Thread.Sleep(1000);

                await _client.SetGameAsync("Av");

                System.Threading.Thread.Sleep(1000);

                await _client.SetGameAsync("Ava");

                System.Threading.Thread.Sleep(1000);

                await _client.SetGameAsync("Avar");

                System.Threading.Thread.Sleep(1000);

                await _client.SetGameAsync("Avaris");

                System.Threading.Thread.Sleep(1000);
                await Program.ReadyAsync();
            }


            if (mas == "Zellidev")

            {
                Console.WriteLine("A candian programmer...");
                await _client.SetGameAsync("Z");
                System.Threading.Thread.Sleep(900);
                await _client.SetGameAsync("Ze");
                System.Threading.Thread.Sleep(900);
                await _client.SetGameAsync("Zel");
                System.Threading.Thread.Sleep(900);
                await _client.SetGameAsync("Zell");
                System.Threading.Thread.Sleep(900);
                await _client.SetGameAsync("Zelly");
                System.Threading.Thread.Sleep(900);
                await Program.ReadyAsync();
            }

            if (mas == "Kirua")
            {
                Console.WriteLine("My Friend");
                await _client.SetGameAsync("K");
                System.Threading.Thread.Sleep(900);
                await _client.SetGameAsync("Ki");
                System.Threading.Thread.Sleep(900);
                await _client.SetGameAsync("Kir");
                System.Threading.Thread.Sleep(900);
                await _client.SetGameAsync("Kiru");
                System.Threading.Thread.Sleep(900);
                await _client.SetGameAsync("Kirua");
                System.Threading.Thread.Sleep(900);
                await Program.ReadyAsync();


            }

     


            if (mas == "ByStan")
            {
                await _client.SetGameAsync("S");
                System.Threading.Thread.Sleep(900);
                await _client.SetGameAsync("St");
                System.Threading.Thread.Sleep(900);
                await _client.SetGameAsync("Sta");
                System.Threading.Thread.Sleep(900);
                await _client.SetGameAsync("Stan");
                System.Threading.Thread.Sleep(900);


                var fileStream = new FileStream(Directory.GetCurrentDirectory() + "/Stan.png", FileMode.Open);
                var image = new Image(fileStream);
                await _client.CurrentUser.ModifyAsync(u => u.Avatar = image);



                await Program.ReadyAsync();
            }



            if (mas == "Credit")

            {
                Console.WriteLine("Devloppement : By Stanley#0001");
                Console.WriteLine("Design : By Stanley#0001");

            }



            if (mas == "12")
            {
                Console.Clear();
                Console.WriteLine("Login succes : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\r\n\t       ████████  ██████████  ██████  ██    ██      ████████  ██████  ██  ██████    ██████  ████████\r\n\t    ██              ██      ██  ██  ████  ██      ██    ██  ██  ██      ██   ██   ██      ██    ██\r\n\t     ██████        ██      ██████  ████████      ████████  ██████  ██  ██    ██  ████    ████████\r\n\t          ██      ██      ██  ██  ██  ████      ██  ██    ██  ██  ██  ██   ██   ██      ██  ██\r\n\t ████████        ██      ██  ██  ██    ██  ██  ██    ██  ██  ██  ██  ██████    ██████  ██    ██\r\n\t\t\t\tBy Stanley & Rataka");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hi " + _client.CurrentUser.Username + " This is the raid option !");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[12] Game settings");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Wath is the game you wanna set? ");
                string name = Console.ReadLine();

                await _client.SetGameAsync(name);

                await Program.ReadyAsync();
            }

            if (mas == "11")

            {
                Console.Clear();
                Console.WriteLine("Login succes : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\r\n\t       ████████  ██████████  ██████  ██    ██      ████████  ██████  ██  ██████    ██████  ████████\r\n\t    ██              ██      ██  ██  ████  ██      ██    ██  ██  ██      ██   ██   ██      ██    ██\r\n\t     ██████        ██      ██████  ████████      ████████  ██████  ██  ██    ██  ████    ████████\r\n\t          ██      ██      ██  ██  ██  ████      ██  ██    ██  ██  ██  ██   ██   ██      ██  ██\r\n\t ████████        ██      ██  ██  ██    ██  ██  ██    ██  ██  ██  ██  ██████    ██████  ██    ██\r\n\t\t\t\tBy Stanley & Rataka");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hi " + _client.CurrentUser.Username + " This is the raid option !");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[11] Twitch settings");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Que regardez vous ?");
                string a = Console.ReadLine();

                Console.WriteLine("Le lien twitch ?");
                string b = Console.ReadLine();

                await _client.SetGameAsync(a, b, StreamType.Twitch);

                await Program.ReadyAsync();
            }

            if (mas == "10")

            {
                Console.Clear();
                Console.WriteLine("Login succes : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\r\n\t       ████████  ██████████  ██████  ██    ██      ████████  ██████  ██  ██████    ██████  ████████\r\n\t    ██              ██      ██  ██  ████  ██      ██    ██  ██  ██      ██   ██   ██      ██    ██\r\n\t     ██████        ██      ██████  ████████      ████████  ██████  ██  ██    ██  ████    ████████\r\n\t          ██      ██      ██  ██  ██  ████      ██  ██    ██  ██  ██  ██   ██   ██      ██  ██\r\n\t ████████        ██      ██  ██  ██    ██  ██  ██    ██  ██  ██  ██  ██████    ██████  ██    ██\r\n\t\t\t\tBy Stanley & Rataka");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hi " + _client.CurrentUser.Username + " This is the raid option !");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[10] Unban Specific User");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("Guild ID : ");
                string guildid2 = Console.ReadLine();

                
                ulong id = Convert.ToUInt64(guildid2);

                Console.Write("User ID : ");
                string userID = Console.ReadLine();

                ulong userid = Convert.ToUInt64(userID);

                SocketGuild guild = _client.GetGuild(id);

                foreach (SocketUser user in guild.Users)
                {
                    try
                    {
                        await guild.RemoveBanAsync(userid);

                    }
                    catch (Exception)
                    {


                    }



                }

                await Program.ReadyAsync();




            }

            if (mas == "9")

            {
                Console.Clear();
                Console.WriteLine("Login succes : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\r\n\t       ████████  ██████████  ██████  ██    ██      ████████  ██████  ██  ██████    ██████  ████████\r\n\t    ██              ██      ██  ██  ████  ██      ██    ██  ██  ██      ██   ██   ██      ██    ██\r\n\t     ██████        ██      ██████  ████████      ████████  ██████  ██  ██    ██  ████    ████████\r\n\t          ██      ██      ██  ██  ██  ████      ██  ██    ██  ██  ██  ██   ██   ██      ██  ██\r\n\t ████████        ██      ██  ██  ██    ██  ██  ██    ██  ██  ██  ██  ██████    ██████  ██    ██\r\n\t\t\t\tBy Stanley & Rataka");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hi " + _client.CurrentUser.Username + " This is the raid option !");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[9] Ban all");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Guild ID : ");

                string guildid2 = Console.ReadLine();

                ulong id = Convert.ToUInt64(guildid2);

                SocketGuild guild = _client.GetGuild(id);

                foreach (SocketUser user in guild.Users)
                {
                    try
                    {
                        await guild.AddBanAsync(user, 0, "Using Stanraid");

                    }
                    catch (Exception)
                    {

                        
                    }



                }

                await Program.ReadyAsync();




            }

            if (mas == "8")

            {
                Console.Clear();
                Console.WriteLine("Login succes : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\r\n\t       ████████  ██████████  ██████  ██    ██      ████████  ██████  ██  ██████    ██████  ████████\r\n\t    ██              ██      ██  ██  ████  ██      ██    ██  ██  ██      ██   ██   ██      ██    ██\r\n\t     ██████        ██      ██████  ████████      ████████  ██████  ██  ██    ██  ████    ████████\r\n\t          ██      ██      ██  ██  ██  ████      ██  ██    ██  ██  ██  ██   ██   ██      ██  ██\r\n\t ████████        ██      ██  ██  ██    ██  ██  ██    ██  ██  ██  ██  ██████    ██████  ██    ██\r\n\t\t\t\tBy Stanley & Rataka");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hi " + _client.CurrentUser.Username + " This is the raid option !");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[8] ???????");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Green;


                await Program.ReadyAsync();
            }

            if (mas == "7")

            {
                Console.Clear();
                Console.WriteLine("Login succes : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\r\n\t       ████████  ██████████  ██████  ██    ██      ████████  ██████  ██  ██████    ██████  ████████\r\n\t    ██              ██      ██  ██  ████  ██      ██    ██  ██  ██      ██   ██   ██      ██    ██\r\n\t     ██████        ██      ██████  ████████      ████████  ██████  ██  ██    ██  ████    ████████\r\n\t          ██      ██      ██  ██  ██  ████      ██  ██    ██  ██  ██  ██   ██   ██      ██  ██\r\n\t ████████        ██      ██  ██  ██    ██  ██  ██    ██  ██  ██  ██  ██████    ██████  ██    ██\r\n\t\t\t\tBy Stanley & Rataka");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hi " + _client.CurrentUser.Username + " This is the raid option !");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[7] Create mass voice channel");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("Server ID : ");
                string guildid2 = Console.ReadLine();

                Console.Write("Voice Channel Name : ");
                string textchan = Console.ReadLine();

                ulong id = Convert.ToUInt64(guildid2);

                SocketGuild guild = _client.GetGuild(id);

                for (int i = 0; i < 100; i++)
                {
                    try
                    {
                        await guild.CreateVoiceChannelAsync(textchan.Replace(' ', '-'));
                    }
                    catch (Exception)
                    {


                    }

                }

                await Program.ReadyAsync();
            }

            if (mas == "6")

            {
                Console.Clear();
                Console.WriteLine("Login succes : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\r\n\t       ████████  ██████████  ██████  ██    ██      ████████  ██████  ██  ██████    ██████  ████████\r\n\t    ██              ██      ██  ██  ████  ██      ██    ██  ██  ██      ██   ██   ██      ██    ██\r\n\t     ██████        ██      ██████  ████████      ████████  ██████  ██  ██    ██  ████    ████████\r\n\t          ██      ██      ██  ██  ██  ████      ██  ██    ██  ██  ██  ██   ██   ██      ██  ██\r\n\t ████████        ██      ██  ██  ██    ██  ██  ██    ██  ██  ██  ██  ██████    ██████  ██    ██\r\n\t\t\t\tBy Stanley & Rataka");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hi " + _client.CurrentUser.Username + " This is the raid option !");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[6] List Server");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Green;

                foreach (var guild in _client.Guilds)
                {
                    Console.WriteLine("+ Name : " + guild.Name + " | ID : " + guild.Id + " | Owner : " + guild.Owner);
                    
                }

                Console.ReadKey();
                await Program.ReadyAsync();
            }

            if (mas == "5")

            {
                Console.Clear();
                Console.WriteLine("Login succes : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\r\n\t       ████████  ██████████  ██████  ██    ██      ████████  ██████  ██  ██████    ██████  ████████\r\n\t    ██              ██      ██  ██  ████  ██      ██    ██  ██  ██      ██   ██   ██      ██    ██\r\n\t     ██████        ██      ██████  ████████      ████████  ██████  ██  ██    ██  ████    ████████\r\n\t          ██      ██      ██  ██  ██  ████      ██  ██    ██  ██  ██  ██   ██   ██      ██  ██\r\n\t ████████        ██      ██  ██  ██    ██  ██  ██    ██  ██  ██  ██  ██████    ██████  ██    ██\r\n\t\t\t\tBy Stanley & Rataka");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hi " + _client.CurrentUser.Username + " This is the raid option !");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[5] ???????");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Green;





                await Program.ReadyAsync();
            }

            if (mas == "4")

            {
                Console.Clear();
                Console.WriteLine("Login succes : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\r\n\t       ████████  ██████████  ██████  ██    ██      ████████  ██████  ██  ██████    ██████  ████████\r\n\t    ██              ██      ██  ██  ████  ██      ██    ██  ██  ██      ██   ██   ██      ██    ██\r\n\t     ██████        ██      ██████  ████████      ████████  ██████  ██  ██    ██  ████    ████████\r\n\t          ██      ██      ██  ██  ██  ████      ██  ██    ██  ██  ██  ██   ██   ██      ██  ██\r\n\t ████████        ██      ██  ██  ██    ██  ██  ██    ██  ██  ██  ██  ██████    ██████  ██    ██\r\n\t\t\t\tBy Stanley & Rataka");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hi " + _client.CurrentUser.Username + " This is the raid option !");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[4] Create mass text channel");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("Server ID : ");
                string guildid2 = Console.ReadLine();

                Console.Write("Text Channel Name : ");
                string textchan = Console.ReadLine();

                ulong id = Convert.ToUInt64(guildid2);

                SocketGuild guild = _client.GetGuild(id);

                for (int i = 0; i < 100; i++)
                {
                    try
                    {
                        await guild.CreateTextChannelAsync(textchan.Replace(' ' , '-'));
                    }

                    catch (Exception)
                    {

                       
                    }
                    
                }


                await Program.ReadyAsync();
            }



            if (mas == "3")

            {
                Console.Clear();
                Console.WriteLine("Login succes : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\r\n\t       ████████  ██████████  ██████  ██    ██      ████████  ██████  ██  ██████    ██████  ████████\r\n\t    ██              ██      ██  ██  ████  ██      ██    ██  ██  ██      ██   ██   ██      ██    ██\r\n\t     ██████        ██      ██████  ████████      ████████  ██████  ██  ██    ██  ████    ████████\r\n\t          ██      ██      ██  ██  ██  ████      ██  ██    ██  ██  ██  ██   ██   ██      ██  ██\r\n\t ████████        ██      ██  ██  ██    ██  ██  ██    ██  ██  ██  ██  ██████    ██████  ██    ██\r\n\t\t\t\tBy Stanley & Rataka");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hi " + _client.CurrentUser.Username + " This is the raid option !");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[3] Delete all channel");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("Guild ID : ");

                string guildid2 = Console.ReadLine();

                ulong id = Convert.ToUInt64(guildid2);

                SocketGuild guild = _client.GetGuild(id);

                foreach (SocketTextChannel chan in guild.TextChannels)
                {


                    try
                    {
                        await chan.DeleteAsync();
                        
                    }
                    catch (Exception)
                    {



                    }
                    
                }

                foreach (SocketVoiceChannel chanv in guild.VoiceChannels)
                {
                    try
                    {
                        await chanv.DeleteAsync();
                    }
                    catch (Exception)
                    {

                        
                    }
                }

                await Program.ReadyAsync();
            }

            if (mas == "2")

            {
                Console.Clear();
                Console.WriteLine("Login succes : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\r\n\t       ████████  ██████████  ██████  ██    ██      ████████  ██████  ██  ██████    ██████  ████████\r\n\t    ██              ██      ██  ██  ████  ██      ██    ██  ██  ██      ██   ██   ██      ██    ██\r\n\t     ██████        ██      ██████  ████████      ████████  ██████  ██  ██    ██  ████    ████████\r\n\t          ██      ██      ██  ██  ██  ████      ██  ██    ██  ██  ██  ██   ██   ██      ██  ██\r\n\t ████████        ██      ██  ██  ██    ██  ██  ██    ██  ██  ██  ██  ██████    ██████  ██    ██\r\n\t\t\t\tBy Stanley & Rataka");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hi " + _client.CurrentUser.Username + " This is the raid option !");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[2] DMALL");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("DMALL Message : ");

                string DMALL2 = Console.ReadLine();



                foreach (SocketGuild guild in _client.Guilds)
                {
                    foreach (SocketUser user in guild.Users)
                    {
                        try
                        {
                            await user.SendMessageAsync(DMALL2);
                            
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Cannot send : 1 : message");
                        }
                        
                    }

                    await Program.ReadyAsync();


                }

                



            }

            if (mas == "1")

            {
                Console.Clear();
                Console.WriteLine("Login succes : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\r\n\t       ████████  ██████████  ██████  ██    ██      ████████  ██████  ██  ██████    ██████  ████████\r\n\t    ██              ██      ██  ██  ████  ██      ██    ██  ██  ██      ██   ██   ██      ██    ██\r\n\t     ██████        ██      ██████  ████████      ████████  ██████  ██  ██    ██  ████    ████████\r\n\t          ██      ██      ██  ██  ██  ████      ██  ██    ██  ██  ██  ██   ██   ██      ██  ██\r\n\t ████████        ██      ██  ██  ██    ██  ██  ██    ██  ██  ██  ██  ██████    ██████  ██    ██\r\n\t\t\t\tBy Stanley & Rataka");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hi " + _client.CurrentUser.Username + " This is the raid option !");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[1] Leave");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Leave message : ");

}


            return Task.CompletedTask;



        }
    }
}
