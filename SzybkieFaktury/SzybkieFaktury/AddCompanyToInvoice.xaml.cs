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
using System.Windows.Shapes;

namespace SzybkieFaktury
{
    /// <summary>
    /// Interaction logic for AddCompanyToInvoice.xaml
    /// </summary>
    public partial class AddCompanyToInvoice : Window
    {

        public AddCompanyToInvoice()
        {
            InitializeComponent();
            DataBaseCon.GridViewSelect("SELECT * FROM Company", "Company", AddCompanyToInvoice_DataGrid);
        }

        private void CreateInvoice_Button_Click(object sender, RoutedEventArgs e)
        {
            AddInvoice Win1 = new AddInvoice();
            Win1.Show();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            DataBaseCon.GridViewSelect("SELECT * FROM Company where nip like" + AddInvoiceToCompany_TextBox.Text + ";", "Company", AddCompanyToInvoice_DataGrid);
        }

        private void AddCompanyToInvoice_DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
