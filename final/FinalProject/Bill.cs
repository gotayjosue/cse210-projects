public class Bill : Sale
{
    Sale sale = Sale.Instance;
    Cart cart = Cart.Instance;
    Closing closing = Closing.Instance;
    
    public void GenerateBill() {
        Console.WriteLine(" ");
        Console.Write("Num   ");
        Console.Write("Product    ");
        Console.Write("Price\n______________________ ");
    
        
        Console.WriteLine(" ");


        int numIndex = 1;
        foreach (var (x, y) in cart.GetProductsList().Zip(cart.GetPricesList())){
            Console.WriteLine($"{numIndex}. {x} ${y}");
            numIndex += 1;
        }

        Console.WriteLine("______________________");
        Console.WriteLine($"       This sale ${sale.GetTotal()}");
        Console.WriteLine(" ");
        int currentClosing = closing.GetSalesCashClosing();
        int thisSale = sale.GetTotal();
        closing.SetSalesCashClosing(currentClosing + thisSale);
        sale.SetTotal(0);
        cart.GetProductsList().Clear();
        cart.GetPricesList().Clear();
    }
}