using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace demopdf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola XD");
            // Must have write permissions to the path folder
            string rutaDefault = Path.GetTempPath();
            string archivo = Path.Combine(rutaDefault, "demo.pdf");
            PdfWriter writer = new PdfWriter(archivo);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            string headText = string.Format("Prueba Pdf Generado a las: {0}", DateTime.Now.ToString());
            Paragraph header = new Paragraph(headText)
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(20);

            document.Add(header);
            document.Close();
            Console.WriteLine("Documento generado en: {0}",archivo);
            System.Diagnostics.Process.Start(archivo);
            Console.ReadKey();
        }
    }
}
