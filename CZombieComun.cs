using POO23A_MA.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_MA
{
    public class CZombieComun : CZombie
    {
        public CZombieComun(Control AreaDesplazamiento) : base(AreaDesplazamiento)
        {
            int X;
            int Y;

            //Desplaza el zombie por un tiempo indefinido.
            //Nota: se utiliza un hilo de ejecución el cual deberá
            //      ser finalizado al término del programa.

            ProcesoVida = new Thread(() =>
            {
                while (!Muerto)
                {

                    if (Nacido)
                    {
                        //Coordenada de origen.

                        X = Location.X;
                        Y = Location.Y;

                        //Calcula desplazamiento.

                        if (Norte)
                        {
                            Y -= 1;
                        }

                        if (Sur)
                        {
                            Y += 1;
                        }

                        if (Este)
                        {
                            X += 1;
                        }

                        if (Oeste)
                        {
                            X -= 1;
                        }

                        //Procesa el rebote.

                        if (X <= 5)
                        {
                            Oeste = false;
                            Este = true;
                        }

                        if (Y <= AreaDesplazamiento.Height / 2)
                        {
                            Norte = false;
                            Sur = true;
                        }

                        if (X >= AreaDesplazamiento.Width - Width)
                        {
                            Oeste = true;
                            Este = false;
                        }

                        if (Y >= AreaDesplazamiento.Height - Height)
                        {
                            Norte = true;
                            Sur = false;
                        }

                        // Posición final

                        Location = new Point(X, Y);
                        Thread.Sleep(this.Velocidad);
                    }
                }
            });

            ProcesoVida.Start();
        }

        protected override Bitmap FotoZombie()
        {
            return new Bitmap(Resources.Hunter);
        }
    }
}
