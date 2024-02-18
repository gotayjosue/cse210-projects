public class Closing : Sale 
{
    private int _salesCashClosing = 0;

    public int GetSalesCashClosing() {
        return _salesCashClosing;
    }

    public void SetSalesCashClosing(int salesCashClosing) {
        _salesCashClosing = salesCashClosing;
    }

}