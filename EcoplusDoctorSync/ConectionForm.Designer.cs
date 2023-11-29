namespace EcoplusDoctorSync
{
    partial class ConectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConectionForm));
            this.ckbManual = new System.Windows.Forms.CheckBox();
            this.gbManual = new System.Windows.Forms.GroupBox();
            this.lblStringConexao = new System.Windows.Forms.Label();
            this.txtStringConexao = new System.Windows.Forms.TextBox();
            this.lblBandoDeDados = new System.Windows.Forms.Label();
            this.txtBancoDeDados = new System.Windows.Forms.TextBox();
            this.lblApelido = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.lblServidor = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gbImportar = new System.Windows.Forms.GroupBox();
            this.btnFindXLS = new System.Windows.Forms.Button();
            this.txtExcelPath = new System.Windows.Forms.TextBox();
            this.lvConexoes = new System.Windows.Forms.ListView();
            this.Apelido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StringDeConexão = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbManual.SuspendLayout();
            this.gbImportar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckbManual
            // 
            this.ckbManual.AutoSize = true;
            this.ckbManual.Location = new System.Drawing.Point(105, 12);
            this.ckbManual.Name = "ckbManual";
            this.ckbManual.Size = new System.Drawing.Size(15, 14);
            this.ckbManual.TabIndex = 26;
            this.ckbManual.UseVisualStyleBackColor = true;
            // 
            // gbManual
            // 
            this.gbManual.Controls.Add(this.lblStringConexao);
            this.gbManual.Controls.Add(this.txtStringConexao);
            this.gbManual.Controls.Add(this.lblBandoDeDados);
            this.gbManual.Controls.Add(this.txtBancoDeDados);
            this.gbManual.Controls.Add(this.lblApelido);
            this.gbManual.Controls.Add(this.txtApelido);
            this.gbManual.Controls.Add(this.lblServidor);
            this.gbManual.Controls.Add(this.txtServidor);
            this.gbManual.Controls.Add(this.lblUsuario);
            this.gbManual.Controls.Add(this.txtUsuario);
            this.gbManual.Controls.Add(this.lblSenha);
            this.gbManual.Controls.Add(this.txtSenha);
            this.gbManual.Location = new System.Drawing.Point(12, 12);
            this.gbManual.Name = "gbManual";
            this.gbManual.Size = new System.Drawing.Size(399, 399);
            this.gbManual.TabIndex = 25;
            this.gbManual.TabStop = false;
            this.gbManual.Text = "Inserção Manual";
            // 
            // lblStringConexao
            // 
            this.lblStringConexao.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStringConexao.Location = new System.Drawing.Point(6, 318);
            this.lblStringConexao.Name = "lblStringConexao";
            this.lblStringConexao.Size = new System.Drawing.Size(387, 25);
            this.lblStringConexao.TabIndex = 10;
            this.lblStringConexao.Text = "STRING DE CONEXÃO";
            this.lblStringConexao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStringConexao
            // 
            this.txtStringConexao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStringConexao.Location = new System.Drawing.Point(6, 345);
            this.txtStringConexao.Name = "txtStringConexao";
            this.txtStringConexao.ReadOnly = true;
            this.txtStringConexao.Size = new System.Drawing.Size(387, 20);
            this.txtStringConexao.TabIndex = 11;
            this.txtStringConexao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBandoDeDados
            // 
            this.lblBandoDeDados.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBandoDeDados.Location = new System.Drawing.Point(6, 133);
            this.lblBandoDeDados.Name = "lblBandoDeDados";
            this.lblBandoDeDados.Size = new System.Drawing.Size(387, 25);
            this.lblBandoDeDados.TabIndex = 8;
            this.lblBandoDeDados.Text = "BASE DE DADOS";
            this.lblBandoDeDados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBancoDeDados
            // 
            this.txtBancoDeDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBancoDeDados.Location = new System.Drawing.Point(6, 158);
            this.txtBancoDeDados.Name = "txtBancoDeDados";
            this.txtBancoDeDados.Size = new System.Drawing.Size(387, 20);
            this.txtBancoDeDados.TabIndex = 3;
            this.txtBancoDeDados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblApelido
            // 
            this.lblApelido.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApelido.Location = new System.Drawing.Point(6, 22);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(387, 25);
            this.lblApelido.TabIndex = 0;
            this.lblApelido.Text = "APELIDO";
            this.lblApelido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtApelido
            // 
            this.txtApelido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApelido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApelido.Location = new System.Drawing.Point(6, 47);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(387, 20);
            this.txtApelido.TabIndex = 1;
            this.txtApelido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblServidor
            // 
            this.lblServidor.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServidor.Location = new System.Drawing.Point(6, 76);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(387, 25);
            this.lblServidor.TabIndex = 2;
            this.lblServidor.Text = "SERVIDOR";
            this.lblServidor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtServidor
            // 
            this.txtServidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServidor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtServidor.Location = new System.Drawing.Point(6, 101);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(387, 20);
            this.txtServidor.TabIndex = 2;
            this.txtServidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(6, 196);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(387, 25);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "USUARIO";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Location = new System.Drawing.Point(6, 221);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(387, 20);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSenha
            // 
            this.lblSenha.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(6, 254);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(387, 25);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "SENHA";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Location = new System.Drawing.Point(6, 282);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(387, 20);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSalva
            // 
            this.btnSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalva.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(417, 18);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(131, 30);
            this.btnSalva.TabIndex = 6;
            this.btnSalva.Text = "SALVAR";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(674, 18);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(114, 30);
            this.btnFechar.TabIndex = 29;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(554, 18);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(114, 30);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // gbImportar
            // 
            this.gbImportar.Controls.Add(this.btnFindXLS);
            this.gbImportar.Controls.Add(this.txtExcelPath);
            this.gbImportar.Location = new System.Drawing.Point(12, 421);
            this.gbImportar.Name = "gbImportar";
            this.gbImportar.Size = new System.Drawing.Size(399, 121);
            this.gbImportar.TabIndex = 31;
            this.gbImportar.TabStop = false;
            this.gbImportar.Text = "Inserir Grupo";
            // 
            // btnFindXLS
            // 
            this.btnFindXLS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindXLS.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindXLS.Location = new System.Drawing.Point(6, 36);
            this.btnFindXLS.Name = "btnFindXLS";
            this.btnFindXLS.Size = new System.Drawing.Size(387, 30);
            this.btnFindXLS.TabIndex = 12;
            this.btnFindXLS.Text = "IMPORTAR ARQUIVO CSV";
            this.btnFindXLS.UseVisualStyleBackColor = true;
            // 
            // txtExcelPath
            // 
            this.txtExcelPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExcelPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExcelPath.Enabled = false;
            this.txtExcelPath.Location = new System.Drawing.Point(6, 72);
            this.txtExcelPath.Name = "txtExcelPath";
            this.txtExcelPath.Size = new System.Drawing.Size(387, 20);
            this.txtExcelPath.TabIndex = 13;
            this.txtExcelPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lvConexoes
            // 
            this.lvConexoes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Apelido,
            this.StringDeConexão});
            this.lvConexoes.HideSelection = false;
            this.lvConexoes.Location = new System.Drawing.Point(418, 59);
            this.lvConexoes.Name = "lvConexoes";
            this.lvConexoes.Size = new System.Drawing.Size(370, 483);
            this.lvConexoes.TabIndex = 32;
            this.lvConexoes.UseCompatibleStateImageBehavior = false;
            this.lvConexoes.View = System.Windows.Forms.View.Details;
            this.lvConexoes.SelectedIndexChanged += new System.EventHandler(this.lvConexoes_SelectedIndexChanged);
            // 
            // Apelido
            // 
            this.Apelido.Text = "APELIDO";
            this.Apelido.Width = 100;
            // 
            // StringDeConexão
            // 
            this.StringDeConexão.Text = "STRING DE CONEXÃO";
            this.StringDeConexão.Width = 180;
            // 
            // ConectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.lvConexoes);
            this.Controls.Add(this.gbImportar);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.ckbManual);
            this.Controls.Add(this.gbManual);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConectionForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eco+ DoctorSync 2099 - Conexões";
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            this.gbManual.ResumeLayout(false);
            this.gbManual.PerformLayout();
            this.gbImportar.ResumeLayout(false);
            this.gbImportar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbManual;
        private System.Windows.Forms.GroupBox gbManual;
        private System.Windows.Forms.Label lblBandoDeDados;
        private System.Windows.Forms.TextBox txtBancoDeDados;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblStringConexao;
        private System.Windows.Forms.TextBox txtStringConexao;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox gbImportar;
        private System.Windows.Forms.Button btnFindXLS;
        private System.Windows.Forms.TextBox txtExcelPath;
        private System.Windows.Forms.ListView lvConexoes;
        private System.Windows.Forms.ColumnHeader Apelido;
        private System.Windows.Forms.ColumnHeader StringDeConexão;
    }
}