// See https://aka.ms/new-console-template for more information
using codefirst_sample.Models;
using System;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DBFirst_EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddNewbook();
            //GetAllBooks();
            //GetBookByID();
            //UpdateBookByID();
            //DeleteBookById();
            //AddNewCustomer();
            //DeleteorderById();
             GetAllCustomerWithOrder_EagerLoading();
            //Disconnectedarchitecture();
        }

        private static void Disconnectedarchitecture()
        {
            var ctx = new TrainingContext();

            var customer = ctx.customer.Where(c => c.ID == 1).SingleOrDefault();
            ctx.Dispose();
            UpdateCustomerName(customer);
        }
        private static void UpdateCustomerName(Customer customer)
        {
            var ctx = new TrainingContext(); //new connection to db
            customer.Name = "Divya";
            Console.WriteLine(ctx.Entry(customer).State.ToString());
            ctx.Update<Customer>(customer);
                                                                     
            //OR
                                                                   
            //ctx.Update(customer);
                                                                     //OR
                                                                  
            //ctx.Customers.Update(customer);
                                                                     //OR
           // ctx.Attach(customer).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified; //modifying existing customer //adding new customer
            //Customer cust = new Customer();
            //cust.Name = "Asha";
            //cust.ID = 3;
            //cust.Age = 10;
            //ctx.Attach(cust).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Added;
            ctx.SaveChanges();
            Console.WriteLine("customer name is updated via disconnected mode");
        }



        private static void GetAllCustomerWithOrder_EagerLoading()
        {
            //Eager loading means that the related data is loaded
            //from the database as part of the initial query
            var ctx = new TrainingContext();
            try
            {
                //var customers = ctx.customer.Include("Orders");
                var customers = ctx.customer.Include(o => o.Orders);

                foreach(var cust in customers)
                {
                    Console.WriteLine(cust.Name);
                    Console.WriteLine("--->");

                    foreach(var order in cust.Orders)
                    {
                        Console.WriteLine(order.Amount + " " + order.Order_ID);
                    }
                    Console.WriteLine("----");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }

        private static void DeleteorderById()
        {
            var ctx = new TrainingContext();
            try
            {
                var order = ctx.Orders.Where(o => o.Order_ID == 18).SingleOrDefault();
                ctx.Remove(order);
                ctx.SaveChanges();
                Console.WriteLine("Removed order Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }

        private static void AddNewCustomer()
        {
            var ctx = new TrainingContext();
            Customer newcust = new Customer();
            newcust.ID = 1;
            newcust.Name = "Divya";
            newcust.Age = 22;
            //var customer = ctx.customer.Where(c => c.ID == 1).SingleOrDefault();

            Order ord = new Order();
            ord.Order_ID = 15;
            ord.Amount = 1000;
            ord.OrderDate= DateTime.Now;
            ord.cust = newcust;

            try
            {
                ctx.Orders.Add(ord);
                ctx.SaveChanges();
                Console.WriteLine("New customer and order added");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }

        private static void AddNewbook()
        {
            var ctx = new TrainingContext();
            book bk = new book();
            bk.book_name = "Tsql";
            bk.author = "Anonymous";
            bk.price = 1200;

            try
            {
                ctx.Add(bk);
                ctx.SaveChanges();
                Console.WriteLine("New Book Added");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
      
        }
        private static void GetAllBooks()
        {
            var ctx = new TrainingContext();
            var book = ctx.books;
            //DbSet<Emp> employees1 = ctx.Emps;
            foreach (var bk in book)
            {
                Console.WriteLine(bk.book_id + " " + bk.book_name + " " + bk.price);
            }

        }
        private static void GetBookByID()
        {
            var ctx = new TrainingContext();
            try
            {
                var book = ctx.books.Where(b => b.book_id == 1).SingleOrDefault();
                Console.WriteLine(book.book_name + " " + book.price);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
        private static void UpdateBookByID()
        {
            var ctx = new TrainingContext();
            try
            {
                var book = ctx.books.Where(b => b.book_id == 1001).SingleOrDefault();
                book.book_name = "Jungle book";
                ctx.SaveChanges();
                Console.WriteLine("Updated changes successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
        private static void DeleteBookById()
        {
            var ctx = new TrainingContext();
            try
            {
                var book = ctx.books.Where(b => b.book_id == 1001).SingleOrDefault();
                ctx.Remove(book);
                ctx.SaveChanges();
                Console.WriteLine("Removed Book Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
    }
}