using EcoplusDoctorSync.Helpers;
using EcoplusDoctorSync.Models;
using Newtonsoft.Json;
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

namespace EcoplusDoctorSync
{
    public partial class ConectionForm : Form
    {
        public ConectionForm()
        {
            InitializeComponent();

            conectionsList = new Root();
            conectionsList.Conexoes = new List<Conexao>();
            LoadJson();

        }

        public Root conectionsList; 

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (lvConexoes.SelectedItems.Count != 0)
            {
                string apelido = lvConexoes.SelectedItems[0].SubItems[0].Text;
                int index = lvConexoes.SelectedItems[0].Index;
                conectionsList.Conexoes.RemoveAll(c => c.Apelido == apelido);
                lvConexoes.Items.RemoveAt(index);
            }

            Conexao conexao = new Conexao
            {
                Apelido = txtApelido.Text,
                Servidor = txtServidor.Text,
                Base = txtBancoDeDados.Text,
                Usuario = txtUsuario.Text,
                Senha = txtSenha.Text
            };

            conectionsList.Conexoes.Add(conexao);
            ListViewItem novoItem = new ListViewItem(new[] { conexao.Apelido, conexao.GetStringDeConexao() });

            lvConexoes.Items.Add(novoItem);

            lvConexoes.Refresh();

            Limpar();
        }

        private void LoadJson() 
        {

            conectionsList = ConfigurationHelper.ReadValue();

            foreach (var conn in conectionsList.Conexoes)
            {
                ListViewItem novoItem = new ListViewItem(new[] { conn.Apelido, conn.GetStringDeConexao() });
                lvConexoes.Items.Add(novoItem);

            }

            lvConexoes.Refresh();

        }

        private void CloseForm()
        {
            ConfigurationHelper.WriteJsonFile(conectionsList);
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void lvConexoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvConexoes.SelectedItems.Count > 0)
            {
                // Obter o texto da primeira coluna (índice 0) do item selecionado
                string textoDaPrimeiraColuna = lvConexoes.SelectedItems[0].SubItems[0].Text;
                Popularform(textoDaPrimeiraColuna);
            }
        }

        private void Popularform(string conexaoSelecionada) 
        {

            Conexao conexao = conectionsList.Conexoes.FirstOrDefault(con => con.Apelido == conexaoSelecionada);

            if (conexao != null) 
            { 
            
                    txtApelido.Text = conexao.Apelido;
                    txtServidor.Text = conexao.Servidor;
                    txtUsuario.Text = conexao.Usuario;
                    txtSenha.Text = conexao.Senha;
                    txtBancoDeDados.Text = conexao.Base;
                    txtStringConexao.Text = conexao.GetStringDeConexao();
            }

        }

        private void Limpar() 
        {

            txtApelido.Text = string.Empty;
            txtServidor.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtBancoDeDados.Text = string.Empty;
            txtStringConexao.Text = string.Empty;

            if (lvConexoes.SelectedItems.Count > 0)
            {
                // Desselecionar a linha selecionada
                lvConexoes.SelectedItems.Clear();
            }

        }


    }
}
