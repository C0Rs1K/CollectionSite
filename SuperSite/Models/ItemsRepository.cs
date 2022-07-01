using System.Text.Json;

namespace SuperSite.Models;

public class ItemsRepository
{
    public IEnumerable<Item> Get()
    {
        using var file = System.IO.File.OpenRead("Data/collection.json");

        return JsonSerializer.Deserialize<IEnumerable<Item>>(file)!;
    }
}