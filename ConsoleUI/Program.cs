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
            Start start = new Start();
            start.ProductTest();
            start.OrderTest(); 
            start.CustomerTest();
            start.CategoryTest();
        }
    }
}
