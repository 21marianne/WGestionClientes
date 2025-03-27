using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WGestionClientes
{

    public class ClsClientesIndividuales: Clientes
    {

        public const int LimiteCuentas = 3; 
        public int CantidadCuentasActivas { get; private set; }

        public ClsClientesIndividuales(string nombre, int id, double saldo) : base(nombre, id, saldo)
        {
            if (CantidadCuentasActivas <= LimiteCuentas)
            {

                throw new ArgumentException("El cliente ya cuenta con un límite de cuentas creadas");

            }     

        }
        public override double CalcularBeneficio()
        {

            return CantidadCuentasActivas;
        }


        //listas crud
    }
}
