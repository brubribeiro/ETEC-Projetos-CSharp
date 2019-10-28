using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploRandom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random objeto = new Random();
        private void btnSortear_Click(object sender, EventArgs e)
        {
            int numero;
            numero = objeto.Next(1, 4);

            //lblResultado.Text = "Resultado: " + numero.ToString();

            switch (numero)
            {
                case 1:
                    lblResultado.Text = "Abiguin";
                    ptbSorteio.Image = Properties.Resources.antes;
                    break;

                    case 2:
                    lblResultado.Text = "Beijin";
                    ptbSorteio.Image = Properties.Resources.antes2;
                    break;

                case 3:
                    lblResultado.Text = "Nunca nem vi";
                    ptbSorteio.Image = Properties.Resources.antes3;
                    break;

            }
        }
    }
}
