using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtraiPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Variables   
        String htmlFile = null; 
        String HREF = "href=";        
        #endregion
        #region Botões
        private void button2_Click(object sender, EventArgs e)
        {
            Open();
        }//BT Choose html File
        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }//BT Clear
        private void btAction_Click(object sender, EventArgs e)
        {
            String HTTPS = "*https://";
            String HTTP = "http://";
            String PDF = ".pdf";
            String MP3 = "*.mp3";
            String MP4 = "*.mp4";
            String CST = textBox2.Text;            
            if (this.PDF.Checked)
            {
                if (this.HTTP.Checked)
                {
                    SearchinWorking(PDF, HTTP);
                }
                if (this.HTTPS.Checked)
                {
                    SearchinWorking(PDF, HTTPS);
                }                
            }
            if (this.MP3.Checked)
            {
                if (this.HTTP.Checked)
                {
                    SearchinWorking(MP3, HTTP);
                }
                if (this.HTTPS.Checked)
                {
                    SearchinWorking(MP3, HTTPS);
                }                
            }
            if (this.MP4.Checked)
            {
                if (this.HTTP.Checked)
                {
                    SearchinWorking(MP4, HTTP);
                }
                if (this.HTTPS.Checked)
                {
                    SearchinWorking(MP4, HTTPS);
                }               
            }
            if (Custom.Checked)
            {
                if (CST.Contains("."))
                {                    
                    CST = CST.Substring(1);
                }
                CST = "." + CST;
                if (this.HTTP.Checked)
                {
                    SearchinWorking(CST, HTTP);
                }
                if (this.HTTPS.Checked)
                {
                    SearchinWorking(CST, HTTPS);
                }                                                                   
          }
        }// BT GO
        #endregion
        #region Funções
        public void Search(String EXT, String TYPE)
        {
            if (htmlFile == null)
            {
                htmlFile = @"c:\windows\temp\enem.html";
            }
            #region Variaveis
            String HREF = "href=";
            int cLine = 0;
            String content;
            String line;
            String lineLink;
            int stsbstring = 0;
            int stLine = 0;
            int fiLine = 0;
            int szLine = 0;
            int szstring = 0;            
            StreamReader str = new StreamReader(htmlFile);
            #endregion

            #region Leitura do HTML 

            while ((content = str.ReadLine()) != null)
            {
                cLine++;
                line = content;
                while (line.Contains(TYPE) && line.Contains(EXT))
                {
                    #region Contem / Não Contem
                    if (line.Contains(TYPE) && line.Contains(EXT) && line.Contains(HREF))
                    {
                        szLine = line.Length;
                        String cabecalho = (HREF + "\"" + TYPE);
                        stLine = line.IndexOf(cabecalho) + HREF.Length + 1;
                        szstring = (szLine) - (stLine + 4);
                        lineLink = line.Substring(stLine, szstring);
                        szLine = lineLink.Length;
                        fiLine = lineLink.IndexOf(EXT);
                        fiLine = fiLine + EXT.Length;
                        lineLink = lineLink.Substring(0, fiLine);
                        stsbstring = line.IndexOf(EXT);
                        rtbResult.AppendText(cLine + " | " + lineLink);
                        rtbResult.AppendText("\n");
                    }
                    #endregion
                }
                line = line.Substring(stsbstring + EXT.Length);
            }
            lcLines.Text = Convert.ToString(cLine);
            #endregion            
        }
        public void SearchinWorking(String EXT, String TYPE)
        {
            htmlFile = PATH.Text;
            if (!htmlFile.ToUpper().Contains("HTML") || !htmlFile.ToUpper().Contains("HTM"))
            {
                MessageBox.Show("Favor informar o caminho do arquivo HTML\nValor não pode ser em branco");
            }
            else
            {
                String content;
                String line;
                String lineLink;
                int countLine = 0;
                int startLine = 0;
                int finishLine = 0;
                int sizeLine = 0;
                int sizeString = 0;
                int startSubstring = 0;
                String tempContent = "";
                int countOccurrence = 0;

                StreamReader str = new StreamReader(htmlFile);
                while ((content = str.ReadLine()) != null)
                {
                    countLine++;
                    line = content;
                    while (line.Contains(TYPE) && line.Contains(EXT))
                    {

                        if (line.Contains(TYPE) && line.Contains(EXT) && line.Contains(HREF))
                        {

                            sizeLine = line.Length; 
                            String cabecalho = (HREF + "\"" + TYPE);
                            startLine = line.IndexOf(cabecalho) + HREF.Length + 1;
                            sizeString = (sizeLine) - (startLine + 4);
                            lineLink = line.Substring(startLine, sizeString); 
                            sizeLine = lineLink.Length; 
                            finishLine = lineLink.IndexOf(EXT);
                            finishLine = finishLine + EXT.Length;
                            lineLink = lineLink.Substring(0, finishLine);
                            startSubstring = line.IndexOf(EXT);

                            for (int i = 0; i < lineLink.Length; i++)
                            {
                                tempContent = tempContent + lineLink[i];
                                if (tempContent.Contains(TYPE) && tempContent.Contains("\">"))
                                {
                                    int posNaoPDF = lineLink.IndexOf("\">");
                                    lineLink = lineLink.Substring(posNaoPDF + 2);
                                    tempContent = "";
                                    break;
                                }

                                if (tempContent.Contains(TYPE) && !tempContent.Contains("\">") && tempContent.Contains(EXT))
                                {
                                    try
                                    {
                                        rtbResult.AppendText(countLine + " |"+ EXT.Substring(1) +"| " + tempContent);
                                        rtbResult.AppendText("\n");
                                        tempContent = "";
                                        countOccurrence++;
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.ToString());
                                    }
                                }
                            }
                        }
                        line = line.Substring(startSubstring + EXT.Length);
                    }
                }
                lcLines.Text = Convert.ToString(countLine);
                lcOccurrences.Text = Convert.ToString(countOccurrence);
            }
        }
        public void Clear()
        {
            rtbResult.Text = " ";
        }
        public void Open()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Title = "Selecionar Arquivo";
            ofd.InitialDirectory = @"c:\windows\temp";
            ofd.Filter = "HTML|*.html";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;
            ofd.ReadOnlyChecked = true;
            ofd.ShowReadOnly = true;
            DialogResult dr = ofd.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String arquivo in ofd.FileNames)
                {
                    htmlFile = arquivo;
                    PATH.Text = arquivo;
                }
            }            
        }
        #endregion        
    }
}