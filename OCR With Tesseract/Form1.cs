using Tesseract;

namespace OCR_With_Tesseract
{
    public partial class Form1 : Form
    {
        string imagePath = @"E:\\temp\\ocr-img\image.jpg";
        public Form1()
        {
            InitializeComponent();
            pbPageImage.ImageLocation = imagePath;
            pbPageImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnOCRStart_Click(object sender, EventArgs e)
        {

            // https://github.com/tesseract-ocr/tessdata_best
            // place this data in the debug app folder

            using (var engine = new TesseractEngine("./tessdata", "urd", EngineMode.Default))
            {
                using(var image = Pix.LoadFromFile(imagePath))
                {
                    using(var page = engine.Process(image))
                    {
                        txtExtractedText.Text = page.GetText();
                    }
                }
            }
        }
    }
}
