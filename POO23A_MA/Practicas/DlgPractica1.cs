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

        //-------------------------------------------------------------------------
        //Crea 3 objetos de calculadora en variables independientes..
        //-------------------------------------------------------------------------
        private void BtnCalculadora_Click(object sender, EventArgs e)
        {
            CCalculadoraBasica MiCalculadora1;
            CCalculadoraBasica MiCalculadora2;
            CCalculadoraBasica MiCalculadora3;
            double Resultado;
            double Sumatoria;

            //Se crean las calculadoras.

            MiCalculadora1 = new CCalculadoraBasica(1, 2);
            MiCalculadora2 = new CCalculadoraBasica(3, 4);
            MiCalculadora3 = new CCalculadoraBasica(5, 6);

            //Se agregan a la lista.

            List<CCalculadoraBasica> MiListaCalculadoras;
            MiListaCalculadoras = new List<CCalculadoraBasica>();//Constructor
            MiListaCalculadoras.Add(MiCalculadora1);
            MiListaCalculadoras.Add(MiCalculadora2);
            MiListaCalculadoras.Add(MiCalculadora3);

            //Se realizan operaciones.

            Resultado = MiCalculadora1.Multiplica();
            MessageBox.Show("El resultado de la multiplicación en calc 1 es  " + Resultado.ToString());

            Resultado = MiCalculadora2.Multiplica();
            MessageBox.Show("El resultado de la multiplicación en calc 2 es  " + Resultado.ToString());

            Resultado = MiCalculadora3.Multiplica();
            MessageBox.Show("El resultado de la multiplicación en calc 3 es  " + Resultado.ToString());

            //Recorre la lista de calculadoras para obtener su resultado.

            Sumatoria = 0;

            foreach (CCalculadoraBasica CalculadoraAux in MiListaCalculadoras)
            {
                double ResultadoDesdeLista;

                ResultadoDesdeLista = CalculadoraAux.GetResultado();

                MessageBox.Show("El resultado obtenido dentro de la lista es " + ResultadoDesdeLista);

                Sumatoria = Sumatoria + CalculadoraAux.GetResultado();
            }

            MessageBox.Show("La sumatoria de los resultados de las calculadoras es " + Sumatoria);

            //Efecto Resta-Multiplicación-División

            Resultado = MiCalculadora1.Resta();
            MessageBox.Show("El resultado de la resta es " + Resultado.ToString());

            Resultado = MiCalculadora1.Multiplica();
            MessageBox.Show("El resultado de la multiplicación es " + Resultado.ToString());

            Resultado = MiCalculadora1.Divide();
            MessageBox.Show("El resultado de la división es " + Resultado.ToString());
        }

        //-------------------------------------------------------------------------
        //Crea 100 objetos de calculadora dentro de un Iterador.
        //-------------------------------------------------------------------------
        private void Btn100Calculadoras_Click(object sender, EventArgs e)
        {
            CCalculadoraBasica MiCalculadora1;
            List<CCalculadoraBasica> MiListaCalculadoras;

            MiListaCalculadoras = new List<CCalculadoraBasica>();

            double Aux = 1;

            for (int i = 0; i < 100; i++)
            {
                MiCalculadora1 = new CCalculadoraBasica(Aux, Aux + 1);
                MiCalculadora1.Multiplica();
                MiListaCalculadoras.Add(MiCalculadora1);

                Aux = Aux + 2;
            }

            double Sumatoria;
            Sumatoria = 0;

            foreach (CCalculadoraBasica CalculadoraAux in MiListaCalculadoras)
            {
                Sumatoria = Sumatoria + CalculadoraAux.GetResultado();
            }

            MessageBox.Show(Sumatoria.ToString());
        }
    }
}
