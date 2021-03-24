using Core.Utilities.DataResults;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        IDataResult<Order> GetById(int orderId);
        IDataResult<List<OrderDetailDto>> GetOrdersDetailDtos();
        IResult Add(Order order);
        IResult Update(Order order);
        IResult Delete(Order order);
    }
}
