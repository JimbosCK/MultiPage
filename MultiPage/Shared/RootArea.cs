using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPage.Shared {
    using System.Text.Json.Serialization;

    namespace StockTracker.Shared {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class RootArea {
            [JsonPropertyName("areas")]
            public List<Area> areas { get; set; }

            [JsonPropertyName("game_indices")]
            public List<GameIndex> game_indices { get; set; }

            [JsonPropertyName("id")]
            public int id { get; set; }

            [JsonPropertyName("name")]
            public string name { get; set; }

            [JsonPropertyName("names")]
            public List<Name> names { get; set; }

            [JsonPropertyName("region")]
            public Region region { get; set; }
        }

        public class Area {
            [JsonPropertyName("name")]
            public string name { get; set; }

            [JsonPropertyName("url")]
            public string url { get; set; }
        }

        public class GameIndex {
            [JsonPropertyName("game_index")]
            public int game_index { get; set; }

            [JsonPropertyName("generation")]
            public Generation generation { get; set; }
        }

        public class Generation {
            [JsonPropertyName("name")]
            public string name { get; set; }

            [JsonPropertyName("url")]
            public string url { get; set; }
        }

        public class Language {
            [JsonPropertyName("name")]
            public string name { get; set; }

            [JsonPropertyName("url")]
            public string url { get; set; }
        }

        public class Name {
            [JsonPropertyName("language")]
            public Language language { get; set; }

            [JsonPropertyName("name")]
            public string name { get; set; }
        }

        public class Region {
            [JsonPropertyName("name")]
            public string name { get; set; }

            [JsonPropertyName("url")]
            public string url { get; set; }
        }

    }
}
