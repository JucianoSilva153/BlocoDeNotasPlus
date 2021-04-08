using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BlocoDeNotasPLUS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barraDeStatus_ss_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ocultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (barraDeStatus_ss.Visible == true)
            {
                pagina_rtb.Width = 673;
                pagina_rtb.Height = 366;
                barraDeStatus_ss.Visible = false;
            }

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (barraDeStatus_ss.Visible == false)
            {
                pagina_rtb.Width = 673;
                pagina_rtb.Height = 341;
                barraDeStatus_ss.Visible = true;
            }
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fonte_fdl.ShowDialog();
            pagina_rtb.SelectionFont = fonte_fdl.Font;
        }

        private void corDeFonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cor_cdl.ShowDialog();
            pagina_rtb.SelectionColor = Cor_cdl.Color;
        }

        private void corDePáginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cor_cdl.ShowDialog();
            pagina_rtb.BackColor = Cor_cdl.Color;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            abrirFicheiro_ofd.ShowDialog();
            string path = abrirFicheiro_ofd.FileName;
            nomeDocumento_lbl.Text = abrirFicheiro_ofd.SafeFileName;
            this.Text = "Bloco de Notas PLUS - " + abrirFicheiro_ofd.SafeFileName;

            if (path != "")
            {
                StreamReader Leitor = new StreamReader(path);
                pagina_rtb.Text = Leitor.ReadToEnd();
                Leitor.Close();
            }





        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            salvarFicheiro_sfd.ShowDialog();
            string path = salvarFicheiro_sfd.FileName;

            if (path != "")
            {
                StreamWriter Salvar = new StreamWriter(path);
                Salvar.Write(pagina_rtb.Text);
                Salvar.Close();

                // C:/Users/Juciano Silva/Documents/texto.txt
                // \\ = / 

                nomeDocumento_lbl.Text = salvarFicheiro_sfd.FileName;
                char[] nome = nomeDocumento_lbl.Text.ToCharArray();
                int count = 0;

                for (int i = nome.Length - 1; i != 0; i--)
                {
                    if (nome[i] == '\\')
                    {
                        nomeDocumento_lbl.Text = nomeDocumento_lbl.Text.Substring(i + 1, count);
                        this.Text = "Bloco de Notas PLUS - " + nomeDocumento_lbl.Text;
                        break;
                    }

                    count++;
                }

            }


        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreOBlocoDeNotasPLUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sobre = new sobre_frm();
            sobre.Show();
        }

        private void abrirFicheiro_ofd_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
