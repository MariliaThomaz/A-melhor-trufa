using A_MELHOR_TRUFA.Domain.Constantes.Global;
using A_MELHOR_TRUFA.Fomularios.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_MELHOR_TRUFA.Fomularios
{
    public partial class frmLogin : Form
    {

        #region ..:: Construtores ::..

        public frmLogin()
        {
            InitializeComponent();
        }

        #endregion

        #region ..:: Métodos ::..

        private void CarregarCredenciais()
        {
            txtUsuario.Text = Properties.Settings.Default.Usuario;
            txtSenha.Text = Properties.Settings.Default.Senha;
            ckLembrarMe.Checked = Properties.Settings.Default.LembrarMe;
        }

        private bool PodeLogar()
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Informe seu usuário!", SistemaConstantes.NomeSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Informe sua senha!", SistemaConstantes.NomeSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return false;
            }

            return true;
        }

        private void Logar()
        {
            if (!PodeLogar()) return;

            SalvarSenha();

            new frmDashboard().ShowDialog();
        }

        private void PerformarEventoKeyPress(ref KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!PodeLogar()) return;

                btnAcessar.PerformClick();
            }
        }

        private bool PodeSalvarSenha()
        {
            return ckLembrarMe.Checked;
        }

        private void SalvarSenha()
        {
            if (!PodeSalvarSenha()) return;

            Properties.Settings.Default.Usuario = txtUsuario.Text;
            Properties.Settings.Default.Senha = txtSenha.Text;
            Properties.Settings.Default.LembrarMe = ckLembrarMe.Checked;

            Properties.Settings.Default.Save();
        }

        #endregion

        #region ..:: Eventos ::..

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            PerformarEventoKeyPress(ref e);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            CarregarCredenciais();
        }

        #endregion
    }
}
