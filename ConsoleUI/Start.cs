using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Start
    {
        //order
        public  void OrderTest()
        {
            OrderManager orderManager = new OrderManager(new EfOrderDal());
            foreach (var order in orderManager.GetAll().Data)
            {
                Console.WriteLine("CustomerID : " + order.CustomerID);
                Console.WriteLine("EmployeeID : " + order.EmployeeID);
                Console.WriteLine("OrderID : " + order.OrderID);
                Console.WriteLine("ShipCity : " + order.ShipCity);
                Console.WriteLine("OrderDate : " + order.OrderDate);
                Console.WriteLine("---------------------------");
            }
            foreach (var order in orderManager.GetOrdersDetailDtos().Data)
            {
                Console.WriteLine("CompanyName : " + order.CompanyName + " \t " + "ContactName : " + order.ContactName);
                Console.WriteLine("---------------------------");
            }
        }
        //Category
        public void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        /**   public  void ProductTest()
           {
               ProductManager productManager = new ProductManager(new EfProductDal());
               //var result = productManager.GetProductDetailDtos();
               //if (result.Success == true)
               //{
               //    foreach (var product in result.Data)
               //    {
               //        Console.WriteLine("ProductId" + product.ProductId);
               //        Console.WriteLine("ProductName" + product.ProductName);
               //        Console.WriteLine("CategoryName" + product.CategoryName);
               //        Console.WriteLine("UnitsInStock" + product.UnitsInStock);
               //    }
               //}
               //else
               //{
               //    Console.WriteLine(result.Message);
               //}


               var result2 = productManager.GetAll();
               if (result2.Success == true)
               {
                   foreach (var product in result2.Data)
                   {
                       Console.WriteLine("ProductID : " + product.ProductID);
                       Console.WriteLine("ProductName : " + product.CategoryID);
                       Console.WriteLine("ProductName : " + product.ProductName);
                       Console.WriteLine("UnitPrice : " + product.UnitPrice);
                       Console.WriteLine("ProductName : " + product.UnitsInStock);
                       Console.WriteLine("=========================" );

                   }
               }
               else
               {
                   Console.WriteLine(result2.Message);
               }

               //foreach (var product in productManager.GetAll().Data)
               //{
               //    Console.WriteLine("ProductID : " + product.ProductID);
               //    Console.WriteLine("ProductName : " + product.CategoryID);
               //    Console.WriteLine("ProductName : " + product.ProductName);
               //    Console.WriteLine("UnitPrice : " + product.UnitPrice);
               //    Console.WriteLine("ProductName : " + product.UnitsInStock);
               //}

               //productManager.Add(new Product
               //{
               //    ProductID = 78,
               //    ProductName = "Test",
               //    SupplierID = 10,
               //    CategoryID = 220,
               //    QuantityPerUnit = "0 boxes x 8 pieces",
               //    UnitPrice = 500,
               //    UnitsInStock = 7,
               //    UnitsOnOrder = 70,
               //    ReorderLevel = 20,
               //    Discontinued = false

               //});
               //productManager.GetById(2021);
               //productManager.GetAllByCategoryId(2020);

               //foreach (var product in productManager.GetProductDetailDtos().Data)
               //{
               //    Console.WriteLine("ProductId" + product.ProductId);
               //    Console.WriteLine("ProductName" + product.ProductName);
               //    Console.WriteLine("CategoryName" + product.CategoryName);
               //    Console.WriteLine("UnitsInStock" + product.UnitsInStock);
               //}

               //productManager.GetByUnitPrice(500, 1500);

               //productManager.Update(new Product
               //{
               //    ProductID = 2025,
               //    CategoryID = 2025,
               //    ProductName = "TestTest",
               //    UnitPrice = 50,
               //    UnitsInStock = 70
               //});
               //productManager.Delete(new Product
               //{
               //    ProductID = 50,
               //    ProductName = "Valkoinen suklaa",
               //    SupplierID = 23,
               //    CategoryID =3,
               //    QuantityPerUnit = "12 - 100 g bars",
               //    UnitPrice = 162500,
               //    UnitsInStock = 65,
               //    UnitsOnOrder = 0,
               //    ReorderLevel = 30,
               //    Discontinued = false
               //});

           }*/
        //customer
        //********************** SonarQube ********************
        public void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine("CustomerID : " + customer.CustomerID);
                Console.WriteLine("CompanyName : " + customer.CompanyName);
                Console.WriteLine("ContactName : " + customer.ContactName);
                Console.WriteLine("City : " + customer.City);
            }
            Customer customer1 =customerManager.GetById("TRAIH").Data;
            Console.WriteLine(customer1.CompanyName);
            Console.WriteLine(customer1.ContactName);
            Console.WriteLine(customer1.City);

        }
    }
}
