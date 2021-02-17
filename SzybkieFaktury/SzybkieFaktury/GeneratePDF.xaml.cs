using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.Pdf.Interactive;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
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
using Color = System.Drawing.Color;

namespace SzybkieFaktury
{
    /// <summary>
    /// Interaction logic for GeneratePDF.xaml
    /// </summary>
    public partial class GeneratePDF : Window
    {
        public GeneratePDF()
        {
            InitializeComponent();
            DataBaseCon.GridViewSelect("SELECT id_invoice,id_company, issue_date, payment_date, status FROM Invoice", "Invoice", Invoices_DataGrid);
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            
                //Create PDF with PDF/A-3b conformance.
                PdfDocument document = new PdfDocument(PdfConformanceLevel.Pdf_A3B);
                //Set ZUGFeRD profile.
                document.ZugferdConformanceLevel = ZugferdConformanceLevel.Basic;
            //Create border color.
            PdfColor borderColor = new PdfColor(Color.FromArgb(255, 142, 170, 219));
            PdfBrush lightBlueBrush = new PdfSolidBrush(new PdfColor(Color.FromArgb(255, 91, 126, 215)));

            PdfBrush darkBlueBrush = new PdfSolidBrush(new PdfColor(Color.FromArgb(255, 65, 104, 209)));

            PdfBrush whiteBrush = new PdfSolidBrush(new PdfColor(Color.FromArgb(255, 255, 255, 255)));
            PdfPen borderPen = new PdfPen(borderColor, 1f);

            //Create TrueType font.
            PdfTrueTypeFont headerFont = new PdfTrueTypeFont(new Font("Arial", 30, System.Drawing.FontStyle.Regular), true);
            PdfTrueTypeFont arialRegularFont = new PdfTrueTypeFont(new Font("Arial", 9, System.Drawing.FontStyle.Regular), true);
            PdfTrueTypeFont arialBoldFont = new PdfTrueTypeFont(new Font("Arial", 11, System.Drawing.FontStyle.Bold), true);


            const float margin = 30;
            const float lineSpace = 7;
            const float headerHeight = 90;


            //Add page to the PDF.
            PdfPage page = document.Pages.Add();

            PdfGraphics graphics = page.Graphics;

            //Get the page width and height.
            float pageWidth = page.GetClientSize().Width;
            float pageHeight = page.GetClientSize().Height;
            //Draw page border
            graphics.DrawRectangle(borderPen, new RectangleF(0, 0, pageWidth, pageHeight));

            //Fill the header with light Brush.
            graphics.DrawRectangle(lightBlueBrush, new RectangleF(0, 0, pageWidth, headerHeight));

            RectangleF headerAmountBounds = new RectangleF(400, 0, pageWidth - 400, headerHeight);

            graphics.DrawString("Faktura VAT Nr."+ (Invoices_DataGrid.SelectedCells[0].Column.GetCellContent(Invoices_DataGrid.SelectedItem) as TextBlock).Text, headerFont, whiteBrush, new PointF(margin, headerAmountBounds.Height / 3));

            graphics.DrawRectangle(darkBlueBrush, headerAmountBounds);

            graphics.DrawString("Amount", arialRegularFont, whiteBrush, headerAmountBounds, new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle));

            PdfTextElement textElement = new PdfTextElement("Numer faktury:"+(Invoices_DataGrid.SelectedCells[0].Column.GetCellContent(Invoices_DataGrid.SelectedItem) as TextBlock).Text, arialRegularFont);

            PdfLayoutResult layoutResult = textElement.Draw(page, new PointF(headerAmountBounds.X - margin, 120));

            textElement.Text = "Data wystawienia : " + (Invoices_DataGrid.SelectedCells[2].Column.GetCellContent(Invoices_DataGrid.SelectedItem) as TextBlock).Text;
            textElement.Draw(page, new PointF(layoutResult.Bounds.X, layoutResult.Bounds.Bottom + lineSpace));
            textElement.Text = "Data płatności : " + (Invoices_DataGrid.SelectedCells[3].Column.GetCellContent(Invoices_DataGrid.SelectedItem) as TextBlock).Text;
            textElement.Draw(page, new PointF(layoutResult.Bounds.X, layoutResult.Bounds.Bottom + lineSpace+20));

            textElement.Text = "Nabywca:";
            layoutResult = textElement.Draw(page, new PointF(margin, 120));

