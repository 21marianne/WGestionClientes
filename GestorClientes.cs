using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGestionClientes
{
    public class GestorClientes
    {

        private static GestorClientes _instancia;
        private List<Clientes> clientes;

        private GestorClientes()
        {
            clientes= new List<Clientes>();
        }

        public static GestorClientes Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new GestorClientes();
                }
                return _instancia;
            }
        }
        public void AgregarCliente(Clientes cliente)
        {
            clientes.Add(cliente);
        }

        public List<Clientes> NuevosClientes()
        {
            return clientes;
        }








    }
}
