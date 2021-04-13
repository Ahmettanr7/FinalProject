using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine( "Kategori : {0}  Ürün : {1}  Fiyat : {2}  Stok Durumu : {3}",
                   product.CategoryId ,
                   product.ProductName, 
                   product.UnitPrice, 
                   product.UnitsInStock
                    );
            };
        }
    }
}
