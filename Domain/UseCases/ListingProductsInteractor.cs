using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases
{
    public class ListingProductsInteractor
    {
        private readonly IGettingProductsFromWebsite _productsGettingFromWebsite;
        private readonly IEFProductRepository _productRepository;
        public ListingProductsInteractor(IGettingProductsFromWebsite productsGettingFromWebsite, IEFProductRepository productRepository)
        {
            _productsGettingFromWebsite = productsGettingFromWebsite;
            _productRepository = productRepository;
        }
        public List<ProductDetails> ListProducts(string keyword, string website)
        {
            return _productsGettingFromWebsite.SearchForProducts(keyword, website);
        }

        public void SaveSearchResultToDB(List<ProductDetails> productDetails)
        {
            _productRepository.SaveSearchResultToDB(productDetails);
        }
        public List<ProductDetails> GetProductsByKeyword(string keyword)
        {
            return _productRepository.GetProductsByKeyword(keyword);
        }
    }
}
