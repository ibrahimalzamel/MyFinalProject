using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfOrderDal : EfEntityRepositoryBase<Order, NorthwindContext>, IOrderDal
    {
        public List<OrderDetailDto> GetOrdersDetailDtos()
        {
            using(NorthwindContext context = new NorthwindContext())
            {
                var result = from o in context.Orders
                             join  c in context.Customers
                             on o.CustomerID equals c.CustomerID
                             select new OrderDetailDto
                             {
                                 OrderID = o.OrderID,
                                 OrderDate = o.OrderDate,
                                 CompanyName= c.CompanyName,
                                 ContactName = c.ContactName,
                                 ShipCity = o.ShipCity
                             };
                return result.ToList();

            }
        }
    }
}
