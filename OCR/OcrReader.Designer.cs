namespace OCR
{
    partial class OcrReader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.selectedFile = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(482, 10);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // selectedFile
            // 
            this.selectedFile.Location = new System.Drawing.Point(12, 12);
            this.selectedFile.Name = "selectedFile";
            this.selectedFile.ReadOnly = true;
            this.selectedFile.Size = new System.Drawing.Size(464, 20);
            this.selectedFile.TabIndex = 1;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(12, 41);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(633, 260);
            this.resultBox.TabIndex = 2;
            this.resultBox.Text = "";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(563, 9);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // OcrReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 313);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.selectedFile);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "OcrReader";
            this.Text = "OCR READER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox selectedFile;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.Button btnRead;


    }
}

