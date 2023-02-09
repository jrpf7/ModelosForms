using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace OrdemDeProducao.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CarregaTela();
        }

        #region Eventos

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    MsgAlerta("Campo usuário vazio!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    MsgAlerta("Campo senha vazio!");
                    return;
                }

                ModoAguarde();

                if (true)
                {
                    //LoginValido
                }
                else
                {
                    //LoginInvalido
                }
            }
            catch (Exception erro)
            {
                MsgErro(erro.Message);
            }
            finally
            {
                ModoAguarde(false);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            try
            {
                pnlUsuario.BackColor = Color.DarkSlateGray;

                if (txtUsuario.Text.Equals("USUÁRIO"))
                    txtUsuario.Clear();
            }
            catch (Exception erro)
            {
                MsgErro(erro.Message);
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            try
            {
                txtSenha.PasswordChar = '•';
                pnlSenha.BackColor = Color.DarkSlateGray;

                if (txtSenha.Text.Equals("SENHA"))
                    txtSenha.Clear();
            }
            catch (Exception erro)
            {
                MsgErro(erro.Message);
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    txtSenha.PasswordChar = '\0';
                    txtSenha.Text = "SENHA";
                }

                pnlSenha.BackColor = Color.White;
            }
            catch (Exception erro)
            {
                MsgErro(erro.Message);
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                    txtUsuario.Text = "USUÁRIO";

                pnlUsuario.BackColor = Color.White;
            }
            catch (Exception erro)
            {
                MsgErro(erro.Message);
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((Keys)e.KeyChar == Keys.Enter)
                    btnLogin_Click(null, null);
            }
            catch (Exception erro)
            {
                MsgErro(erro.Message);
            }
        }

        #endregion Eventos

        #region Métodos

        private void ModoAguarde(bool ativo = true)
        {
            try
            {
                Cursor.Current = ativo ? Cursors.WaitCursor : Cursors.Default;

                txtUsuario.Enabled =
                txtSenha.Enabled =
                btnLogin.Enabled =
                btnSair.Enabled = !ativo;
            }
            catch (Exception erro)
            {
                MsgErro(erro.Message);
            }
        }

        private static void CentralizaControl(int tamanhoForm, Control control)
        {
            try
            {
                control.Left = (tamanhoForm - control.Width) / 2;
            }
            catch (Exception erro)
            {
                MsgErro(erro.Message);
            }
        }

        private void CarregaTela()
        {
            try
            {
                lblVersao.Text += Assembly.GetExecutingAssembly().GetName().Version.ToString();

                CentralizaControl(ClientSize.Width, pbxLogo);
                CentralizaControl(ClientSize.Width, pnlUsuario);
                CentralizaControl(ClientSize.Width, pnlSenha);
                CentralizaControl(ClientSize.Width, btnLogin);
                CentralizaControl(ClientSize.Width, btnSair);
                CentralizaControl(ClientSize.Width, lblVersao);
            }
            catch (Exception erro)
            {
                MsgErro(erro.Message);
            }
        }

        public static void MsgErro(string msg)
        {
            MessageBox.Show(msg, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MsgAlerta(string msg)
        {
            MessageBox.Show(msg, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        #endregion Métodos
    }
}
