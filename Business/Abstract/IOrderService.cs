using Core.Utilities.DataResults;
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

    }
}
