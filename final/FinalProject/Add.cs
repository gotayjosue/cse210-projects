public class Add : Sale
{
    Products products = new Products();
    SumCart sumCart = new SumCart();
    Sale sale = Sale.Instance;
    
    public override void RenderCart() {

        Cart cart = Cart.Instance;
        
        Console.WriteLine("Please type the product code (from 1 - 5)");
        string code = Console.ReadLine();

        string[] lines = File.ReadAllLines(products.GetProducts());


        foreach (string line in lines){

            string [] parts = line.Split(",");

            string productCode = parts[0];
            string productName = parts[1];
            string productPrice = parts[2];
            int intPrice = int.Parse(productPrice);

            if (productCode.Contains(code)){

                string selectedProduct = $"{productName} ${productPrice}";
                Console.WriteLine(selectedProduct);
                Console.WriteLine(" ");
                Console.WriteLine("This product will be added to the cart. Are you sure? yes/no");
                string response = Console.ReadLine();

                if (response == "yes"){
                    sumCart.SumCartObjects(intPrice);
                    cart.GetProductsList().Add(productName);
                    cart.GetPricesList().Add(intPrice);
                    Console.WriteLine("The product was added to the cart");
                }

            }

        }
    }

}