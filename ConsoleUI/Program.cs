using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //S(O)LID
    //Open Closed Principle - Yeni özellik eklendiğinde bozulmama
    class Program
    {
        static void Main(string[] args)
        {
            // ProductTest();
            //CategoryTest();
            //ListOfProduct();

            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetProductDetails();

            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }

        private static void ListOfProduct()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

            foreach (var product in productManager.GetProductDetails().Data)
            {
                Console.WriteLine("ID : {0} - Kategori : {1} - Ürün : {2} - Fiyat : {3} - Stok Durumu : {4}",
                   product.ProductId, product.CategoryName, product.ProductName, product.UnitPrice, product.UnitsInStock);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

            foreach (var product in productManager.GetAll().Data)
            {
                Console.WriteLine("ID : {0} - Kategori : {1} - Ürün : {2} - Fiyat : {3} - Stok Durumu : {4}",
                   product.ProductId, product.CategoryId, product.ProductName, product.UnitPrice, product.UnitsInStock);
            }
        }
    }
}
