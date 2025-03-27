using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGestionClientes
{
   public class ClientesFactory
    {

        public static Clientes CrearCliente(string tipo, string nombre, int id, double saldo)
        {


            if (tipo == "Clientes Corporativos")
            {

                return new ClsClientesCorporativos(nombre, id, saldo);


            }
            else if (tipo == "Clientes Individuales")
            {
                return new ClsClientesIndividuales(nombre, id, saldo);

            }
            else
            {
                throw new ArgumentException("Tipo de cliente no valido");
            }


        }
  
       
    }

    
}
