﻿using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.DataResults;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _ProductDal;
        ICategoryService _categoryService; 
        public ProductManager(IProductDal productDal , ICategoryService categoryService)
        {
            _ProductDal = productDal;
            _categoryService = categoryService;
        }

        //salting
        //Claim
        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            //Loglama , Cacheremove , performance , transsaction , Auth
            
            IResult result =  BusinessRules.Run(CheckIfProductNameExists(product.ProductName),
                CheckIfProductCountOfCategoryCorrect(product.CategoryID), CheckIfCategoryLimitExceded());

            if (result!=null)
            {
                return result;
            }
            _ProductDal.Add(product);
            return new SuccessResult( Messages.ProductAdded);

        }

        public IResult Delete(Product product)
        {
            _ProductDal.Delete(product);
            return new SuccessResult(true,SuccessMessages.ProductDeleted);
        }
        public IResult Update(Product product)
        {
            _ProductDal.Update(product);
            return new SuccessResult(true,SuccessMessages.ProductUpdated);
        }

        public IDataResult<List<Product>> GetAll()
        {
                  
            return new SuccessDataResult<List<Product>>(_ProductDal.GetAll(), Messages.ProductListed);       
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int Id)
        {
            return new SuccessDataResult<List<Product>>(_ProductDal.GetAll(p => p.CategoryID == Id),Messages.ProductListed);
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_ProductDal.Get(p => p.ProductID == productId),SuccessMessages.ProductListed);
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult <List<Product>>(_ProductDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max), SuccessMessages.ProductListed);
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetailDtos()
        {
            if (DateTime.Now.Hour==4)
            {
                return new ErrorDataResult<List<ProductDetailDto>>(ErrorMessages.MaintenanceTime1);
            }
            return new SuccessDataResult<List<ProductDetailDto>>( _ProductDal.GetProductDetailDtos(),SuccessMessages.ProductListed);
        }      

        private IResult  CheckIfProductCountOfCategoryCorrect(int  CategoryId)
        {
            var result = _ProductDal.GetAll(p => p.CategoryID ==CategoryId).Count;
            if (result >= 15)
            {
                return new ErrorResult(ErrorMessages.ProductCountOfCategoreError1);
            }
            return new  SuccessResult();
        }
        private IResult CheckIfProductNameExists(string productName)
        {
            var result = _ProductDal.GetAll(p=>p.ProductName==productName).Any();
            if (result)
            {
                return new ErrorResult(ErrorMessages.ProductNameAlreadyExists1);
            }
            return new SuccessResult();
        }
        private IResult CheckIfCategoryLimitExceded()
        {
            var result = _categoryService.GetAll();
            if (result.Data.Count>15)
            {
                return new ErrorResult(ErrorMessages.CategoryLimitExceded);
            }
            return new SuccessResult();
        }

       
    }
}
