using System;
using System.Collections.Generic;
using ClassLibrary1;
using ClassLibrary2;
using ClassLibrary3;
//class Program
//{
//    static void Main(string[] args)
//    {
//        List<Customer> customers = new List<Customer>
//        {
//            new Customer { CustomerId = 1, Firstname = "John", Lastname = "Doe", Country = "USA" },
//            new Customer { CustomerId = 2, Firstname = "Jane", Lastname = "Doe", Country = "USA" },
//            new Customer { CustomerId = 3, Firstname = "Alice", Lastname = "Smith", Country = "Canada" },
//            new Customer { CustomerId = 4, Firstname = "Bob", Lastname = "Smith", Country = "Canada" },
//            new Customer { CustomerId = 5, Firstname = "Charlie", Lastname = "Brown", Country = "USA" }
//        };

//        List<Product> products = new List<Product>
//        {
//            new Product { ProductId = 1, Productname = "Chai", UnitPrice = 18.00M },
//            new Product { ProductId = 2, Productname = "Chang", UnitPrice = 19.00M },
//            new Product { ProductId = 3, Productname = "Aniseed Syrup", UnitPrice = 10.00M },
//            new Product { ProductId = 4, Productname = "Chef Anton's Cajun Seasoning", UnitPrice = 22.00M },
//            new Product { ProductId = 5, Productname = "Chef Anton's Gumbo Mix", UnitPrice = 21.35M },
//            new Product { ProductId = 6, Productname = "Grandma's Boysenberry Spread", UnitPrice = 25.00M },
//            new Product { ProductId = 7, Productname = "Uncle Bob's Organic Dried Pears", UnitPrice = 30.00M },
//            new Product { ProductId = 8, Productname = "Northwoods Cranberry Sauce", UnitPrice = 40.00M },
//            new Product { ProductId = 9, Productname = "Mishi Kobe Niku", UnitPrice = 97.00M },
//            new Product { ProductId = 10, Productname = "Ikura", UnitPrice = 31.00M },
//            new Product { ProductId = 11, Productname = "Queso Cabrales", UnitPrice = 21.00M },
//            new Product { ProductId = 12, Productname = "Queso Manchego La Pastora", UnitPrice = 38.00M },
//            new Product { ProductId = 13, Productname = "Konbu", UnitPrice = 6.00M },
//            new Product { ProductId = 14, Productname = "Tofu", UnitPrice = 23.25M },
//            new Product { ProductId = 15, Productname = "Genen Shouyu", UnitPrice = 15.50M }
//        };

//        List<Order> orders = new List<Order>
//            {
//                new Order { OrderId = 1, CustomerId = 1, OrderDate = new DateTime(2022, 1, 1), ShippedDate = new DateTime(2022, 1, 10) },
//                new Order { OrderId  = 2, CustomerId = 1, OrderDate = new DateTime(2022, 2, 1), ShippedDate = new DateTime(2022, 2, 10) },
//                new Order { OrderId  = 3, CustomerId = 2, OrderDate = new DateTime(2022, 3, 1), ShippedDate = new DateTime(2022, 3, 10) },
//                new Order {  OrderId  = 4, CustomerId = 3, OrderDate = new DateTime(2022, 4, 1), ShippedDate = new DateTime(2022, 4, 10) },
//                new Order {  OrderId  = 5, CustomerId = 4, OrderDate = new DateTime(2022, 5, 1), ShippedDate = new DateTime(2022, 5, 10) },
//                new Order {  OrderId  = 6, CustomerId = 5, OrderDate = new DateTime(2022, 6, 1), ShippedDate = new DateTime(2022, 6, 10) },
//                new Order {  OrderId  = 7, CustomerId = 1, OrderDate = new DateTime(2022, 7, 1), ShippedDate = new DateTime(2022, 7, 10) },
//                new Order {  OrderId  = 8, CustomerId = 2, OrderDate = new DateTime(2022, 8, 1), ShippedDate = new DateTime(2022, 8, 10) },
//                new Order {  OrderId  = 9, CustomerId = 3, OrderDate = new DateTime(2022, 9, 1), ShippedDate = new DateTime(2022, 9, 10) },
//                new Order {  OrderId  = 10, CustomerId = 4, OrderDate = new DateTime(2022, 10, 1), ShippedDate = new DateTime(2022, 10, 10) }
//                };

