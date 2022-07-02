namespace SuperSite.Models;

public class ItemsRepository
{
    private readonly CollectionContext _context;

    public ItemsRepository(CollectionContext context)
    {
        _context = context;
    }

    public IEnumerable<Item> Get()
    {
        return _context.CollectionItems;
    }
}
