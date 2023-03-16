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
using _1practika.Danie_DatasetTableAdapters;

namespace _1practika
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<string> data = new List<string>() { "Object", "Brigade", "Type" };
        public MainWindow()
        {
            InitializeComponent();
            Chooser.ItemsSource = data;
            Chooser.SelectedIndex = 0;  

        }

        private void Chooser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch ((string)Chooser.SelectedItem)
            {
                case "Object": { Tables.Content = new ObjectPage(); break; }
                case "Brigade": { Tables.Content = new BragadePage(); break; }
                case "Type": { Tables.Content = new TypePage(); break; }
            }
        }
    }
}
