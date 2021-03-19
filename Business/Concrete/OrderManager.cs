using Business.Abstract;
using Core.Utilities.DataResults;
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

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>( _OrderDal.GetAll());
        }

        public IDataResult<Order> GetById(int orderId)
        {
            return new SuccessDataResult<Order>( _OrderDal.Get(o => o.OrderID == orderId));
        }

        public IDataResult<List<OrderDetailDto>> GetOrdersDetailDtos()
        {
            return new SuccessDataResult<List<OrderDetailDto>>( _OrderDal.GetOrdersDetailDtos());
        }
    }
}
