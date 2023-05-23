using POO23A_MA.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace POO23A_MA
{
    //-------------------------------------------------------------------------
    //Clase que representa un zombie.
    //MA. 02/05/2023.
    //-------------------------------------------------------------------------

    public class CZombie : PictureBox
    {
        //-------------------------------------------------------------------------
        //Atributos.
        //-------------------------------------------------------------------------

        //Atributos de nacimiento:

        protected int XNacimiento;
        protected int YNacimiento;

        protected SoundPlayer SonidoZombie;
        protected SoundPlayer SonidoMuerte;
        private Bitmap TipoZombie;

        //Atributos del área de desplazamiento:

        protected Control AreaDesplazamiento;
        protected bool Norte;
        protected bool Sur;
        protected bool Este;
        protected bool Oeste;
        protected int Velocidad;

        //Atributos de control:

        protected bool Nacido;
        protected bool Muerto;
        //private bool RegresarACasa;

        //Atributos de ejecucción:

        protected Thread ProcesoVida;

        //-------------------------------------------------------------------------
        //Constructor.
        //-------------------------------------------------------------------------

        public CZombie(Control AreaDesplazamiento) : base()
        {
            Random Aleatorio;

            Aleatorio = new Random();
            XNacimiento = Aleatorio.Next(0, AreaDesplazamiento.Width - 41);
            YNacimiento = Aleatorio.Next(0, AreaDesplazamiento.Height - 41);

            //Inicializa atributos de área de vuelo.

            this.AreaDesplazamiento = AreaDesplazamiento;
            this.AreaDesplazamiento.Controls.Add(this);

            //Construye el zombie.

            Location = new Point(XNacimiento, YNacimiento);
            BackColor = Color.Transparent;
            Name = "Zombie";
            Size = new Size(55, 75);
            TipoZombie = null;
            SonidoZombie = null;

            BringToFront();

            //Inicializa atributos.

            Nacido = false;
            Muerto = false;


            Norte = false;
            Sur = true;
            Este = true;
            Oeste = false;
            Velocidad = 0;
            
            ProcesoVida = null;

            //Método manejador del clic.

            Click += new EventHandler(Matar);
            MouseEnter += new EventHandler(Sonido);
        }

        //-------------------------------------------------------------------------
        //Identifica el zombie.
        //-------------------------------------------------------------------------

        public void Matar (object sender, EventArgs e)
        {
            int[] Localizacion;

            Localizacion = GetAreaLocalizacion();

            MessageBox.Show("Zombie muerto en: " + Localizacion[0] + ", " + Localizacion[1] + ", " + Localizacion[2] + ", " + Localizacion[3]);
            Morir();

        }
        public void Sonido(object sender, EventArgs e)
        {
            SonidoZombie.Play();
        }
        //-------------------------------------------------------------------------
        //Desplaza el zombie.
        //-------------------------------------------------------------------------
        public void Desplazar(int Velocidad)
        {

            int X;
            int Y;

            this.Velocidad = Velocidad;

            //Desplaza el zombie por un tiempo indefinido.
            //NOTA: se utiliza un hilo de ejecucción el cual deberá ser
            //finalizado al término del programa.

            ProcesoVida = new Thread(() =>
            {

                while(!Muerto)
                {
                    if (Nacido)
                    {
                        //Posición Inicial

                        X = Location.X;
                        Y = Location.Y;

                        //Calcula el desplazamiento

                        if (Norte)
                        {
                            Y = Y - 1;
                        }

                        if (Sur)
                        {
                            Y = Y + 1;
                        }

                        if (Este)
                        {
                            X = X + 1;
                        }

                        if (Oeste)
                        {
                            X = X - 1;
                        }

                        //Procesa el rebote.

                        if (X <= 0)
                        {
                            Oeste = false;
                            Este = true;
                        }

                        if (X >= AreaDesplazamiento.Width - 41)
                        {
                            Oeste = true;
                            Este = false;
                        }

                        if (Y <= 0)
                        {
                            Norte = false;
                            Sur = true;
                        }

                        if (Y >= AreaDesplazamiento.Height - 41)
                        {
                            Norte = true;
                            Sur = false;
                        }

                        //Posición final
                        Location = new Point(X, Y);
                        Thread.Sleep(this.Velocidad);
                    }
                }
            });
            ProcesoVida.Start();
        }

        //-------------------------------------------------------------------------
        //Da vida al zombie después de un momento.
        //-------------------------------------------------------------------------
        public void Nacer()
        {
            //Thread ProcesoEjecucion; //Declara
            ////Color ColorNacimiento;

            ////ColorNacimiento = this.ColorNacimiento();

            ////Sistema de colores aleatorios.

            ////Aleatorio = new Random();
            ////R = Aleatorio.Next(0, 255);
            ////G = Aleatorio.Next(0, 255);
            ////B = Aleatorio.Next(0, 255);

            ////ColorAleatorio = Color.FromArgb(R, G, B);


            //ProcesoEjecucion = new Thread(() => //Diseña
            //{
            //    Thread.Sleep(1500);
            //    Nacido = true;

            //});

            //ProcesoEjecucion.Start(); //Arranca o inicia

            TipoZombie = this.FotoZombie();
            SonidoZombie = this.SonidoRugido();
            SonidoMuerte = this.SonidoMorir();
            BackColor = Color.Transparent;
            Image = TipoZombie;
            SizeMode = PictureBoxSizeMode.StretchImage;
            Nacido = true;

            Task.Delay(1500).ContinueWith(_ =>
            {
                // Código adicional a ejecutar después del retraso (si es necesario)
            });
        }

        public void Morir()
        {
            Thread ProcesoMuerte;

            ProcesoMuerte = new Thread(() =>
            {
                Muerto = true;
                SonidoMuerte.Play();
                Thread.Sleep(500);
                Visible = false;
                AreaDesplazamiento.Controls.Remove(this);
                AreaDesplazamiento.Invalidate();
            });

            ProcesoMuerte.Start();
        }

        protected virtual Bitmap FotoZombie()
        {
            return new Bitmap(Resources.Hunter);
        }

        protected virtual SoundPlayer SonidoRugido()
        {
            return new SoundPlayer(Resources.SonidoHunterSalto);
        }

        protected virtual SoundPlayer SonidoMorir()
        {
            return new SoundPlayer(Resources.SonidoHunterMuerte);
        }

        //-------------------------------------------------------------------------
        //Termina el hilo de zombie.
        //-------------------------------------------------------------------------
        protected override void Dispose(bool disposing)
        {
            Muerto = true;
            base.Dispose(disposing);
        }

        //-------------------------------------------------------------------------
        //Colorea el zombie al momento de nacer.
        //-------------------------------------------------------------------------
        protected virtual Color ColorNacimiento()
        {
            return Color.FromArgb(0, 0, 0);
        }

        //-------------------------------------------------------------------------
        //Obtiene el área de localización de un zombie.
        //-------------------------------------------------------------------------
        public int[] GetAreaLocalizacion()
        {
            int[] Localizacion;

            Localizacion = new int[4];

            Localizacion[0] = Location.X;
            Localizacion[1] = Location.Y;
            Localizacion[2] = Location.X + 55;
            Localizacion[3] = Location.Y + 75;

            return Localizacion;
        }
    }
}
