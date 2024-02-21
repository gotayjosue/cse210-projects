public class Remove : Sale 
{
    SubstractCart substractCart = new SubstractCart();
    Cart cart = Cart.Instance;
    Sale sale = Sale.Instance;
    public override void RenderCart() {
        Console.WriteLine("Please type the product number you want to remove from the cart");
        Console.WriteLine(" ");

        int numIndex = 1;
        foreach (var (x, y) in cart.GetProductsList().Zip(cart.GetPricesList())){
            Console.WriteLine($"{numIndex}. {x} ${y}");

            numIndex += 1;
        }
        string removedProduct = Console.ReadLine();
        int removedInt = int.Parse(removedProduct);
        cart.GetProductsList().RemoveAt(removedInt - 1);
        int newTotal = cart.GetPricesList().ElementAt(removedInt - 1);
        int currentSale = sale.GetTotal();
        substractCart.SubstractCartObjects(currentSale, newTotal);
        cart.GetPricesList().RemoveAt(removedInt -1);
        Console.WriteLine(" ");
        Console.WriteLine("The product has been removed");
    }
}