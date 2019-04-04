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
using System.Reflection;
using Microsoft.Win32;
using System.IO;
using System.Globalization;

namespace OOP4_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void colorbinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void colorRedbinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MyTextBox.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, Red.Background);
        }

        private void colorBluebinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MyTextBox.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, Blue.Background);
        }

        private void colorBlackbinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MyTextBox.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, Black.Background);
        }

        private void colorGreenbinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MyTextBox.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, Green.Background);
        }

        private void colorYellowbinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MyTextBox.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, Yellow.Background);
        }

        ResourceDictionary prev = null;
        string buffer = "";
        List<string> files;
        public MainWindow()
        {
            InitializeComponent();
            MyWindow.Cursor = new Cursor("F:\\2.cur");
            MyTextBox.Cursor = new Cursor("F:\\1.cur");
            files = new List<string>();
           
            using (StreamReader sr = new StreamReader("files.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    files.Add(line);
                }
            }

            file.ItemsSource = files;

            App.LanguageChanged += LanguageChanged;

            CultureInfo currLang = App.Language;

            //Заполняем меню смены языка:
            menuLanguage.Items.Clear();
            foreach (var lang in App.Languages)
            {
                MenuItem menuLang = new MenuItem();
                menuLang.Header = lang.DisplayName;
                menuLang.Tag = lang;
                menuLang.IsChecked = lang.Equals(currLang);
                menuLang.Click += ChangeLanguageClick;
                menuLanguage.Items.Add(menuLang);
            }

            this.MyTextBox.AddHandler(RichTextBox.DragOverEvent, new DragEventHandler(this.DragItem), true);
            this.MyTextBox.AddHandler(RichTextBox.DropEvent, new DragEventHandler(this.DropItem), true);
        }

        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            if (Theme.SelectedItem != null)
            {
                string style = (Theme.SelectedItem as ComboBoxItem).Content as string;
                // определяем путь к файлу ресурсов
                var uri = new Uri(style + ".xaml", UriKind.Relative);
                // загружаем словарь ресурсов
                ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
                // очищаем коллекцию ресурсов приложения
                if(prev!=null)
                    Application.Current.Resources.Remove(prev);
                // добавляем загруженный словарь ресурсов
                Application.Current.Resources.MergedDictionaries.Add(resourceDict);
                prev = resourceDict;
            }
        }

        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;

            
            foreach (MenuItem i in menuLanguage.Items)
            {
                CultureInfo ci = i.Tag as CultureInfo;
                i.IsChecked = ci != null && ci.Equals(currLang);
            }
        }

        private void ChangeLanguageClick(Object sender, EventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            if (mi != null)
            {
                CultureInfo lang = mi.Tag as CultureInfo;
                if (lang != null)
                {
                    App.Language = lang;
                }
            }

        }

        private void DragItem(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.All;
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
            e.Handled = false;
        }

        private void DropItem(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] docPath = (string[])e.Data.GetData(DataFormats.FileDrop);
                    if (System.IO.File.Exists(docPath[0]))
                    {
                        try
                        {
                            TextRange range = new TextRange(this.MyTextBox.Document.ContentStart, this.MyTextBox.Document.ContentEnd);
                            FileStream fStream = new FileStream(docPath[0], FileMode.OpenOrCreate);
                            range.Load(fStream, DataFormats.Rtf);
                            fStream.Close();
                            this.Title = "Text Editor (" + docPath[0] + ") ";
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("File could not be opened. Make sure the file is a text file.");
                        }
                    }
                }
            }
        }

      

        private void Create_button_Click(object sender, RoutedEventArgs e)    
        {
            MyTextBox.Document.Blocks.Clear();
        }

        private void Open_button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(dlg.FileName, FileMode.Open);
                TextRange range = new TextRange(MyTextBox.Document.ContentStart,
                MyTextBox.Document.ContentEnd);
                range.Load(fileStream, DataFormats.Text);
                this.Title = dlg.FileName;
                if (!files.Contains(dlg.FileName))
                {
                    files.Add(dlg.FileName);
                }
                using (StreamWriter sw = new StreamWriter("files.txt"))
                {
                    foreach (string str in files)
                        sw.WriteLine(str);
                }
            }
        }


        private void Save_button_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(dlg.FileName, FileMode.Create);
                TextRange range = new TextRange(MyTextBox.Document.ContentStart,
               MyTextBox.Document.ContentEnd);
                range.Save(fileStream, DataFormats.Rtf);
            }

        }

        private void Font_Chosen(object sender, SelectionChangedEventArgs e)
        {
            if (MyFontBox.SelectedItem != null && MyTextBox != null)
            {
                MyTextBox.Selection.ApplyPropertyValue(System.Windows.Controls.RichTextBox.FontFamilyProperty, MyFontBox.SelectedItem);
                MyTextBox.Focus();
            }
        }

        private void Size_Changed(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (MyTextBox != null)
            {
                MyTextBox.Selection.ApplyPropertyValue(System.Windows.Controls.RichTextBox.FontSizeProperty, SizeBox.Value);
                MyTextBox.Focus();
            }
        }

        private void BoldButton_Checked(object sender, RoutedEventArgs e)
        {

            if (MyTextBox != null)
            {
                MyTextBox.Selection.ApplyPropertyValue(Run.FontWeightProperty, FontWeights.Bold);
            }
        }
        private void BoldButton_Unchecked(object sender, RoutedEventArgs e)
        {
            if (MyTextBox != null)
            {
                MyTextBox.Selection.ApplyPropertyValue(Run.FontWeightProperty, FontWeights.Normal);
            }
        }

        private void ItalicButton_Checked(object sender, RoutedEventArgs e)
        {
            if (MyTextBox != null)
            {
                MyTextBox.Selection.ApplyPropertyValue(Run.FontStyleProperty, FontStyles.Italic);
            }
        }

        private void ItalicButton_Unchecked(object sender, RoutedEventArgs e)
        {
            if (MyTextBox != null)
            {
                MyTextBox.Selection.ApplyPropertyValue(Run.FontStyleProperty, FontStyles.Normal);
            }
        }

        private void UnderlineButton_Checked(object sender, RoutedEventArgs e)
        {
            if (MyTextBox != null)
            {
                MyTextBox.Selection.ApplyPropertyValue(Run.TextDecorationsProperty, TextDecorations.Underline);
            }
        }

        private void UnderlineButton_Unchecked(object sender, RoutedEventArgs e)
        {

            if (MyTextBox != null)
            {
                MyTextBox.Selection.ApplyPropertyValue(Run.TextDecorationsProperty, null);
            }
        }

        private void MyTextBox_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string file = (string)e.Data.GetData(DataFormats.FileDrop);

                if (file.Split('.').Last() == "txt")
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        MyTextBox.AppendText(sr.ReadToEnd());
                    }
                }
            }
        }

        private void Paste_Button_Click(object sender, RoutedEventArgs e)
        {
            MyTextBox.Selection.Text = buffer;
        }

        private void Copy_Button_Click(object sender, RoutedEventArgs e)
        {
            buffer = MyTextBox.Selection.Text;
        }

        private void MyTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (MyTextBox != null && lblStatus != null)
            {
                int countOfSymbols = 0;
                TextRange range = new TextRange(MyTextBox.Document.ContentStart, MyTextBox.Document.ContentEnd);
                string getText = range.Text;
                for (int i = 0; i < getText.Length; i++)
                {
                    if (getText[i] == '\n') { countOfSymbols--; }
                }
                for (int i = 0; i < getText.Length; i++)
                {
                    if (getText[i] != '\n') { countOfSymbols++; }
                }
                lblStatus.Text = countOfSymbols.ToString();
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            
                Close();
        }

        private void file_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Title = ((ComboBox)sender).SelectedItem as string;

            FileStream fileStream = new FileStream(((ComboBox)sender).SelectedItem as string, FileMode.Open);
            TextRange range = new TextRange(MyTextBox.Document.ContentStart,
            MyTextBox.Document.ContentEnd);
            range.Load(fileStream, DataFormats.Text);
        }
    }
}
