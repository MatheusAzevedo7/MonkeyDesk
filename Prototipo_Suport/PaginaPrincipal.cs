using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_Suport
{
    public partial class telaPrincipal : Form
    {
        public telaPrincipal()
        {
            InitializeComponent();
        }

        private void btnNovoChamado_Click(object sender, EventArgs e)
        {
            TelaDeChamadocs telaDeChamadocs = new TelaDeChamadocs();
            telaDeChamadocs.Show();
            this.Hide();
            
        }
    }
}
