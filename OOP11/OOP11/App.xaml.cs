using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace OOP11
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            List<Concert> concerts = new List<Concert>()
            {
                new Concert("MyGroup", DateTime.Now.AddDays(30), 10, 0, 100, 0),
                new Concert("SecondGroup", DateTime.Now.AddDays(60), 30, 0, 1000, 2000),
                new Concert("Scorpions", DateTime.Now.AddMonths(19), 100, 200, 1500, 3000)
            };
            MainWindow view = new MainWindow(); // создали View
            MainViewModel viewModel = new MainViewModel(concerts); // Создали
            view.DataContext = viewModel; // положили ViewModel во View в качестве
            view.Show();
        }

    }
}
