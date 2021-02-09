using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace SzybkieFaktury
{
    /// <summary>
    /// Interaction logic for AddCompany.xaml
    /// </summary>
    public partial class AddCompany : Window
    {
        
        public AddCompany()
        {
            InitializeComponent();
            DataBaseCon.GridViewSelect("SELECT * FROM Company", "Company", AddingCompany_DataGridView);

        }

 
        private void AddCompany_Button(object sender, RoutedEventArgs e)
        {
            DataBaseCon.Query(Company.AddCompany(AddNip_TextBox.Text,AddName_TextBox.Text,AddCity_TextBox.Text, AddStreet_TextBox.Text, AddBuilding_TextBox.Text, AddPostcode_TextBox.Text));
            DataBaseCon.GridViewSelect("SELECT * FROM Company", "Company", AddingCompany_DataGridView);
     
        }

        private void DelCompany_Button_Click(object sender, RoutedEventArgs e)
        {
            
            string nip = (AddingCompany_DataGridView.SelectedCells[1].Column.GetCellContent(AddingCompany_DataGridView.SelectedItem) as TextBlock).Text;
            string names = (AddingCompany_DataGridView.SelectedCells[2].Column.GetCellContent(AddingCompany_DataGridView.SelectedItem) as TextBlock).Text;

            ConfirmationDel Win1 = new ConfirmationDel(nip, names);
            Win1.Show();
                  
            
        }

        private void AddingCompany_DataGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //    AddNip_TextBox.Text = "example";
            //    AddName_TextBox.Text = "example";
            //    AddCity_TextBox.Text = "example";
            //    AddStreet_TextBox.Text = "example";
            //    AddBuilding_TextBox.Text = "example";
            //    AddPostcode_TextBox.Text = "example";
            AddNip_TextBox.Text = (AddingCompany_DataGridView.SelectedCells[1].Column.GetCellContent(AddingCompany_DataGridView.SelectedItem) as TextBlock).Text;
            AddName_TextBox.Text = (AddingCompany_DataGridView.SelectedCells[2].Column.GetCellContent(AddingCompany_DataGridView.SelectedItem) as TextBlock).Text;
            AddCity_TextBox.Text = (AddingCompany_DataGridView.SelectedCells[3].Column.GetCellContent(AddingCompany_DataGridView.SelectedItem) as TextBlock).Text;
            AddStreet_TextBox.Text = (AddingCompany_DataGridView.SelectedCells[4].Column.GetCellContent(AddingCompany_DataGridView.SelectedItem) as TextBlock).Text;
            AddBuilding_TextBox.Text = (AddingCompany_DataGridView.SelectedCells[5].Column.GetCellContent(AddingCompany_DataGridView.SelectedItem) as TextBlock).Text;
            AddPostcode_TextBox.Text = (AddingCompany_DataGridView.SelectedCells[6].Column.GetCellContent(AddingCompany_DataGridView.SelectedItem) as TextBlock).Text;



         

        }

        private void EditCompany_Button_Click(object sender, RoutedEventArgs e)
        {
            //DataBaseCon.Query(Company.EditCompany(nip, name, city, street, building,postcode));
            DataBaseCon.Query(Company.EditCompany(AddNip_TextBox.Text, AddName_TextBox.Text, AddCity_TextBox.Text, AddStreet_TextBox.Text, AddBuilding_TextBox.Text, AddPostcode_TextBox.Text));
            this.Close();
            AddCompany Win1 = new AddCompany();
            Win1.Show();

        }

      
    }
}
