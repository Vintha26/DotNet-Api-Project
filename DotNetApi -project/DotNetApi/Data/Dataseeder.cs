using DotNetApi.Model;
using Microsoft.EntityFrameworkCore;

namespace DotNetApi.Data
{
    public static class DataSeeder
    {
        public static async Task SeedAsync(AppDbContext context)
        {
            
            if (await context.Customers.AnyAsync())
            {
                return;
            }

            // Customer
            var customer = new Customer
            {
                CustomerName = "Yagna",
                CustomerEmail = "yagna@gmail.com",
                CustomerPhone = "5045551234",
                CustomerAddress = "Golden Monarch Street",
                CustomerCity = "Jacksonville",
                CustomerPostalCode = "32217",
                CustomerCountry = "USA"
            };

            // Employee
            var employee = new Employee
            {
                EmployeeFirstName = "Vintha",
                EmployeeLastName = "Sree",
                Birthday = new DateTime(1990, 5, 15),
                Notes = "Dot Net Employee"
            };

            // Shipper
            var shipper = new Shipper
            {
                ShipperName = "Fast Shipping",
                phone = "5045555678"
            };

            // Category
            var category = new Category
            {
                CategoryName = "Electronics",
                CategoryDescription = "Electronic products"
            };

            // Supplier
            var supplier = new Supplier
            {
                SupplierName = "Tech Supplier",
                SupplierEmail = "supplier@gmail.com",
                SupplierPhone = "9045559876",
                SupplierCity = "Jacksonville",
                SupplierCountry = "USA"
            };

            context.Customers.Add(customer);
            context.Employees.Add(employee);
            context.Shippers.Add(shipper);
            context.Categories.Add(category);
            context.Suppliers.Add(supplier);

            await context.SaveChangesAsync();

            // Product
            var product = new Product
            {
                ProductName = "Laptop",
                Unit = "1 Piece",
                Price = 1200.00m,
                SupplierId = supplier.SupplierId,
                CategoryId = category.CategoryId
            };

            context.Products.Add(product);

            await context.SaveChangesAsync();

            // Order
            var order = new Order
            {
                CustomerId = customer.CustomerId,
                EmployeeId = employee.EmployeeId,
                ShipperId = shipper.ShipperId,
                OrderDate = DateTime.Now
            };

            context.Orders.Add(order);

            await context.SaveChangesAsync();

            // Order Detail
            var orderDetail = new OrderDetail
            {
                OrderId = order.OrderId,
                ProductId = product.ProductId,
                Quantity = 2
            };

            context.OrderDetails.Add(orderDetail);

            await context.SaveChangesAsync();
        }
    }
}