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
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine("ID : {0} - Kategori : {1} - Ürün : {2} - Fiyat : {3} - Stok Durumu : {4}",
                   product.ProductId, product.CategoryName, product.ProductName, product.UnitPrice, product.UnitsInStock);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine("ID : {0} - Kategori : {1} - Ürün : {2} - Fiyat : {3} - Stok Durumu : {4}",
                   product.ProductId, product.CategoryId, product.ProductName, product.UnitPrice, product.UnitsInStock);
            }
        }
    }
}
