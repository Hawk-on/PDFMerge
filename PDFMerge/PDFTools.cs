using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace PDFMerge
{
    public static class PDFTools
    {
        public static void MergePDFs(string sourcePath, string? targetPath = null)
        {
            var targetFilepath = Path.Combine(targetPath ?? sourcePath, "output.pdf");
            var files = Directory.GetFiles(sourcePath, "*.pdf").Select(fn => new FileInfo(fn)).
                                    OrderBy(f => f.Name).Select(d => d.FullName);
            var counter = 0;
            while (File.Exists(targetFilepath))
            {
                counter++;
                targetFilepath = Path.Combine(targetPath ?? sourcePath, $"output{counter}.pdf");
            }
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            using var targetDoc = new PdfDocument();
            foreach (var pdf in files)
            {
                using var pdfDoc = PdfReader.Open(pdf, PdfDocumentOpenMode.Import);
                for (var i = 0; i < pdfDoc.PageCount; i++)
                    targetDoc.AddPage(pdfDoc.Pages[i]);
            }
            targetDoc.Save(targetFilepath);
        }
    }
}
