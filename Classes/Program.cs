// See https://aka.ms/new-console-template for more information
using System.Collections.Specialized;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
//book
Book book1 = new Book();
book1.title = "1984";
book1.autor = "George Orwell";
book1.bookInfo();

Book book2 = new Book();
book2.title = "Ham on rye";
book2.autor = "Charles Bukowski";
book2.bookInfo();

Book book3 = new Book();
book3. title = "man for himself";
book3.autor = "Erich Fromm";
book3.bookInfo();

//employee
Employee worker = new Employee();
worker.name = "Anton";
worker.position = "traine Junior";
worker.salary = 300;
worker.workDays = 20;
worker.addWorkDays();
worker.printSummary();

Order Shop = new Order();
Shop.PrintOrder();

class Book
{
    public string title { get; set; }
    public string autor { get; set; }
    public void bookInfo()
    {
        Console.WriteLine($"Name Of book: {title}, Author: {autor}");
    }
}


class Employee
{
    public string name { get; set; }
    public string position { get; set; }
    public double salary { get; set; }
    private int _workDays;
    public int workDays { get { return _workDays; }
                          set { _workDays = value; } 
                        }
    public void addWorkDays(int days = 1)
    {
        if (days > 0)
        {
            workDays += days;
        }
    }
    public void printSummary()
    {
        Console.WriteLine($"\nName: {name}, \nPosition: {position}, \nSalary: {salary}, \nQuantity of work days: {workDays}");
    }
    
   
}

class Order
{
    private List<string>_products;
    public bool isCompleted { get; set; }
    public void Filling(List<string> element)
    {
        _products.Add("computer");
        _products.Add("Volksvagen Golf");
        _products.Add("Smartphone");
        _products.Add("Peace to Ukraine");
    }
    public void AddProducts(string products)
    {
        _products.Add(products);
    }
       
    public void RemoveProduct(string product)
    {
        _products.Remove(product);
        
    }
    public void PrintOrder()
    {
        foreach(string a in _products)
        {
            Console.WriteLine($"Products: {a} ");
        }
    }
    
    
}

    


