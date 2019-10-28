namespace ExemploComboBox
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbcursos = new System.Windows.Forms.ComboBox();
            this.lblcursos = new System.Windows.Forms.Label();
            this.btnselecionar = new System.Windows.Forms.Button();
            this.lblnovocurso = new System.Windows.Forms.Label();
            this.txtcurso = new System.Windows.Forms.TextBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnexcluircurso = new System.Windows.Forms.Button();
            this.lblano = new System.Windows.Forms.Label();
            this.cmbanonasc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbcursos
            // 
            this.cmbcursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcursos.FormattingEnabled = true;
            this.cmbcursos.Items.AddRange(new object[] {
            "Administração",
            "Ensino Médio",
            "Informática",
            "Logística"});
            this.cmbcursos.Location = new System.Drawing.Point(51, 69);
            this.cmbcursos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbcursos.Name = "cmbcursos";
            this.cmbcursos.Size = new System.Drawing.Size(180, 26);
            this.cmbcursos.Sorted = true;
            this.cmbcursos.TabIndex = 0;
            // 
            // lblcursos
            // 
            this.lblcursos.AutoSize = true;
            this.lblcursos.Location = new System.Drawing.Point(51, 33);
            this.lblcursos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcursos.Name = "lblcursos";
            this.lblcursos.Size = new System.Drawing.Size(61, 18);
            this.lblcursos.TabIndex = 1;
            this.lblcursos.Text = "Cursos:";
            // 
            // btnselecionar
            // 
            this.btnselecionar.Location = new System.Drawing.Point(270, 69);
            this.btnselecionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnselecionar.Name = "btnselecionar";
            this.btnselecionar.Size = new System.Drawing.Size(183, 32);
            this.btnselecionar.TabIndex = 2;
            this.btnselecionar.Text = "Selecionar Curso";
            this.btnselecionar.UseVisualStyleBackColor = true;
            this.btnselecionar.Click += new System.EventHandler(this.btnselecionar_Click);
            // 
            // lblnovocurso
            // 
            this.lblnovocurso.AutoSize = true;
            this.lblnovocurso.Location = new System.Drawing.Point(51, 119);
            this.lblnovocurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnovocurso.Name = "lblnovocurso";
            this.lblnovocurso.Size = new System.Drawing.Size(93, 18);
            this.lblnovocurso.TabIndex = 3;
            this.lblnovocurso.Text = "Novo Curso:";
            // 
            // txtcurso
            // 
            this.txtcurso.Location = new System.Drawing.Point(51, 151);
            this.txtcurso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcurso.Name = "txtcurso";
            this.txtcurso.Size = new System.Drawing.Size(180, 24);
            this.txtcurso.TabIndex = 4;
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(270, 147);
            this.btncadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(183, 32);
            this.btncadastrar.TabIndex = 5;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btnexcluircurso
            // 
            this.btnexcluircurso.Location = new System.Drawing.Point(158, 204);
            this.btnexcluircurso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnexcluircurso.Name = "btnexcluircurso";
            this.btnexcluircurso.Size = new System.Drawing.Size(160, 32);
            this.btnexcluircurso.TabIndex = 6;
            this.btnexcluircurso.Text = "Excluir Curso";
            this.btnexcluircurso.UseVisualStyleBackColor = true;
            this.btnexcluircurso.Click += new System.EventHandler(this.btnexcluircurso_Click);
            // 
            // lblano
            // 
            this.lblano.AutoSize = true;
            this.lblano.Location = new System.Drawing.Point(48, 259);
            this.lblano.Name = "lblano";
            this.lblano.Size = new System.Drawing.Size(142, 18);
            this.lblano.TabIndex = 7;
            this.lblano.Text = "Ano de Nascimento:";
            // 
            // cmbanonasc
            // 
            this.cmbanonasc.FormattingEnabled = true;
            this.cmbanonasc.Location = new System.Drawing.Point(51, 296);
            this.cmbanonasc.Name = "cmbanonasc";
            this.cmbanonasc.Size = new System.Drawing.Size(121, 26);
            this.cmbanonasc.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(495, 365);
            this.Controls.Add(this.cmbanonasc);
            this.Controls.Add(this.lblano);
            this.Controls.Add(this.btnexcluircurso);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txtcurso);
            this.Controls.Add(this.lblnovocurso);
            this.Controls.Add(this.btnselecionar);
            this.Controls.Add(this.lblcursos);
            this.Controls.Add(this.cmbcursos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Exemplo ComboBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbcursos;
        private System.Windows.Forms.Label lblcursos;
        private System.Windows.Forms.Button btnselecionar;
        private System.Windows.Forms.Label lblnovocurso;
        private System.Windows.Forms.TextBox txtcurso;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnexcluircurso;
        private System.Windows.Forms.Label lblano;
        private System.Windows.Forms.ComboBox cmbanonasc;
    }
}

