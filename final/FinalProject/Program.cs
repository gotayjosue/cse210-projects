using System;
using System.Security.Permissions;

class Program
{
    static void Main(string[] args)
    {
        Sale sale = Sale.Instance;
        Products products = new Products();
        Cart cart = Cart.Instance;
        Closing closing = Closing.Instance;
        Add add = new Add();
        Remove remove = new Remove();
        Bill bill = new Bill();


        List<string> options = new List<string>{"1. Add to cart", "2. Remove from cart", "3. Show cart", "4. Generate Bill", "5. Sales cash closing", "6. Quit"};

        string answer = "0";

        while (answer != "6") {
            foreach (string option in options) { /* Add to cart option */
                Console.WriteLine(option);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Please select an option");
            answer = Console.ReadLine();

            if (answer == "1") {

                add.RenderCart();
  
            }

            if (answer == "2"){ /*Remove from cart option */

                remove.RenderCart();

            }

            if (answer == "3"){ /*View cart option*/
                
                
                Console.WriteLine("The products in the cart are:");
                Console.WriteLine(" ");

                int numIndex = 1;
                foreach (var (x, y) in cart.GetProductsList().Zip(cart.GetPricesList())){
                    Console.WriteLine($"{numIndex}. {x} ${y}");
                    numIndex += 1;
                }
                Console.WriteLine(" ");
                Console.WriteLine($"Cart total ${sale.GetTotal()}");
                Console.WriteLine(" ");
            }

            if (answer == "4"){ /*Bill Option -- If you choose this option a bill is going to generate, the cart is going to be cleared and the total sale too*/

                bill.GenerateBill();
            }

            if (answer == "5"){ /*Sales Closing Option -- This option is for you to see the total amount of money you have earn for every sale */
                Console.WriteLine(" ");
                Console.WriteLine($"The total of this day is: ${closing.GetSalesCashClosing()}");
                Console.WriteLine(" ");
            }
        }
    }
}