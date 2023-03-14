using Microsoft.Extensions.Logging;
using POS.Product.Model.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Product.Service.Product
{
    public class ProductDetails : IProductDetails
    {
        private readonly ILogger _logger;
        private readonly ILoggerFactory _loggerFactory;
        public ProductDetails(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
            _logger = _loggerFactory.CreateLogger<ProductDetails>();
        }

        public List<ProductDetailModel> GetProductDetails()
        {
            List<ProductDetailModel> lstProductDetails = new List<ProductDetailModel>();
            lstProductDetails.Add(new ProductDetailModel
            {
                ProductCode = "A01",
                ProductDescription = "ABCD AA",
                ProductId = 1,
                ProductName = "ABCD"
            });
            lstProductDetails.Add(new ProductDetailModel
            {
                ProductCode = "A02",
                ProductDescription = "ABCD AA2",
                ProductId = 2,
                ProductName = "ABCD2"
            });

            return lstProductDetails;
        }
    }
}
