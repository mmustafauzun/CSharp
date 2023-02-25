namespace OOP1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Birinci yol - first way
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Masa";
            product1.CategoryId = 2;
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            // ikinci yol - second way
            Product product2 = new Product {Id= 2,CategoryId=5,UnitsInStock=5,ProductName="Kalem",UnitPrice=35 };

            // Creating an instance using ProdutcManager
            // case sensitive
            // PascalCase   //camelCase
                    // stack                     //heap
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
        }
    }
}