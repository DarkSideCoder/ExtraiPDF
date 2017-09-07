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
        String htmlFile = @"c:\windows\temp\enem.html";        
        String HTTP = "http://";
        String HTTPS = "*https://";
        String HREF = "href=";
        String PDF = ".pdf";
        String MP3 = "*.mp3";
        String MP4 = "*.mp4";
        String Custom = textBox2.text;    
      


        public Form1()
        {
            InitializeComponent();
        }
        #region Botões
        private void btAction_Click(object sender, EventArgs e)
        {
            SearchPDF();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }
        #endregion
        #region Funções
        public void SearchPDF()
        {
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
                if (line.Contains(HTTP) && line.Contains(PDF) && line.Contains(HREF)) //verificando se a linha contem o http
                {
                    #region Primeira Verificação
                    result1 = line;
                    stLine = line.IndexOf(HREF);                                     
                    result1 = line.Substring(stLine);
                    l2Line = line.IndexOf(PDF);
                    fiLine = l2Line + 4;
                    szLine = fiLine - stLine;
                    result1 = line.Substring(stLine, szLine);
                    #endregion

                    #region Segunda Verificação
                    result2 = result1;                  
                    stLine = result1.LastIndexOf(HREF);
                    result2 = result1.Substring(stLine);
                    l2Line = result1.IndexOf(PDF);
                    fiLine = l2Line + 4;
                    szLine = fiLine - stLine;
                    result2 = result1.Substring(stLine, szLine);
                    #endregion

                    #region Resultado
                    line = result2;
                    rtbResult.AppendText(cLine+" | "+line);                   
                    rtbResult.AppendText("\n");
                    #endregion

        public void SearchMP3()
        {
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
                if (line.Contains(HTTP) && line.Contains(MP3) && line.Contains(HREF)) //verificando se a linha contem o http
                {
                    #region Primeira Verificação
                    result1 = line;
                    stLine = line.IndexOf(HREF);
                    result1 = line.Substring(stLine);
                    l2Line = line.IndexOf(MP3);
                    fiLine = l2Line + 4;
                    szLine = fiLine - stLine;
                    result1 = line.Substring(stLine, szLine);
                    #endregion

                    #region Segunda Verificação
                    result2 = result1;
                    stLine = result1.LastIndexOf(HREF);
                    result2 = result1.Substring(stLine);
                    l2Line = result1.IndexOf(MP3);
                    fiLine = l2Line + 4;
                    szLine = fiLine - stLine;
                    result2 = result1.Substring(stLine, szLine);
                    #endregion

                    #region Resultado
                    line = result2;
                    rtbResult.AppendText(cLine + " | " + line);
                    rtbResult.AppendText("\n");
                    #endregion
                }
                 public void SearcMP4()
        {
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
                if (line.Contains(HTTP) && line.Contains(MP4) && line.Contains(HREF)) //verificando se a linha contem o http
                {
                    #region Primeira Verificação
                    result1 = line;
                    stLine = line.IndexOf(HREF);
                    result1 = line.Substring(stLine);
                    l2Line = line.IndexOf(MP4);
                    fiLine = l2Line + 4;
                    szLine = fiLine - stLine;
                    result1 = line.Substring(stLine, szLine);
                    #endregion

                    #region Segunda Verificação
                    result2 = result1;
                    stLine = result1.LastIndexOf(HREF);
                    result2 = result1.Substring(stLine);
                    l2Line = result1.IndexOf(MP4);
                    fiLine = l2Line + 4;
                    szLine = fiLine - stLine;
                    result2 = result1.Substring(stLine, szLine);
                    #endregion

                    #region Resultado
                    line = result2;
                    rtbResult.AppendText(cLine + " | " + line);
                    rtbResult.AppendText("\n");
                    #endregion
                }
                 public void SearchCustom()
        {
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
                if (line.Contains(HTTP) && line.Contains(Custom) && line.Contains(HREF)) //verificando se a linha contem o http
                {
                    #region Primeira Verificação
                    result1 = line;
                    stLine = line.IndexOf(HREF);
                    result1 = line.Substring(stLine);
                    l2Line = line.IndexOf(Custom);
                    fiLine = l2Line + 4;
                    szLine = fiLine - stLine;
                    result1 = line.Substring(stLine, szLine);
                    #endregion

                    #region Segunda Verificação
                    result2 = result1;
                    stLine = result1.LastIndexOf(HREF);
                    result2 = result1.Substring(stLine);
                    l2Line = result1.IndexOf(Custom);
                    fiLine = l2Line + 4;
                    szLine = fiLine - stLine;
                    result2 = result1.Substring(stLine, szLine);
                    #endregion

                    #region Resultado
                    line = result2;
                    rtbResult.AppendText(cLine + " | " + line);
                    rtbResult.AppendText("\n");
                    #endregion
                }
                 

                #endregion
            }
            #endregion

            lcLines.Text = Convert.ToString(cLine);
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
            ofd.ShowDialog();

        }
        public void Checks()
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Checked";
            }
            else
            {
                checkBox1.Text = "Unchecked";
            }
            if (checkBox2.Checked)
            {
                checkBox2.Text = "Checked";
            }
            else
            {
                checkBox2.Text = "Unchecked";
            }
            if (checkBox3.Checked)
            {
                checkBox3.Text = "Checked";
            }
            else
            {
                checkBox3.Text = "Unchecked";
            }
            if (checkBox4.Checked)
            {
                checkBox4.Text = "Checked";
            }
            else
            {
                checkBox4.Text = "Unchecked";
            }
            if (checkBox5.Checked)
            {
                checkBox5.Text = "Checked";
            }
            else
            {
                checkBox5.Text = "Unchecked";
            }
            if (checkBox6.Checked)
            {
                checkBox6.Text = "Checked";
            }
            else
            {
                checkBox6.Text = "Unchecked";
            }

        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            Open();
        }
    }
}
