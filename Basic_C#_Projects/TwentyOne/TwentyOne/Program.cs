using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Matt\'s Casino! \nLet\'s start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("Thank you {0}, and how much money will you be playing with today?",playerName);
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ok {0}, would you like to join a game of 21?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName,bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino.  Bye for now!");
            Console.ReadLine();
        }
        
    }
}
