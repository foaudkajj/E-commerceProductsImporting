using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IProductRepository
    {
        void SaveSearchResultToDB(List<ProductDetails> productDetails);
        List<ProductDetails> GetProductsByKeyword(string keyword);
    }
}
