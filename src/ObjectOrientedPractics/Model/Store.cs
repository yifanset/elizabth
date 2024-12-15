using ObjectOrientedPractics;
/// <summary>
/// Представляет магазин, который содержит товары и клиентов
/// </summary>
public class Store
{
    /// <summary>
    /// Хранит список товаров в магазине
    /// </summary>
    private List<Item> _items;

    /// <summary>
    /// Хранит список клиентов магазина
    /// </summary>
    private List<Customer> _customers;

    /// <summary>
    /// Возвращает и задает список товаров в магазине
    /// </summary>
    public List<Item> Items
    {
        set { _items = value; }
        get { return _items; }
    }

    /// <summary>
    /// Возвращает и задает список клиентов в магазине
    /// </summary>
    public List<Customer> Customers
    {
        set { _customers = value; }
        get { return _customers; }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Store"/> с пустыми списками товаров и клиентов
    /// </summary>
    public Store()
    {
        _items = new List<Item>();
        _customers = new List<Customer>();
    }
}
