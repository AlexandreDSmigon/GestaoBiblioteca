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
    public partial class FormUtilizador : Form
    {
        public FormUtilizador()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Terminar a operação.
        /// </summary>
        private void BotaoOK_Click(object sender, EventArgs e)
        {
            
                this.DialogResult = DialogResult.OK;
                this.Close();
            
        }

        /// <summary>
        /// Cancelar a operação e fechar a janela.
        /// </summary>
        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
           
            
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            
        }
    }
}
