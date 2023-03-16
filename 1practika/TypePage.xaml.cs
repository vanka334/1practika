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
    /// Логика взаимодействия для TypePage.xaml
    /// </summary>
    public partial class TypePage : Page
    {
        private type_ObjectTableAdapter type = new type_ObjectTableAdapter();
        public TypePage()
        {
            InitializeComponent();
            Typivi.ItemsSource = type.GetData();

        }
    }
}
