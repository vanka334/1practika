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
using System.Windows.Shapes;
using _1practika.Danie_DatasetTableAdapters;
namespace _1practika
{
    /// <summary>
    /// Логика взаимодействия для ObjectPage.xaml
    /// </summary>
    public partial class ObjectPage : Page
    {
        ObjectTableAdapter objecty = new ObjectTableAdapter();
        BrigadeTableAdapter brig = new BrigadeTableAdapter();
        type_ObjectTableAdapter typey = new type_ObjectTableAdapter();
        public ObjectPage()
        {
            InitializeComponent();
            Objectivi.ItemsSource = objecty.GetData();
            Object_type.ItemsSource= typey.GetData();   
            Object_Brigade.ItemsSource = brig.GetData();
            Object_type.SelectedValuePath = "Id";
            Object_type.DisplayMemberPath = "Name_of_type";
            Object_Brigade.SelectedValuePath = "Id";
            Object_Brigade.DisplayMemberPath = "Name_of_Brigade";
        }

        private void Select_Object_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)Object_type.SelectedValue;
            int id1 = (int)Object_Brigade.SelectedValue;
            objecty.InsertQuery(id, id1);
            Objectivi.ItemsSource = objecty.GetData();

        }

        private void Delete_Object_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)(Objectivi.SelectedItem as DataRowView).Row[0];
            objecty.DeleteQuery(id);
            Objectivi.ItemsSource = objecty.GetData();

        }

        private void Update_Object_Click(object sender, RoutedEventArgs e)
        {
            if (Objectivi.SelectedItem != null)
            {
                int id = (int)(Objectivi.SelectedItem as DataRowView).Row[0];
                objecty.UpdateQuery(Convert.ToInt32(Object_type.SelectedValue), Convert.ToInt32(Object_Brigade.SelectedValue), Convert.ToInt32(id));
                Objectivi.ItemsSource = objecty.GetData();
            }
        }

        private void Objectivi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(Objectivi.SelectedItem != null) { 
            Object_Brigade.SelectedValue = Convert.ToString((Objectivi.SelectedItem as DataRowView).Row[2]);
            Object_type.SelectedValue = Convert.ToString((Objectivi.SelectedItem as DataRowView).Row[1]);
            }
            
        }
    }
}
