using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace sellular_shop
{
    internal sealed class ReceiptData
    {
        public DateTime SaleDate { get; set; }
        public List<ReceiptItemData> Items { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentType { get; set; }
        public string ClientName { get; set; }
        public string EmployeeName { get; set; }
    }

    internal sealed class ReceiptItemData
    {
        public string ItemName { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
    }

    internal static class ReceiptPdfExporter
    {
        public static void ExportSaleReceipt(string filePath, ReceiptData data)
        {
            using (Bitmap receiptBitmap = DrawReceiptBitmap(data))
            using (MemoryStream jpegStream = new MemoryStream())
            {
                receiptBitmap.Save(jpegStream, ImageFormat.Jpeg);
                byte[] jpegBytes = jpegStream.ToArray();
                SavePdfWithJpeg(filePath, jpegBytes, receiptBitmap.Width, receiptBitmap.Height);
            }
        }

        private static Bitmap DrawReceiptBitmap(ReceiptData data)
        {
            List<string> itemLines = data.Items
                .Select(item =>
                {
                    string name = item.ItemName ?? "Позиция";
                    if (name.Length > 20)
                    {
                        name = name.Substring(0, 20);
                    }

                    return string.Format(
                        CultureInfo.InvariantCulture,
                        "{0,-20} {1}x{2:0.##}",
                        name,
                        item.Quantity,
                        item.Price);
                })
                .ToList();

            int lineHeight = 30;
            int width = 700;
            int totalLines = 8 + itemLines.Count;
            int height = 30 + (totalLines * lineHeight);

            Bitmap bitmap = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            using (Brush brush = new SolidBrush(Color.Black))
            using (Font titleFont = new Font("Arial", 18, FontStyle.Bold))
            using (Font textFont = new Font("Consolas", 14))
            {
                graphics.Clear(Color.White);
                graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

                int y = 20;
                string dateText = data.SaleDate.ToString("dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture);
                DrawCenteredString(graphics, dateText, titleFont, brush, width, y);
                y += lineHeight + 5;

                DrawCenteredString(graphics, "Салон сотовой связи", titleFont, brush, width, y);
                y += lineHeight + 15;

                foreach (string line in itemLines)
                {
                    graphics.DrawString(line, textFont, brush, 30, y);
                    y += lineHeight;
                }

                y += 6;
                graphics.DrawString($"Итого{new string(' ', 28)}{data.TotalAmount:0.##}", textFont, brush, 30, y);
                y += lineHeight;

                string paymentType = string.IsNullOrWhiteSpace(data.PaymentType)
                    ? "не указана"
                    : data.PaymentType;

                graphics.DrawString($"Оплата {paymentType}", textFont, brush, 30, y);
                y += lineHeight + 10;

                graphics.DrawString($"Покупатель: {data.ClientName}", textFont, brush, 30, y);
                y += lineHeight;
                graphics.DrawString($"Продавец: {data.EmployeeName}", textFont, brush, 30, y);
            }

            return bitmap;
        }

        private static void DrawCenteredString(Graphics graphics, string text, Font font, Brush brush, int width, int y)
        {
            SizeF textSize = graphics.MeasureString(text, font);
            float x = (width - textSize.Width) / 2;
            graphics.DrawString(text, font, brush, x, y);
        }

        private static void SavePdfWithJpeg(string filePath, byte[] jpegBytes, int width, int height)
        {
            string imageDrawingCommand = string.Format(CultureInfo.InvariantCulture, "q {0} 0 0 {1} 0 0 cm /Im0 Do Q", width, height);
            byte[] contentBytes = Encoding.ASCII.GetBytes(imageDrawingCommand);

            using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(stream, Encoding.ASCII))
            {
                List<long> offsets = new List<long> { 0 };

                WriteAscii(writer, "%PDF-1.4\n%\n");

                offsets.Add(stream.Position);
                WriteAscii(writer, "1 0 obj\n<< /Type /Catalog /Pages 2 0 R >>\nendobj\n");

                offsets.Add(stream.Position);
                WriteAscii(writer, "2 0 obj\n<< /Type /Pages /Kids [3 0 R] /Count 1 >>\nendobj\n");

                offsets.Add(stream.Position);
                WriteAscii(
                    writer,
                    string.Format(
                        CultureInfo.InvariantCulture,
                        "3 0 obj\n<< /Type /Page /Parent 2 0 R /MediaBox [0 0 {0} {1}] /Resources << /XObject << /Im0 4 0 R >> >> /Contents 5 0 R >>\nendobj\n",
                        width,
                        height));

                offsets.Add(stream.Position);
                WriteAscii(
                    writer,
                    string.Format(
                        CultureInfo.InvariantCulture,
                        "4 0 obj\n<< /Type /XObject /Subtype /Image /Width {0} /Height {1} /ColorSpace /DeviceRGB /BitsPerComponent 8 /Filter /DCTDecode /Length {2} >>\nstream\n",
                        width,
                        height,
                        jpegBytes.Length));
                writer.Write(jpegBytes);
                WriteAscii(writer, "\nendstream\nendobj\n");

                offsets.Add(stream.Position);
                WriteAscii(
                    writer,
                    string.Format(
                        CultureInfo.InvariantCulture,
                        "5 0 obj\n<< /Length {0} >>\nstream\n",
                        contentBytes.Length));
                writer.Write(contentBytes);
                WriteAscii(writer, "\nendstream\nendobj\n");

                long xrefPosition = stream.Position;
                WriteAscii(writer, "xref\n0 6\n");
                WriteAscii(writer, "0000000000 65535 f \n");

                for (int i = 1; i < offsets.Count; i++)
                {
                    WriteAscii(writer, offsets[i].ToString("0000000000", CultureInfo.InvariantCulture) + " 00000 n \n");
                }

                WriteAscii(
                    writer,
                    string.Format(
                        CultureInfo.InvariantCulture,
                        "trailer\n<< /Size 6 /Root 1 0 R >>\nstartxref\n{0}\n%%EOF",
                        xrefPosition));
            }
        }

        private static void WriteAscii(BinaryWriter writer, string text)
        {
            writer.Write(Encoding.ASCII.GetBytes(text));
        }
    }
}
