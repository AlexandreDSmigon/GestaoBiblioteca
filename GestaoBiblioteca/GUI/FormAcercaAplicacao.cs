using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoBiblioteca.GUI
{
    public partial class FormAcercaAplicacao : Form
    {
        public FormAcercaAplicacao()
        {
            InitializeComponent();

            // A janela deverá surgir no centro do ecrã
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormAcercaAplicacao_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.AcceptButton = BotaoOk;
            this.Text = "Acerca desta aplicação";

            LabelNomeAplicacao.Text = Definicoes.NomeAplicacao;
            LabelVersao.Text = "v0.1";
            LabelCopyright.Text = "© 2024 João Martiniano";
            LinkRepositorio.Text = "https://github.com/joaomartiniano/bibliotex";

            this.ResumeLayout(false);
        }

        /// <summary>
        /// Fechar a janela.
        /// </summary>
        private void BotaoOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Abrir a hiperligação
        /// </summary>
        private void LinkRepositorio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Especificar que a hiperligação foi visitada
            LinkRepositorio.LinkVisited = true;

            // Abrir a hiperligação
            System.Diagnostics.Process.Start(LinkRepositorio.Text);
        }
    }
}
