using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductDetails : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Discount { get; set; }
        public string Price { get; set; }
        public string WebSite { get; set; }
        public DateTime ListingDate { get; set; }
        public string Keyword { get; set; }

        // The following code is used to refresh the grid after data added.
        private void OnPropertyChanged(string propertyName)
        {
            this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, args);
            }
        }
        #region INotifyPropertyChanged Members 

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
