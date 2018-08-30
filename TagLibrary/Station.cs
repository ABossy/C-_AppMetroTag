using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TagLibrary
{
    public class Station
    {
        private IApiRequest _IApiRequest;

        public Station(IApiRequest IApiRequest)
        {
            this._IApiRequest = IApiRequest;
        }
        public Station()
            : this(new ApiRequest())
        {
        }

        public Dictionary<string, List<ChampRoute>> GetStation()
        {
            string responseFromServer = _IApiRequest.Request("https://data.metromobilite.fr/api/linesNear/json?y=45.185270&x=5.727231&dist=600&details=true");
            List<ChampApi> stations = JsonConvert.DeserializeObject<List<ChampApi>>(responseFromServer);

            Dictionary<string, List<ChampRoute>> listeStationUnique = new Dictionary<string, List<ChampRoute>>();
            foreach (ChampApi station in stations)
            {
                if (!listeStationUnique.ContainsKey(station.Name))
                {
                    listeStationUnique.Add(station.Name, new List<ChampRoute>());
                }

                foreach (var line in station.Lignes)
                {
                    if (!listeStationUnique[station.Name].Any(_ => _.Id == line))
                    {
                        ChampRoute route = GetRoute(line);
                        listeStationUnique[station.Name].Add(route);
                    }
                }
            }



            return listeStationUnique;
        }

        public List<DictionaryToList> GetDataList(Dictionary<string, List<ChampRoute>> listeStationUnique)
        {
            List<DictionaryToList> result = new List<DictionaryToList>();

            foreach (KeyValuePair<string, List<ChampRoute>> kvp in listeStationUnique)
            {
                result.Add(new DictionaryToList(kvp.Key, kvp.Value));
            }

            return result;
        }

        

        public ChampRoute GetRoute(string line)
        {
            string responseFromServer2 = _IApiRequest.Request(string.Format("https://data.metromobilite.fr/api/routers/default/index/routes?codes={0}", line));
            ChampRoute[] routes = JsonConvert.DeserializeObject<ChampRoute[]>(responseFromServer2);
            return routes[0];
        }
    }
}


