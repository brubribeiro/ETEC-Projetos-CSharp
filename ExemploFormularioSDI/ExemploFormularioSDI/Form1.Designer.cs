namespace ExemploFormularioSDI
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
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnDialogo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNormal
            // 
            this.btnNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormal.Location = new System.Drawing.Point(120, 65);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(210, 28);
            this.btnNormal.TabIndex = 0;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnDialogo
            // 
            this.btnDialogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDialogo.Location = new System.Drawing.Point(124, 130);
            this.btnDialogo.Name = "btnDialogo";
            this.btnDialogo.Size = new System.Drawing.Size(206, 29);
            this.btnDialogo.TabIndex = 1;
            this.btnDialogo.Text = "Exibir Dialogo";
            this.btnDialogo.UseVisualStyleBackColor = true;
            this.btnDialogo.Click += new System.EventHandler(this.btnDialogo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 237);
            this.Controls.Add(this.btnDialogo);
            this.Controls.Add(this.btnNormal);
            this.Name = "Form1";
            this.Text = "Exibir Telas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnDialogo;
    }
}

