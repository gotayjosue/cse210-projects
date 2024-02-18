public class Products : Sale
{
    private string _productsFile = "Products.txt";

    public string GetProducts() {

        return _productsFile;
    }
}