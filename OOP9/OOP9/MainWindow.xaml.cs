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

namespace OOP9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            using (Model1 db = new Model1())
            {
                ADDRESS adr = new ADDRESS { STREET = "Жемайтская", HOUSING = "2", HOUSE = "11", FLAT = 4 };

                var itemToRemove = db.ADDRESSes.FirstOrDefault(x => x.STREET == "Жемайтская"); //returns a single item.

                if (itemToRemove != null)
                {
                    db.ADDRESSes.Remove(itemToRemove);
                    db.SaveChanges();

                }

                datarid.ItemsSource = db.ADDRESSes.ToList();
            }
        }
    }
}
