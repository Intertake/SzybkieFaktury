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
            string CmdString = "SELECT * FROM Company";
            
            OleDbDataAdapter sda = new OleDbDataAdapter(CmdString, ConfigurationManager.ConnectionStrings["Connection"].ToString());
            DataTable dt = new DataTable("Company");
            sda.Fill(dt);
            AddingCompany_DataGridView.ItemsSource = dt.DefaultView;

          

        }

 
        private void AddCompany_Button(object sender, RoutedEventArgs e)
        {
            DataBaseCon.Query(Company.AddCompany(AddNip_TextBox.Text,AddName_TextBox.Text,AddCity_TextBox.Text, AddStreet_TextBox.Text, AddBuilding_TextBox.Text, AddPostcode_TextBox.Text));
            this.Close();
        }

        private void DelCompany_Button_Click(object sender, RoutedEventArgs e)
        {
            
            string nip = (AddingCompany_DataGridView.SelectedCells[1].Column.GetCellContent(AddingCompany_DataGridView.SelectedItem) as TextBlock).Text;
            string names = (AddingCompany_DataGridView.SelectedCells[2].Column.GetCellContent(AddingCompany_DataGridView.SelectedItem) as TextBlock).Text;

            ConfirmationDel Win1 = new ConfirmationDel(nip, names);
            Win1.Show();
                  
            
        }

     
    }
}
