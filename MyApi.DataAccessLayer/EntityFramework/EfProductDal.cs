﻿using MyApi.DataAccessLayer.Abstract;
using MyApi.DataAccessLayer.Context;
using MyApi.DataAccessLayer.Repositories;
using MyApi.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApi.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(ApiContext context) : base(context)
        {
        }

        public int GetProductCount()
        {
            var context = new ApiContext();
            int value= context.Products.Count();
            return value;
        }
    }
}
