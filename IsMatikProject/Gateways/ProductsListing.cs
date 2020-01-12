using Domain.Entities;
using Domain.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsMatikProject.Gateways
{
    class ProductsListing : IProductsListing
    {
        public List<ProductDetails> SearchForProducts(string keyword, string website)
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                List<ProductDetails> products = new List<ProductDetails>();
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                driver.Navigate().GoToUrl(website);

                if (website.Contains("n11"))
                {
                    driver.FindElement(By.Id("searchData")).SendKeys(keyword + Keys.Enter);

                    var prices = wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//section[contains(@class,'group listingGroup resultListGroup')] //div[@class='listView ' or contains(@class,'catalogView ')] //div[contains(@class,'columnContent ')]//div[contains(@class,'proDetail') or contains(@class,'pro') and not(contains(@class,'proStatus'))] "))).Select(se => se.Text.Split(new[] { Environment.NewLine },
StringSplitOptions.None)).ToList();


                    foreach (var item in prices.Select((value, index) => new { value, index }))
                    {
                        if (item.index % 2 == 0)
                        {
                            var productPricesObject = prices[item.index + 1];
                            bool IsThereDiscount = productPricesObject.Any(an => an == "%");
                            string ProductPrice = IsThereDiscount ? productPricesObject[1] : productPricesObject[0];
                            string ProductDiscount = IsThereDiscount ? productPricesObject[3] : "0";

                            products.Add(new ProductDetails { Keyword = keyword, ListingDate = DateTime.Now, Price = ProductPrice, Discount = ProductDiscount + "%", ProductName = item.value[0], WebSite = new Uri(website) });
                        }

                    }

                }
                else
                {
                    driver.FindElement(By.Id("js-site-search-input")).SendKeys(keyword + Keys.Enter);

                    var prices = wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//ul[contains(@class,'product-listing ')] //div[@class='product_click'] "))).Select(se => se.Text.Split(new[] { Environment.NewLine },
                StringSplitOptions.None)).ToList();

                    foreach (var item in prices)
                    {
                        bool IsThereDiscount = item.Any(an => an.Contains("%"));
                        string ProductPrice = IsThereDiscount ? item[3] : item[1];
                        string ProductDiscount = IsThereDiscount ? item[1] : "0";

                        products.Add(new ProductDetails { Keyword = keyword, ListingDate = DateTime.Now, Price = ProductPrice, Discount = ProductDiscount + "%", ProductName = item[0], WebSite = new Uri(website) });

                    }
                }






                #region SomeTryings(not important)
                //var firstResult = wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//*[@class='ratio']")));


                //var firstResuldt = driver.FindElements(By.XPath("//div[@class='listView ']//div[@class='columnContent ']")).Where(wh => wh.FindElements(By.XPath("//span[contains(@class,'percent')]")).Count >= 1).ToList();

                //var firstResuldft = driver.FindElements(By.XPath("//div[@class='listView '] //div[@class='proDetail']//div[not(contains(@class,'discount '))]"));

                //var names = driver.FindElements(By.XPath("//div[@class='listView '] //div[@class='columnContent ']//h3[contains(@class,'productName')]"));

                //            var t = firstResult.Select(element => element.Text.Split(new[] { Environment.NewLine },
                //StringSplitOptions.None))
                //    .ToList(); 
                #endregion
            }

            return products;
        }
    }
}
