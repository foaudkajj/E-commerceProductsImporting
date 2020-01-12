using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsMatikProject.Gateways
{
    class ProductRepository : IProductRepository
    {
        public List<ProductDetails> GetProductsByKeyword(string keyword)
        {
            throw new NotImplementedException();
        }

        public void SaveSearchResultToDB(List<ProductDetails> productDetails)
        {
            throw new NotImplementedException();
        }
    }
}
