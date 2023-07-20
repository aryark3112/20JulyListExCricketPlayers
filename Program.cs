using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20JulyCric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> listPlayers = new List<Player>()
            {
                new Player { Id=1,Name="MSD",Team="CSK",MFee=300000.89},
                new Player { Id=2,Name="H.Pandya",Team="GT",MFee=250000.89},
                new Player { Id=3,Name="Umraan Malik",Team="SRH",MFee=200000},
                new Player { Id=5,Name="R.Sharma",Team="MI",MFee=270000.89},
                new Player { Id=6,Name="DK",Team="MI",MFee=190000.89},
                new Player { Id=7,Name="VK",Team="RCB",MFee=210000.89},

            };
            Console.WriteLine("Number of Players are:"+listPlayers.Count);
            foreach (Player player in listPlayers)
            {
                Console.WriteLine("ID: " + player.Id);
                Console.WriteLine("Name: " + player.Name);
                Console.WriteLine("Team: " + player.Team);
                Console.WriteLine("Match Fee: " + player.MFee);
            
            }
            Console.ReadKey();
        }
    }
}
