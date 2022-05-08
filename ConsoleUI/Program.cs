


// See https://aka.ms/new-console-template for more information
using Busines.Concrete;
using DataAccess.Concrete.EntityFramework;

Console.WriteLine("Hello, World!");

ProductDetailTest();
//CategoryTest();





static void ProductDetailTest()
{
    ProductManager productManager = new(new EfProductDal());
    var result = productManager.GetProductDetails();

    if (result.Success)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine($"{product.ProductName} - {product.CategoryName}");
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }

    Console.WriteLine("\n\n\n\n");
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}