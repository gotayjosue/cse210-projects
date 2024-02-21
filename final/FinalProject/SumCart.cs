public class SumCart : Sale 
{   
    Sale sale = Sale.Instance;
    public void SumCartObjects(int price) {

        sale.AddToTotal(price);
 
    }
}