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
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(50,100))
            {
                Console.WriteLine( "Kategori : {0} - Ürün : {1} - Fiyat : {2} - Stok Durumu : {3}",
                   product.CategoryId ,product.ProductName, product.UnitPrice, product.UnitsInStock
                                  );
            };
        }
    }
}