            textElement.Text = DataBaseCon.ReadData("select name_company from Company where id_company="+(Invoices_DataGrid.SelectedCells[1].Column.GetCellContent(Invoices_DataGrid.SelectedItem) as TextBlock).Text+"; ");
            layoutResult = textElement.Draw(page, new PointF(margin, layoutResult.Bounds.Bottom + lineSpace));
            textElement.Text = DataBaseCon.ReadData("select nip from Company where id_company=" + (Invoices_DataGrid.SelectedCells[1].Column.GetCellContent(Invoices_DataGrid.SelectedItem) as TextBlock).Text + "; ");
            layoutResult = textElement.Draw(page, new PointF(margin, layoutResult.Bounds.Bottom + lineSpace));
            textElement.Text = DataBaseCon.ReadData("select street from Company where id_company=" + (Invoices_DataGrid.SelectedCells[1].Column.GetCellContent(Invoices_DataGrid.SelectedItem) as TextBlock).Text + "; ")+" "+ DataBaseCon.ReadData("select building_nr from Company where id_company=" + (Invoices_DataGrid.SelectedCells[1].Column.GetCellContent(Invoices_DataGrid.SelectedItem) as TextBlock).Text + "; ");
            layoutResult = textElement.Draw(page, new PointF(margin, layoutResult.Bounds.Bottom + lineSpace));
            textElement.Text = DataBaseCon.ReadData("select city from Company where id_company=" + (Invoices_DataGrid.SelectedCells[1].Column.GetCellContent(Invoices_DataGrid.SelectedItem) as TextBlock).Text + "; ") + ", " + DataBaseCon.ReadData("select postcode from Company where id_company=" + (Invoices_DataGrid.SelectedCells[1].Column.GetCellContent(Invoices_DataGrid.SelectedItem) as TextBlock).Text + "; ");
            layoutResult = textElement.Draw(page, new PointF(margin, layoutResult.Bounds.Bottom + lineSpace));


            string CmdString = "select id_invoicegoods, article, quantity, value_netto, total_netto from invoiceGoods where id_invoice="+(Invoices_DataGrid.SelectedCells[0].Column.GetCellContent(Invoices_DataGrid.SelectedItem) as TextBlock).Text;
            OleDbDataAdapter sda = new OleDbDataAdapter(CmdString, ConfigurationManager.ConnectionStrings["Connection"].ToString());
            DataTable dt = new DataTable("invoiceGoods");
            sda.Fill(dt);
            
            PdfGrid grid = new PdfGrid();

            grid.DataSource = dt.DefaultView;

            grid.Columns[0].Width = 150;
            grid.Style.Font = arialRegularFont;
            grid.Style.CellPadding.All = 5;

            grid.ApplyBuiltinStyle(PdfGridBuiltinStyle.ListTable4Accent5);

            layoutResult = grid.Draw(page, new PointF(0, layoutResult.Bounds.Bottom + 40));
           
            textElement.Text = "Razem: ";
            textElement.Font = arialBoldFont;
            layoutResult = textElement.Draw(page, new PointF(headerAmountBounds.X - 40, layoutResult.Bounds.Bottom + lineSpace));
            decimal sum = 0;
            foreach (DataRow row in dt.Rows)
            {
                sum += Convert.ToDecimal(row["total_netto"]);
            }

            decimal totalAmount = sum;
            /*DataBaseCon.GridCalc("select total_netto from invoiceGoods where id_invoice = " + (Invoices_DataGrid.SelectedCells[0].Column.GetCellContent(Invoices_DataGrid.SelectedItem) as TextBlock).Text, "invoiceGoods", grid, 0);*/
            textElement.Text = totalAmount.ToString()+" zł";
            layoutResult = textElement.Draw(page, new PointF(layoutResult.Bounds.Right + 4, layoutResult.Bounds.Y));

            graphics.DrawString(" zł" + totalAmount.ToString(), arialBoldFont, whiteBrush, new RectangleF(400, lineSpace, pageWidth - 400, headerHeight + 15), new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle));


            borderPen.DashStyle = PdfDashStyle.Custom;
            borderPen.DashPattern = new float[] { 3, 3 };

            PdfLine line = new PdfLine(borderPen, new PointF(0, 0), new PointF(pageWidth, 0));
            layoutResult = line.Draw(page, new PointF(0, pageHeight - 100));

            textElement.Text = "Sprzedawca: ";
            textElement.Font = arialRegularFont;
            layoutResult = textElement.Draw(page, new PointF(margin, layoutResult.Bounds.Bottom + lineSpace ));
            textElement.Text = "Filip Filip";
            layoutResult = textElement.Draw(page, new PointF(margin, layoutResult.Bounds.Bottom + lineSpace));
            textElement.Text = "NIP: 7862019988";
            layoutResult = textElement.Draw(page, new PointF(margin, layoutResult.Bounds.Bottom + lineSpace));
            textElement.Text = "ul. Bławatkowa 85";
            layoutResult = textElement.Draw(page, new PointF(margin, layoutResult.Bounds.Bottom + lineSpace));
            textElement.Text = "Środa Wielkopolska, 63-000";
            layoutResult = textElement.Draw(page, new PointF(margin, layoutResult.Bounds.Bottom + lineSpace));
           
            


            //PdfAttachment attachment = new PdfAttachment("ZUGFeRD-invoice.xml", zugferdXML);
            //attachment.Relationship = PdfAttachmentRelationship.Alternative;
            //attachment.ModificationDate = DateTime.Now;
            //attachment.Description = "ZUGFeRD-invoice";
            //attachment.MimeType = "application/xml";
            //document.Attachments.Add(attachment);
            document.Save("ZUGFeRDInvoice.pdf");
            document.Close(true);
        }

      
    }
}
