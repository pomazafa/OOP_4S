using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OOP13
{
    /// <summary>
    /// Логика взаимодействия для Dialog.xaml
    /// </summary>
    public partial class Dialog : Window
    {
        public Dialog()
        {
            InitializeComponent();
        }

        public static List<Circle> circles = new List<Circle>();
        public static List<Rectangle> rectangles = new List<Rectangle>();

        private static readonly Regex _regex = new Regex("[^0-9.-]+");
        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text) && text != "";
        }
        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if(IsTextAllowed(YellowCircle.Text) && IsTextAllowed(YellowRectangle.Text) && IsTextAllowed(RedRectangle.Text) && IsTextAllowed(RedCircle.Text))
            {
                Creator redCreator = new Creator(new FactoryRed(), int.Parse(RedCircle.Text), int.Parse(RedRectangle.Text));
                Creator yellowCreator = new Creator(new FactoryYellow(), int.Parse(YellowCircle.Text), int.Parse(YellowRectangle.Text));

                Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }
    }
}
