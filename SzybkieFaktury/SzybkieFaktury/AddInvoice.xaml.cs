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
    /// Interaction logic for AddInvoice.xaml
    /// </summary>
    public partial class AddInvoice : Window
    {
        int id_company1;
        public AddInvoice()
        {
            InitializeComponent();
            DataBaseCon.GridViewSelect("SELECT * FROM invoiceGoods where id_invoice="+id_company1, "invoiceGoods", invoiceGoods_GridView);
        }
        
        public AddInvoice(int id_company)
        {
            id_company1 = id_company;
            InitializeComponent();
        }


        private void AddItemToInvoice_button_Click(object sender, RoutedEventArgs e)
        {

            DataBaseCon.Query(Invoice.AddItemToInvoice(DataBaseCon.ReadData("SELECT TOP 1 id_invoice FROM Invoice ORDER BY id_invoice DESC"),Item_text.Text,Quantity_text.Text, netto_text.Text));
            Item_text.Text = null;
            Quantity_text.Text = null;
            netto_text.Text = null;
            DataBaseCon.GridViewSelect("SELECT * FROM invoiceGoods where id_invoice="+ DataBaseCon.ReadData("SELECT TOP 1 id_invoice FROM Invoice ORDER BY id_invoice DESC"), "invoiceGoods", invoiceGoods_GridView);
            
        }
        private void close_invoice_Click(object sender, RoutedEventArgs e)
        {
            DataBaseCon.Query(Invoice.UpdateInvoice(DataBaseCon.ReadData("SELECT TOP 1 id_invoice FROM Invoice ORDER BY id_invoice DESC"), auth_recieve.Text, Payment_Text.Text));

        }
    }
}
