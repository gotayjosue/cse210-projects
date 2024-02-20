public class Remove : Sale 
{
    Cart cart = new Cart();
    Sale sale = new Sale();
    Products products = new Products();
        
    public override void RenderCart() {
        Console.WriteLine("Please type the product number you want to remove from the cart");
        Console.WriteLine(" ");

        int numIndex = 1;
        foreach (var (x, y) in cart.products.Zip(cart.prices)){
            Console.WriteLine($"{numIndex}. {x} ${y}");

            numIndex += 1;
        }
        string removedProduct = Console.ReadLine();
        int removedInt = int.Parse(removedProduct);
        cart.products.RemoveAt(removedInt - 1);
        int newTotal = cart.prices.ElementAt(removedInt - 1);
        int currentSale = sale.GetTotal();
        sale.SetTotal(currentSale - newTotal);
        cart.prices.RemoveAt(removedInt -1);
        Console.WriteLine(" ");
        Console.WriteLine("The product has been removed");
    }
}