using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Newtonsoft.Json;


namespace TagLibrary
{
    public class ChampApi
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lon")]
        public double Longitude { get; set; }

        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [JsonProperty("lines")]
        public string[] Lignes { get; set; }

    }

    public class ChampRoute
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("longName")]
        public string LongName { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("textColor")]
        public string TextColor { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        public string RealColor  
        {
            get
            {
                return "#" + Color;
            }
        }

        public string PictureVehicule 
        {
            get
            {
                if (Mode == "BUS")
                {
                    return "https://png.icons8.com/color/50/000000/trolleybus.png";
                }
                else
                {
                    return "https://png.icons8.com/color/50/000000/tram.png";
                }
            }
        }
    }


}