//        // define a list of order details
//        List<OrderDetail> orderDetails = new List<OrderDetail>()
//            {
//                new OrderDetail() { OrderDetailId = 1, OrderId = 1, ProductId = 1, Quantity = 5, Discount = 0.1m },
//                new OrderDetail() { OrderDetailId = 2, OrderId = 1, ProductId = 2, Quantity = 3, Discount = 0m },
//                new OrderDetail() { OrderDetailId = 3, OrderId = 2, ProductId = 3, Quantity = 2, Discount = 0.05m },
//                new OrderDetail() { OrderDetailId = 4, OrderId = 2, ProductId = 4, Quantity = 1, Discount = 0m },
//                new OrderDetail() { OrderDetailId = 5, OrderId = 3, ProductId = 5, Quantity = 4, Discount = 0m },
//                new OrderDetail() { OrderDetailId = 6, OrderId = 4, ProductId = 6, Quantity = 2, Discount = 0m },
//                new OrderDetail() { OrderDetailId = 7, OrderId = 4, ProductId = 7, Quantity = 1, Discount = 0m },
//                new OrderDetail() { OrderDetailId = 8, OrderId = 5, ProductId = 8, Quantity = 3, Discount = 0m },
//                new OrderDetail() { OrderDetailId = 9, OrderId = 5, ProductId = 9, Quantity = 2, Discount = 0m },
//                new OrderDetail() { OrderDetailId = 10, OrderId = 5, ProductId = 10, Quantity = 1, Discount = 0m },
//                new OrderDetail() { OrderDetailId = 11, OrderId = 6, ProductId = 1, Quantity = 4, Discount = 0m },
//                new OrderDetail() { OrderDetailId = 12, OrderId = 7, ProductId = 2, Quantity = 1, Discount = 0m },
//                new OrderDetail() { OrderDetailId = 13, OrderId = 7, ProductId = 3, Quantity = 2, Discount = 0m },
//                new OrderDetail() { OrderDetailId = 14, OrderId = 7, ProductId = 4, Quantity = 3, Discount = 0.1m },
//                new OrderDetail() { OrderDetailId = 15, OrderId = 8, ProductId = 5, Quantity = 7, Discount = 0m },
//                new OrderDetail() { OrderDetailId = 16, OrderId = 8, ProductId = 6, Quantity = 1, Discount = 0m },
//                new OrderDetail() { OrderDetailId = 17, OrderId = 9, ProductId = 7, Quantity = 2, Discount = 0m },
//                new OrderDetail() { OrderDetailId = 18, OrderId = 10, ProductId = 8, Quantity = 3, Discount = 0m },
//                new OrderDetail() { OrderDetailId = 19, OrderId = 10, ProductId = 9, Quantity = 1, Discount = 0m },
//                new OrderDetail() { OrderDetailId = 20, OrderId = 10, ProductId = 10, Quantity = 4, Discount = 0m }
//            };

//        var allcustomers = customers.OrderBy(temp => temp.Lastname);

//        var allproducts = products.OrderByDescending(p => p.UnitPrice);

//        var shippedoct = orders.Where(o => o.ShippedDate?.Year == 2021 && o.ShippedDate?.Month == 10);

//        var usacustomers = orders.Where(o => customers.Any(c => c.CustomerId == o.CustomerId && c.Country == "USA"));

//        var query5 = orderDetails
//        .GroupBy(od => od.ProductId)
//        .Select(g => new
//        {
//            ProductID = g.Key,
//            TotalQuantity = g.Sum(od => od.Quantity),
//            TotalRevenue = g.Sum(od => od.Quantity * products.Single(p => p.ProductId == od.ProductId).UnitPrice)
//        })
//        .Where(p => p.TotalQuantity > 0);

//        var query6 = customers
//            .Join(
//                orders,
//                customers => customers.CustomerId,
//                orders => orders.OrderId,
//                (customers, orders) => new { customers, orders }
//            ).Join(
//                orderDetails,
//                c => c.orders.OrderId,
//                orderDetails => orderDetails.OrderId,
//                (c, orderDetails) => new { c.customers, c.orders, orderDetails }

//            ).Join(
//                products,
//                c => c.orderDetails.ProductId,
//                products => products.ProductId,
//                (c, products) => new { c.customers, c.orders, c.orderDetails, products }
//            ).GroupBy(
//                c => c.customers,
//                c => c,
//                (customers, orderProducts) => new
//                {
//                    Customer = customers,
//                    TotalAmountSpent = orderProducts.Sum(x => (x.orderDetails.Quantity * x.products.UnitPrice) * (1 - x.orderDetails.Discount)),
//                    NumberOforders = orderProducts.Select(x => x.orders.OrderId).Distinct().Count(),
//                    AverageOrderAmount = orderProducts.Sum(x => (x.orderDetails.Quantity * x.products.UnitPrice) * (1 - x.orderDetails.Discount)) / orderProducts.Select(x => x.orders.OrderId).Distinct().Count(),
//                }

//            )
//            .OrderByDescending(c => c.TotalAmountSpent)
//            .Take(5);

//        //the most popular product 
//        var query7 = orderDetails
//            .GroupBy(od => od.ProductId)
//            .Select(g => new
//            {
//                ProductId = g.Key,
//                TotalQuantity = g.Sum(od => od.Quantity)
//            })
//            .OrderByDescending(p => p.TotalQuantity)
//            .First();





//        Console.WriteLine("all customers in alphabetical order by lastname");
//        foreach (var customer in allcustomers)
//        {
//            Console.WriteLine($"{customer.Firstname} {customer.Lastname}");
//        }

