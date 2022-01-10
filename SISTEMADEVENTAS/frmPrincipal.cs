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
    public partial class frmPrincipal : Form
    {
        public string tipoUsuario; 

        public string user;
        public int vendedor;
        public string Compañia;
        public int idCompañia;

        public frmPrincipal(string tipopUsuario, int idVendedor, string nameCompany, string username, int idCompany)
        {
            InitializeComponent();
            tipoUsuario = tipopUsuario;
            user = username;
            vendedor = idVendedor;
            Compañia = nameCompany;
            idCompañia = idCompany;

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUsuario frmUsuarios = new frmUsuario();
                frmUsuarios.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmUsuario)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmUsuarios.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void compaiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           try
            {
                frmClienteCompaniaEmpleado frmUsuarios = new frmClienteCompaniaEmpleado(idCompañia, "Compañias ON");
                frmUsuarios.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmClienteCompaniaEmpleado)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmUsuarios.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmOrdenn frmOrden = new frmOrdenn();
                frmOrden.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmOrdenn)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmOrden.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmProdyCondiciones frmReportes = new frmProdyCondiciones();
                frmReportes.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmProdyCondiciones)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmReportes.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmClienteCompaniaEmpleado frmClientes = new frmClienteCompaniaEmpleado(idCompañia, "Clientes ON");
                frmClientes.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmClienteCompaniaEmpleado)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmClientes.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmClienteCompaniaEmpleado frmClientes = new frmClienteCompaniaEmpleado(idCompañia, "Empleados ON");
                frmClientes.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmClienteCompaniaEmpleado)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmClientes.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void condicionesDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmProdyCondiciones frmProductosyCondiciones = new frmProdyCondiciones();
                frmProductosyCondiciones.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmProdyCondiciones)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmProductosyCondiciones.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void todasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmReportes frmReportes = new frmReportes();
                frmReportes.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmReportes)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmReportes.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevaOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmOrdenn frmOrden = new frmOrdenn();
                frmOrden.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmOrdenn)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmOrden.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void todasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmReportes frmReportes = new frmReportes();
                frmReportes.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmReportes)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmReportes.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
