using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnselecionar_Click(object sender, EventArgs e)
        {
            if(cmbcursos.Text == "")//Se a opção estiver vazia
            {
                MessageBox.Show("Selecione um Curso! ");
            }
            else //Se algum curso for selecionado
            {
                MessageBox.Show("Curso selecionado: " + cmbcursos.Text);
            }
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
           if( txtcurso.Text == "")
            {
                MessageBox.Show("Digite um curso para cadastrar! ");
            }
           else
            {
                cmbcursos.Items.Add(txtcurso.Text);
                MessageBox.Show("Curso Cadastrado! ");
                txtcurso.Text = "";
            }
        }

        private void btnexcluircurso_Click(object sender, EventArgs e)
        {
            if(cmbcursos.Text == "")
            {
                MessageBox.Show("Selecione um curso para excluir! ");
            }
            else
            {
                cmbcursos.Items.RemoveAt(cmbcursos.SelectedIndex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int ano;
            for( ano = 2018; ano >= 1980; ano --)
            {
                cmbanonasc.Items.Add(ano.ToString());
            }
        }
    }
}
