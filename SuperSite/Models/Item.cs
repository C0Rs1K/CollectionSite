using System.Text.Json.Serialization;

namespace SuperSite.Models;
    public class Item
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("icon")]
        public string Icon { get; set; }
        [JsonPropertyName("flavourText")]
        public string Description { get; set; }
    }
