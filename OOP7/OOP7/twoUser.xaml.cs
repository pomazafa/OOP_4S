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

namespace OOP7
{
    /// <summary>
    /// Логика взаимодействия для twoUser.xaml
    /// </summary>
    public partial class twoUser : UserControl
    {
        public twoUser()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = ((MainWindow)System.Windows.Application.Current.MainWindow);
            var clickedButton = sender as Button;
            var clickedSmile = clickedButton.Background;
            main.Rich.Background = clickedSmile;
        }
    }
}
