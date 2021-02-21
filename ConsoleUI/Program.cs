using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //DataAccess.Concrete.InMemory.InMemoryProductDal;
            ProductManager productManager1 = new ProductManager(new InMemoryProductDal());

            foreach (var product in productManager1.GetAll())
            {
                Console.Write("ProductId : "+ product.ProductId + ", ");
                Console.Write("CategoryId : " + product.CategoryId + ", ");
                Console.Write("ProductName : " + product.ProductName + ", ");
                Console.Write("UnitPrice : " + product.UnitPrice + ", ");
                Console.WriteLine("UnitsInStock : " + product.UnitsInStock + ", ");

            }


            //DataAccess.Concrete.EntityFramework.EFProductDal;
            ProductManager productManager2 = new ProductManager(new EFProductDal());

            foreach (var product in productManager2.GetAll())
            {
                Console.Write("ProductId : " + product.ProductId + ", ");
                Console.Write("CategoryId : " + product.CategoryId + ", ");
                Console.Write("ProductName : " + product.ProductName + ", ");
                Console.Write("UnitPrice : " + product.UnitPrice + ", ");
                Console.WriteLine("UnitsInStock : " + product.UnitsInStock + ", ");

            }

        }
    }
}
