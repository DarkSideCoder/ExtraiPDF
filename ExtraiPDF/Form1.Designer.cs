namespace ExtraiPDF
{
    partial class Form1
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
            this.btAction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lcLines = new System.Windows.Forms.Label();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PATH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.HTTP = new System.Windows.Forms.CheckBox();
            this.HTTPS = new System.Windows.Forms.CheckBox();
            this.PDF = new System.Windows.Forms.CheckBox();
            this.MP3 = new System.Windows.Forms.CheckBox();
            this.MP4 = new System.Windows.Forms.CheckBox();
            this.Custom = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lcOccurrences = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAction
            // 
            this.btAction.Location = new System.Drawing.Point(554, 14);
            this.btAction.Name = "btAction";
            this.btAction.Size = new System.Drawing.Size(75, 23);
            this.btAction.TabIndex = 0;
            this.btAction.Text = "GO";
            this.btAction.UseVisualStyleBackColor = true;
            this.btAction.Click += new System.EventHandler(this.btAction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lines:";
            // 
            // lcLines
            // 
            this.lcLines.AutoSize = true;
            this.lcLines.Location = new System.Drawing.Point(62, 458);
            this.lcLines.Name = "lcLines";
            this.lcLines.Size = new System.Drawing.Size(10, 13);
            this.lcLines.TabIndex = 3;
            this.lcLines.Text = "-";
            // 
            // rtbResult
            // 
            this.rtbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResult.Location = new System.Drawing.Point(12, 65);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(616, 382);
            this.rtbResult.TabIndex = 4;
            this.rtbResult.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PATH
            // 
            this.PATH.Location = new System.Drawing.Point(94, 17);
            this.PATH.Name = "PATH";
            this.PATH.Size = new System.Drawing.Size(454, 20);
            this.PATH.TabIndex = 6;
            this.PATH.Text = "c:\\windows\\temp\\enem.html";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Path:";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(13, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "Choose HTML File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Protocol";
            // 
            // HTTP
            // 
            this.HTTP.AutoSize = true;
            this.HTTP.Checked = true;
            this.HTTP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HTTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HTTP.Location = new System.Drawing.Point(143, 46);
            this.HTTP.Name = "HTTP";
            this.HTTP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HTTP.Size = new System.Drawing.Size(55, 17);
            this.HTTP.TabIndex = 10;
            this.HTTP.Text = "HTTP";
            this.HTTP.UseVisualStyleBackColor = true;
            // 
            // HTTPS
            // 
            this.HTTPS.AutoSize = true;
            this.HTTPS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HTTPS.Location = new System.Drawing.Point(204, 46);
            this.HTTPS.Name = "HTTPS";
            this.HTTPS.Size = new System.Drawing.Size(62, 17);
            this.HTTPS.TabIndex = 11;
            this.HTTPS.Text = "HTTPS";
            this.HTTPS.UseVisualStyleBackColor = true;
            // 
            // PDF
            // 
            this.PDF.AutoSize = true;
            this.PDF.Checked = true;
            this.PDF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PDF.Location = new System.Drawing.Point(326, 45);
            this.PDF.Name = "PDF";
            this.PDF.Size = new System.Drawing.Size(47, 17);
            this.PDF.TabIndex = 12;
            this.PDF.Text = "PDF";
            this.PDF.UseVisualStyleBackColor = true;
            // 
            // MP3
            // 
            this.MP3.AutoSize = true;
            this.MP3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MP3.Location = new System.Drawing.Point(379, 45);
            this.MP3.Name = "MP3";
            this.MP3.Size = new System.Drawing.Size(48, 17);
            this.MP3.TabIndex = 13;
            this.MP3.Text = "MP3";
            this.MP3.UseVisualStyleBackColor = true;
            // 
            // MP4
            // 
            this.MP4.AutoSize = true;
            this.MP4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MP4.Location = new System.Drawing.Point(433, 45);
            this.MP4.Name = "MP4";
            this.MP4.Size = new System.Drawing.Size(48, 17);
            this.MP4.TabIndex = 14;
            this.MP4.Text = "MP4";
            this.MP4.UseVisualStyleBackColor = true;
            // 
            // Custom
            // 
            this.Custom.AutoSize = true;
            this.Custom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Custom.Location = new System.Drawing.Point(487, 45);
            this.Custom.Name = "Custom";
            this.Custom.Size = new System.Drawing.Size(61, 17);
            this.Custom.TabIndex = 15;
            this.Custom.Text = "Custom";
            this.Custom.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Extension";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(544, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 20);
            this.textBox2.TabIndex = 18;
            // 
            // lcOccurrences
            // 
            this.lcOccurrences.AutoSize = true;
            this.lcOccurrences.Location = new System.Drawing.Point(113, 458);
            this.lcOccurrences.Name = "lcOccurrences";
            this.lcOccurrences.Size = new System.Drawing.Size(10, 13);
            this.lcOccurrences.TabIndex = 19;
            this.lcOccurrences.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 488);
            this.Controls.Add(this.lcOccurrences);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Custom);
            this.Controls.Add(this.MP4);
            this.Controls.Add(this.MP3);
            this.Controls.Add(this.PDF);
            this.Controls.Add(this.HTTPS);
            this.Controls.Add(this.HTTP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PATH);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.lcLines);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAction);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lcLines;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PATH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox HTTP;
        private System.Windows.Forms.CheckBox HTTPS;
        private System.Windows.Forms.CheckBox PDF;
        private System.Windows.Forms.CheckBox MP3;
        private System.Windows.Forms.CheckBox MP4;
        private System.Windows.Forms.CheckBox Custom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lcOccurrences;
    }
}

