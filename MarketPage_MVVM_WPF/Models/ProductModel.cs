using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MarketPage_MVVM_WPF.Models
{
    public class ProductModel : INotifyPropertyChanged
    {
        private string _name;
        private string _image;
        private string _price;
        private string _availability;
        private string _code;

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string Availability
        {
            get { return _availability; }
            set 
            { 
                _availability = value;
                OnPropertyChanged("Availability");
            }
        }

        public string Price
        {
            get { return _price; }
            set 
            { 
                _price = value;
                OnPropertyChanged("Price");
            }
        }

        public string Image
        {
            get { return _image; }
            set 
            { 
                _image = value; 
                OnPropertyChanged("Image");
            }
        }

        public string Name
        {
            get { return _name; }
            set
            { 
                _name = value; 
                OnPropertyChanged("Name");
            }
        }

        public ProductModel(string name, string price, string image, string code, string availability)
        {
            Name = name;
            Price = price;
            Image = image;
            Code = code;
            Availability = availability;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
