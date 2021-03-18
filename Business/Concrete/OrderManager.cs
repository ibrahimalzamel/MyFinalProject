using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _OrderDal;
        
        public OrderManager(IOrderDal orderDal)
        {
            _OrderDal = orderDal;
        }

        public List<Order> GetAll()
        {
            return _OrderDal.GetAll();
        }

        public Order GetById(int orderId)
        {
            return _OrderDal.Get(o => o.OrderID == orderId);
        }

        public List<OrderDetailDto> GetOrdersDetailDtos()
        {
            return _OrderDal.GetOrdersDetailDtos();
        }
    }
}
