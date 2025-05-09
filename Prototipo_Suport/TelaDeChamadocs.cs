using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_Suport
{
    public partial class TelaDeChamadocs : Form
    {
        public TelaDeChamadocs()
        {
            InitializeComponent();
        }

        private void TelaDeChamadocs_Load(object sender, EventArgs e)
        {
            //AbrirTelaChamadocs();
        }
        private void AbrirTelaChamadocs() // ou em um botão, por exemplo
        {
            TelaDeChamadocs chamadocs = new TelaDeChamadocs();

            // Esconde a tela principal
            this.Hide();

            // Quando a tela de chamados for fechada, reexibe a principal
            chamadocs.FormClosed += (s, args) => this.Show();

            // Exibe a tela de chamados
            chamadocs.Show();
        }

    }
}
