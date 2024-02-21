public class SubstractCart : Sale 
{
    Sale sale = Sale.Instance;
    public void SubstractCartObjects(int currentSale, int newTotal) {
        
        sale.SetTotal(currentSale - newTotal);

    }
}