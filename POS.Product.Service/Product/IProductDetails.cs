using POS.Product.Model.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Product.Service.Product
{
    public interface IProductDetails
    {
        List<ProductDetailModel> GetProductDetails();
    }
}
