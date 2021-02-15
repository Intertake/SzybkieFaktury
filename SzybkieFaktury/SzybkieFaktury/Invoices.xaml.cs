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
    /// Interaction logic for Invoices.xaml
    /// </summary>
    public partial class Invoices : Window
    {
        public Invoices()
        {
            InitializeComponent();
            DataBaseCon.GridViewSelect("SELECT * FROM invoice ", "invoice", Invoices_datagrid);
        }

        private void AddInvoice_Button_Click(object sender, RoutedEventArgs e)
        {
            AddCompanyToInvoice Win1 = new AddCompanyToInvoice();
            Win1.Show();

        }

        private void EditInvoice_Button_Click(object sender, RoutedEventArgs e)
        {
            EditInvoice Win2 = new EditInvoice();
            Win2.Show();
        }

        private void DelInvoice_Button_Click(object sender, RoutedEventArgs e)
        {
            ConfirmationDelInvoice Win3 = new ConfirmationDelInvoice();
            Win3.Show();
        }

        
    }
}
