using Domain.Entities;
using IsMatikProject.Gateways;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace IsMatikProject
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void radGridView1_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string keyWord = KeywordTextBox.Text;
            
            ProductsListing productsListing = new ProductsListing();
            List<ProductDetails> searchResult = productsListing.SearchForProducts(keyWord, CarrefourSACheckBox.Tag.ToString());

            ProductRepository productRepository = new ProductRepository();
            productRepository.SaveSearchResultToDB(searchResult);

        }
    }
}
