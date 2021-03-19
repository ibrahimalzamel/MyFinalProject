using Business.Abstract;
using Business.Constants;
using Core.Utilities.DataResults;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {


        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {

            //İş kodları
            _categoryDal = categoryDal;
        }

        public IDataResult< List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(Messages.ProductAdded);
        }
        // Select * from Categories where Category = 3 ; 
        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category> (_categoryDal.Get(c => c.CategoryID == categoryId));
        }
    }
}
