using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases
{
    class ListingProductsInteractor
    {
        private readonly IProductsListing _productsListing;

        public ListingProductsInteractor(IProductsListing productsListing)
        {
            _productsListing = productsListing;
        }
        public List<ProductDetails> ListProducts(string keyword, string website)
        {
            return _productsListing.SearchForProducts(keyword, website);
        }
    }
}
