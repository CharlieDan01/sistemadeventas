
namespace SISTEMADEVENTAS
{
    partial class frmOrdenn
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
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAñadirCotizado = new System.Windows.Forms.Button();
            this.txtTotalCotizado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtIDcliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataGridCotizacion = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciomásIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCotizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // timePicker
            // 
            this.timePicker.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(369, 112);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(187, 22);
            this.timePicker.TabIndex = 60;
            this.timePicker.ValueChanged += new System.EventHandler(this.timePicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "Hora de entrega";
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(369, 68);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(187, 22);
            this.datePicker.TabIndex = 58;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // btnAñadirCotizado
            // 
            this.btnAñadirCotizado.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnAñadirCotizado.FlatAppearance.BorderSize = 0;
            this.btnAñadirCotizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirCotizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirCotizado.ForeColor = System.Drawing.Color.White;
            this.btnAñadirCotizado.Location = new System.Drawing.Point(669, 173);
            this.btnAñadirCotizado.Name = "btnAñadirCotizado";
            this.btnAñadirCotizado.Size = new System.Drawing.Size(103, 23);
            this.btnAñadirCotizado.TabIndex = 57;
            this.btnAñadirCotizado.Text = "Buscar cotizado";
            this.btnAñadirCotizado.UseVisualStyleBackColor = false;
            this.btnAñadirCotizado.Click += new System.EventHandler(this.btnAñadirCotizado_Click);
            // 
            // txtTotalCotizado
            // 
            this.txtTotalCotizado.Location = new System.Drawing.Point(672, 368);
            this.txtTotalCotizado.Name = "txtTotalCotizado";
            this.txtTotalCotizado.ReadOnly = true;
            this.txtTotalCotizado.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCotizado.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(612, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "T O T A L";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "Fecha entrega";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(143, 110);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 22);
            this.txtNombreCliente.TabIndex = 53;
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.txtNombreCliente_TextChanged);
            // 
            // txtIDcliente
            // 
            this.txtIDcliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDcliente.Location = new System.Drawing.Point(143, 71);
            this.txtIDcliente.Name = "txtIDcliente";
            this.txtIDcliente.ReadOnly = true;
            this.txtIDcliente.Size = new System.Drawing.Size(100, 22);
            this.txtIDcliente.TabIndex = 52;
            this.txtIDcliente.TextChanged += new System.EventHandler(this.txtIDcliente_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 32);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nombre \r\ncliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Id cliente";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(576, 87);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 49;
            this.btnGuardar.Text = "Confirmar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dataGridCotizacion
            // 
            this.dataGridCotizacion.AllowUserToAddRows = false;
            this.dataGridCotizacion.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCotizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.partida,
            this.nombreProducto,
            this.cantidad,
            this.precio,
            this.fechaEntrega,
            this.preciomásIva,
            this.idCotizacion});
            this.dataGridCotizacion.Location = new System.Drawing.Point(36, 202);
            this.dataGridCotizacion.Name = "dataGridCotizacion";
            this.dataGridCotizacion.Size = new System.Drawing.Size(736, 162);
            this.dataGridCotizacion.TabIndex = 48;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.Name = "idProducto";
            // 
            // partida
            // 
            this.partida.HeaderText = "partida";
            this.partida.Name = "partida";
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "nombreProducto";
            this.nombreProducto.Name = "nombreProducto";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // precio
            // 
            this.precio.HeaderText = "precio";
            this.precio.Name = "precio";
            // 
            // fechaEntrega
            // 
            this.fechaEntrega.HeaderText = "fechaEntrega";
            this.fechaEntrega.Name = "fechaEntrega";
            // 
            // preciomásIva
            // 
            this.preciomásIva.HeaderText = "precio + IVA";
            this.preciomásIva.Name = "preciomásIva";
            // 
            // idCotizacion
            // 
            this.idCotizacion.HeaderText = "idCotizacion";
            this.idCotizacion.Name = "idCotizacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(601, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "------------>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(666, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "<------------";
            // 
            // frmOrdenn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.btnAñadirCotizado);
            this.Controls.Add(this.txtTotalCotizado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtIDcliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridCotizacion);
            this.Name = "frmOrdenn";
            this.Text = "frmOrdenn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCotizacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnAñadirCotizado;
        public System.Windows.Forms.TextBox txtTotalCotizado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNombreCliente;
        public System.Windows.Forms.TextBox txtIDcliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.DataGridView dataGridCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciomásIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCotizacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}