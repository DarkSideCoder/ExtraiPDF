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
        String htmlFile = null;
        #region Botões
        private void button2_Click(object sender, EventArgs e)
        {
            Open();
        }
        private void btAction_Click(object sender, EventArgs e)
        {
            String HTTP = "http://";
            String HTTPS = "*https://";
            String PDF = ".pdf";
            String MP3 = "*.mp3";
            String MP4 = "*.mp4";
            String CST = textBox2.Text;
            CST = CST.ToLower();
            CST = "." + CST;
            #region Checks
            #region PDF
            if (this.PDF.Checked)
            {
                if (this.HTTP.Checked)
                {
                    Search(PDF, HTTP);
                }
                if (this.HTTPS.Checked)
                {
                    Search(PDF, HTTPS);
                }
                else
                {
                    Search(PDF, HTTP);
                }
            }
            #endregion
            #region MP3
            if (this.MP3.Checked)
            {
                if (this.HTTP.Checked)
                {
                    Search(MP3, HTTP);
                }
                if (this.HTTPS.Checked)
                {
                    Search(MP3, HTTPS);
                }
                else
                {
                    Search(MP3, HTTP);
                }
            }
            #endregion
            #region MP4
            if (this.MP4.Checked)
            {
                if (this.HTTP.Checked)
                {
                    Search(MP4, HTTP);
                }
                if (this.HTTPS.Checked)
                {
                    Search(MP4, HTTPS);
                }
                else
                {
                    Search(MP4, HTTP);
                }
            }
            #endregion
            #region Custom
            if (Custom.Checked)
            {
                if (this.HTTP.Checked)
                {
                    Search(CST, HTTP);
                }
                if (this.HTTPS.Checked)
                {
                    Search(CST, HTTPS);
                }
                else
                {
                    Search(CST, HTTP);
                }
            }
            #endregion
            #endregion            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }
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
            String TC = "";
            int stsbstring = 0;           
            int stLine = 0;
            int fiLine = 0;
            int szLine = 0;
            int szstring = 0;
            int CO = 0;     
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

                        for (int i = 0; i < lineLink.Length; i++)
                        {
                            TC = TC + lineLink[i];
                            if (TC.Contains(TYPE) && TC.Contains("\">"))
                            {
                                int FSP = lineLink.IndexOf("\">");
                                lineLink = lineLink.Substring(FSP + 2);
                                TC = "";
                                break;
                            }
                            if (TC.Contains(TYPE) && !TC.Contains("\">") && TC.Contains(EXT))
                            {
                                try
                                {
                                    rtbResult.AppendText(cLine + " | " + TC);
                                    rtbResult.AppendText("\n");
                                    TC = "";
                                    CO++;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                }
                            }
                        }
                    }

                    #endregion
                }
                    line = line.Substring(stsbstring + EXT.Length);
            }
            #endregion            
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
        #endregion        
    }
    }
}