// See https://aka.ms/new-console-template for more information
using Classes;
using System.Collections.Specialized;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
//book
Book book1 = new Book();
book1.Title = "1984";
book1.Autor = "George Orwell";
book1.BookInfo();

Book book2 = new Book();
book2.Title = "Ham on rye";
book2.Autor = "Charles Bukowski";
book2.BookInfo();

Book book3 = new Book();
book3. Title = "man for himself";
book3.Autor = "Erich Fromm";
book3.BookInfo();

//employee
Employee worker = new Employee();
worker.Name = "Anton";
worker.Position = "traine Junior";
worker.Salary = 300;
worker.WorkDays = 15;

Console.WriteLine("You must have minimum 25 work days");
worker.AddWorkDays();
worker.PrintSummary();

//Order
Order shop = new Order();
shop.AddProducts("Nissan Rogue");
shop.PrintOrder();
shop.RemoveProduct("Computer");
shop.PrintOrder();






    


