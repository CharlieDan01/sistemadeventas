
namespace SISTEMADEVENTAS
{
    partial class frmReportes
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalNoConfirmado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridNoConfirmado = new System.Windows.Forms.DataGridView();
            this.txtTotalConfirmado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridConfirmado = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNoConfirmado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConfirmado)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Cotizaciones No Confirmadas";
            // 
            // txtTotalNoConfirmado
            // 
            this.txtTotalNoConfirmado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNoConfirmado.Location = new System.Drawing.Point(341, 405);
            this.txtTotalNoConfirmado.Name = "txtTotalNoConfirmado";
            this.txtTotalNoConfirmado.ReadOnly = true;
            this.txtTotalNoConfirmado.Size = new System.Drawing.Size(100, 22);
            this.txtTotalNoConfirmado.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "TOTAL";
            // 
            // dataGridNoConfirmado
            // 
            this.dataGridNoConfirmado.AllowUserToAddRows = false;
            this.dataGridNoConfirmado.BackgroundColor = System.Drawing.Color.White;
            this.dataGridNoConfirmado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNoConfirmado.Location = new System.Drawing.Point(36, 238);
            this.dataGridNoConfirmado.Name = "dataGridNoConfirmado";
            this.dataGridNoConfirmado.ReadOnly = true;
            this.dataGridNoConfirmado.Size = new System.Drawing.Size(728, 165);
            this.dataGridNoConfirmado.TabIndex = 25;
            // 
            // txtTotalConfirmado
            // 
            this.txtTotalConfirmado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalConfirmado.Location = new System.Drawing.Point(341, 200);
            this.txtTotalConfirmado.Name = "txtTotalConfirmado";
            this.txtTotalConfirmado.ReadOnly = true;
            this.txtTotalConfirmado.Size = new System.Drawing.Size(100, 22);
            this.txtTotalConfirmado.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "TOTAL";
            // 
            // dataGridConfirmado
            // 
            this.dataGridConfirmado.AllowUserToAddRows = false;
            this.dataGridConfirmado.BackgroundColor = System.Drawing.Color.White;
            this.dataGridConfirmado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConfirmado.Location = new System.Drawing.Point(36, 29);
            this.dataGridConfirmado.Name = "dataGridConfirmado";
            this.dataGridConfirmado.ReadOnly = true;
            this.dataGridConfirmado.Size = new System.Drawing.Size(728, 165);
            this.dataGridConfirmado.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Cotizaciones Confirmadas";
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalNoConfirmado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridNoConfirmado);
            this.Controls.Add(this.txtTotalConfirmado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridConfirmado);
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNoConfirmado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConfirmado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalNoConfirmado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridNoConfirmado;
        private System.Windows.Forms.TextBox txtTotalConfirmado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridConfirmado;
        private System.Windows.Forms.Label label2;
    }
}