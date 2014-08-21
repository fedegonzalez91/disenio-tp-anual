namespace TPDisenio2014
{
    partial class agregarunAmigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarunAmigo));
            this.btnAgregarAmigo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listJugadores = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarAmigo
            // 
            this.btnAgregarAmigo.Location = new System.Drawing.Point(32, 272);
            this.btnAgregarAmigo.Name = "btnAgregarAmigo";
            this.btnAgregarAmigo.Size = new System.Drawing.Size(140, 27);
            this.btnAgregarAmigo.TabIndex = 2;
            this.btnAgregarAmigo.Text = "Agregar Amigo";
            this.btnAgregarAmigo.UseVisualStyleBackColor = true;
            this.btnAgregarAmigo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Jugadores:";
            // 
            // listJugadores
            // 
            this.listJugadores.FormattingEnabled = true;
            this.listJugadores.Location = new System.Drawing.Point(31, 110);
            this.listJugadores.Name = "listJugadores";
            this.listJugadores.Size = new System.Drawing.Size(341, 134);
            this.listJugadores.TabIndex = 7;
            this.listJugadores.SelectedIndexChanged += new System.EventHandler(this.listJugadores_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Jugador:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(76, 22);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(96, 13);
            this.labelNombre.TabIndex = 9;
            this.labelNombre.Text = "Jugador Logueado";
            // 
            // agregarunAmigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 440);
            this.ControlBox = false;
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listJugadores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregarAmigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "agregarunAmigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Amigos";
            this.Load += new System.EventHandler(this.recomendacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarAmigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listJugadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombre;
    }
}