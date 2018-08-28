using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLibrary;
	

namespace AppMetroTag
{
    public class Program 
    {
        static void Main(string[] args)
        {
            Station station = new Station();
            WriteInConsole(station.GetStation());
        }

        private static void WriteInConsole(Dictionary<string, List<ChampRoute>> listeStationUnique)
        {
            foreach (KeyValuePair<string, List<ChampRoute>> station in listeStationUnique)
            {
                Console.WriteLine(station.Key);
                foreach (ChampRoute item in station.Value)
                {
                    Console.WriteLine(string.Format("{0}: {1}", item.ShortName, item.Mode));
                }
            }
        }
    }
}
