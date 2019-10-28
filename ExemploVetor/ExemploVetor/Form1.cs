using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploVetor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i; //indice do vetor
        //exemplo declaração do vetor
        //tipo[] nomedoVetor = new tipo[quantPosições]
        string[] vet_Nomes = new string[5];
        string[] vet_Telefones = new string[5];
        int[] vet_idade = new int[5];


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--; // i = i - 1;
                txtNome.Text = vet_Nomes[i];
                mtbTelefone.Text = vet_Telefones[i];
                numidade.Value = vet_idade[i];
                lblindice.Text = "Indice: " + i;
            }
            else
            {
                MessageBox.Show("Já chegou ao inicio do vetor!!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            i = 0; //Definir posição inicial
            //Gravar os nomes no vetor
            vet_Nomes [0] = "João";
            vet_Nomes[1] = "Maria";
            vet_Nomes[2] = "Pedro";
            vet_Nomes[3] = "Joaquina";
            vet_Nomes[4] = "Cirilo";

            //Gravar os telefones no vetor
            vet_Telefones[0] = "11911112222";
            vet_Telefones[1] = "11933334444";
            vet_Telefones[2] = "11955556666";
            vet_Telefones[3] = "11977778888";
            vet_Telefones[4] = "11999990000";

            //Gravar as idades no vetor
            vet_idade[0] = 18;
            vet_idade[1] = 28;
            vet_idade[2] = 38;
            vet_idade[3] = 40;
            vet_idade[4] = 45;

            txtNome.Text = vet_Nomes[i];
            mtbTelefone.Text = vet_Telefones[i];
            numidade.Value = vet_idade[i];
            lblindice.Text = "Indice: " + i;

        }

        private void btnproximo_Click(object sender, EventArgs e)
        {
            if (i < 4)
            {
                i++; // i = i + 1;
                txtNome.Text = vet_Nomes[i];
                mtbTelefone.Text = vet_Telefones[i];
                numidade.Value = vet_idade[i];
                lblindice.Text = "Indice: " + i;
            }
            else
            {
                MessageBox.Show("O Vetor Acabou!!");
            }

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            vet_Nomes[i] = txtNome.Text;
            vet_Telefones[i] = mtbTelefone.Text;
            vet_idade[i] =  Convert.ToInt16(numidade.Value);

            MessageBox.Show("Alterações salvas!");
        }
    }
}
