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

namespace WpfApp_Step_Ders_6_May
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            var repo = Database.GetInstance();
            repo.AddProduct(new Product { Name = "Hello", Price = 12.2 });
            repo.AddProduct(new Product { Name = "Data", Price = 22.2 });
            repo.AddProduct(new Product { Name = "Yellow", Price = 32.2 });

            List<Product> products = repo.GetAllProducts();

            MessageBox.Show($"{products[1].Name}, {products[1].Price}");

            repo.DeleteProductWithName("Data");

            products = repo.GetAllProducts();

            MessageBox.Show($"{products[1].Name}, {products[1].Price}");

        }
    }
}
