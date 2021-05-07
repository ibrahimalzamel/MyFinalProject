using Core.Utilities.DataResults;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        //IDataResult
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
        IDataResult <List<Product>> GetAll();
        IDataResult<Product> GetById(int productId);
        IDataResult<List<Product>> GetAllByCategoryId(int Id);
        IDataResult<List<ProductDetailDto>> GetProductDetailDtos();
        IDataResult<List<Product>> GetByUnitPrice(decimal min , decimal max);
     
     
      
    }
}
