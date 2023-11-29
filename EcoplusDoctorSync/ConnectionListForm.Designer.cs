namespace EcoplusDoctorSync
{
    partial class ConnectionListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionListForm));
            this.clbConexoes = new System.Windows.Forms.CheckedListBox();
            this.btnProsseguir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbMarcarTodos = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // clbConexoes
            // 
            this.clbConexoes.FormattingEnabled = true;
            this.clbConexoes.Location = new System.Drawing.Point(12, 27);
            this.clbConexoes.MultiColumn = true;
            this.clbConexoes.Name = "clbConexoes";
            this.clbConexoes.Size = new System.Drawing.Size(361, 229);
            this.clbConexoes.TabIndex = 0;
            // 
            // btnProsseguir
            // 
            this.btnProsseguir.Location = new System.Drawing.Point(12, 276);
            this.btnProsseguir.Name = "btnProsseguir";
            this.btnProsseguir.Size = new System.Drawing.Size(119, 33);
            this.btnProsseguir.TabIndex = 1;
            this.btnProsseguir.Text = "PROSSEGUIR";
            this.btnProsseguir.UseVisualStyleBackColor = true;
            this.btnProsseguir.Click += new System.EventHandler(this.btnProsseguir_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "FECHAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbMarcarTodos
            // 
            this.cbMarcarTodos.AutoSize = true;
            this.cbMarcarTodos.Location = new System.Drawing.Point(13, 4);
            this.cbMarcarTodos.Name = "cbMarcarTodos";
            this.cbMarcarTodos.Size = new System.Drawing.Size(74, 14);
            this.cbMarcarTodos.TabIndex = 3;
            this.cbMarcarTodos.Text = "Marcar Todos";
            this.cbMarcarTodos.UseVisualStyleBackColor = true;
            this.cbMarcarTodos.CheckedChanged += new System.EventHandler(this.cbMarcarTodos_CheckedChanged);
            // 
            // ConnectionListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 321);
            this.Controls.Add(this.cbMarcarTodos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnProsseguir);
            this.Controls.Add(this.clbConexoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectionListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eco+ DoctorSync 2099";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbConexoes;
        private System.Windows.Forms.Button btnProsseguir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cbMarcarTodos;
    }
}