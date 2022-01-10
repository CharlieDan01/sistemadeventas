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
    public partial class frmUsuario : Form
    {
        public static string nombreUser;
        public static int idUser;
        public static string contraUser;
        static string tipoUsuario;
        public static int idVendedor;
        public static string consulta = "";
        DataSet ds = new DataSet();
        public frmUsuario()
        {
            InitializeComponent();

        }

        private void btnAñadirUsuario_Click(object sender, EventArgs e)
        {
            nombreUser = txtUsernameNuevo.Text;
            contraUser = txtContraseñaNueva.Text;
            idVendedor = cmbVendedor.SelectedIndex;
            tipoUsuario = cmbTipoUsuarioNuevo.Text;

            if (Datos.manejadorr == "SQL SERVER")
            {

                Datos.contarid("SELECT COUNT(*) FROM  usuario");
                idUser = Datos.count;

                consulta = "INSERT INTO Usuario(idUsuario, username, pwd, tipoUsuario, idVendedor, idCompania) VALUES (" + idUser + ",'" + nombreUser + "','" + contraUser + "','" + tipoUsuario + "'," + idVendedor + "," + Datos.company + ")";
                Datos.EjecutarComando(consulta);


            }

            else if (Datos.manejadorr == "MYSQL")
            {


                Datos.contarid("SELECT COUNT(*) FROM  [linkedServer].autos.usuario");
                idUser = Datos.count;

                consulta = "INSERT INTO OPENQUERY (SI,'SELECT username, pwd, tipoUsuario, idVendedor, idCompany FROM autos.USUARIO') VALUES (" + idUser + ",'" + nombreUser + "','" + contraUser + "'," + tipoUsuario + "'," + idVendedor + "," + Datos.company + ")";
                Datos.EjecutarComando(consulta);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            dataGridUsuarios.Enabled = true;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridUsuarios.Rows[dataGridUsuarios.CurrentRow.Index];


            int idUser = Convert.ToInt32(row.Cells[0].Value);
            string nombreUser = row.Cells[1].Value.ToString();
            string contraUser = row.Cells[2].Value.ToString();

            int idVendedor = Convert.ToInt32(row.Cells[4].Value);


            consulta = "EXEC UPDATE_USUARIO '" + Datos.manejadorr + "'," + idUser + ",'" + nombreUser + "','" + contraUser + "'," + idVendedor + "," + Datos.company + "";
            Datos.EjecutarComando(consulta);
            // MessageBox.Show(consulta);

            dataGridUsuarios.Enabled = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;

        }

        private void cmbTipoUsuarioNuevo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            if(Datos.manejadorr=="SQL SERVER")
            {
                consulta = "SELECT idUsuario,username,pwd,tipoUsuario,idVendedor FROM Usuario where idCompania = "+Datos.company;
                Datos.AgregarDataTable(ds, consulta, "Cotizacion", dataGridUsuarios);
            }
            
        }
    }
}
