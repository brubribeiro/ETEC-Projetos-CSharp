using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploFormularioSDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNormal_Click(object sender, EventArgs e) //pode abrir mais de uma tela
        {
            //instanciar um objeto --> criar na memoria RAM
            //classe nome do objeto = new MetodoConstrutor();
            frmSegunda tela = new frmSegunda();

            tela.Show(); //pode abrir varias telas
        }

        private void btnDialogo_Click(object sender, EventArgs e) //esse aq trava as telas
        {
            frmSegunda tela = new frmSegunda();
            tela.ShowDialog();//não pode abrir varias telas
        }
    }
}
