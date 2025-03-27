using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGestionClientes
{
    public abstract class Clientes //Clase Base 
    {
        public string Nombre { get; set; }
        public int ID { get; set; }
        public double Saldo { get; set; }


        public Clientes(string nombre, int iD, double saldo)
        {
         
            //Principio responsabilidad 
            //Validaciones 

            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("Ingrese por favor un nombre del cliente");
            }
            if (iD < 0)
            {
                throw new ArgumentException("Ingrese por favor un ID valido");
            }

            if (saldo <= 0)
            {
                throw new ArgumentException("Ingrese por favor un saldo valido mayor a 0");
            }

            Nombre = nombre;
            ID = iD;
            Saldo = saldo;

        }

        public abstract double CalcularBeneficio();
    }
}
