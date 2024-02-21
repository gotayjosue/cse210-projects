public class Closing : Sale 
{
    private static Closing instance;
    private int _salesCashClosing = 0;

     public static Closing Instance
    {
        get
        {
            // If the instance hasn't been created yet, create it
            if (instance == null)
            {
                instance = new Closing();
            }
            return instance;
        }
    }

    public int GetSalesCashClosing() {
        return _salesCashClosing;
    }

    public void SetSalesCashClosing(int salesCashClosing) {
        _salesCashClosing = salesCashClosing;
    }

}