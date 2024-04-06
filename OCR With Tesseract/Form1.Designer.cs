namespace OCR_With_Tesseract
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOCRStart = new Button();
            txtExtractedText = new TextBox();
            pbPageImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbPageImage).BeginInit();
            SuspendLayout();
            // 
            // btnOCRStart
            // 
            btnOCRStart.BackColor = Color.ForestGreen;
            btnOCRStart.ForeColor = Color.White;
            btnOCRStart.Location = new Point(1071, 403);
            btnOCRStart.Name = "btnOCRStart";
            btnOCRStart.Size = new Size(102, 39);
            btnOCRStart.TabIndex = 0;
            btnOCRStart.Text = "OCR Start";
            btnOCRStart.UseVisualStyleBackColor = false;
            btnOCRStart.Click += btnOCRStart_Click;
            // 
            // txtExtractedText
            // 
            txtExtractedText.Location = new Point(695, 12);
            txtExtractedText.Multiline = true;
            txtExtractedText.Name = "txtExtractedText";
            txtExtractedText.Size = new Size(478, 385);
            txtExtractedText.TabIndex = 1;
            // 
            // pbPageImage
            // 
            pbPageImage.Location = new Point(36, 12);
            pbPageImage.Name = "pbPageImage";
            pbPageImage.Size = new Size(632, 385);
            pbPageImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPageImage.TabIndex = 2;
            pbPageImage.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 450);
            Controls.Add(pbPageImage);
            Controls.Add(txtExtractedText);
            Controls.Add(btnOCRStart);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbPageImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOCRStart;
        private TextBox txtExtractedText;
        private PictureBox pbPageImage;
    }
}
