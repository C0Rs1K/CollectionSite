using System.Text.Json.Serialization;

namespace SuperSite.Models;
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
    }
