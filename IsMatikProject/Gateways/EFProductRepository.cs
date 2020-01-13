using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsMatikProject.Gateways
{
    class EFProductRepository : IEFProductRepository
    {
        private readonly IsMatikContext _isMatikContext;

        public EFProductRepository()
        {
            _isMatikContext = new IsMatikContext() ;
        }
        public List<ProductDetails> GetProductsByKeyword(string keyword)
        {
            return _isMatikContext.productDetails.Where(wh=> wh.ProductName.Contains(keyword)).ToList();
        }

        public void SaveSearchResultToDB(List<ProductDetails> productDetails)
        {
            _isMatikContext.productDetails.AddRange(productDetails);
            _isMatikContext.SaveChanges();
        }
    }
}
