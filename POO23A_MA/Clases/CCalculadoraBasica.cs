using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_MA.Cosas
{
    //-------------------------------------------------------------------------
    //Clase que representa una calculadora básica.
    //MA. 07/02/2023.
    //-------------------------------------------------------------------------
    public class CCalculadoraBasica
    {
        //-------------------------------------------------------------------------
        //Atributos.
        //-------------------------------------------------------------------------
        private double Operando1;
        private double Operando2;
        private double Resultado;

        //-------------------------------------------------------------------------
        //Contructor.
        //-------------------------------------------------------------------------
        public CCalculadoraBasica(double Operando1, double Operando2)
        {
            this.Operando1 = Operando1;
            this.Operando2 = Operando2;
        }

        //-------------------------------------------------------------------------
        //Suma los operandos.
        //-------------------------------------------------------------------------
        public double Suma()
        {
            Resultado = Operando1 + Operando2;
            return Resultado;
        }

        //-------------------------------------------------------------------------
        //Resta los operandos.
        //-------------------------------------------------------------------------
        public double Resta()
        {
            Resultado = Operando1 - Operando2;
            return Resultado;
        }

        //-------------------------------------------------------------------------
        //Multiplica los operandos.
        //-------------------------------------------------------------------------
        public double Multiplica()
        {
            Resultado = Operando1 * Operando2;
            return Resultado;
        }

        //-------------------------------------------------------------------------
        //Divide los operandos.
        //-------------------------------------------------------------------------
        public double Divide()
        {
            if (Operando2 != 0)
            {
                Resultado = Operando1 / Operando2;
            }
            else
            {
                Resultado = -1; //Error.
            }

            return Resultado;
        }
    }
}
