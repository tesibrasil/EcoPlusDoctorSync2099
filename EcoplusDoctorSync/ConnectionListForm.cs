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
    public partial class ConnectionListForm : Form
    {
        public ConnectionListForm()
        {
            InitializeComponent();
            LoadJson();
        }

        public Root connectionsList;

        public Root selectedConnetions;

        private void LoadJson()
        {

            connectionsList = new Root();
            connectionsList.Conexoes = new List<Conexao>();
            connectionsList = ConfigurationHelper.ReadValue();

            if (connectionsList.Conexoes != null)
            {
                foreach (var conn in connectionsList.Conexoes)
                {

                    clbConexoes.Items.Add(conn.Apelido);
                }
            }

            clbConexoes.Refresh();

        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            selectedConnetions = new Root();
            selectedConnetions.Conexoes = new List<Conexao>();


            for (int i = 0; i < clbConexoes.Items.Count; i++)
            {
                // Verificar se o item está marcado
                if (clbConexoes.GetItemChecked(i))
                {

                    Conexao conexao = connectionsList.Conexoes.FirstOrDefault(con => con.Apelido == clbConexoes.Items[i].ToString());
                    selectedConnetions.Conexoes.Add(conexao);
                }
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMarcarTodos_CheckedChanged(object sender, EventArgs e)
        {
            if(cbMarcarTodos.Checked)
            {
                for (int i = 0; i < clbConexoes.Items.Count; i++)
                {
                    clbConexoes.SetItemChecked(i, true);

                }
            }
            else 
            {
                for (int i = 0; i < clbConexoes.Items.Count; i++)
                {
                    clbConexoes.SetItemChecked(i, false);

                }
            }
        }
    }
}
