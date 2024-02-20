using System;
using System.Security.Permissions;

class Program
{
    static void Main(string[] args)
    {
        Sale sale = new Sale();
        Products products = new Products();
        Cart cart = new Cart();
        Closing closing = new Closing();
        Add add = new Add();
        Remove remove = new Remove();


        List<string> options = new List<string>{"1. Add to cart", "2. Remove from cart", "3. Show cart", "4. Generate Bill", "5. Sales cash closing", "6. Quit"};

        string answer = "0";

        while (answer != "6") {
            foreach (string option in options) {
                Console.WriteLine(option);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Please select an option");
            answer = Console.ReadLine();

            if (answer == "1") {

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
                            int currentSale = sale.GetTotal();
                            sale.SetTotal(currentSale + intPrice);
                            cart.products.Add(productName);
                            cart.prices.Add(intPrice);
                            Console.WriteLine("The product was added to the cart");
                        }

                    }

                }

                
            }

            if (answer == "2"){ /*Remove from cart option */


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

            if (answer == "3"){ /*View cart option*/
                
                
                Console.WriteLine("The products in the cart are:");
                Console.WriteLine(" ");

                int numIndex = 1;
                foreach (var (x, y) in cart.products.Zip(cart.prices)){
                    Console.WriteLine($"{numIndex}. {x} ${y}");
                    numIndex += 1;
                }
                Console.WriteLine(" ");
                Console.WriteLine($"Cart total ${sale.GetTotal()}");
                Console.WriteLine(" ");
            }

            if (answer == "4"){ /*Bill Option */

                Console.WriteLine(" ");
                Console.Write("Num   ");
                Console.Write("Product    ");
                Console.Write("Price\n______________________ ");
            
                
                Console.WriteLine(" ");


                int numIndex = 1;
                foreach (var (x, y) in cart.products.Zip(cart.prices)){
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
                cart.products.Clear();
                cart.prices.Clear();

            }

            if (answer == "5"){ /*Sales Closing Option */
                Console.WriteLine(" ");
                Console.WriteLine($"The total of this day is: ${closing.GetSalesCashClosing()}");
                Console.WriteLine(" ");
            }
        }
    }
}