using Business.Abstract;
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

            if (product.ProductName.Length<2)
            {
                return new ErrorResult("Ürün isim en az 2 karakter olmalıdır");
            }
            _ProductDal.Add(product);

            return new SuccessResult("Ürün Eklendi");
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
        public List<Product> GetAll()
        {

            // İş Kodları
            // Yetkisi var mi ? 
            return _ProductDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int Id)
        {
            return _ProductDal.GetAll(p => p.CategoryID == Id);
        }

        public Product GetById(int productId)
        {
            return _ProductDal.Get(p => p.ProductID == productId);

        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _ProductDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetailDtos()
        {
            return _ProductDal.GetProductDetailDtos();
        }

       
    }
}
