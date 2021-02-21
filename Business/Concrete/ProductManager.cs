using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
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

        List<Product> _products; 
        public List<Product> GetAll()
        {

            // İş Kodları
            // Yetkisi var mi ? 
            return _ProductDal.GetAll();
        }
    }
}
