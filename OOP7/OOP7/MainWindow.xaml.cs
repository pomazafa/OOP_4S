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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HandleChildSignal(object sender, System.Windows.RoutedEventArgs e)
        {
            MessageBox.Show("Bubble событие сработало в MainWindow");
        }


        public static readonly RoutedEvent CloseEvent = EventManager.RegisterRoutedEvent(
       "CloseEv", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(MainWindow));

        // Provide CLR accessors for the event
        public event RoutedEventHandler CloseEv
        {
            add { AddHandler(CloseEvent, value); }
            remove { RemoveHandler(CloseEvent, value); }
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.RaiseEvent(new RoutedEventArgs(CloseEvent, this));
        }

        private void close_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Direct событие сработало в MainWindow");
        }


        public void CommandBinding_Executed(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы нажали контр + а");
        }
    }

    public class SizeDP : DependencyObject
    {
        public static readonly DependencyProperty TextSizeProperty;
        static SizeDP()
        {
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            TextSizeProperty = DependencyProperty.Register(
            "SizeProp",
            typeof(string),
            typeof(SizeDP), metadata);
        }


        public string SizeProp
        {
            get { return (string)GetValue(TextSizeProperty); }
            set { SetValue(TextSizeProperty, value); }
        }
    }

    public class BackGroundDP : DependencyObject
    {
        public static readonly DependencyProperty BackGroundProperty;
        static BackGroundDP()
        {
            BackGroundProperty = DependencyProperty.Register(
            "BackGround",
            typeof(string),
            typeof(BackGroundDP));
        }
        public string BackGroundProp
        {
            get { return (string)GetValue(BackGroundProperty); }
            set { SetValue(BackGroundProperty, value); }
        }
    }

    public class ContentDP : DependencyObject
    {
        public static readonly DependencyProperty ContentProperty;
        static ContentDP()
        {
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.CoerceValueCallback = new CoerceValueCallback(CoerceValueCallbackMetod);
            ContentProperty = DependencyProperty.Register(
            "ContentProp",
            typeof(string),
            typeof(ContentDP), metadata, new ValidateValueCallback(ValidateMyContent));
        }

        private static object CoerceValueCallbackMetod(DependencyObject d, object baseValue)
        {
            if (baseValue != null)
            {
                string currentValue = (string)baseValue;
                if (currentValue.Contains("свойства") )
                    return currentValue;
                return "текст без свойства был";
            }
            return null;
        }
        public static bool ValidateMyContent(object value)
        {
            if (value != null)
            {
                string currentValue = (string)value;
                if (currentValue.Contains("контент"))
                    return true;
                return false;
            }
            return true;
        }

        public string ContentProp
        {
            get { return (string)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }
    }

    public class MyCommands
    {
        // Создание команды requery
        private static RoutedUICommand requery;

        static MyCommands()
        {
            // Инициализация команды
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.F, ModifierKeys.Control, "Ctrl + F"));
            requery = new RoutedUICommand("Requery", "Requery", typeof(MyCommands), inputs);
        }

        public static RoutedUICommand Requery
        {
            get { return requery; }
        }

       
    }
}
