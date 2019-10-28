namespace ExemploFormularioSDI
{
    partial class frmSegunda
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
            this.btnClique = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClique
            // 
            this.btnClique.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClique.Location = new System.Drawing.Point(309, 188);
            this.btnClique.Name = "btnClique";
            this.btnClique.Size = new System.Drawing.Size(118, 28);
            this.btnClique.TabIndex = 2;
            this.btnClique.Text = "Clique Aqui";
            this.btnClique.UseVisualStyleBackColor = true;
            this.btnClique.Click += new System.EventHandler(this.btnClique_Click);
            // 
            // frmSegunda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 237);
            this.Controls.Add(this.btnClique);
            this.Name = "frmSegunda";
            this.Text = "frmSegunda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClique;
    }
}