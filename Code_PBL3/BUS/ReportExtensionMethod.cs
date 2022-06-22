using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Words;
using Aspose.Words.Tables;

namespace Code_PBL3.BUS
{
    internal static class ReportExtensionMethod
    {
        public static void PutValue(this Table table, int row, int column, string text)
        {
            Row r = table.Rows[row];
            if (r == null || text == null)
                return;

            Cell cell = r.Cells[column];
            if (cell == null)
                return;

            var paragraph = cell.Paragraphs[0];
            if (paragraph == null)
                cell.Paragraphs.Add(new Paragraph(cell.Document));
            paragraph = cell.Paragraphs[0];

            var run = paragraph.Runs[0];
            if (run == null)
                paragraph.Runs.Add(new Run(paragraph.Document));
            run = paragraph.Runs[0];

            run.Text = text;
        }
        public static void InsertRows(this Table table, int index_source_row, int index_insert, int count)
        {
            try
            {
                var sourceRow = table.Rows[index_source_row];
                if (sourceRow != null)
                    for (int i = 1; i <= count; i++)
                        table.Rows.Insert(index_insert, sourceRow.Clone(true));
            }
            catch { }
        }

    }

    internal static class Ex
    {
        public static void SaveAndOpenFile(this Document doc, string filename = "tmp.doc")
        {
            int dem = 0;
            string thuMuc = @"C:\Users\huuhu\source\repos\PBL3_Code_HQT\Code_PBL3\BILL";
            if (!Directory.Exists(thuMuc))
                Directory.CreateDirectory(thuMuc);

            while (true)
            {
                string tenTep = $"{thuMuc}\\{filename}";
                try
                {
                    doc.Save(tenTep);
                    Process.Start(tenTep);
                    break;
                }
                catch
                {
                    dem++;
                }
            }
        }
    }
}
