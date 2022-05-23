using MarketPage_MVVM_WPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MarketPage_MVVM_WPF
{
    /// <summary>
    /// Логика взаимодействия для ProductTileButton.xaml
    /// </summary>
    public partial class ProductTileButton : UserControl
    {
        public ProductTileButton()
        {
            InitializeComponent();
            DataContext = new ProductViewModel();
        }
    }
}
