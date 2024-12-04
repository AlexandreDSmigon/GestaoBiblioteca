using GestaoBiblioteca.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoBiblioteca
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            // A janela deverá surgir no centro do ecrã e maximizada
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();

            // Nome da aplicação
            this.Text = $"Principal - {Definicoes.NomeAplicacao}";

            LabelTituloAplicacao.Text = Definicoes.NomeAplicacao;

            // Posicionar controlos
            LabelTituloAplicacao.Left = (this.ClientRectangle.Width / 2) - (LabelTituloAplicacao.Width / 2);
            LabelSubtituloAplicacao.Left = (this.ClientRectangle.Width / 2) - (LabelSubtituloAplicacao.Width / 2);

            this.ResumeLayout(false);
        }

        /// <summary>
        /// Terminar a aplicação.
        /// </summary>
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        /// <summary>
        /// Mostrar informações acerca desta aplicação.
        /// </summary>
        private void acercaDaAplicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAcercaAplicacao frmAcerca = new FormAcercaAplicacao();
            frmAcerca.ShowDialog();
            frmAcerca.Dispose();
        }

        private void BotaoUtilizadores_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Gestão de utilizadores.
            /// </summary>
            private void BotaoUtilizadores_Click(object sender, EventArgs e)
            {
                FormUtilizadores frmUtilizadores = new FormUtilizadores();
                frmUtilizadores.ShowDialog();
                frmUtilizadores.Dispose();
            }
        }
    }
}
