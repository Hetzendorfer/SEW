using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WindowsFormsApp1.pdf
{
    class PDF
    {

        static public void CreatePDF(config.Rechnung Rechnung)
        {
            FileStream fs = new FileStream("rechnung.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            Rectangle rec = new Rectangle(PageSize.A4);
            Document doc = new Document(rec, 36, 72, 108, 180);

            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            writer.PageEvent = new HeaderFooter();
            doc.Open();

            #region Unternehmensdaten
            Paragraph unternehmensName = new Paragraph(10f, Rechnung.Unternehmen.Name, new Font(Font.FontFamily.TIMES_ROMAN));
            Paragraph straßeHausnummer = new Paragraph(10f, Rechnung.Unternehmen.Standort.Straße + " " + Rechnung.Unternehmen.Standort.Hausnummer, new Font(Font.FontFamily.TIMES_ROMAN));
            Paragraph plzStadtname = new Paragraph(10f, Rechnung.Unternehmen.Standort.PLZ + " " + Rechnung.Unternehmen.Standort.Stadt, new Font(Font.FontFamily.TIMES_ROMAN));
            Paragraph telefon = new Paragraph(10f, Rechnung.Unternehmen.Telefon, new Font(Font.FontFamily.TIMES_ROMAN));
            Paragraph email = new Paragraph(10f, Rechnung.Unternehmen.EMail, new Font(Font.FontFamily.TIMES_ROMAN));
            Paragraph fax = new Paragraph(10f, Rechnung.Unternehmen.FAX, new Font(Font.FontFamily.TIMES_ROMAN));
            Paragraph uid = new Paragraph(10f, Rechnung.Unternehmen.UID, new Font(Font.FontFamily.TIMES_ROMAN));
            Paragraph firmenbuchnummer = new Paragraph(10f, Rechnung.Unternehmen.Firmenbuchnummer, new Font(Font.FontFamily.TIMES_ROMAN));

            unternehmensName.Alignment = Element.ALIGN_RIGHT;
            straßeHausnummer.Alignment = Element.ALIGN_RIGHT;
            plzStadtname.Alignment = Element.ALIGN_RIGHT;
            telefon.Alignment = Element.ALIGN_RIGHT;
            fax.Alignment = Element.ALIGN_RIGHT;
            email.Alignment = Element.ALIGN_RIGHT;
            uid.Alignment = Element.ALIGN_RIGHT;
            firmenbuchnummer.Alignment = Element.ALIGN_RIGHT;

            doc.Add(unternehmensName);
            doc.Add(straßeHausnummer);
            doc.Add(plzStadtname);
            doc.Add(telefon);
            doc.Add(fax);
            doc.Add(email);
            doc.Add(uid);
            doc.Add(firmenbuchnummer);
            #endregion

            #region Klientdaten
            Paragraph käuferName = new Paragraph(10f, Rechnung.Käufer.Name, new Font(Font.FontFamily.TIMES_ROMAN));
            Paragraph käuferStraßeHausnummer = new Paragraph(10f, Rechnung.Käufer.Standort.Straße + " " + Rechnung.Käufer.Standort.Hausnummer, new Font(Font.FontFamily.TIMES_ROMAN));
            Paragraph käuferPLZStadt = new Paragraph(10f, Rechnung.Käufer.Standort.PLZ + " " + Rechnung.Käufer.Standort.Stadt, new Font(Font.FontFamily.TIMES_ROMAN));

            käuferName.Alignment = Element.ALIGN_LEFT;
            käuferPLZStadt.Alignment = Element.ALIGN_LEFT;
            käuferStraßeHausnummer.Alignment = Element.ALIGN_LEFT;

            doc.Add(käuferName);
            doc.Add(käuferStraßeHausnummer);
            doc.Add(käuferPLZStadt);
            #endregion

            Paragraph lehrZeile = new Paragraph(10f, " ", new Font(Font.FontFamily.TIMES_ROMAN));
            Paragraph rechnungNr = new Paragraph(10f, "Rechnungsnummer: " + Rechnung.ID.ToString(), new Font(Font.FontFamily.HELVETICA));

            doc.Add(lehrZeile);
            doc.Add(lehrZeile);
            doc.Add(lehrZeile);
            doc.Add(rechnungNr);
            doc.Add(lehrZeile);

            PdfPTable table = new PdfPTable(5);
            table.AddCell("Menge");
            table.AddCell("Beschreibung");
            table.AddCell("Einzelpreis (Brutto)");
            table.AddCell("Gesamtpreis(Brutto)");
            table.AddCell("Ust.");

            decimal gesamtsummeBrutto = 0, gesamtsummeNetto = 0;
            foreach (config.Rechnung_Produkt item in Rechnung.Rechnung_Produkte)
            {
                table.AddCell(item.Menge.ToString());
                table.AddCell(item.Produkt.Name);
                table.AddCell((item.Produkt.Preis * (1 + item.Produkt.UST)).ToString());
                table.AddCell((item.Menge * item.Produkt.Preis * (1 + item.Produkt.UST)).ToString());
                table.AddCell(item.Produkt.UST.ToString());
                gesamtsummeBrutto += item.Menge * item.Produkt.Preis * (1 + item.Produkt.UST);
                gesamtsummeNetto += item.Menge* item.Produkt.Preis;
            }

            /*table.AddCell("");
            table.AddCell("");
            Font f = new Font();
            f.SetStyle(Font.BOLD);
            table.AddCell(new Phrase("Gesamtsumme Brutto:", f));
            table.AddCell(gesamtsummeBrutto.ToString());
            table.AddCell("");

            table.AddCell("");
            table.AddCell("");
            table.AddCell(new Phrase("Netto:", f));
            table.AddCell(gesamtsummeNetto.ToString());
            table.AddCell("");

            table.AddCell("");
            table.AddCell("");
            table.AddCell(new Phrase("Ust.:", f));
            table.AddCell((gesamtsummeBrutto - gesamtsummeNetto).ToString());
            table.AddCell(""); */

            Font f = new Font();
            f.Size = 10f;

            Paragraph parGesamtBrutto = new Paragraph("Gesamtsumme Brutto: " + gesamtsummeBrutto.ToString() + " €", f);
            Paragraph parGesamtNetto = new Paragraph("Netto: " + gesamtsummeNetto.ToString() + " €", f);
            Paragraph parUST = new Paragraph("Ust.: " + (gesamtsummeBrutto - gesamtsummeNetto).ToString() + " €", f);
            parGesamtBrutto.IndentationLeft = 300;
            parGesamtNetto.IndentationLeft = 300;
            parUST.IndentationLeft = 300;

            doc.Add(table);
            doc.Add(lehrZeile);
            doc.Add(parGesamtBrutto);
            doc.Add(parGesamtNetto);
            doc.Add(parUST);
            doc.Close();
        }
        static private void CreateUnternehmenData(Document doc)
        {

        }
    }
}
