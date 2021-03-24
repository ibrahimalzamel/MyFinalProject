using Business.Abstract;
using Business.Constants;
using Core.Utilities.DataResults;
using Core.Utilities.Results;
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

        public IResult Add(Order order)
        {
            _OrderDal.Add(order);
            return new SuccessResult(true, SuccessMessages.OrderAdded);
        }

        public IResult Delete(Order order)
        {
            _OrderDal.Delete(order);
            return new SuccessResult(true, SuccessMessages.OrderDeleted);
        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>( _OrderDal.GetAll(), SuccessMessages.OrderListed);
        }

        public IDataResult<Order> GetById(int orderId)
        {
            return new SuccessDataResult<Order>( _OrderDal.Get(o => o.OrderID == orderId), SuccessMessages.OrderListed);
        }

        public IDataResult<List<OrderDetailDto>> GetOrdersDetailDtos()
        {
            return new SuccessDataResult<List<OrderDetailDto>>( _OrderDal.GetOrdersDetailDtos(),SuccessMessages.OrderListed);
        }

        public IResult Update(Order order)
        {
            _OrderDal.Update(order);
            return new SuccessResult(true,SuccessMessages.OrderUpdated);
        }
    }
}
