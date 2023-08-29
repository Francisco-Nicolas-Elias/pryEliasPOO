namespace pryEliasPOO
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCrearPersonaje = new System.Windows.Forms.Button();
            this.txtFuerza = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDestreza = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFuerza = new System.Windows.Forms.Label();
            this.lblDestreza = new System.Windows.Forms.Label();
            this.lblDatosDeLoCreado = new System.Windows.Forms.Label();
            this.lblMostrarDatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrearPersonaje
            // 
            this.btnCrearPersonaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearPersonaje.Location = new System.Drawing.Point(12, 114);
            this.btnCrearPersonaje.Name = "btnCrearPersonaje";
            this.btnCrearPersonaje.Size = new System.Drawing.Size(100, 43);
            this.btnCrearPersonaje.TabIndex = 3;
            this.btnCrearPersonaje.Text = "Crear personaje";
            this.btnCrearPersonaje.UseVisualStyleBackColor = true;
            this.btnCrearPersonaje.Click += new System.EventHandler(this.btnCrearPersonaje_Click);
            // 
            // txtFuerza
            // 
            this.txtFuerza.Location = new System.Drawing.Point(80, 48);
            this.txtFuerza.Name = "txtFuerza";
            this.txtFuerza.Size = new System.Drawing.Size(36, 22);
            this.txtFuerza.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(80, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(105, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // txtDestreza
            // 
            this.txtDestreza.Location = new System.Drawing.Point(80, 76);
            this.txtDestreza.Name = "txtDestreza";
            this.txtDestreza.Size = new System.Drawing.Size(37, 22);
            this.txtDestreza.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFuerza
            // 
            this.lblFuerza.AutoSize = true;
            this.lblFuerza.Location = new System.Drawing.Point(12, 54);
            this.lblFuerza.Name = "lblFuerza";
            this.lblFuerza.Size = new System.Drawing.Size(55, 16);
            this.lblFuerza.TabIndex = 5;
            this.lblFuerza.Text = "Fuerza:";
            // 
            // lblDestreza
            // 
            this.lblDestreza.AutoSize = true;
            this.lblDestreza.Location = new System.Drawing.Point(12, 82);
            this.lblDestreza.Name = "lblDestreza";
            this.lblDestreza.Size = new System.Drawing.Size(66, 16);
            this.lblDestreza.TabIndex = 6;
            this.lblDestreza.Text = "Destreza:";
            // 
            // lblDatosDeLoCreado
            // 
            this.lblDatosDeLoCreado.AutoSize = true;
            this.lblDatosDeLoCreado.Location = new System.Drawing.Point(12, 174);
            this.lblDatosDeLoCreado.Name = "lblDatosDeLoCreado";
            this.lblDatosDeLoCreado.Size = new System.Drawing.Size(236, 16);
            this.lblDatosDeLoCreado.TabIndex = 7;
            this.lblDatosDeLoCreado.Text = "Aquí los datos de los que creamos...";
            // 
            // lblMostrarDatos
            // 
            this.lblMostrarDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostrarDatos.Location = new System.Drawing.Point(15, 207);
            this.lblMostrarDatos.Name = "lblMostrarDatos";
            this.lblMostrarDatos.Size = new System.Drawing.Size(179, 56);
            this.lblMostrarDatos.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 289);
            this.Controls.Add(this.lblMostrarDatos);
            this.Controls.Add(this.lblDatosDeLoCreado);
            this.Controls.Add(this.lblDestreza);
            this.Controls.Add(this.lblFuerza);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtDestreza);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtFuerza);
            this.Controls.Add(this.btnCrearPersonaje);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creación de personajes";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearPersonaje;
        private System.Windows.Forms.TextBox txtFuerza;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDestreza;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFuerza;
        private System.Windows.Forms.Label lblDestreza;
        private System.Windows.Forms.Label lblDatosDeLoCreado;
        private System.Windows.Forms.Label lblMostrarDatos;
    }
}

