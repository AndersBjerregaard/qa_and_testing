namespace ClassLibrary;

public class Basket
{
    public List<Item> Items { get; set; }
    public decimal Total { get; private set; }

    public Basket()
    {
        Items = new List<Item>();
    }

    public void Add(Item item)
    {
        Items.Add(item);
        Total += item.Price;
    }

    public decimal TotalOfSpecificItemType(string itemName) => Items
        .Where(x => x.Name == itemName)
        .Select(x => x.Price)
        .Sum();
}

public class Item
{
    public decimal Price { get; set; }
    public string Name { get; set; }

    public Item() { }
}