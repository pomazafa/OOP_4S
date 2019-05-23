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

namespace OOP13
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Builder baker;
        public MainWindow()
        {
            InitializeComponent();
            Dialog wind = new Dialog();
            wind.ShowDialog();
            baker = new Builder();
            Result.Text += "Создано:\n" + Dialog.circles.Count() + " кругов\n" + Dialog.rectangles.Count() + " прямоугольников\n";

            checkBool(wind);





            IFigure figure = new Rectangle1(30, 40);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            figure = new Circle1(30);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
        }

        private void checkBool(Dialog wind)
        {
            if ((bool)wind.Single.IsChecked)
            {
                SingleTon.getInstance();
            }

            if ((bool)wind.ellipce.IsChecked)
            {
                AbstractBuilder builder = new EllipceBuilder();
                ColoredFigure ellipce = baker.Build(builder);
                Result.Text += "Создан " + ellipce.ToString();
            }

            if ((bool)wind.blueTriangle.IsChecked)
            {
                AbstractBuilder builder = new BlueTriangleBuilder();
                ColoredFigure blueTriangle = baker.Build(builder);
                Result.Text += "Создан " + blueTriangle.ToString();
            }
        }
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            Dialog wind = new Dialog();
            wind.ShowDialog();
            Result.Text += "\n\nНа данный момент создано:\n" + Dialog.circles.Count() + " кругов\n" + Dialog.rectangles.Count() + " прямоугольников\n";
            checkBool(wind);
        }
    } 
}
