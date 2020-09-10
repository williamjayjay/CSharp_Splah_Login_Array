using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash_Screen
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[4];
            vetor[0] = 7;
            vetor[1] = 3;
            vetor[2] = 5;
            vetor[3] = 1;
            //int valor = vetor[1];
            //System.Array.Sort(vetor);
            for (int index = 0; index < 4; index++)
                MessageBox.Show(vetor[index].ToString(),
                    "Array");
        }

        private void btnVetorTextos_Click(object sender, EventArgs e)
        {
            string[] semana = new string[7];
            semana[0] = "Domingo";
            semana[1] = "Segunda-Feira";
            semana[2] = "Terça-Feira";
            semana[3] = "Quarta-Feira";
            semana[4] = "Quinta-Feira";
            semana[5] = "Sexta-Feira";
            semana[6] = "Sábado";

            string valor = semana[1];
            for (int index = 0; index < 7; index++)
                MessageBox.Show(semana[index].ToString(),
                    "Array");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Array_Multi novo = new Array_Multi();
            novo.Show();
            this.Visible = false;
        }
    }
}
