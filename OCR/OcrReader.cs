using System;
using System.Windows.Forms;

namespace OCR
{
    public partial class OcrReader : Form
    {
        public OcrReader()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.ShowDialog();
            selectedFile.Text = ofd.FileName;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //resultBox.Text = (new API.Api().AnalyzeDocumentV2(selectedFile.Text));
            resultBox.Text = (new Tesseract.Library().AnalyzeDocument(selectedFile.Text));
        }
    }
}
