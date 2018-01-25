using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;

namespace createBill
{

    public partial class Form1 : Form
    {
      
        FileStream fs; 
        Document doc; 
        PdfWriter writer; 

        public Form1()
        {
            try
            {
                fs = new FileStream("hello.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
                doc = new Document(PageSize.A4);
                writer = PdfWriter.GetInstance(doc, fs);
                writer.PageEvent = new HeaderFooter();

                InitializeComponent();
                
            }

            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doc.Open();

            PdfPTable table = new PdfPTable(3);

            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(@"C:\Users\Kevin\Pictures\1478720017672.jpg", true);
            img.ScaleAbsolute(159f, 159f);

            table.AddCell("Produkt");
            table.AddCell("Menge");
            table.AddCell("Preis");

            table.AddCell("Tanktop");
            table.AddCell("5");
            table.AddCell("14000");

            PdfPCell cell = new PdfPCell(new Phrase("Ferngläser"));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase("500"));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase("29765"));
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Sonnenbrille"));
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Das ist ein Test"));
            cell.Rowspan = 2;
            cell.Colspan = 2;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Anderes"));
            table.AddCell(cell);

            BaseFont bfs = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Paragraph paras = new Paragraph("\nHier könnten Daten stehen stehen \n Hier könnten Daten stehen stehen", new iTextSharp.text.Font(bfs));

            BaseFont a = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Paragraph right = new Paragraph("\nHier könnten Daten stehen stehen\n Hier könnten Daten stehen stehen \n Hier könnten Daten stehen stehen\n\n", new iTextSharp.text.Font(a));
            right.Alignment = Element.ALIGN_RIGHT;

            BaseFont z = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Paragraph header = new Paragraph("Das hier könnte der Header werden", new iTextSharp.text.Font(z));
            header.Alignment = Element.ALIGN_TOP;

            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1))); cell.Border = 1;              

            for (int i = 0; i < 10; i++)
            {

                BaseFont s = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Paragraph site = new Paragraph("SeitenAnzahl: " + i, new iTextSharp.text.Font(s));
                site.Alignment = Element.ALIGN_BOTTOM;
                site.Alignment = Element.ALIGN_CENTER;
                site.Alignment = Element.ALIGN_RIGHT;

                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Paragraph para = new Paragraph("Das ist eine Test Zeile, die eine Adresse darstellen könnte", new iTextSharp.text.Font(bf));
                para.Alignment = Element.ALIGN_CENTER;
                para.Alignment = Element.ALIGN_TOP;

                doc.Add(header);
                doc.Add(p);
                doc.Add(img);
                doc.Add(para);
                doc.Add(right);
                doc.Add(table);
                doc.Add(paras);
                doc.Add(site);
                OnEndPage(writer, doc);
                doc.NewPage();
                
            }

            doc.Close();
            MessageBox.Show("PDF wurde erstellt");
        }

        public void OnEndPage(PdfWriter writer, Document document)
        {

            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(@"C:\Users\Kevin\Pictures\1478720017672.jpg", true);
            img.ScaleAbsolute(159f, 159f);
          
            PdfContentByte cb = writer.DirectContent;
            ColumnText ct = new ColumnText(cb);

            cb.BeginText();
            cb.SetFontAndSize(BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 12.0f);
            cb.SetTextMatrix(document.LeftMargin, document.BottomMargin);
            cb.ShowText(String.Format("{0} {1}", "Das ist ein Footer", "Nice"));
            cb.EndText();         

        }
    }
}
