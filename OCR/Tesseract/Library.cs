using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.IO;
using tessnet2;

namespace OCR.Tesseract
{
    public class Library
    {
        public string AnalyzeDocument(string path)
        {
           var langDir =  Directory.GetParent(Environment.CurrentDirectory);
            var sb = new StringBuilder();
            var image = new Bitmap(path);
            var ocr = new tessnet2.Tesseract();           
           
            var tessdata = (langDir + @"\tessdata").Trim();
            ocr.Init(tessdata, "eng", false);
            List<Word> result = ocr.DoOCR(image, Rectangle.Empty);
            ocr.GetThresholdedImage(image, Rectangle.Empty);
            result.ForEach(word =>
            {
                sb.Append(word.Text + " ");
            });           
            return sb.ToString().Trim();
        }
    }
}
