using DataAccess.Concrete.InMemory;
using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        //SOLID
        //Open Closed Principle
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(40,100)) 
            {
                Console.WriteLine(product.ProductName);
            }
            
            Console.ReadLine();
        }
    }
}
