using Domain.Entities;
using Domain.Interfaces;
using Domain.UseCases;
using IsMatikProject.Gateways;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Data.Entity;
using System.Linq;
using Telerik.WinControls.Data;

namespace IsMatikProject
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        private readonly IsMatikContext dbContext = new IsMatikContext();
        public RadForm1()
        {
            InitializeComponent();
            dbContext.productDetails.Load();
            this.radGridView1.DataSource = this.dbContext.productDetails.Local.ToBindingList();
            this.radGridView1.Columns[0].IsVisible = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string keyWord = KeywordTextBox.Text;

            CheckIfAtLeastOneWebsiteIsSelected();

            // Using Selenium to get products from e-commerece webiste.
            IGettingProductsFromWebsite gettingProductsBySelenium = new GettingProductsBySelenium();
            IEFProductRepository productRepository = new EFProductRepository();
            var listingProducts = new ListingProductsInteractor(gettingProductsBySelenium, productRepository);
            List<ProductDetails> searchResult;
            // -----------------------------------------------------------

            // Looping through existed websites to fetch products from.
            bool IsDataFetched = false;
            foreach (Control item in groupBox1.Controls)
            {
                if (item is CheckBox && ((CheckBox)item).Checked)
                {
                    searchResult = listingProducts.ListProducts(keyWord, ((CheckBox)item).Tag.ToString());
                    listingProducts.SaveSearchResultToDB(searchResult);
                    IsDataFetched = true;
                }

            }
            // ------------------------------------------------------

            // After fetching and saving the data, refresh the grid and filter it.
            if (IsDataFetched)
            {
                refreshGrid();
                filterTextBox1.Text = keyWord;
            }


        }

        private void CheckIfAtLeastOneWebsiteIsSelected()
        {
            bool websiteSelectedFlag = false;
            foreach (Control item in groupBox1.Controls)
            {
                if (item is CheckBox && ((CheckBox)item).Checked)
                {
                    websiteSelectedFlag = true;
                }
            }

            if (!websiteSelectedFlag)
                MessageBox.Show("Lütfen en az bir website işaretleyiniz...");
        }

        private void KeywordTextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                SearchButton.PerformClick();
            }
        }

        private void KeywordTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchButton.Enabled = !string.IsNullOrEmpty(KeywordTextBox.Text);
        }


        private void refreshGrid()
        {
            dbContext.productDetails.Load();
            this.radGridView1.DataSource = this.dbContext.productDetails.Local.ToBindingList();
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {
            radGridView1.MasterTemplate.Refresh();
        }

        private void radGridView1_CustomFiltering(object sender, GridViewCustomFilteringEventArgs e)
        {
            if (string.IsNullOrEmpty(filterTextBox1.Text))
            {
                e.Visible = true;
                return;
            }

            e.Visible = false;
            for (int i = 0; i < radGridView1.ColumnCount; i++)
            {
                string text = e.Row.Cells[i].Value.ToString();
                if (text.ToLower().IndexOf(filterTextBox1.Text.ToLower(), StringComparison.InvariantCulture) >= 0)
                {
                    e.Visible = true;
                }
            }
        }
    }
}
