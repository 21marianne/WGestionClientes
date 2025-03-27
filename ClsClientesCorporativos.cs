using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WGestionClientes
{
    public class ClsClientesCorporativos: Clientes
    {
        public string LineaCredito { get; set; }
        public bool TieneLineaCredito { get; private set; }

        public ClsClientesCorporativos(string nombre, int id, double saldo) : base(nombre, id, saldo)
        {
            if (saldo >= 50000000)
            {
                LineaCredito = "La linea del crédito ha sido aprobada";
                TieneLineaCredito = true;
            }
            if (saldo < 50000000)
            {
                MessageBox.Show("La línea de Crédito ha sido negada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TieneLineaCredito = false;
            }

        }
            public override double CalcularBeneficio()
        {
         
            return Saldo + (TieneLineaCredito ? 1 : 0); // Convierte true en 1 y false en 0       
        }
        

    }


}
   
