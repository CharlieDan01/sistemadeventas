
namespace SISTEMADEVENTAS
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.cmbSelectCompany = new System.Windows.Forms.ComboBox();
            this.btnLoginSalir = new System.Windows.Forms.Button();
            this.cmbSelectDataBase = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoginIngresar = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Items.AddRange(new object[] {
            "Jesus",
            "Ireth"});
            this.cmbUsuarios.Location = new System.Drawing.Point(319, 31);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(173, 24);
            this.cmbUsuarios.TabIndex = 59;
            this.cmbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarios_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(331, 93);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 20);
            this.checkBox1.TabIndex = 58;
            this.checkBox1.Text = "Mostrar contraseña";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.DimGray;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.Black;
            this.txtContraseña.Location = new System.Drawing.Point(318, 66);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(174, 15);
            this.txtContraseña.TabIndex = 48;
            this.txtContraseña.Text = "123";
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // cmbSelectCompany
            // 
            this.cmbSelectCompany.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectCompany.FormattingEnabled = true;
            this.cmbSelectCompany.Items.AddRange(new object[] {
            "concesiones gutierrez"});
            this.cmbSelectCompany.Location = new System.Drawing.Point(12, 66);
            this.cmbSelectCompany.Name = "cmbSelectCompany";
            this.cmbSelectCompany.Size = new System.Drawing.Size(173, 24);
            this.cmbSelectCompany.TabIndex = 53;
            this.cmbSelectCompany.SelectedIndexChanged += new System.EventHandler(this.cmbSelectCompany_SelectedIndexChanged);
            // 
            // btnLoginSalir
            // 
            this.btnLoginSalir.BackColor = System.Drawing.Color.Black;
            this.btnLoginSalir.FlatAppearance.BorderSize = 0;
            this.btnLoginSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginSalir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginSalir.ForeColor = System.Drawing.Color.White;
            this.btnLoginSalir.Location = new System.Drawing.Point(544, 68);
            this.btnLoginSalir.Name = "btnLoginSalir";
            this.btnLoginSalir.Size = new System.Drawing.Size(173, 34);
            this.btnLoginSalir.TabIndex = 52;
            this.btnLoginSalir.Text = "Salir";
            this.btnLoginSalir.UseVisualStyleBackColor = false;
            this.btnLoginSalir.Click += new System.EventHandler(this.btnLoginSalir_Click);
            // 
            // cmbSelectDataBase
            // 
            this.cmbSelectDataBase.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectDataBase.FormattingEnabled = true;
            this.cmbSelectDataBase.Items.AddRange(new object[] {
            "SQL SERVER",
            "MYSQL",
            "ORACLE"});
            this.cmbSelectDataBase.Location = new System.Drawing.Point(12, 19);
            this.cmbSelectDataBase.Name = "cmbSelectDataBase";
            this.cmbSelectDataBase.Size = new System.Drawing.Size(121, 24);
            this.cmbSelectDataBase.TabIndex = 51;
            this.cmbSelectDataBase.Text = "SQL SERVER";
            this.cmbSelectDataBase.SelectedIndexChanged += new System.EventHandler(this.cmbSelectDataBase_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(239, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "Contraseña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(261, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Usuario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLoginIngresar
            // 
            this.btnLoginIngresar.BackColor = System.Drawing.Color.Black;
            this.btnLoginIngresar.FlatAppearance.BorderSize = 0;
            this.btnLoginIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginIngresar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginIngresar.ForeColor = System.Drawing.Color.White;
            this.btnLoginIngresar.Location = new System.Drawing.Point(544, 31);
            this.btnLoginIngresar.Name = "btnLoginIngresar";
            this.btnLoginIngresar.Size = new System.Drawing.Size(174, 31);
            this.btnLoginIngresar.TabIndex = 47;
            this.btnLoginIngresar.Text = "Entrar";
            this.btnLoginIngresar.UseVisualStyleBackColor = false;
            this.btnLoginIngresar.Click += new System.EventHandler(this.btnLoginIngresar_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(316, 116);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(175, 13);
            this.linkLabel2.TabIndex = 56;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "____________________________";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(319, 58);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(175, 13);
            this.linkLabel1.TabIndex = 57;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "____________________________";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 142);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.cmbSelectCompany);
            this.Controls.Add(this.btnLoginSalir);
            this.Controls.Add(this.cmbSelectDataBase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLoginIngresar);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.ComboBox cmbSelectCompany;
        private System.Windows.Forms.Button btnLoginSalir;
        private System.Windows.Forms.ComboBox cmbSelectDataBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoginIngresar;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}