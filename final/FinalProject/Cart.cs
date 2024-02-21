public class Cart : Sale
{
    private static Cart instance;
    private List<string> products;
    private List<int> prices;

    private Cart()
    {
        products = new List<string>();
        prices = new List<int>();
    }

    public static Cart Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Cart();
            }
            return instance;
        }
    }
    public List<string> GetProductsList() {
        return products;
    }

    public List<int> GetPricesList() {
        return prices;
    }
    
}