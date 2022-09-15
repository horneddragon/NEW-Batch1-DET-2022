using Microsoft.EntityFrameworkCore;
using NEW_Batch1_DET_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_Batch1_DET_2022.Models
{

    internal class MainBook
    {
        static void Main()
        {
            //AddNewBook();
            //UpdateBook();
            //GetAllBooks();
            //DeleteBook();
            //Console.ReadLine();
            //AddNewCustomerAndOrder();
            //Addorder();
            //GetCustomersAndOrder_ExplicitLoading();
            //GetCustomerAndOrderEagerLoading();
            Disconnectedarchitecture();

        }

        private static void Disconnectedarchitecture()
        {
            var ctx = new BookContext();

            var customer = ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();

            ctx.Dispose();

            UpdateCustomerName(customer);
        }


        private static void UpdateCustomerName(Customer customer)
        {
            var ctx = new BookContext();
            customer.Name = "Mike";
            Console.WriteLine(ctx.Entry(customer).State.ToString());
            //ctx.Update<Customer>(customer);
            //OR
            ctx.Update(customer);
            //OR
            //ctx.Customers.Update(customer);
            //OR

            // ctx.Attach(customer).State = EntityState.Modified;
            ctx.SaveChanges();
            Console.WriteLine("customer name is updated via disconnected mode");

        }

        //private static void GetCustomersAndOrder_ExplicitLoading()
        //{
        //    //Explicit loading means that the related data is
        //    //explicitly loaded from the database at a later time.
        //    //Needs MARS to be set to TRUE in connection string
        //    var ctx = new BookContext();
        //    try
        //    {
        //        var customers = ctx.Customers;

        //        foreach (var customer in customers)
        //        {
        //            Console.WriteLine(customer.Name);
        //            Console.WriteLine("----->");

        //            ctx.Entry(customer).Collection(o => o.Orders).Load();

        //            foreach (var order in customer.Orders)
        //            {
        //                Console.WriteLine(order.Amount.ToString() + " " + order.OrderDate.ToString());

        //            }
        //            Console.WriteLine("-----");

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
        //private static void GetCustomerAndOrderEagerLoading()
        //{
        //    //Eager loading means that the related data is loaded
        //    //from the database as part of the initial query.
        //    var ctx = new BookContext();
        //    try
        //    {
        //        var customers = ctx.Customers.Include("Orders");

        //        //var customers = ctx.Customers.Include(o => o.Orders);

        //        foreach (var customer in customers)
        //        {
        //            Console.WriteLine(customer.Name);
        //            Console.WriteLine("----->");


        //            foreach (var order in customer.Orders)
        //            {
        //                Console.WriteLine(order.Amount.ToString() + " " + order.Order_ID);
        //            }
        //            Console.WriteLine("-----");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        //public static void Addorder()
        //{
        //    var ctx = new BookContext();
        //    var ord1 = ctx.Orders.Where(b => b.cust.ID == 1).SingleOrDefault();
        //    try
        //    {
        //        ctx.Add(ord1);

        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //private static void AddNewCustomerAndOrder()
        //{
        //    var ctx = new BookContext();
        //     Customer customer = new Customer();
        //    //customer.ID = 1;
        //    //customer.Name = "Anirudha";
        //    //customer.Age = 20;

        //    Order ord = new Order();
        //    //ord.Order_ID = 100;
        //    //ord.Amount = 2020;
        //    //ord.OrderDate = DateTime.Now;




        //    ord.cust = customer;
        //    try
        //    {
        //        ctx.Orders.Add(ord1);
        //        ctx.SaveChanges();
        //        Console.WriteLine("Customer And order is created");
        //    }
        //    catch(Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }

        //}
        //private static void AddNewBook()
        //{
        //    var ctx = new BookContext();
        //    Book book5 = new Book();
        //    book5 = new Book();
        //    book5.BookID = 5;
        //    book5.BookName = "EF Core4";
        //    book5.author = "Taison";
        //    book5.price = 120;


        //    try
        //    {
        //        ctx.Books.Add(book5);
        //        ctx.SaveChanges();
        //        Console.WriteLine("New Book Added  successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //private static void UpdateBook()
        //{
        //    var ctx = new BookContext();
        //    var Book = ctx.Books.Where(b => b.BookID == 3).SingleOrDefault();

        //    try
        //    {
        //        Book.BookName = "EF core - 2";
        //        ctx.Update(Book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("One Book got Updated");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}


        //private static void GetAllBooks()
        //{

        //    var ctx = new BookContext();
        //    var Book = ctx.Books;

        //    Console.WriteLine("Books are:");
        //    foreach (var book in Book)
        //    {
        //        Console.WriteLine(book.BookID + " is " + book.BookName);
        //    }

        //}



        //private static void DeleteBook()
        //{
        //    var ctx = new BookContext();
        //    var Book = ctx.Books.Where(b => b.BookID == 3).SingleOrDefault();
        //    try
        //    {
        //        Book.BookName = "EF core - 2";
        //        ctx.Remove(Book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("One Book got Deleted");
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //public static void InsertBook()
        //{
        //    var ctx = new BookContext();
        //    var book = ctx.Books.Where(b => b.BookID == 3).SingleOrDefault();

        //    try
        //    {
        //        book.BookName =
        //    }
        //}
    }
}