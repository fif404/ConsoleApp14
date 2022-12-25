// Скрипников ИСП 22.1 17 вариант
Console.WriteLine("Введите количесткво товаров:");
var count = int.Parse(Console.ReadLine());
var items = new Item[count];
for (var i = 0; i < items.Length; i++)
{
    Console.WriteLine($"Товар №{i + 1}");
    items[i] = CreateItem();
}

foreach (var item in items)
{
    Console.WriteLine($"{item.Name} годен до {item.ExpirationDate}");
}

static Item CreateItem()
{
    Console.Write("№ серии = ");
    var id = Console.ReadLine();

    Console.Write("Наименование = ");
    var name = Console.ReadLine();

    Console.Write("Дата производства = ");
    var creationDate = DateOnly.Parse(Console.ReadLine());

    Console.Write("Срок годности = ");
    var expirationDate = DateOnly.Parse(Console.ReadLine());

    Console.Write("Цена = ");
    var price = decimal.Parse(Console.ReadLine());

    return new Item
    {
        Id = id,
        Name = name,
        CreationDate = creationDate,
        ExpirationDate = expirationDate,
        Price = price
    };
}

internal readonly struct Item
{
    public string Id { get; init; }
    public string Name { get; init; }
    public DateOnly CreationDate { get; init; }
    public DateOnly ExpirationDate { get; init; }
    public decimal Price { get; init; }
}