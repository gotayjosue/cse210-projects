public class Products : Sale
{
    private string _productFile = "Products.txt";

    public string GetProducts() {

        return _productFile;
    }
}