using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {   //Veritabanından geliyormuş gibi simule ediyoruz
            _products = new List<Product> { 
                new Product {ProductId=1, CategoryId=1, ProductName = "Bardak", UnitPrice=15,UnitsInStock=15},
                new Product {ProductId=2, CategoryId=2, ProductName = "Kamera", UnitPrice=500,UnitsInStock=3},
                new Product {ProductId=2, CategoryId=2, ProductName = "Telefom", UnitPrice=1500,UnitsInStock=2},
                new Product {ProductId=2, CategoryId=2, ProductName = "Klavye", UnitPrice=150,UnitsInStock=65},
                new Product {ProductId=2, CategoryId=2, ProductName = "Fare", UnitPrice=85,UnitsInStock=1},
                new Product {ProductId=3, CategoryId=3, ProductName = "Fatih Kalem", UnitPrice=15,UnitsInStock=100},
                new Product {ProductId=4, CategoryId=4, ProductName = "Fenerbahçe 2021 Çubuklu Maç Forması", UnitPrice=230,UnitsInStock=200},
                new Product {ProductId=3, CategoryId=5, ProductName = "Citroen Berlingo Koltuk Kılıfı", UnitPrice=450,UnitsInStock=15},
            };
        }
        
       
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {   //Gönderdiğim ürün Id'sine sahip Listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
