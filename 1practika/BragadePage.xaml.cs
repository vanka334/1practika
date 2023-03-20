using System;
using System.Collections.Generic;
using System.Data;
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

        private void Select_Brigade_Click(object sender, RoutedEventArgs e)
        {

            brigadas.InsertQuery(Brigade_Name.Text);
            MayaBrigada.ItemsSource = brigadas.GetData();

        }

        private void Delete_Brigade_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)(MayaBrigada.SelectedItem as DataRowView).Row[0];
            brigadas.DeleteQuery(id);
            MayaBrigada.ItemsSource = brigadas.GetData();
            
        }

        private void Update_Brigadas_Click(object sender, RoutedEventArgs e)
        {
            if(MayaBrigada.SelectedItem != null)
            {

            int id = (int)(MayaBrigada.SelectedItem as DataRowView).Row[0];
            brigadas.UpdateQuery(Brigade_Name.Text, id);
            MayaBrigada.ItemsSource = brigadas.GetData();
            }   

        }

        private void MayaBrigada_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if(MayaBrigada.SelectedItem!= null) { 
            
                Brigade_Name.Text = Convert.ToString((MayaBrigada.SelectedItem as DataRowView).Row[1]);
            }
        }
    }
}
