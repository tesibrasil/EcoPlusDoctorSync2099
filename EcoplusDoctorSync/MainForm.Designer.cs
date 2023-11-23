using EcoplusDoctorSync.Models;

namespace EcoplusDoctorSync
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImagePath = new System.Windows.Forms.Button();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.picBoxRubrica = new System.Windows.Forms.PictureBox();
            this.lblCRM = new System.Windows.Forms.Label();
            this.txtCRM = new System.Windows.Forms.TextBox();
            this.lblTratamento = new System.Windows.Forms.Label();
            this.txtTratamento = new System.Windows.Forms.TextBox();
            this.lbl3l3n = new System.Windows.Forms.Label();
            this.txt3l3n = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblAssinatura = new System.Windows.Forms.Label();
            this.txtAssinatura = new System.Windows.Forms.TextBox();
            this.ckbManual = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFindXLS = new System.Windows.Forms.Button();
            this.txtExcelPath = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnInicializar = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.prgLog = new System.Windows.Forms.ProgressBar();
            this.ofdExcel = new System.Windows.Forms.OpenFileDialog();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.btnConexoes = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRubrica)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImagePath);
            this.groupBox1.Controls.Add(this.lblImagePath);
            this.groupBox1.Controls.Add(this.txtImagePath);
            this.groupBox1.Controls.Add(this.picBoxRubrica);
            this.groupBox1.Controls.Add(this.lblCRM);
            this.groupBox1.Controls.Add(this.txtCRM);
            this.groupBox1.Controls.Add(this.lblTratamento);
            this.groupBox1.Controls.Add(this.txtTratamento);
            this.groupBox1.Controls.Add(this.lbl3l3n);
            this.groupBox1.Controls.Add(this.txt3l3n);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.lblSobrenome);
            this.groupBox1.Controls.Add(this.txtSobrenome);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblAssinatura);
            this.groupBox1.Controls.Add(this.txtAssinatura);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 588);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserção Manual";
            // 
            // btnImagePath
            // 
            this.btnImagePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagePath.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagePath.Location = new System.Drawing.Point(6, 542);
            this.btnImagePath.Name = "btnImagePath";
            this.btnImagePath.Size = new System.Drawing.Size(435, 30);
            this.btnImagePath.TabIndex = 14;
            this.btnImagePath.Text = "IMPORTAR RUBRICA";
            this.btnImagePath.UseVisualStyleBackColor = true;
            this.btnImagePath.Click += new System.EventHandler(this.btnFindImage_Click);
            // 
            // lblImagePath
            // 
            this.lblImagePath.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagePath.Location = new System.Drawing.Point(6, 346);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(435, 25);
            this.lblImagePath.TabIndex = 15;
            this.lblImagePath.Text = "RUBRICA";
            this.lblImagePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtImagePath
            // 
            this.txtImagePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImagePath.Location = new System.Drawing.Point(6, 510);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.ReadOnly = true;
            this.txtImagePath.Size = new System.Drawing.Size(435, 26);
            this.txtImagePath.TabIndex = 16;
            this.txtImagePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picBoxRubrica
            // 
            this.picBoxRubrica.Location = new System.Drawing.Point(3, 374);
            this.picBoxRubrica.Name = "picBoxRubrica";
            this.picBoxRubrica.Size = new System.Drawing.Size(439, 130);
            this.picBoxRubrica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxRubrica.TabIndex = 14;
            this.picBoxRubrica.TabStop = false;
            // 
            // lblCRM
            // 
            this.lblCRM.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCRM.Location = new System.Drawing.Point(234, 238);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(207, 25);
            this.lblCRM.TabIndex = 12;
            this.lblCRM.Text = "CRM";
            this.lblCRM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCRM
            // 
            this.txtCRM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCRM.Location = new System.Drawing.Point(234, 263);
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.Size = new System.Drawing.Size(207, 26);
            this.txtCRM.TabIndex = 13;
            this.txtCRM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCRM.Leave += new System.EventHandler(this.CamposAssinatura_EventLeave);
            this.txtCRM.KeyPress += txtCRM_KeyPress;
            // 
            // lblTratamento
            // 
            this.lblTratamento.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratamento.Location = new System.Drawing.Point(6, 238);
            this.lblTratamento.Name = "lblTratamento";
            this.lblTratamento.Size = new System.Drawing.Size(207, 25);
            this.lblTratamento.TabIndex = 10;
            this.lblTratamento.Text = "Tratamento";
            this.lblTratamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTratamento
            // 
            this.txtTratamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTratamento.Location = new System.Drawing.Point(6, 263);
            this.txtTratamento.Name = "txtTratamento";
            this.txtTratamento.Size = new System.Drawing.Size(207, 26);
            this.txtTratamento.TabIndex = 11;
            this.txtTratamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTratamento.Leave += new System.EventHandler(this.CamposAssinatura_EventLeave);
            // 
            // lbl3l3n
            // 
            this.lbl3l3n.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3l3n.Location = new System.Drawing.Point(6, 184);
            this.lbl3l3n.Name = "lbl3l3n";
            this.lbl3l3n.Size = new System.Drawing.Size(435, 25);
            this.lbl3l3n.TabIndex = 8;
            this.lbl3l3n.Text = "3L3N";
            this.lbl3l3n.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt3l3n
            // 
            this.txt3l3n.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt3l3n.Location = new System.Drawing.Point(6, 209);
            this.txt3l3n.Name = "txt3l3n";
            this.txt3l3n.Size = new System.Drawing.Size(435, 26);
            this.txt3l3n.TabIndex = 9;
            this.txt3l3n.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(6, 22);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(435, 25);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "USERNAME (DOMINIO)";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsername.Location = new System.Drawing.Point(6, 47);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(435, 26);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.Location = new System.Drawing.Point(6, 76);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(435, 25);
            this.lblSobrenome.TabIndex = 2;
            this.lblSobrenome.Text = "SOBRENOME";
            this.lblSobrenome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSobrenome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSobrenome.Location = new System.Drawing.Point(6, 101);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(435, 26);
            this.txtSobrenome.TabIndex = 3;
            this.txtSobrenome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSobrenome.TextChanged += new System.EventHandler(this.txtSobrenome_TextChanged);
            this.txtSobrenome.Leave += new System.EventHandler(this.CamposAssinatura_EventLeave);
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(6, 130);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(435, 25);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "NOME";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(6, 155);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(435, 26);
            this.txtNome.TabIndex = 5;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.Leave += new System.EventHandler(this.CamposAssinatura_EventLeave);
            // 
            // lblAssinatura
            // 
            this.lblAssinatura.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssinatura.Location = new System.Drawing.Point(3, 292);
            this.lblAssinatura.Name = "lblAssinatura";
            this.lblAssinatura.Size = new System.Drawing.Size(435, 25);
            this.lblAssinatura.TabIndex = 6;
            this.lblAssinatura.Text = "ASSINATURA COMPLETA";
            this.lblAssinatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAssinatura
            // 
            this.txtAssinatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAssinatura.Location = new System.Drawing.Point(3, 317);
            this.txtAssinatura.Name = "txtAssinatura";
            this.txtAssinatura.ReadOnly = true;
            this.txtAssinatura.Size = new System.Drawing.Size(439, 26);
            this.txtAssinatura.TabIndex = 7;
            this.txtAssinatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAssinatura.TextChanged += new System.EventHandler(this.txtAssinatura_TextChanged);
            // 
            // ckbManual
            // 
            this.ckbManual.AutoSize = true;
            this.ckbManual.Location = new System.Drawing.Point(135, 14);
            this.ckbManual.Name = "ckbManual";
            this.ckbManual.Size = new System.Drawing.Size(15, 14);
            this.ckbManual.TabIndex = 24;
            this.ckbManual.UseVisualStyleBackColor = true;
            this.ckbManual.CheckedChanged += new System.EventHandler(this.ckbManual_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFindXLS);
            this.groupBox2.Controls.Add(this.txtExcelPath);
            this.groupBox2.Location = new System.Drawing.Point(12, 606);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 121);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inserir Grupo";
            // 
            // btnFindXLS
            // 
            this.btnFindXLS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindXLS.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindXLS.Location = new System.Drawing.Point(6, 36);
            this.btnFindXLS.Name = "btnFindXLS";
            this.btnFindXLS.Size = new System.Drawing.Size(436, 30);
            this.btnFindXLS.TabIndex = 12;
            this.btnFindXLS.Text = "IMPORTAR ARQUIVO CSV";
            this.btnFindXLS.UseVisualStyleBackColor = true;
            this.btnFindXLS.Click += new System.EventHandler(this.btnFindXLS_Click);
            // 
            // txtExcelPath
            // 
            this.txtExcelPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExcelPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExcelPath.Enabled = false;
            this.txtExcelPath.Location = new System.Drawing.Point(6, 72);
            this.txtExcelPath.Name = "txtExcelPath";
            this.txtExcelPath.ReadOnly = true;
            this.txtExcelPath.Size = new System.Drawing.Size(436, 26);
            this.txtExcelPath.TabIndex = 13;
            this.txtExcelPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFechar
            // 
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(750, 20);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(132, 30);
            this.btnFechar.TabIndex = 21;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnInicializar
            // 
            this.btnInicializar.Enabled = false;
            this.btnInicializar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicializar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicializar.Location = new System.Drawing.Point(612, 20);
            this.btnInicializar.Name = "btnInicializar";
            this.btnInicializar.Size = new System.Drawing.Size(132, 30);
            this.btnInicializar.TabIndex = 20;
            this.btnInicializar.Text = "INICIALIZAR";
            this.btnInicializar.UseVisualStyleBackColor = true;
            this.btnInicializar.Click += new System.EventHandler(this.btnInicializar_Click);
            // 
            // txtLog
            // 
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(478, 88);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(421, 639);
            this.txtLog.TabIndex = 23;
            // 
            // prgLog
            // 
            this.prgLog.Location = new System.Drawing.Point(478, 56);
            this.prgLog.Maximum = 1000;
            this.prgLog.Name = "prgLog";
            this.prgLog.Size = new System.Drawing.Size(404, 25);
            this.prgLog.TabIndex = 22;
            // 
            // ofdExcel
            // 
            this.ofdExcel.Filter = "CSV Files|*.csv";
            // 
            // ofdImage
            // 
            this.ofdImage.Filter = "Image Files| *.jpg;*.png;*.bmp";
            // 
            // btnConexoes
            // 
            this.btnConexoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConexoes.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConexoes.Location = new System.Drawing.Point(478, 20);
            this.btnConexoes.Name = "btnConexoes";
            this.btnConexoes.Size = new System.Drawing.Size(128, 30);
            this.btnConexoes.TabIndex = 25;
            this.btnConexoes.Text = "CONEXÕES";
            this.btnConexoes.UseVisualStyleBackColor = true;
            this.btnConexoes.Click += new System.EventHandler(this.btnConexoes_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 744);
            this.Controls.Add(this.btnConexoes);
            this.Controls.Add(this.ckbManual);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnInicializar);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.prgLog);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eco+ DoctorSync 2099";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRubrica)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.OpenFileDialog ofdExcel;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.TextBox txtAssinatura;
        private System.Windows.Forms.Label lblAssinatura;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txt3l3n;
        private System.Windows.Forms.Label lbl3l3n;
        private System.Windows.Forms.PictureBox picBoxRubrica;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button btnImagePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtExcelPath;
        private System.Windows.Forms.Button btnFindXLS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar prgLog;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnInicializar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.CheckBox ckbManual;
        private System.Windows.Forms.Button btnConexoes;
        private System.Windows.Forms.Label lblTratamento;
        private System.Windows.Forms.TextBox txtTratamento;
        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.TextBox txtCRM;

    }
}

