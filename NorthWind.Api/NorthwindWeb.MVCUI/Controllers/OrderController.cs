﻿using Microsoft.AspNetCore.Mvc;
using Northwind.BL.Abstract;
using Northwind.Entites.Entities;
using NorthwindWeb.MVCUI.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
namespace NorthwindWeb.MVCUI.Controllers
{
    public class OrderController(NorthwindContext context) : Controller
    {
        public IActionResult Index()
        {
            /*
             * select OrderID ,c.CompanyName Customer,(e.FirstName + ' ' + e.LastName) Employee ,
                 s.CompanyName Shipper,o.OrderDate,o.ShipCity,o.ShipCountry
                 from Orders o 
                 inner join Customers c on c.CustomerID=o.CustomerID
                 inner join Employees e on e.EmployeeID = o.EmployeeID
                 inner join Shippers s on s.ShipperID =o.ShipVia
             * 
             * 
             * 
             * 
             * 
             */

            #region Metod Syntax
            //var selectVm = context.Orders
            //       .Include(p => p.Customer)
            //       .Include(p => p.Employee)
            //       .Include(p => p.ShipViaNavigation)
            //       .Select(p => new OrderSelectVM
            //       {
            //           OrderId = p.OrderId,
            //           Customer = p.Customer.CompanyName,
            //           Employee = p.Employee.FirstName + " " + p.Employee.LastName,
            //           Shipper = p.ShipViaNavigation.CompanyName,
            //           OrderDate = p.OrderDate,
            //           ShipCity = p.ShipCity,
            //           ShipCountry = p.ShipCountry

            //       }).ToList(); 
            #endregion

            #region Query Syntax
            var result = (from order in context.Orders
                          join customer in context.Customers on order.CustomerId equals customer.CustomerId
                          join employee in context.Employees on order.EmployeeId equals employee.EmployeeId
                          join shipper in context.Shippers on order.ShipVia equals shipper.ShipperId
                          select new OrderSelectVM
                          {
                              OrderId = order.OrderId,
                              Customer = order.Customer.CompanyName,
                              Employee = order.Employee.FirstName + " " + order.Employee.LastName,
                              Shipper = order.ShipViaNavigation.CompanyName,
                              OrderDate = order.OrderDate,
                              ShipCity = order.ShipCity,
                              ShipCountry = order.ShipCountry
                          }).ToList(); 
            #endregion
            return View(result);
        }
        public IActionResult Create()
        {
            OrderInsertDTO dTO = new OrderInsertDTO();
            dTO.ShipperList = new SelectList(context.Shippers.ToList(), "ShipperId", "CompanyName");
            dTO.CustomerList = new SelectList(context.Customers.ToList(), "CustomerId", "CompanyName");
            dTO.EmployeeList = new SelectList(context.Employees.ToList(), "EmployeeId", "FirstName LastName");
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
