using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WGestionClientes
{
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            //Traer variables

            string nombre = txtNombre.Text;
            int id = int.Parse(txtId.Text);
            double saldo = double.Parse(txtSaldo.Text);
            string tipo =cmbTipoCliente.SelectedItem.ToString();

            //VALIDACIONES DE DATOS --- Regla 1 

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

             //REVISAR CONDICIONES DEL SALDO 


            if (!double.TryParse(txtSaldo.Text, out saldo) || saldo <= 0)
            {
                MessageBox.Show("Ingrese un saldo valido mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtId.Text, out id) || id < 0) 
            {
                MessageBox.Show("Ingrese por favor un ID valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                //FACTORY

                Clientes nuevocliente = ClientesFactory.CrearCliente(tipo, nombre, id, saldo);
                GestorClientes.Instancia.AgregarCliente(nuevocliente);
                MessageBox.Show("Se ha garegado el cliente satisfactoriamente!","Información",MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #region[Combo Empleados]
        private void Clientes_Load(object sender, EventArgs e)
        {

            
            cmbTipoCliente.SelectedIndex = 0;
            
        }
        #endregion
        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtSaldo.Clear();
            txtId.Clear();
            cmbTipoCliente.SelectedItem = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                {
                    lstClientes.Items.Clear();
                    foreach (var cli in GestorClientes.Instancia.NuevosClientes())
                    {
                        lstClientes.Items.Add($"{cli.Nombre} - Salario: {cli.CalcularBeneficio()}");

                    }
                }
            }
        }

    }
}
