using Business.Abstract;
using Core.Utilities.DataResults;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>> ( _customerDal.GetAll());
        }

        public IDataResult<Customer> GetById(string customerId)
        {
            return new ErrorDataResult<Customer> (_customerDal.Get(c=>c.CustomerID == customerId));
        }
       
    }
}
