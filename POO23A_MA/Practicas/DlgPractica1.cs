using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO23A_MA.Cosas;

namespace POO23A_MA
{
    //-------------------------------------------------------------------------
    //Diálogo de la práctica 1.
    //MA. 07/02/2023.
    //-------------------------------------------------------------------------

    public partial class DlgPractica1 : Form
    {
        //-------------------------------------------------------------------------
        //Atributos.
        //-------------------------------------------------------------------------

        //-------------------------------------------------------------------------
        //Constructor.
        //-------------------------------------------------------------------------
        public DlgPractica1()
        {
            InitializeComponent();
            string filePath = "C:\\Users\\PC\\Documents\\Universidad\\3er Semestre\\Programación Orientada a Objetos\\Descripciones\\Práctica 1.txt";
            string fileContent = File.ReadAllText(filePath);
            LblDescripcion.Text = "Descripción: " + fileContent;
        }

        SoundPlayer Reproducir = new SoundPlayer();

        //-------------------------------------------------------------------------
        //Botón para cerrar práctica.
        //-------------------------------------------------------------------------

        private void PbxIconoPractica1_Click(object sender, EventArgs e)
        {
            DlgPrincipal VDlgP = new DlgPrincipal();
            VDlgP.Show();

            this.Close();

            Reproducir.Stream = Properties.Resources.SonidoCerrar;
            Reproducir.Play();
        }

        private void BtnCalculadora_Click(object sender, EventArgs e)
        {
            CCalculadoraBasica MiCalculadora;
            double Resultado;

            MiCalculadora = new CCalculadoraBasica(2, 3);
            Resultado = MiCalculadora.Suma();
            MessageBox.Show("El resultado de la suma es " + Resultado.ToString());

            Resultado = MiCalculadora.Resta();
            MessageBox.Show("El resultado de la resta es " + Resultado.ToString());

            Resultado = MiCalculadora.Multiplica();
            MessageBox.Show("El resultado de la multiplicación es " + Resultado.ToString());

            Resultado = MiCalculadora.Divide();
            MessageBox.Show("El resultado de la división es " + Resultado.ToString());
        }
    }
}
