﻿using Business.Abstract;
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
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult(true,SuccessMessages.CategoryAdded);
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(true,SuccessMessages.CategoryDeleted);
        }

        public IDataResult< List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>( _categoryDal.GetAll(), SuccessMessages.CategoryListed);
        }
        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category> (_categoryDal.Get(c => c.CategoryID == categoryId), SuccessMessages.CategoryListed);
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(true, SuccessMessages.CategoryUpdated);
        }
    }
}
