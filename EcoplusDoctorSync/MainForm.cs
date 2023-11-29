using EcoplusDoctorSync.Helpers;
using EcoplusDoctorSync.Models;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace EcoplusDoctorSync
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }


        //Usuario usuarioLogado;
        private void MainForm_Load(object sender, EventArgs e)
        {
            ckbManual.Checked = true;
            ckbManual.Checked = false;

            LogFileHelper.Get().Write($"=================================================", txtLog);
            LogFileHelper.Get().Write($"Aplicação Eco+ DoctorSync 2099 Iniciada: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}", txtLog);
            LogFileHelper.Get().Write($"Versão da Aplicação: {TheSync.Versao}", txtLog);
            LogFileHelper.Get().Write($"Estação Logada: {TheSync.Estacao}", txtLog);
            LogFileHelper.Get().Write($"Usuário do Windows Logado: {TheSync.UsuarioWindows}", txtLog);
            LogFileHelper.Get().Write($"Usuário Sync Logado: {TheSync.UsuarioLogado.UserName}", txtLog);
            LogFileHelper.Get().Write($"=================================================", txtLog);
            LogFileHelper.Get().Write($"\n", txtLog);

            txtUsername.Text = "FLEURY.COM.BR\\MEDICO";
            txtSobrenome.Text = "CIRURGIAO";
            txtNome.Text = "MEDICO";
            txt3l3n.Text = "ZYX654";
            txtTratamento.Text = "Dr.";
            txtCRM.Text = "123456";
            txtAssinatura.Text = "Dr. MEDICO CIRURGIAO - CRM: 123456";

            btnInicializar.Enabled = true;
            btnInicializar.Select();


        }

        private void btnInicializar_Click(object sender, EventArgs e)
        {

            if (!Validacao())
                return;

            Inserir();

        }

        private bool Validacao()
        {
            bool valido = true;

            if (ckbManual.Checked)
            {
                if (string.IsNullOrEmpty(txtUsername.Text.Trim()) || string.IsNullOrEmpty(txtNome.Text.Trim()) || string.IsNullOrEmpty(txtSobrenome.Text.Trim()) || string.IsNullOrEmpty(txtTratamento.Text.Trim()) || string.IsNullOrEmpty(txtCRM.Text.Trim()) || string.IsNullOrEmpty(txt3l3n.Text.Trim()))
                {
                    MessageBox.Show("Por Favor Insira todas as informações obrigatórias", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    valido = false;
                    return valido;
                }
                if (MessageBox.Show("Quer realmente inserir o medico indicado?", "Favor controlar os dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    valido = false;
                    return valido;
                }

            }
            else
            {
                if (txtExcelPath.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("Por Favor Selecione um Arquivo CSV para ser Importado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    valido = false;
                    return valido;
                }
                if (MessageBox.Show("Quer realmente inserir os medicos importados?", "Favor controlar os dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    valido = false;
                    return valido;
                }

            }

            return valido;

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Text = txtUsername.Text.Trim();
            txtUsername.SelectionStart = txtUsername.TextLength;
            btnInicializar.Enabled = ((txtUsername.TextLength > 0) && (txtSobrenome.TextLength > 0) && (txtNome.TextLength > 0) && (txtAssinatura.TextLength > 0));
        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {
            btnInicializar.Enabled = ((txtUsername.TextLength > 0) && (txtSobrenome.TextLength > 0) && (txtNome.TextLength > 0) && (txtAssinatura.TextLength > 0));
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            btnInicializar.Enabled = ((txtUsername.TextLength > 0) && (txtSobrenome.TextLength > 0) && (txtNome.TextLength > 0) && (txtAssinatura.TextLength > 0));
        }

        private void txtAssinatura_TextChanged(object sender, EventArgs e)
        {
            btnInicializar.Enabled = ((txtUsername.TextLength > 0) && (txtSobrenome.TextLength > 0) && (txtNome.TextLength > 0) && (txtAssinatura.TextLength > 0));
        }

        private void txtUO_TextChanged(object sender, EventArgs e)
        {
            btnInicializar.Enabled = ((txtUsername.TextLength > 0) && (txtSobrenome.TextLength > 0) && (txtNome.TextLength > 0) && (txtAssinatura.TextLength > 0));
        }

        private void btnFindXLS_Click(object sender, EventArgs e)
        {
            ofdExcel.ShowDialog();
            txtExcelPath.Text = ofdExcel.SafeFileName;
            btnInicializar.Enabled = true;
        }

        private void btnFindImage_Click(object sender, EventArgs e)
        {
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = ofdImage.FileName;
            }

            picBoxRubrica.ImageLocation = txtImagePath.Text;
            picBoxRubrica.Load();

        }

        private void ckbManual_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbManual.Checked)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
        }

        private void CamposAssinatura_EventLeave(object sender, EventArgs e)
        {
            this.MontaAssinatura();
        }

        private void txtCRM_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !btnFechar.Enabled;
        }


        private void btnConexoes_Click(object sender, EventArgs e)
        {
            ConectionForm formConexao = new ConectionForm();
            formConexao.ShowDialog();
        }



        private void Inserir()
        {

            bool bErrors = false;

            Root selectedConnetions;
            selectedConnetions = new Root();
            selectedConnetions.Conexoes = new List<Conexao>();

            ConnectionListForm formConexao = new ConnectionListForm();
            formConexao.ShowDialog();

            selectedConnetions = formConexao.selectedConnetions;

            if (selectedConnetions == null || selectedConnetions.Conexoes.Count == 0)
            {
                MessageBox.Show("Nenhuma conexão foi selecionada.\nInicie o processo novamente ou configure novas conexões", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Medico> listaMedicosX = new List<Medico>();


            if (ckbManual.Checked)
            {
                Medico medico = new Medico();
                medico.sUserName = txtUsername.Text.Trim();
                medico.sNome = txtNome.Text.Trim();
                medico.sSobrenome = txtSobrenome.Text.Trim();
                medico.s3L3N = txt3l3n.Text.Trim();
                medico.sTratamento = txtTratamento.Text.Trim();
                medico.sCRM = txtCRM.Text.Trim();
                medico.sAssinatura = txtAssinatura.Text.Trim();
                medico.sRubricaB64 = txtImagePath.Text.Trim();

                listaMedicosX.Add(medico);

            }
            else
            {
                listaMedicosX = ImportarMedicosDoCSV(ofdExcel.FileName);

                if (listaMedicosX.Count == 0)
                {
                    MessageBox.Show("Nenhum médico foi importado do arquivo apontado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            //Inicio da importação

            Cursor.Current = Cursors.WaitCursor;
            btnFechar.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            ckbManual.Enabled = false;
            LogFileHelper.Get().Write("\n", txtLog);

            int iMedico = 0;

            try
            {
                foreach (var medico in listaMedicosX)
                {
                    iMedico++;
                    LogFileHelper.Get().Write($"Médico {iMedico} de {listaMedicosX.Count}", txtLog);
                    LogFileHelper.Get().Write("\n", txtLog);


                    LogFileHelper.Get().Write("INICIO     --> " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), txtLog);
                    LogFileHelper.Get().Write("USERNAME   --> " + medico.sUserName, txtLog);
                    LogFileHelper.Get().Write("SOBRENOME  --> " + medico.sSobrenome, txtLog);
                    LogFileHelper.Get().Write("NOME       --> " + medico.sNome, txtLog);
                    LogFileHelper.Get().Write("TRATAMENTO --> " + medico.sTratamento, txtLog);
                    LogFileHelper.Get().Write("CRM        --> " + medico.sCRM, txtLog);
                    LogFileHelper.Get().Write("ASSINATURA --> " + medico.sAssinatura, txtLog);
                    LogFileHelper.Get().Write("3L3N       --> " + medico.s3L3N, txtLog);
                    LogFileHelper.Get().Write("RUBRICA    --> " + medico.sRubricaB64, txtLog);

                    LogFileHelper.Get().Write("\n", txtLog);

                    int iConn = 0;

                    foreach (var conn in selectedConnetions.Conexoes)
                    {

                        iConn++;
                        LogFileHelper.Get().Write($"Servidor {iMedico} de {selectedConnetions.Conexoes.Count}", txtLog);
                        LogFileHelper.Get().Write("\n", txtLog);

                        //Processa todas as mensagens do Windows que está na atual fila de mensagem.
                        Application.DoEvents();


                        //Pega a string de conexão
                        string connStr = conn.GetStringDeConexao();

                        if (TheSync.UsuarioLogado.Admin)
                        {
                            LogFileHelper.Get().Write($"String de Conexão: {connStr}", txtLog);
                            LogFileHelper.Get().Write("\n", txtLog);
                        }

                        using (SqlConnection sqlConn = new SqlConnection(connStr))
                        {

                            LogFileHelper.Get().Write($"Servidor: {conn.Apelido}", txtLog);

                            try
                            {
                                sqlConn.Open();
                            }
                            catch (Exception ex)
                            {
                                LogFileHelper.Get().Write($"Não foi possivel se conectar ao Servidor {conn.Apelido}, devido a {ex.Message}", txtLog);
                                LogFileHelper.Get().Write("\n", txtLog);
                                bErrors = true;
                                continue;
                            }

                            //VERIFICA SE A ESTRUTURA DO BANCO DE DADOS ESTÁ CORRETA
                            bool bdColuna = DataBaseHelper.VerificaColuna(sqlConn);

                            if (bdColuna && TheSync.UsuarioLogado.Admin)
                            {
                                if (MessageBox.Show($"O Banco de Dados do servidor {conn.Apelido} não está com as tabelas adequadas para que a inserção seja executada.\nDeseja fazer as alterações necessárias?", $"Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    DataBaseHelper.ReestruturacaoBD(sqlConn);
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            else if (bdColuna)
                            {
                                MessageBox.Show($"O Banco de Dados do servidor {conn.Apelido} não está com as tabelas adequadas para que a inserção seja executada.\nContate a Tesi Brasil para executar essa ação. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                LogFileHelper.Get().Write($"O Banco de Dados do servidor {conn.Apelido} não está com as tabelas adequadas para que a inserção seja executada. Não foi possível prosseguir com a ação", txtLog);
                                continue;

                            }


                            long iIDUtente = 0;

                            using (SqlCommand cmd = new SqlCommand())
                            {
                                //ETAPA 1 - VERIFICA SE USUÁRIO JÁ EXISTE NO BANCO DE DADOS
                                LogFileHelper.Get().Write($"Etapa 1/12 - VERIFICA SE USUÁRIO JÁ EXISTE NO BANCO DE DADOS\n", txtLog);

                                cmd.Connection = sqlConn;
                                cmd.CommandText = $"SELECT ID FROM UTENTI WHERE USERNAME='{medico.sUserName}' ORDER BY ID";


                                if (TheSync.UsuarioLogado.Admin)
                                {
                                    LogFileHelper.Get().Write(cmd.CommandText, txtLog);
                                    LogFileHelper.Get().Write("\n", txtLog);
                                }

                                object objTemp = cmd.ExecuteScalar();

                                if (objTemp == null)
                                {

                                    //ETAPA 2 - CRIA NOVO USUARIO
                                    LogFileHelper.Get().Write($"Etapa 2/12 - CRIA NOVO USUARIO\n", txtLog);


                                    cmd.CommandText = $"INSERT INTO UTENTI (USERNAME,PASSWORD, ID_GRUPPO, DISABILITATO, SCADENZA_PASSWORD, DATA_PASSWORD, DATA_ULTIMO_UTILIZZO, PRIMO_LOGIN, TIPO_PASSWORD, ELIMINATO, OLD_ROWGUID) " +
                                                          $"VALUES ('{medico.sUserName}',NULL, 22, 0, 0, '{DateTime.Now.ToString("yyyyMMddHHmmss")}', '{DateTime.Now.ToString("yyyyMMddHHmmss")}', 0, 0, 0, NEWID())";

                                    if (TheSync.UsuarioLogado.Admin)
                                    {
                                        LogFileHelper.Get().Write(cmd.CommandText, txtLog);
                                    }

                                    cmd.ExecuteNonQuery();
                                    LogFileHelper.Get().Write("\nCRIACAO DE USUARIO CONCLUIDA\n", txtLog);


                                    //SELECIONA O ID DO USUARIO CRIADO
                                    cmd.CommandText = $"SELECT ID FROM UTENTI WHERE USERNAME='{medico.sUserName}' ORDER BY ID";

                                    if (TheSync.UsuarioLogado.Admin)
                                    {
                                        LogFileHelper.Get().Write(cmd.CommandText, txtLog);
                                        LogFileHelper.Get().Write("\n", txtLog);
                                    }

                                    iIDUtente = Convert.ToInt64(cmd.ExecuteScalar());

                                    //ETAPA 3 - CRIA NOVA LINHA NA TABELA UTENTI_DETTAGLIO
                                    LogFileHelper.Get().Write($"Etapa 3/12 - CRIANDO OS DETALHES DO USUARIO\n", txtLog);


                                    cmd.CommandText = $"INSERT INTO utenti_dettaglio (idutente, cognome, nome, codfisc, codice, titolo, email, specialita, firma1, firma2, immaginefirma, worklist, fmf_id, fmf_nt, fmf_nt_scadenza, fmf_pe, fmf_pe_scadenza, ROWGUID)" +
                                                          $"VALUES ({iIDUtente}, '{medico.sSobrenome}', '{medico.sNome}', {medico.sCRM}, '{medico.s3L3N}','{medico.sTratamento}', '', NULL, '{medico.sAssinatura}', NULL, '', NULL, NULL, 0, NULL, 0, NULL, NEWID())";

                                    if (TheSync.UsuarioLogado.Admin)
                                    {
                                        LogFileHelper.Get().Write(cmd.CommandText, txtLog);
                                    }

                                    cmd.ExecuteScalar();
                                    LogFileHelper.Get().Write("\nINSERCAO DOS DETALHES DO USUARIO CONCLUIDA\n", txtLog);

                                    LogFileHelper.Get().Write($"Etapa 4/12 - NAO NECESSARIA\n", txtLog);
                                    LogFileHelper.Get().Write($"Etapa 5/12 - NAO NECESSARIA\n", txtLog);
                                    LogFileHelper.Get().Write($"Etapa 6/12 - NAO NECESSARIA\n", txtLog);
                                    LogFileHelper.Get().Write($"Etapa 7/12 - NAO NECESSARIA\n", txtLog);

                                }
                                else
                                {
                                    //Fazer update e delete e insert de todas as infos

                                    if (MessageBox.Show($"O médico com o username {medico.sUserName} já existe no banco de dados.\nDeseja sobrescrever as informações?", $"Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                    {
                                        continue;
                                    }


                                    //ETAPA 2 - SELECIONA O ID DO USUARIO EXISTENTE 
                                    LogFileHelper.Get().Write($"Etapa 2/12 - SELECIONA O USUARIO EXISTENTE\n", txtLog);

                                    cmd.CommandText = $"SELECT ID FROM UTENTI WHERE USERNAME='{medico.sUserName}' ORDER BY ID";

                                    if (TheSync.UsuarioLogado.Admin)
                                    {
                                        LogFileHelper.Get().Write(cmd.CommandText, txtLog);
                                        LogFileHelper.Get().Write("\n", txtLog);
                                    }

                                    iIDUtente = Convert.ToInt64(cmd.ExecuteScalar());

                                    LogFileHelper.Get().Write("USUARIO ENCONTRADO\n", txtLog);


                                    //ETAPA 3 - ATUALIZA AS INFORMAÇÕS NA TABELA UTENTI_DETTAGLIO
                                    LogFileHelper.Get().Write($"Etapa 3/12 - ATUALIZA OS DETALHES DO USUARIO\n", txtLog);

                                    cmd.CommandText = $"UPDATE utenti_dettaglio SET cognome = '{medico.sSobrenome}', nome = '{medico.sNome}', codfisc = {medico.sCRM} , codice = '{medico.s3L3N}' , titolo = '{medico.sTratamento}', firma1 = '{medico.sAssinatura}'" +
                                                      $"WHERE idutente = {iIDUtente}";

                                    if (TheSync.UsuarioLogado.Admin)
                                    {
                                        LogFileHelper.Get().Write(cmd.CommandText, txtLog);
                                    }

                                    cmd.ExecuteScalar();
                                    LogFileHelper.Get().Write("\nATUALIZACA ODOS DETALHES DO USUARIO CONCLUIDA\n", txtLog);
                                    //


                                    //ETAPA 4 - LIMPA OS REGISTROS DA TABELA UTENTI_ESAMI
                                    LogFileHelper.Get().Write($"Etapa 4/12 - APAGA CONFIGURAÇÕES DE EXAME DO USUARIO\n", txtLog);

                                    cmd.CommandText = $"DELETE FROM UTENTI_ESAMI " +
                                                      $"WHERE idutente = {iIDUtente}";

                                    if (TheSync.UsuarioLogado.Admin)
                                    {
                                        LogFileHelper.Get().Write(cmd.CommandText, txtLog);
                                    }

                                    cmd.ExecuteScalar();
                                    LogFileHelper.Get().Write("\nDELETE DAS CONFIGURAÇÕES DE EXAME DO USUARIO CONCLUIDA\n", txtLog);
                                    //

                                    //ETAPA 5 - LIMPA OS REGISTROS NA TABELA UTENTI_INTERFACCIA
                                    LogFileHelper.Get().Write($"Etapa 5/12 - APAGA CONFIGURAÇÕES DE INTERFACE DO USUARIO\n", txtLog);

                                    cmd.CommandText = $"DELETE FROM UTENTI_INTERFACCIA " +
                                                      $"WHERE idutente = {iIDUtente}";

                                    if (TheSync.UsuarioLogado.Admin)
                                    {
                                        LogFileHelper.Get().Write(cmd.CommandText, txtLog);
                                    }

                                    cmd.ExecuteScalar();
                                    LogFileHelper.Get().Write("\nDELETE DAS CONFIGURAÇÕES DE INTERFACE DO USUARIO CONCLUIDA\n", txtLog);
                                    //

                                    //ETAPA 6 - LIMPA OS REGISTROS NA TABELA UTENTI_SETTING
                                    LogFileHelper.Get().Write($"Etapa 6/12 - APAGA CONFIGURAÇÕES GERAIS DO USUARIO\n", txtLog);

                                    cmd.CommandText = $"DELETE FROM UTENTI_SETTING " +
                                                      $"WHERE idutente = {iIDUtente}";

                                    if (TheSync.UsuarioLogado.Admin)
                                    {
                                        LogFileHelper.Get().Write(cmd.CommandText, txtLog);
                                    }

                                    cmd.ExecuteScalar();
                                    LogFileHelper.Get().Write("\nDELETE DAS CONFIGURAÇÕES GERAIS DO USUARIO CONCLUIDO\n", txtLog);
                                    //

                                    //ETAPA 7 - LIMPA OS REGISTROS NA TABELA REPORTX_UTENTI
                                    LogFileHelper.Get().Write($"Etapa 7/12 - APAGA CONFIGURAÇÕES DE LAUDO DO USUARIO\n", txtLog);

                                    cmd.CommandText = $"DELETE FROM REPORTEX_UTENTI " +
                                                      $"WHERE IDUTENTE = {iIDUtente}";

                                    if (TheSync.UsuarioLogado.Admin)
                                    {
                                        LogFileHelper.Get().Write(cmd.CommandText, txtLog);
                                    }

                                    cmd.ExecuteScalar();
                                    LogFileHelper.Get().Write("\nDELETE DAS CONFIGURAÇÕES DE LAUDO DO USUARIO CONCLUIDO\n", txtLog);
                                    //
                                }
                                

                                // INSERÇÃO EM TABELAS SECUNDÁRIAS

                                //ETAPA 8 -  INSERE NA TABELA UTENTI_ESAMI
                                LogFileHelper.Get().Write($"Etapa 8/12 - INSERE CONFIGURAÇÕES DE EXAME DO USUARIO\n", txtLog);

                                cmd.CommandText = $"INSERT INTO utenti_esami (idutente, numero, tipo, valore, ROWGUID) VALUES " +
                                                  $"({iIDUtente}, 1, 0, 0, NEWID())," +
                                                  $"({iIDUtente}, 1, 1, 0, NEWID())," +
                                                  $"({iIDUtente}, 1, 2, 0, NEWID())," +
                                                  $"({iIDUtente}, 1, 3, 0, NEWID())," +
                                                  $"({iIDUtente}, 2, 3, 0, NEWID())," +
                                                  $"({iIDUtente}, 3, 3, 0, NEWID())," +
                                                  $"({iIDUtente}, 4, 3, 0, NEWID())," +
                                                  $"({iIDUtente}, 5, 3, 0, NEWID())," +
                                                  $"({iIDUtente}, 6, 3, 0, NEWID())," +
                                                  $"({iIDUtente}, 7, 3, 0, NEWID())," +
                                                  $"({iIDUtente}, 8, 3, 0, NEWID())," +
                                                  $"({iIDUtente}, 9, 3, 0, NEWID())," +
                                                  $"({iIDUtente}, 10, 3, 0, NEWID())," +
                                                  $"({iIDUtente}, 12, 3, 0, NEWID())," +
                                                  $"({iIDUtente}, 13, 3, 0, NEWID())";

                                if (TheSync.UsuarioLogado.Admin)
                                {
                                    LogFileHelper.Get().Write(cmd.CommandText, txtLog);
                                }

                                cmd.ExecuteScalar();
                                LogFileHelper.Get().Write("\nINSERCAO DAS CONFIGURAÇÕES DE EXAME DO USUARIO CONCLUIDA\n", txtLog);
                                //

                                //ETAPA 9 -  INSERE NA TABELA UTENTI_INTERFACCIA
                                LogFileHelper.Get().Write($"Etapa 9/12 - INSERE CONFIGURAÇÕES DE INTERFACE DO USUARIO\n", txtLog);


                                cmd.CommandText = $"INSERT INTO utenti_interfaccia (idutente, idcontrollo, visibile, x, y, lunghezza, altezza, ROWGUID) VALUES " +
                                                  $"({iIDUtente}, 1021, 1, 76, 47, 165, 26, NEWID())," +
                                                  $"({iIDUtente}, 1022, 1, 76, 17, 156, 26, NEWID())," +
                                                  $"({iIDUtente}, 1024, 1, 295, 17, 18, 26, NEWID())," +
                                                  $"({iIDUtente}, 1025, 1, 428, 17, 121, 26, NEWID())," +
                                                  $"({iIDUtente}, 1026, 1, 636, 17, 154, 26, NEWID())," +
                                                  $"({iIDUtente}, 1027, 0, 296, 341, 121, 26, NEWID())," +
                                                  $"({iIDUtente}, 1028, 0, 448, 47, 77, 26, NEWID())," +
                                                  $"({iIDUtente}, 1029, 1, 294, 47, 54, 26, NEWID())," +
                                                  $"({iIDUtente}, 1030, 0, 641, 47, 159, 26, NEWID())," +
                                                  $"({iIDUtente}, 1037, 1, 6, 47, 67, 26, NEWID())," +
                                                  $"({iIDUtente}, 1038, 1, 6, 17, 67, 26, NEWID())," +
                                                  $"({iIDUtente}, 1039, 0, 119, 388, 200, 26, NEWID())," +
                                                  $"({iIDUtente}, 1040, 0, 118, 595, 144, 26, NEWID())," +
                                                  $"({iIDUtente}, 1041, 0, 348, 47, 75, 26, NEWID())," +
                                                  $"({iIDUtente}, 1042, 0, 118, 542, 144, 26, NEWID())," +
                                                  $"({iIDUtente}, 1043, 0, 118, 518, 144, 26, NEWID())," +
                                                  $"({iIDUtente}, 1044, 1, 348, 47, 75, 26, NEWID())," +
                                                  $"({iIDUtente}, 1046, 0, 118, 411, 144, 26, NEWID())," +
                                                  $"({iIDUtente}, 1047, 0, 118, 568, 144, 26, NEWID())," +
                                                  $"({iIDUtente}, 1048, 0, 294, 388, 121, 26, NEWID())," +
                                                  $"({iIDUtente}, 1049, 0, 428, 47, 343, 26, NEWID())," +
                                                  $"({iIDUtente}, 1050, 0, 296, 595, 121, 26, NEWID())," +
                                                  $"({iIDUtente}, 1051, 0, 296, 542, 121, 26, NEWID())," +
                                                  $"({iIDUtente}, 1052, 0, 118, 465, 144, 26, NEWID())," +
                                                  $"({iIDUtente}, 1053, 0, 118, 644, 144, 26, NEWID())," +
                                                  $"({iIDUtente}, 1054, 0, 118, 617, 144, 26, NEWID())," +
                                                  $"({iIDUtente}, 1055, 0, 118, 491, 144, 26, NEWID())," +
                                                  $"({iIDUtente}, 1056, 0, 296, 518, 121, 26, NEWID())," +
                                                  $"({iIDUtente}, 1057, 0, 296, 491, 121, 26, NEWID())," +
                                                  $"({iIDUtente}, 1058, 0, 296, 465, 121, 26, NEWID())," +
                                                  $"({iIDUtente}, 1059, 0, 296, 644, 121, 26, NEWID())," +
                                                  $"({iIDUtente}, 1060, 0, 296, 568, 121, 26, NEWID())," +
                                                  $"({iIDUtente}, 1061, 1, 428, 47, 121, 26, NEWID())," +
                                                  $"({iIDUtente}, 1062, 0, 296, 411, 121, 26, NEWID())," +
                                                  $"({iIDUtente}, 1063, 0, 296, 619, 121, 26, NEWID())," +
                                                  $"({iIDUtente}, 1064, 0, 116, 666, 144, 26, NEWID())," +
                                                  $"({iIDUtente}, 1065, 0, 300, 666, 121, 26, NEWID())," +
                                                  $"({iIDUtente}, 1099, 1, 243, 47, 47, 26, NEWID())," +
                                                  $"({iIDUtente}, 1200, 1, 258, 17, 32, 26, NEWID())," +
                                                  $"({iIDUtente}, 1201, 1, 348, 17, 77, 26, NEWID())," +
                                                  $"({iIDUtente}, 1202, 0, 331, 47, 112, 26, NEWID())," +
                                                  $"({iIDUtente}, 1203, 1, 562, 17, 75, 26, NEWID())," +
                                                  $"({iIDUtente}, 1204, 0, 118, 341, 144, 26, NEWID())," +
                                                  $"({iIDUtente}, 1205, 0, 532, 47, 105, 26, NEWID())";

                                if (TheSync.UsuarioLogado.Admin)
                                {
                                    LogFileHelper.Get().Write(cmd.CommandText, txtLog);
                                }

                                cmd.ExecuteScalar();
                                LogFileHelper.Get().Write("\nINSERCAO DAS CONFIGURAÇÕES DE INTERFACE DO USUARIO CONCLUIDA\n", txtLog);
                                //

                                //ETAPA 10 -  INSERE NA TABELA UTENTI_SETTING
                                LogFileHelper.Get().Write($"Etapa 6/12 - INSERE CONFIGURAÇÕES GERAIS DO USUARIO\n", txtLog);


                                cmd.CommandText = $"INSERT INTO utenti_setting (idutente, chiave, valore, ROWGUID) VALUES " +
                                                  $"({iIDUtente}, 'AddNewExamAfterPatientIns', '1', NEWID())," +
                                                  $"({iIDUtente}, 'AskImportPreviousGeneralFields', '0', NEWID())," +
                                                  $"({iIDUtente}, 'ChangeDoctorName', '1', NEWID())," +
                                                  $"({iIDUtente}, 'ComposeOnlyDefaultParameter', '0', NEWID())," +
                                                  $"({iIDUtente}, 'DefaultExam', '2', NEWID())," +
                                                  $"({iIDUtente}, 'DefaultPatientSex', '1', NEWID())," +
                                                  $"({iIDUtente}, 'DisableWarningMessageBox', '0', NEWID())," +
                                                  $"({iIDUtente}, 'DoctorDefaultName','{medico.sAssinatura}', NEWID())," +
                                                  $"({iIDUtente}, 'EnableModifyAfterExamIns', '1', NEWID())," +
                                                  $"({iIDUtente}, 'FocusGridItemNotes', '0', NEWID())," +
                                                  $"({iIDUtente}, 'FontBold', '0', NEWID())," +
                                                  $"({iIDUtente}, 'FontItalic', '0', NEWID())," +
                                                  $"({iIDUtente}, 'FontName', 'Arial', NEWID())," +
                                                  $"({iIDUtente}, 'FontSize', '10', NEWID())," +
                                                  $"({iIDUtente}, 'FontUnderline', '0', NEWID())," +
                                                  $"({iIDUtente}, 'GotoExamPageAfterExamIns', '2', NEWID())," +
                                                  $"({iIDUtente}, 'ImageFirstReport', '0', NEWID())," +
                                                  $"({iIDUtente}, 'InsertExamType', '0', NEWID())," +
                                                  $"({iIDUtente}, 'MeasureImageBottom', '672', NEWID())," +
                                                  $"({iIDUtente}, 'MeasureImageLeft', '45', NEWID())," +
                                                  $"({iIDUtente}, 'MeasureImageRight', '761', NEWID())," +
                                                  $"({iIDUtente}, 'MeasureImageTop', '185', NEWID())," +
                                                  $"({iIDUtente}, 'OldAlbumMode', '1', NEWID())," +
                                                  $"({iIDUtente}, 'OldStyleCharts', '0', NEWID())," +
                                                  $"({iIDUtente}, 'OldStylePregnancyExam', '0', NEWID())," +
                                                  $"({iIDUtente}, 'PrintImageBorder', '0', NEWID())," +
                                                  $"({iIDUtente}, 'ReportPaneWidth', '200', NEWID())," +
                                                  $"({iIDUtente}, 'ReportPrintExamBar', '0', NEWID())," +
                                                  $"({iIDUtente}, 'ReportPrintFalseField', '0', NEWID())," +
                                                  $"({iIDUtente}, 'SelectParameterReport', '0', NEWID())," +
                                                  $"({iIDUtente}, 'StartAcquirePreset', '0', NEWID())," +
                                                  $"({iIDUtente}, 'ThumbSizeX', '192', NEWID())," +
                                                  $"({iIDUtente}, 'ThumbSizeY', '144', NEWID())," +
                                                  $"({iIDUtente}, 'ViewAnamnesis', '1', NEWID())," +
                                                  $"({iIDUtente}, 'ViewImageReport', '1', NEWID())," +
                                                  $"({iIDUtente}, 'ViewToolbars', '1', NEWID())";

                                if (TheSync.UsuarioLogado.Admin)
                                {
                                    LogFileHelper.Get().Write(cmd.CommandText, txtLog);
                                }

                                cmd.ExecuteScalar();
                                LogFileHelper.Get().Write("\nINSERCAO DAS CONFIGURAÇÕES GERAIS DO USUARIO CONCLUIDA\n", txtLog);

                                //ETAPA 11 - ADICIONA O USUARIO AO REPORTEX
                                LogFileHelper.Get().Write($"Etapa 11/12 - INSERE CONFIGURAÇÕES DE LAUDO DO USUARIO\n", txtLog);


                                cmd.CommandText = $"SELECT ID FROM REPORTEX WHERE ELIMINATO = 0";

                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        cmd.CommandText = $"INSERT INTO REPORTEX_UTENTI (IDREPORTEX, IDUTENTE) VALUES ({reader.GetInt32(0)}, {iIDUtente}) {Environment.NewLine}";
                                    }

                                    if (TheSync.UsuarioLogado.Admin)
                                    {
                                        LogFileHelper.Get().Write(cmd.CommandText, txtLog);
                                    }

                                    reader.Close();
                                };

                                cmd.ExecuteNonQuery();
                                LogFileHelper.Get().Write("\nINSERCAO DAS CONFIGURAÇÕES DE LAUDO DO USUARIO CONCLUIDA\n", txtLog);


                                //ETAPA 12 -  ATUALIZAÇÃO DA RUBRICA
                                LogFileHelper.Get().Write($"Etapa 12/12 - ATUALIZA RUBRICA DO USUARIO\n", txtLog);

                                if (!string.IsNullOrEmpty(medico.sRubricaB64.Trim()))
                                {
                                    string imagePath = medico.sRubricaB64;

                                    if (File.Exists(imagePath))
                                    {
                                        // Lê os bytes da imagem
                                        byte[] imageBytes = File.ReadAllBytes(imagePath);

                                        // Converte os bytes para base64
                                        string base64String = Convert.ToBase64String(imageBytes);

                                        // Agora, 'base64String' contém a representação em base64 da imagem

                                        medico.sRubricaB64 = base64String;

                                        cmd.CommandText = $"UPDATE utenti_dettaglio SET immaginefirma = " +
                                                          $"'{medico.sRubricaB64}'" +
                                                          $"WHERE idutente = {iIDUtente}";

                                        if (TheSync.UsuarioLogado.Admin)
                                        {
                                            LogFileHelper.Get().Write(cmd.CommandText, txtLog);
                                        }
                                        cmd.ExecuteScalar();
                                        LogFileHelper.Get().Write("\nATUALIZACAO DA RUBRICA CONCLUIDA\n", txtLog);

                                        //

                                    }
                                    else
                                    {
                                        // Caso em que o arquivo de imagem não exista

                                        string mensagem = "Arquivo de imagem não encontrado: " + imagePath;
                                        if (TheSync.UsuarioLogado.Admin)
                                        {
                                            LogFileHelper.Get().Write(mensagem, txtLog);
                                            LogFileHelper.Get().Write("\n", txtLog);
                                        }

                                    }

                                }

                            }

                        }

                    }

                    if (bErrors)
                    {
                        LogFileHelper.Get().Write(txtAssinatura.Text + " CONCLUIDO COM ERROS", txtLog);
                        MessageBox.Show(txtAssinatura.Text + " Concluido com ERROS!", "CONCLUIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LogFileHelper.Get().Write("\n", txtLog);
                    }
                    else
                    {
                        LogFileHelper.Get().Write(txtAssinatura.Text + " CONCLUIDO COM SUCESSO", txtLog);
                        LogFileHelper.Get().Write("\n", txtLog);
                    }

                }

                txtUsername.Text = "";
                txtSobrenome.Text = "";
                txtNome.Text = "";
                txt3l3n.Text = "";
                txtTratamento.Text = "";
                txtAssinatura.Text = "";
                txtCRM.Text = "";
                picBoxRubrica.ImageLocation = "";
                txtImagePath.Text = "";
                picBoxRubrica.Dispose();
                txtExcelPath.Text = "";

                LogFileHelper.Get().Write("\n", txtLog);

                Cursor.Current = Cursors.Default;
                btnFechar.Enabled = true;
                btnInicializar.Enabled = true;
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                ckbManual.Enabled = true;
                ckbManual.Checked = false;
                LogFileHelper.Get().Write("\n", txtLog);
            }
            catch (Exception er)
            {
                LogFileHelper.Get().Write(er.ToString(), txtLog);
                LogFileHelper.Get().Write("\n", txtLog);
                LogFileHelper.Get().Write(er.StackTrace, txtLog);
                LogFileHelper.Get().Write("\n", txtLog);

                Cursor.Current = Cursors.Default;
                btnFechar.Enabled = true;
                btnInicializar.Enabled = true;
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                ckbManual.Enabled = true;
                ckbManual.Checked = false;
                LogFileHelper.Get().Write("\n", txtLog);
            }


        }

        public void MontaAssinatura()
        {
            string assinatura = "";

            if (string.IsNullOrEmpty(txtNome.Text.Trim()) || string.IsNullOrEmpty(txtSobrenome.Text.Trim()) || string.IsNullOrEmpty(txtTratamento.Text.Trim()) || string.IsNullOrEmpty(txtCRM.Text.Trim()))
            {
                assinatura = "";
            }
            else
            {
                assinatura = $"{txtTratamento.Text} {txtNome.Text} {txtSobrenome.Text} - CRM: {txtCRM.Text}";
            }

            txtAssinatura.Text = assinatura;
        }

        private List<Medico> ImportarMedicosDoCSV(string caminhoCSV)
        {
            int contador = 0;
            List<Medico> listaMedicos = new List<Medico>();

            LogFileHelper.Get().Write($"Início da importação via CSV.", txtLog);

            try
            {
                // Lê todas as linhas do arquivo CSV
                string[] linhas = File.ReadAllLines(caminhoCSV);

                // Itera sobre cada linha 
                for (int i = 0; i < linhas.Length; i++)
                {
                    // Divide os valores da linha usando o ponto e vírgula como separador
                    string[] valores = linhas[i].Split(';');

                    // Cria um objeto Medico e preenche seus atributos
                    Medico medico = new Medico
                    {
                        sUserName = valores[0],
                        sNome = valores[1],
                        sSobrenome = valores[2],
                        sCRM = valores[3],
                        sTratamento = valores[4],
                        s3L3N = valores[5],
                        sRubricaB64 = valores[6]
                    };

                    if (string.IsNullOrEmpty(medico.sUserName.Trim()) || string.IsNullOrEmpty(medico.sNome.Trim()) || string.IsNullOrEmpty(medico.sSobrenome.Trim()) || string.IsNullOrEmpty(medico.sTratamento.Trim()) || string.IsNullOrEmpty(medico.sCRM.Trim()) || string.IsNullOrEmpty(medico.s3L3N.Trim()))
                    {
                        // O objeto medico está incompleto nas informações, não sendo possível processa-lo
                        LogFileHelper.Get().Write($"O médico referente à linha {i + 1} do arquivo não será importado porque existem inconsistências em suas informações", txtLog);
                    }
                    else
                    {
                        // Cria a assinatura do Médico
                        medico.sAssinatura = $"{medico.sTratamento.Trim()} {medico.sNome.Trim()} {medico.sSobrenome.Trim()} - CRM: {medico.sCRM.Trim()}";

                        // Adiciona o objeto Medico à lista
                        listaMedicos.Add(medico);
                        contador++;
                    }

                }

                LogFileHelper.Get().Write($"{contador} médicos foram carregados a partir do arquivo.", txtLog);
            }
            catch (Exception ex)
            {
                LogFileHelper.Get().Write($"Erro ao ler o arquivo CSV: {ex.Message}", txtLog);
            }

            return listaMedicos;
        }



    }
}
