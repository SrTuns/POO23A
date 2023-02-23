using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_MA
{
    //-------------------------------------------------------------------------
    //Clase Personal (Control Remoto).
    //MA. 21/02/2023.
    //-------------------------------------------------------------------------
    internal class CControlRemoto
    {
        //-------------------------------------------------------------------------
        //Atributos.
        //-------------------------------------------------------------------------
        private string Color; //Formato Hexadecimal (#ABC123)
        private int Marca;//1° Hisense - 2° LG - 3° Steren - 4° Azaela
        private int Estado;//1° Encendido - 2° Apagado
        private string ID;//6 Dígitos (1° - 3° Dígito = Numero 1-3-5 de color) (4° Dígito = Numero de Marca) (5° Dígito = NumBotones ) (6° Dígito = Primera letra de marca)
        private int NumVolumen;
        private int NumCanal;
        private int NumBotones;

        private int Error;

        //-------------------------------------------------------------------------
        //Contructor.
        //-------------------------------------------------------------------------

        public CControlRemoto(int Marca)
        {
            //Recibe Atributos.
            this.Marca = Marca;

            //Inicializa atributos.
            Color = "#";
            Estado = 0;
            ID = "";
            NumBotones = 0;
            NumCanal = 0;
            NumVolumen = 0;

            Error = 0;

        }

        public int Encender()
        {
            return 0;
        }

        public int GetError()
        {
            return Error; //
        }

        //public int CambiarCanal()
        //{

        //}

        //public int CambiarVolumen()
        //{

        //}
    }
}
