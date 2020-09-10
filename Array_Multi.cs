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
    public partial class Array_Multi : Form
    {
        public Array_Multi()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            novo.Show();
            this.Visible = false;
        }

        private void btnArrM_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[2, 4];
            notas[0, 0] = 8.0;
            notas[0, 1] = 20;
            notas[0, 2] = 2;
            notas[0, 3] = 19;
            notas[1, 0] = 13;
            notas[1, 1] = 3;
            notas[1, 2] = 15;
            notas[1, 3] = 25;

            //MessageBox.Show(notas[0, 1].ToString(), "Array");

            for (int x = 0; x < 2; x++)
                for (int y = 0; y < 4; y++)
                    MessageBox.Show(notas[x, y].ToString(), "Array");
            //aqui temos um laço for dentro de outro laço for, oque ocorre é que ele executa os valores
            //dentro do array de 2 posições[coluna, linha].

        }
    }
}
