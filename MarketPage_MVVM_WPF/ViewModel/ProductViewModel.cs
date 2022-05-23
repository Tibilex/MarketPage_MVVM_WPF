using MarketPage_MVVM_WPF.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MarketPage_MVVM_WPF.ViewModel
{
    internal class ProductViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<ProductModel> Products { get; set; }

        public ProductViewModel()
        {
            Products = new ObservableCollection<ProductModel>();
            Products.Add(new ProductModel("Apple iPhone 13 Pro 256GB (Alpine Green)", "47 399 грн", "Resources/AlpineGreen.png", "000062471", "Есть в наличии"));
            Products.Add(new ProductModel("Apple iPhone 13 Pro 128GB (Alpine Green)", "43 699 грн", "Resources/AlpineGreen.png", "000062470", "Есть в наличии"));
            Products.Add(new ProductModel("Apple iPhone 13 Pro 1TB (Sierra Blue)", "57 499 грн", "Resources/SierraBlue.png", "000056462", "Есть в наличии"));
            Products.Add(new ProductModel("Apple iPhone 13 Pro 512GB (Sierra Blue)", "52 799 грн", "Resources/SierraBlue.png", "000056461", "Есть в наличии"));
            Products.Add(new ProductModel("Apple iPhone 13 Pro 256GB (Sierra Blue)", "47 399 грн", "Resources/SierraBlue.png", "000056460", "Есть в наличии"));
            Products.Add(new ProductModel("Apple iPhone 13 Pro 128GB (Sierra Blue)", "42 899 грн", "Resources/SierraBlue.png", "000056459", "Есть в наличии"));
            Products.Add(new ProductModel("Apple iPhone 13 Pro 128GB (Silver)", "56 899 грн", "Resources/Silver.png", "000056458", "Есть в наличии"));
            Products.Add(new ProductModel("Apple iPhone 13 Pro 128GB (Silver)", "52 599 грн", "Resources/Silver.png", "000056457", "Есть в наличии"));
            Products.Add(new ProductModel("Apple iPhone 13 Pro 128GB (Silver)", "48 399 грн", "Resources/Silver.png", "000056456", "Есть в наличии"));
            Products.Add(new ProductModel("Apple iPhone 13 Pro 128GB (Silver)", "42 899 грн", "Resources/Silver.png", "000056455", "Есть в наличии"));
            Products.Add(new ProductModel("Apple iPhone 13 Pro 1TB (Gold)", "56 899 грн", "Resources/Gold.png", "000056454", "Есть в наличии"));
            Products.Add(new ProductModel("Apple iPhone 13 Pro 512GB (Gold)", "52 599 грн", "Resources/Gold.png", "000056453", "Есть в наличии"));
            Products.Add(new ProductModel("Apple iPhone 13 Pro 256GB (Gold)", "46 799 грн", "Resources/Gold.png", "000056452", "Есть в наличии"));
            Products.Add(new ProductModel("Apple iPhone 13 Pro 128GB (Gold)", "42 899 грн", "Resources/Gold.png", "000056451", "Есть в наличии"));
            Products.Add(new ProductModel("Apple iPhone 13 Pro 512GB (Graphite)", "54 299 грн", "Resources/Graphite.png", "000056449", "Есть в наличии"));
            Products.Add(new ProductModel("Apple iPhone 13 Pro 128GB (Graphite)", "46 399 грн", "Resources/Graphite.png", "000056447", "Есть в наличии"));
            Products.Add(new ProductModel("Apple iPhone 13 Pro 1TB (Alpine Green)", "54 999 грн", "Resources/AlpineGreen.png", "000062473", "Нет в наличии"));
            Products.Add(new ProductModel("Apple iPhone 13 Pro 512GB (Alpine Green)", "49 899 грн", "Resources/AlpineGreen.png", "000062472", "Нет в наличии"));
            Products.Add(new ProductModel("Apple iPhone 13 Pro 1TB (Graphite)", "53 399 грн", "Resources/Graphite.png", "000056450", "Нет в наличии"));
            Products.Add(new ProductModel("Apple iPhone 13 Pro 256GB (Graphite)", "48 399 грн", "Resources/Graphite.png", "000056448", "Нет в наличии"));
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
