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
    /// Interaction logic for ConfirmationDel.xaml
    /// </summary>
    public partial class ConfirmationDel : Window
    {
        string nip1;
        string namec;
        public ConfirmationDel(string nip, string name)
        {
            InitializeComponent();         
            nip1 = nip;
            namec = name;
            DeleteName.Content = namec;
            DeleteNIP.Content = nip1;
        }
        public ConfirmationDel()
        {
            InitializeComponent();

            DeleteName.Content = Name;
            DeleteNIP.Content = nip1;
        }

        private void DeleteConfirmed_Click(object sender, RoutedEventArgs e)
        {
             
            DataBaseCon.Query(Company.DelCompany(nip1));

            this.Close();
        }

        private void DeleteAbort_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
