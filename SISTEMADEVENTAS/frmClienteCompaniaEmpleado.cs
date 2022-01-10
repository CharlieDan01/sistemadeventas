using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMADEVENTAS
{
    public partial class frmClienteCompaniaEmpleado : Form
    {
        public static string MANEJADOR = Datos.manejadorr;

        public string consulta = "";
        DataSet ds = new DataSet();

        public static string seccion;
        public static int idCompañia;

        public static int idSujeto = 0;

        public static int id;
        public static string nombre;
        public static string apellidos;
        public static string telefono;
        public static string calle;
        public static string numero;
        public static string colonia;
        public static string direccion;
        public static Int16 estatus;
        public static string nombreaBuscar;
        public static int idComp;
        public static string nombreComp;
        public static string telefonoComp;
        public static string direccionComp;
        public static Int16 estatusComp;
        public static int idCliente;
        public frmClienteCompaniaEmpleado(int Compañia, string sección)
        {
            InitializeComponent();
            idCompañia = Compañia;
            seccion = sección;

        }

        private void MostrarRegistros()
        {

            
        }
        private void InsertarRegistros()
        {
            switch(seccion)
                {
                    case "Clientes ON":
                    if (Datos.manejadorr=="SQL SERVER")
                    { 
                      consulta = "INSERT INTO Usuario(idCompania, idCliente, nombre,apellidos, telefono, calle, numero, colonia) VALUES (@idCliente, @idCompania, @nombre, @apellidos, @telefono, @calle, @numero, @colonia)";
                    }
                    else if(Datos.manejadorr == "MYSQL")
                    {
                      consulta = "INSERT INTO OPENQUERY(SI, 'SELECT nombre, apellidos, telefono, calle, numero, colonia FROM autos.cliente') VALUES(@idCliente, @idCompania, @nombre, @apellidos, @telefono, @calle, @numero, @colonia)";
                    }
                    break;

                case "Empleados ON":
                    if (Datos.manejadorr == "SQL SERVER")
                    {

                    } 
                    else if(Datos.manejadorr == "MYSQL")
                    {

                    }
                    break;

                case "Compañia ON":
                    if (Datos.manejadorr == "SQL SERVER")
                    {

                    }
                    else if (Datos.manejadorr == "MYSQL")
                    {

                    }
                    break;
            }

        
        }


        private void btnAñadir_Click(object sender, EventArgs e)
        {
            idComp = Convert.ToInt32(txtidCompania.Text);
            idCliente = Convert.ToInt32(txtidCliente.Text);
            nombre = txtNombre.Text;
            apellidos = txtApellidos.Text;
            telefono = txtTelefono.Text;
            calle = txtTelefono.Text;
            numero = txtNumero.Text;
            colonia = txtColonia.Text;
            


            InsertarRegistros();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmClienteCompaniaEmpleado_Load(object sender, EventArgs e)
        {
            
                MostrarRegistros();

                if (seccion == "Compañias ON")
                {
                    cmbManejador.Visible = true;
                    cmbManejador.Text = MANEJADOR;
                    lblTEXTcompany.Visible = true;
                }
            
        }

        
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void cmbManejador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MostrarRegistros();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
