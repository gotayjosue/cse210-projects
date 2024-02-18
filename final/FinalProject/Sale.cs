public class Sale 
{
    private int _price;
    private int _total;

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

    public virtual void RenderCart(){
        
    }
}