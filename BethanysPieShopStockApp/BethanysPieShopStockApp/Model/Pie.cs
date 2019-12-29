using System;
using System.ComponentModel;

namespace BethanysPieShopStockApp.Model
{
    public class Pie : INotifyPropertyChanged
    {
        private int _id { get; set; }
        private string _pieName { get; set; }

        private double _price { get; set; }

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                RaisePropertyChanged(nameof(Id));
            }
        }

        public string PieName
        {
            get => _pieName;
            set
            {
                _pieName = value;
                RaisePropertyChanged(nameof(PieName));
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                _price = value;
                RaisePropertyChanged(nameof(Price));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            // If propertyChange is not null, invoke event
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}