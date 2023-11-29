using EcoplusDoctorSync.Helpers;
using EcoplusDoctorSync.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoplusDoctorSync
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private List<Usuario> usuarios;

        private void MainForm_Load(object sender, EventArgs e)
        {
            usuarios = new List<Usuario>();
            usuarios = UserHelper.GetUsuarios();
            lblMensagem.Text = string.Empty;

        }

        private bool Validacao() 
        { 
            bool validacao = false;

            if(string.IsNullOrEmpty(txtUsuario.Text.Trim()) || string.IsNullOrEmpty(txtSenha.Text.Trim())) 
            {
                lblMensagem.Text = "POR FAVOR PREENCHA TODOS OS CAMPOS";
            }
            else 
            { 
                validacao = true;
            }
            return validacao;
        }

        private Usuario Autenticacao() 
        {
            string user = txtUsuario.Text.Trim();
            string pass = txtSenha.Text.Trim();

            Usuario atualUsuario = usuarios.FirstOrDefault(u => u.UserName.Equals(user) && u.Password.Equals(pass));
                
            return atualUsuario;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Entrar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Entrar() 
        {
            if (!Validacao())
                return;

            Usuario atualUsuario = Autenticacao();

            if (atualUsuario != null)
            {
                TheSync.UsuarioLogado = new Usuario { Id = atualUsuario.Id, UserName = atualUsuario.UserName, Admin = atualUsuario.Admin };
                TheSync.ObterNomeDoUsuarioWin();
                TheSync.ObterNomeDaMaquina();
                TheSync.ObterVersaoDoSistema();


                this.Hide();
                MainForm fomulario = new MainForm();
                fomulario.ShowDialog();

                this.Close();
            }
            else
            {
                lblMensagem.Text = "USUÁRIO E/OU SENHA INCORRETOS.";
            }

        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Entrar();
            }
        }
    }
}
