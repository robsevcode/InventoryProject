using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bodega
{
    public partial class formNuevoCliente : formPlantilla
    {
        public formNuevoCliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();

        }

        private void formNuevoContacto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsClientes.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.dsClientes.Cliente);
            this.clienteBindingSource.AddNew();
        }

        private void nombreTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (nombreTextBox.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(nombreTextBox,
                    "introduzca el nombre del cliente");
            }
            else
            {
                errorProvider1.SetError(nombreTextBox, string.Empty);
            }
        }

        private void apellidoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (apellidoTextBox.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(apellidoTextBox,
                    "introduzca el apellido del cliente");
            }
            else
            {
                errorProvider1.SetError(apellidoTextBox, string.Empty);
            }
        }

        private void direccionTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (nombreTextBox.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(direccionTextBox,
                    "introduzca la direccion");
            }
            else
            {
                errorProvider1.SetError(direccionTextBox, string.Empty);
            }
        }

        private void clienteBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            bool validacion = true;
            Random rnd = new Random();
            int Id_cliente;
            // Método para generar ID único de Cliente
            do
            {
                Id_cliente = rnd.Next(10000, 99999);
                for (int i = 0; i <= dsClientes.Cliente.count - 1; i++)
                    if (Id_cliente == dsClientes.Cliente[i].Id_cliente)
                        validacion = false;
            } while (!validacion);
            groupBox1.Controls[1].Text = Convert.ToString(Id_cliente);
            if (this.Validate())
            {
                try
                {
                    this.clienteBindingSource.EndEdit();
                    this.clienteTableAdapter.Update(this.dsClientes.cliente);
                    MessageBox.Show(this, "Cliente Agregado:" +
                    dsClientes.cliente[clienteBindingSource.Position].
                    Nombre + dsClientes.cliente[clienteBindingSource.Position].Apellido, "Guardar", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
                MessageBox.Show(this, "Errores de validación.", "Guardar",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }
    }
}
