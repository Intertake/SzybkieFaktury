using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzybkieFaktury
{
    class Invoice
    {
        public int Id_company { get; set; }
        public DateTime issue_date { get; set; }
        public DateTime payment_date { get; set; }
        public string status { get; set; }
        public string auth_recieve_person { get; set; }
        public string article { get; set; }
        public string quantity { get; set; }
        public float value_netto { get; set; }
        public int id_invoice { get; set; }
        public static string AddInvoice(string id_company)
        {
            Invoice Inv1 = new Invoice
            {
                Id_company = Convert.ToInt32(id_company),
                issue_date = DateTime.Now,
                status = "niezapłacona"              
               
            };
            return "Insert into Invoice(id_company, issue_date,status)Values('" + Inv1.Id_company + "','" + Inv1.issue_date.ToString("yyyy/MM/dd") + "','" + Inv1.status + "')";
        }
        public static string AddItemToInvoice(string id_invoice, string article, string quantity, string value_netto)
        {
            Invoice Inv1 = new Invoice
            {
                id_invoice=Convert.ToInt32(id_invoice),
                article=article,
                quantity=quantity,
                value_netto=Convert.ToInt64(value_netto)

            };
            return "Insert into invoiceGoods(id_invoice, article, quantity, value_netto) Values(" + Inv1.id_invoice + ",'" + Inv1.article + "',"+Inv1.quantity+ ","+Inv1.value_netto+ ")";
        }
        public static string UpdateInvoice(string id_invoice, string authrecieve, string days)
        {
            Invoice Inv1 = new Invoice
            {
                id_invoice = Convert.ToInt32(id_invoice),
                auth_recieve_person = authrecieve,
                
            };
            DateTime payment = Convert.ToDateTime(DataBaseCon.ReadData("SELECT TOP 1 issue_date FROM Invoice where id_invoice=" + id_invoice + " ORDER BY id_invoice DESC")).AddDays(Convert.ToInt64(days));

            return "update invoice set auth_recieve_person='" + authrecieve + "', payment_date='" + payment.ToString("yyyy/MM/dd") + "' where id_invoice=" + id_invoice;
        }


    }
}
