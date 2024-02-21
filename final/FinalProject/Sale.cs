public class Sale 
{
    private static Sale instance;

    private int _price;
    private int _total;

    // Private constructor to prevent instantiation outside the class
    public Sale()
    {
    
    }

    // Public property to access the singleton instance
    public static Sale Instance
    {
        get
        {
            // If the instance hasn't been created yet, create it
            if (instance == null)
            {
                instance = new Sale();
            }
            return instance;
        }
    }
    public int GetPrice() {
        return _price;
    }

    public int GetTotal() {
        return _total;
    }

    public void SetPrice(int price) {

        _price = price;
    }

    public void SetTotal(int total) {

        _total = total;
    }

    public void AddToTotal(int price)
    {
        _total += price;
    }

    public virtual void RenderCart(){
        
    }

}