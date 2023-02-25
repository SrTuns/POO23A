using Microsoft.VisualBasic;
using POO23A_MA.Properties;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Media;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace POO23A_MA
{
    //-------------------------------------------------------------------------
    //Diálogo principal del proyecto de prácticas de POO 23A.
    //MA. 24/01/2023.
    //-------------------------------------------------------------------------
    public partial class DlgPrincipal : Form
    {
        //-------------------------------------------------------------------------
        //Atributos.
        //-------------------------------------------------------------------------
        private int Altura; //Atributos - Caracteristicas
        private int Ancho; //Sirven para almacenar un estado/atributo/caracterisitca/propiedades.

        //-------------------------------------------------------------------------
        //Contructor.
        //-------------------------------------------------------------------------
        public DlgPrincipal()
        {
            InitializeComponent();
            Altura = 720;
            Ancho = 1260;
            Text = "A";
        }

        SoundPlayer Reproducir = new SoundPlayer();
        int NumImagen;

        //-------------------------------------------------------------------------
        //Maximiza el diálogo a partir de los atributos.
        //-------------------------------------------------------------------------
        public void Maximizar() //Métodos - Comportamientos
        {
            Height = Altura;
            Width = Ancho;
            Text = "Maximizada.";
        }

        //-------------------------------------------------------------------------
        //Al clic maximiza el diálogo.
        //-------------------------------------------------------------------------
        private void BtnPruebas1_Click(object sender, EventArgs e)
        {
            Maximizar();
        }

        //-------------------------------------------------------------------------
        //Listado de botones para las prácticas (Click).
        //-------------------------------------------------------------------------

        private void BtnPractica1_Click(object sender, EventArgs e)
        {
            DlgPractica1 VP1 = new DlgPractica1();
            VP1.Show();
            this.Close();

            SonidoAbrir();
        }

        private void BtnPractica2_Click(object sender, EventArgs e)
        {
            SonidoBloqueado();
        }

        private void BtnPractica3_Click(object sender, EventArgs e)
        {
            SonidoBloqueado();
        }

        private void BtnPractica4_Click(object sender, EventArgs e)
        {
            SonidoBloqueado();
        }

        private void BtnPractica5_Click(object sender, EventArgs e)
        {
            SonidoBloqueado();
        }

        private void BtnPractica6_Click(object sender, EventArgs e)
        {
            SonidoBloqueado();
        }

        private void BtnPractica7_Click(object sender, EventArgs e)
        {
            SonidoBloqueado();
        }

        private void BtnPractica8_Click(object sender, EventArgs e)
        {
            SonidoBloqueado();
        }

        private void BtnPractica9_Click(object sender, EventArgs e)
        {
            SonidoBloqueado();
        }

        private void BtnPractica10_Click(object sender, EventArgs e)
        {
            SonidoBloqueado();
        }

        //Abrir panel de configuraciones
        private void BtnConfigurar_Click(object sender, EventArgs e)
        {
            DlgConfigurar VConfig = new DlgConfigurar();
            VConfig.Show();
        }

        //-------------------------------------------------------------------------
        //Listado de eventos para los botones de las prácticas (MouseEnter (Entrar al boton)).
        //-------------------------------------------------------------------------
        private void BtnPractica1_MouseEnter(object sender, EventArgs e)
        {
            NumImagen = 1;
            EjecutarFunciones();

            string text = Properties.Resources.Desc1; // Reemplaza "NombreArchivo" con el nombre que le hayas asignado al archivo
            LblDescripcionPractica.Text = text; // Reemplaza "label1" con el nombre de tu Label

        }

        private void BtnPractica2_MouseEnter(object sender, EventArgs e)
        {
            NumImagen = 2;
            EjecutarFunciones();
        }

        private void BtnPractica3_MouseEnter(object sender, EventArgs e)
        {
            NumImagen = 3;
            EjecutarFunciones();
        }

        private void BtnPractica4_MouseEnter(object sender, EventArgs e)
        {
            NumImagen = 4;
            EjecutarFunciones();
        }

        private void BtnPractica5_MouseEnter(object sender, EventArgs e)
        {
            NumImagen = 5;
            EjecutarFunciones();
        }

        private void BtnPractica6_MouseEnter(object sender, EventArgs e)
        {
            NumImagen = 6;
            EjecutarFunciones();
        }

        private void BtnPractica7_MouseEnter(object sender, EventArgs e)
        {
            NumImagen = 7;
            EjecutarFunciones();
        }

        private void BtnPractica8_MouseEnter(object sender, EventArgs e)
        {
            NumImagen = 8;
            EjecutarFunciones();
        }

        private void BtnPractica9_MouseEnter(object sender, EventArgs e)
        {
            NumImagen = 9;
            EjecutarFunciones();
        }

        private void BtnPractica10_MouseEnter(object sender, EventArgs e)
        {
            NumImagen = 10;
            EjecutarFunciones();
        }

        //-------------------------------------------------------------------------
        //Listado de eventos para los botones de las prácticas (MouseLeave (Salir del boton)).
        //-------------------------------------------------------------------------
        private void BtnPractica1_MouseLeave(object sender, EventArgs e)
        {
            QuitarResaltado();
        }

        private void BtnPractica2_MouseLeave(object sender, EventArgs e)
        {
            QuitarResaltado();
        }

        private void BtnPractica3_MouseLeave(object sender, EventArgs e)
        {
            QuitarResaltado();
        }

        private void BtnPractica4_MouseLeave(object sender, EventArgs e)
        {
            QuitarResaltado();
        }

        private void BtnPractica5_MouseLeave(object sender, EventArgs e)
        {
            QuitarResaltado();
        }

        private void BtnPractica6_MouseLeave(object sender, EventArgs e)
        {
            QuitarResaltado();
        }

        private void BtnPractica7_MouseLeave(object sender, EventArgs e)
        {
            QuitarResaltado();
        }

        private void BtnPractica8_MouseLeave(object sender, EventArgs e)
        {
            QuitarResaltado();
        }

        private void BtnPractica9_MouseLeave(object sender, EventArgs e)
        {
            QuitarResaltado();
        }

        private void BtnPractica10_MouseLeave(object sender, EventArgs e)
        {
            QuitarResaltado();
        }

        //-------------------------------------------------------------------------
        //Listado de Métodos.
        //-------------------------------------------------------------------------

        private void SonidoBloqueado()
        {
            Reproducir.Stream = Properties.Resources.Bloqueado;
            Reproducir.Play();
        }

        private void SonidoSeleccion()
        {
            Reproducir.Stream = Properties.Resources.Seleccionado;
            Reproducir.Play();
        }

        private void SonidoAbrir()
        {
            Reproducir.Stream = Properties.Resources.SonidoAbrir;
            Reproducir.Play();
        }

        private void CargarImagen()
        {
            Image Icono;

            switch (NumImagen)
            {
                case 1:
                    Icono = Properties.Resources.ImagenP1;
                    PbxIconoSeleccionado.Image = Icono;
                    break;
                case 2:
                    Icono = Properties.Resources.Práctica_2;
                    PbxIconoSeleccionado.Image = Icono;
                    break;
                case 3:
                    Icono = Properties.Resources.Práctica_3;
                    PbxIconoSeleccionado.Image = Icono;
                    break;
                case 4:
                    Icono = Properties.Resources.Práctica_4;
                    PbxIconoSeleccionado.Image = Icono;
                    break;
                case 5:
                    Icono = Properties.Resources.Práctica_5;
                    PbxIconoSeleccionado.Image = Icono;
                    break;
                case 6:
                    Icono = Properties.Resources.Práctica_6;
                    PbxIconoSeleccionado.Image = Icono;
                    break;
                case 7:
                    Icono = Properties.Resources.Práctica_7;
                    PbxIconoSeleccionado.Image = Icono;
                    break;
                case 8:
                    Icono = Properties.Resources.Práctica_8;
                    PbxIconoSeleccionado.Image = Icono;
                    break;
                case 9:
                    Icono = Properties.Resources.Práctica_9;
                    PbxIconoSeleccionado.Image = Icono;
                    break;
                case 10:
                    Icono = Properties.Resources.Práctica_10;
                    PbxIconoSeleccionado.Image = Icono;
                    break;
            }
        }

        private void CargarDescripcion()
        {
            string filePath = "C:\\Users\\PC\\Documents\\Universidad\\3er Semestre\\Programación Orientada a Objetos\\Descripciones\\Práctica " + NumImagen + ".txt";
            string fileContent = File.ReadAllText(filePath);
            LblDescripcionPractica.Text = fileContent;
        }

        private void PonerResaltado()
        {
            switch (NumImagen)
            {
                case 1:
                    BtnPractica1.BackgroundImage = Properties.Resources.Resaltado;
                    break;
                case 2:
                    BtnPractica2.BackgroundImage = Properties.Resources.Resaltado;
                    break;
                case 3:
                    BtnPractica3.BackgroundImage = Properties.Resources.Resaltado;
                    break;
                case 4:
                    BtnPractica4.BackgroundImage = Properties.Resources.Resaltado;
                    break;
                case 5:
                    BtnPractica5.BackgroundImage = Properties.Resources.Resaltado;
                    break;
                case 6:
                    BtnPractica6.BackgroundImage = Properties.Resources.Resaltado;
                    break;
                case 7:
                    BtnPractica7.BackgroundImage = Properties.Resources.Resaltado;
                    break;
                case 8:
                    BtnPractica8.BackgroundImage = Properties.Resources.Resaltado;
                    break;
                case 9:
                    BtnPractica9.BackgroundImage = Properties.Resources.Resaltado;
                    break;
                case 10:
                    BtnPractica10.BackgroundImage = Properties.Resources.Resaltado;
                    break;
            }
        }

        private void QuitarResaltado()
        {
            switch (NumImagen)
            {
                case 1:
                    BtnPractica1.BackgroundImage = null;
                    break;
                case 2:
                    BtnPractica2.BackgroundImage = null;
                    break;
                case 3:
                    BtnPractica3.BackgroundImage = null;
                    break;
                case 4:
                    BtnPractica4.BackgroundImage = null;
                    break;
                case 5:
                    BtnPractica5.BackgroundImage = null;
                    break;
                case 6:
                    BtnPractica6.BackgroundImage = null;
                    break;
                case 7:
                    BtnPractica7.BackgroundImage = null;
                    break;
                case 8:
                    BtnPractica8.BackgroundImage = null;
                    break;
                case 9:
                    BtnPractica9.BackgroundImage = null;
                    break;
                case 10:
                    BtnPractica10.BackgroundImage = null;
                    break;
            }
        }

        private void EjecutarFunciones()
        {
            SonidoSeleccion();
            //CargarDescripcion();
            CargarImagen();
            PonerResaltado();
        }
    }
}