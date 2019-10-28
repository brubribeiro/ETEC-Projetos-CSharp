namespace ExemploVetor
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
            this.lblindice = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnproximo = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numidade = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numidade)).BeginInit();
            this.SuspendLayout();
            // 
            // lblindice
            // 
            this.lblindice.AutoSize = true;
            this.lblindice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblindice.Location = new System.Drawing.Point(142, 44);
            this.lblindice.Name = "lblindice";
            this.lblindice.Size = new System.Drawing.Size(69, 25);
            this.lblindice.TabIndex = 0;
            this.lblindice.Text = "Indice";
            this.lblindice.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(126, 94);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(12, 194);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 2;
            this.btnvoltar.Text = "<<";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnproximo
            // 
            this.btnproximo.Location = new System.Drawing.Point(261, 194);
            this.btnproximo.Name = "btnproximo";
            this.btnproximo.Size = new System.Drawing.Size(75, 23);
            this.btnproximo.TabIndex = 3;
            this.btnproximo.Text = ">>";
            this.btnproximo.UseVisualStyleBackColor = true;
            this.btnproximo.Click += new System.EventHandler(this.btnproximo_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(261, 231);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 4;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(126, 121);
            this.mtbTelefone.Mask = "(99) 00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(100, 20);
            this.mtbTelefone.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome:";
            // 
            // numidade
            // 
            this.numidade.Location = new System.Drawing.Point(126, 147);
            this.numidade.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numidade.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numidade.Name = "numidade";
            this.numidade.Size = new System.Drawing.Size(100, 20);
            this.numidade.TabIndex = 8;
            this.numidade.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Idade:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 266);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbTelefone);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnproximo);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblindice);
            this.Name = "Form1";
            this.Text = "EXEMPLO VETOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblindice;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnproximo;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

