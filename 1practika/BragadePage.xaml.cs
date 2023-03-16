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

using _1practika.Danie_DatasetTableAdapters;

namespace _1practika
{
    /// <summary>
    /// Логика взаимодействия для BragadePage.xaml
    /// </summary>
    public partial class BragadePage : Page
    {
        BrigadeTableAdapter brigadas = new BrigadeTableAdapter();
        public BragadePage()
        {
            InitializeComponent();
            MayaBrigada.ItemsSource = brigadas.GetData();
        }
    }
}
