using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMADEVENTAS
{
    class Datos
    {
        private static string cadenaConexion = "Server=DESKTOP-V25DGP1 ;Database = autos; Trusted_Connection = True;";

        private static SqlConnection conexion = new SqlConnection(cadenaConexion);

        public static string manejadorr;
        public int idSujeto;
        public static int idVendedor;
        public static int registroAfectados = 0;
        public static SqlCommand cmd;
        public static string consulta = "";
        public static int count = 0;
        public static int idUsuario = 0;


        public static int company;
        public static void Login(string username, string contraseña, frmLogin thiss, string manejador, int idCompany, string nameCompany)
        {
            company = idCompany;
            manejadorr = manejador;

            try
            {
                conexion.Open();
                switch (manejadorr)
                {
                    case "MYSQL":
                        {
                            cmd = new SqlCommand("SELECT username, pwd, tipoUsuario, idVendedor FROM OPENQUERY([SI], 'Select * from autos.usuario')WHERE username = @username AND pwd = @contraseña AND idCompania = @idCompañia", conexion);
                            break;
                        }
                    case "SQL SERVER":
                        {
                            cmd = new SqlCommand("SELECT username, pwd, tipoUsuario, idVendedor FROM usuario WHERE username = @username AND pwd = @contraseña", conexion);
                            break;
                           
                        }

                    case "ORACLE":
                        {
                            cmd = new SqlCommand("SELECT username, pwd, tipoUsuario, idVendedor FROM usuario WHERE username = @username AND pwd = @contraseña", conexion);
                            break;

                        }

                }
            
            

                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("contraseña", contraseña);
                cmd.Parameters.AddWithValue("idCompañia", company);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {

                    idVendedor = Convert.ToInt32(dt.Rows[0][3]);

                    if (dt.Rows[0][2].ToString() == "admin")
                    {

                        frmPrincipal frrm = new frmPrincipal("admin", idVendedor, nameCompany, username, company);
                        frrm.Show();

                    }
                    else if (dt.Rows[0][2].ToString() == "user")
                    {
                        frmPrincipal frrm = new frmPrincipal("user", idVendedor, nameCompany, username, company);
                        frrm.Show();
                    }
                    thiss.Hide();
                }
                else
                {
                    MessageBox.Show("Por favor, verifique que los datos proporcionados sean correctos.");
                }
            }
           
                finally
                {
                    conexion.Close();
                }
        }

        public static void contarid(string consulta)
        {
            conexion.Open();
            SqlCommand cont = new SqlCommand(consulta, conexion);
            count = (int)cont.ExecuteScalar();
            count++;
            conexion.Close();
        }

        public static void AgregarDataTable(DataSet ds, string consulta, string nombreTabla, DataGridView DataGridView1a)
        {
            SqlDataAdapter da = new SqlDataAdapter(consulta, cadenaConexion);
            ds = new DataSet();
            da.Fill(ds, nombreTabla);
            DataGridView1a.DataSource = ds.Tables["Cotizacion"];
            DataGridView1a.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public static int EjecutarComando(string consulta)
        {

            try
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                registroAfectados = comando.ExecuteNonQuery();

                if (registroAfectados != 0)
                {
                    MessageBox.Show("Los cambios se realizaron correctamente, por favor actualize la tabla");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hubo un error al intentar realizar la operación, verifique que sus datos sean correctos\n" + ex.Message);
            }

            conexion.Close();
            return registroAfectados;

        }

        public static int RealizarConsulta(string consulta)
        {
            int registroAfectados = 0;
            SqlCommand comando = new SqlCommand(consulta, conexion);
            conexion.Open();
            registroAfectados = comando.ExecuteNonQuery();
            conexion.Close();
            return registroAfectados;
        }

        public static void AñadirUsuario(string username, string contraseña, string tipoUsuario, int idVendedor, Control control)
        {
            switch (manejadorr)
            {
                case "SQL SERVER":
                    {
                        cmd = new SqlCommand("SELECT username, idUsuario FROM Usuario WHERE username = @username AND idVendedor = @idVendedor  AND idCompania = @idCompañia", conexion);
                        break;
                    }
                case "MYSQL":
                    {
                        cmd = new SqlCommand(" SELECT username, idUsuario FROM OPENQUERY([SI], 'Select * from autos.usuario')WHERE username = @username AND idVendedor = @idVendedor  AND idCompany = @idCompañia", conexion);
                        break;
                    }

            }
            try
            {
                conexion.Open();


                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("idVendedor", idVendedor);
                cmd.Parameters.AddWithValue("idCompañia", company);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                conexion.Close();

                if (dt.Rows.Count == 1)
                {
                    idUsuario = Convert.ToInt32(dt.Rows[0][1]);
                    //MessageBox.Show("El usuario ya existe");
                    if (MessageBox.Show("El usuario ya existe, desea actualizar la contraseña? ", "El usuario ya existe", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        consulta = "UPDATE_USUARIO_InLOGIN '" + manejadorr + "'," + idUsuario + ",'" + contraseña + "'," + idVendedor + "," + company;
                        Datos.EjecutarComando(consulta);

                        MessageBox.Show("Se ha actualizado la contraseña correctamente, por favor cierre esta ventana y refresque la tabla ");
                        ControlsClear(control);
                    }
                }
                else
                {
                    //bdahjdbhajbdhajbdhajbdhjadhjasbdhjsadb
                    consulta = "INSERT_Usuario '" + manejadorr + "'," + idUsuario + ",'" + username + "', '" + contraseña + "', '" + tipoUsuario + "'," + idVendedor + "," + company;

                    Datos.EjecutarComando(consulta);
                    MessageBox.Show("Se ha añadido el registro exitosamente, por favor cierre esta ventana y refresque la tabla ");
                    ControlsClear(control);
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Hay un conflicto con la id empleado y compañia, por favor verifique que sean correctas o coinciden " + e);
            }



        }

        public static void ControlsClear(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
            }
        }


        
        public static void cmdCompanyLlenar()
        {

        }
    }
}

    
