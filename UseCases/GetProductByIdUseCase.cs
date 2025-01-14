﻿using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases
{
    public class GetProductByIdUseCase : IGetProductByIdUseCase
    {
        private IProductRepository _productRepository;
        public GetProductByIdUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public Product Execute(int productId)
        {
            return _productRepository.GetProductById(productId);
        }
    }
}
