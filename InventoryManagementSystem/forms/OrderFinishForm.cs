using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using InventoryManagementSystem.Data;
using InventoryManagementSystem.Dtos;
using InventoryManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms
{
    public partial class OrderFinishForm : Form
    {
        private readonly DBConnector _dbconnector;
        private readonly TempOrderRepository _temporderreposiory;
        private readonly OrderForm _orderForm;
        List<TempOrderDto> _orders;
        int _totalAmount;
        int _payAmount;
        int invoice_number;
        public OrderFinishForm(OrderForm orderForm,List<TempOrderDto> orders,int totalAmount,int payAmount)
        {
            InitializeComponent();
            _dbconnector = new DBConnector();
            _temporderreposiory = new TempOrderRepository(_dbconnector);
            _orderForm = orderForm;
            _orders = orders;
            _totalAmount = totalAmount;
            _payAmount = payAmount;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearTable()
        {
            _temporderreposiory.ClearDB();
            _orderForm.tbCustomer.Clear();
            this.Close();
        }

        private void bPrintBill_Click(object sender, EventArgs e)
        {
            string exePath = AppContext.BaseDirectory;

            string templatePath = Path.Combine(
               exePath,
                "Templates",
                "Market_Inventory_Template.docx"
            );

            if (!File.Exists(templatePath))
            {
                MessageBox.Show(
                    "Template file not found:\n" + templatePath,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            string billsDir = Path.Combine(
                "Bills"
            );
            Directory.CreateDirectory(billsDir); 

            string outputPath = Path.Combine(
                exePath, billsDir,
                $"Bill_{DateTime.Now:yyyyMMdd_HHmmss}.docx"
            );

            File.Copy(templatePath, outputPath, true);

            using (WordprocessingDocument doc = WordprocessingDocument.Open(outputPath, true))
            {
                Body body = doc.MainDocumentPart.Document.Body;
                invoice_number = _temporderreposiory.TempGetInvoiceNumber();

                ReplaceTextEverywhere(doc, "{invoiceNumber}", invoice_number.ToString());
                ReplaceTextEverywhere(doc, "{cashierName}", lCashierName.Text);
                ReplaceTextEverywhere(doc, "{customerName}", lCustomerName.Text);
                ReplaceTextEverywhere(doc, "{invoiceDate}", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                ++invoice_number;
                Table table = body.Elements<Table>().First();

                TableRow templateRow = table.Elements<TableRow>()
                    .First(r => r.InnerText.Contains("{{ROW}}"));

                TableRow lastRow = templateRow;
                int no = 1;

                foreach (var item in _orders)
                {
                    TableRow row = (TableRow)templateRow.CloneNode(true);

                    ReplaceText(row, "{{ROW}}", no.ToString());
                    ReplaceText(row, "{product_name}", item.temproductName);
                    ReplaceText(row, "{qty}", item.temqty.ToString());
                    ReplaceText(row, "{u_price}", item.temprice.ToString("0.00"));
                    ReplaceText(row, "{t_price}", item.temtPrice.ToString("0.00"));

                    table.InsertAfter(row, lastRow);
                    lastRow = row;
                    no++;
                }

                templateRow.Remove();

                ReplaceTextEverywhere(doc, "{totalAmount}", $"Rs {_totalAmount:0.00}");
                ReplaceTextEverywhere(doc, "{payAmount}", $"Rs {_payAmount:0.00}");
                ReplaceTextEverywhere(doc, "{balance}", $"Rs {_payAmount - _totalAmount:0.00}");

                doc.MainDocumentPart.Document.Save();
            }

            Process.Start(new ProcessStartInfo
            {
                FileName = outputPath,
                UseShellExecute = true
            });
            ClearTable();
        }

        private void ReplaceText(OpenXmlElement element, string placeholder, string value)
        {
            foreach (var text in element.Descendants<Text>())
            {
                if (text.Text.Contains(placeholder))
                {
                    text.Text = text.Text.Replace(placeholder, value);
                }
            }
        }

        private void ReplaceTextEverywhere(WordprocessingDocument doc,string placeholder,string value)
        {
            ReplaceInPart(doc.MainDocumentPart.Document.Body, placeholder, value);

            foreach (var header in doc.MainDocumentPart.HeaderParts)
                ReplaceInPart(header.Header, placeholder, value);

            foreach (var footer in doc.MainDocumentPart.FooterParts)
                ReplaceInPart(footer.Footer, placeholder, value);
        }

        private void ReplaceInPart(OpenXmlElement root, string placeholder, string value)
        {
            foreach (var paragraph in root.Descendants<Paragraph>())
            {
                string fullText = string.Concat(
                    paragraph.Descendants<Text>().Select(t => t.Text)
                );

                if (!fullText.Contains(placeholder))
                    continue;

                fullText = fullText.Replace(placeholder, value);

                paragraph.RemoveAllChildren<Run>();

                Run run = new Run(new Text(fullText)
                {
                    Space = SpaceProcessingModeValues.Preserve
                });

                paragraph.Append(run);
            }
        }



        private void bClose_Click(object sender, EventArgs e)
        {
            ClearTable();
        }
    }
}
