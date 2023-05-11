using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace EAN
{
    public class Print
    {

        // Eingabezahl definieren
        public static void PrintCode(string input)
        {
            string exeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;

            // Pfad zum Ordner, in dem die Ausführungsdatei liegt
            string exeFolderPath = Path.GetDirectoryName(exeFilePath);

            // Pfad zum Projektordner
            string projectFolderPath = Directory.GetParent(exeFolderPath).Parent.FullName;

            // Dateipfad der zu speichernden Datei im Projektordner
            string filePath = Path.Combine(projectFolderPath, "barcode.png");
            // Barcodeformat definieren (hier: QR-Code)
            BarcodeFormat format = BarcodeFormat.EAN_13;

            // Encoding-Optionen festlegen
            var options = new EncodingOptions
            {
                Width = 600,
                Height = 300,
                Margin = 0
            };

            // BarcodeWriter-Objekt erstellen und Barcode generieren
            var writer = new BarcodeWriter();
            writer.Format = format;
            writer.Options = options;
            var bitmap = writer.Write(input);


            // Barcode als Bitmap speichern oder anzeigen
            try
            {
                bitmap.Save(filePath, ImageFormat.Png);
                InZiwschenablageKopieren(filePath);
                Console.WriteLine("Erstellen des Barcodes war Erfolgreich!");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static void InZiwschenablageKopieren(string path)
        {

            Image image = Image.FromFile(path);
            Clipboard.SetImage(image);
            Console.WriteLine("In der Zwischenablage kopiert!");

        }

    }
}
