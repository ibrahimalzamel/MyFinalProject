using Business.Abstract;
using Business.Constants;
using Core.Utilities.DataResults;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _ProductDal;

        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }

        public IResult Add(Product product)
        {
            // business codes
            if (product.ProductName.Length<2)
            {
                //magic strings
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            _ProductDal.Add(product);

            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
            _ProductDal.Delete(product);

            return new Result(true);

        }
        public IResult Update(Product product)
        {
            _ProductDal.Update(product);
            return new Result(true);
        }

        // List<Product> _products; 
        public IDataResult<List<Product>> GetAll()
        {

            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult();
            }
            return new SuccessDataResult<List<Product>>( _ProductDal.GetAll(), true,Messages.Product);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int Id)
        {
            return _ProductDal.GetAll(p => p.CategoryID == Id);
        }

        public Product GetById(int productId)
        {
            return _ProductDal.Get(p => p.ProductID == productId);

        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return _ProductDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetailDtos()
        {
            return _ProductDal.GetProductDetailDtos();
        }

       
    }
}
