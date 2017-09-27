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
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }
        #endregion
        #region Funções
        public void Search(String EXT, String TYPE)
        {
            if(htmlFile == null)
            {
                htmlFile = @"c:\windows\temp\enem.html";
            }
            String HREF = "href=";
            #region Variaveis
            String content;
            String line;
            String result1;
            String result2;
            int cLine = 0;
            int stLine = 0;
            int fiLine = 0;
            int szLine = 0;
            int l2Line = 0;
            StreamReader str = new StreamReader(htmlFile);
            #endregion
            #region Leitura do HTML
            while ((content = str.ReadLine()) != null)
            {
                cLine++; //contando as linhas
                line = content; //recebendo o conteudo do html linha a linha
                #region Contem / Não Contem
                if (line.Contains(TYPE) && line.Contains(EXT) && line.Contains(HREF)) //verificando se a linha contem o http
                {
                    #region Primeira Verificação
                    result1 = line;
                    stLine = line.IndexOf(TYPE);
                    result1 = line.Substring(stLine);
                    l2Line = line.IndexOf(EXT);
                    fiLine = l2Line + EXT.Length;
                    szLine = fiLine - stLine;
                    result1 = line.Substring(stLine, szLine);
                    #endregion


                    #region Segunda Verificação
                    result2 = result1;
                    stLine = result1.LastIndexOf(HREF);                 
                    result2 = result1.Substring(stLine);
                    l2Line = result1.IndexOf(EXT);
                    fiLine = l2Line + EXT.Length;
                    szLine = fiLine - stLine;
                    result2 = result1.Substring(stLine, szLine);
                    #endregion
                  

                    #region Resultado
                    line = result2;
                    rtbResult.AppendText(cLine + " | " + line);
                    rtbResult.AppendText("\n");
                    #endregion

                }

                lcLines.Text = Convert.ToString(cLine);
            }
        }
        #endregion
        #endregion
        #region Funções2
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
            #endregion
        }
    }
}
