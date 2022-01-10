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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLoginSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea cerrar el programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (txtContraseña.PasswordChar == '*')
                {
                    txtContraseña.PasswordChar = '\0';
                }

            }
            else
            {
                txtContraseña.PasswordChar = '●';
            }
        }

        private void cmbSelectDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Datos.cmdCompanyLlenar(cmbSelectCompany, cmbSelectDataBase);
        }

        private void btnLoginIngresar_Click(object sender, EventArgs e)
        {
            Datos.Login(cmbUsuarios.Text, txtContraseña.Text, this, cmbSelectDataBase.Text, cmbSelectCompany.SelectedIndex + 1, cmbSelectCompany.Text);
        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSelectCompany_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
