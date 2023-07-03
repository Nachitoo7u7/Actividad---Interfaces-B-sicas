using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad___interfaces_Básicas
{
    class calculos
    {
        public double suma(string numero1, string numero2)
        {
            double num1 = double.Parse(numero1); //Convertir numero 1 en double

            double num2 = double.Parse(numero2); //Convertir numero 2 en double

            double resultado = num1 + num2;

            return resultado;
        }

        public double resta(string numero1, string numero2)
        {
            double num1 = double.Parse(numero1); //Convertir numero 1 en double

            double num2 = double.Parse(numero2); //Convertir numero 2 en double

            double resultado = num1 - num2;

            return resultado;
        }

        public double multiplicacion(string numero1, string numero2)
        {
            double num1 = double.Parse(numero1); //Convertir numero 1 en double

            double num2 = double.Parse(numero2); //Convertir numero 2 en double

            double resultado = num1 * num2;

            return resultado;
        }

        public double division(string numero1, string numero2)
        {
            double num1 = double.Parse(numero1); //Convertir numero 1 en double

            double num2 = double.Parse(numero2); //Convertir numero 2 en double

            double resultado = num1 / num2;

            return resultado;
        }

    }
}