//        Console.WriteLine("all product in descending order by Unit Price");
//        foreach (var product in allproducts)
//        {
//            Console.WriteLine($"{product.Productname} {product.UnitPrice}");
//        }

//        Console.WriteLine("Orders shipped in 2021 and in the month of october");
//        foreach (var order in orders)
//        {
//            Console.WriteLine($"{order.OrderId}  {order.ShippedDate}");
//        }

//        Console.WriteLine("USA customers orders");
//        foreach (var order in usacustomers)
//        {
//            Console.WriteLine($"Order : {order.OrderId}, shipped to {customers.FirstOrDefault(c => c.CustomerId == order.CustomerId)?.Country}");
//        }

//        Console.WriteLine("\nQuery 5: All products that were ordered at least once, along with the total quantity ordered and the total revenue generated by each product");
//        foreach (var product in query5)
//        {
//            Console.WriteLine($"Product: {products.Single(p => p.ProductId == product.ProductID).Productname}");
//            Console.WriteLine($"Total Quantity Ordered: {product.TotalQuantity}");
//            Console.WriteLine($"Total Revenue Generated: {product.TotalRevenue:C}\n");
//        }

//        Console.WriteLine("\nQuery 6: The top 5 customers by the total amount of money they have spent, along with the number of orders they have placed and the average order amount\n");
//        foreach (var custom in query6)
//        {
//            Console.WriteLine($"{custom.Customer.Firstname} {custom.Customer.Lastname}: Total Amount Spent: {custom.TotalAmountSpent:C}, Number Of orders: {custom.NumberOforders}, Average order Amount: {custom.AverageOrderAmount:C}");
//        }

//        Console.WriteLine("\nQuery 7: The most popular product by the number of times it has been ordered");

//        var mostpopularproduct = products.Single(p => p.ProductId == query7.ProductId).Productname;

//        Console.WriteLine($"The most popular product is {mostpopularproduct} , which has been ordered {query7.TotalQuantity} times.");

//        Console.ReadKey();
//    }

//}

class Program
{
    static void Main(string[] args)
    {
     List<Book> books = new List<Book>
    {
    new Book { BookId = 1, Title = "C# Basics", Author = "John Doe", Category = "Programming", Price = 450 },
    new Book { BookId = 2, Title = "ASP.NET MVC", Author = "Jane Smith", Category = "Web Development", Price = 550 },
    new Book { BookId = 3, Title = "LINQ in Action", Author = "Tom Brown", Category = "Programming", Price = 400 },
    new Book { BookId = 4, Title = "HTML & CSS", Author = "Sara Lee", Category = "Web Development", Price = 300 },
    new Book { BookId = 5, Title = "Clean Code", Author = "Robert Martin", Category = "Programming", Price = 600 }
    };

    List<Member> members = new List<Member>
    {
    new Member { MemberId = 1, Name = "Ali", MemberShipType = "VIP", JoinDate = DateTime.Now.AddMonths(-2) },
    new Member { MemberId = 2, Name = "Sara", MemberShipType = "Basic", JoinDate = DateTime.Now.AddYears(-1) },
    new Member { MemberId = 3, Name = "Hamza", MemberShipType = "Premium", JoinDate = DateTime.Now.AddMonths(-5) },
    new Member { MemberId = 4, Name = "Zainab", MemberShipType = "VIP", JoinDate = DateTime.Now.AddMonths(-8) },
    new Member { MemberId = 5, Name = "Usman", MemberShipType = "Basic", JoinDate = DateTime.Now.AddMonths(-1) }
    };

        List<BorrowTransaction> transactions = new List<BorrowTransaction>
    {
    new BorrowTransaction { TransactionId = 1, BookId = 1, MemberId = 1, BorrowDate = DateTime.Now.AddDays(-10), ReturnDate = DateTime.Now.AddDays(-2) },
    new BorrowTransaction { TransactionId = 2, BookId = 2, MemberId = 2, BorrowDate = DateTime.Now.AddDays(-20), ReturnDate = null },
    new BorrowTransaction { TransactionId = 3, BookId = 1, MemberId = 3, BorrowDate = DateTime.Now.AddDays(-15), ReturnDate = DateTime.Now.AddDays(-5) },
    new BorrowTransaction { TransactionId = 4, BookId = 3, MemberId = 1, BorrowDate = DateTime.Now.AddDays(-7), ReturnDate = null },
    new BorrowTransaction { TransactionId = 5, BookId = 2, MemberId = 1, BorrowDate = DateTime.Now.AddDays(-30), ReturnDate = DateTime.Now.AddDays(-20) }
    };

        var result = members
             .GroupJoin(
              transactions,
              m => m.MemberId,
              b => b.MemberId,
              (m, br) => new { members = m, transactions = br }
            )
             .Where(x => !x.transactions.Any())
             .Select(x => x.members);

        foreach (var member in  result)
        {
            Console.WriteLine($"Member: {member.Name}");
        }

        Console.ReadKey();
    }
}
