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
using System.Data.OleDb;
namespace SzybkieFaktury
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }  
      
        private void Companies_Button(object sender, RoutedEventArgs e)
        {
            AddCompany Win1 = new AddCompany();
            Win1.Show();
        }

        private void AddInvoice_Click(object sender, RoutedEventArgs e)
        {
            Invoices Win2 = new Invoices();
            Win2.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GeneratePDF Win2 = new GeneratePDF();
            Win2.Show();
        }
    }
}
