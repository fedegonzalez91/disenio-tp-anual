namespace tpAnual
{
    partial class inscripciones
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
            this.listJugadores = new System.Windows.Forms.ListBox();
            this.listTipo = new System.Windows.Forms.ListBox();
            this.btnIns = new System.Windows.Forms.Button();
            this.listPartidos = new System.Windows.Forms.ListBox();
            this.labelPartidos = new System.Windows.Forms.Label();
            this.labelInscripcion = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listJugadores
            // 
            this.listJugadores.Enabled = false;
            this.listJugadores.FormattingEnabled = true;
            this.listJugadores.Location = new System.Drawing.Point(251, 106);
            this.listJugadores.Name = "listJugadores";
            this.listJugadores.Size = new System.Drawing.Size(180, 160);
            this.listJugadores.TabIndex = 29;
            // 
            // listTipo
            // 
            this.listTipo.Enabled = false;
            this.listTipo.FormattingEnabled = true;
            this.listTipo.Items.AddRange(new object[] {
            "Estandar",
            "Solidario",
            "Condicional"});
            this.listTipo.Location = new System.Drawing.Point(35, 146);
            this.listTipo.Name = "listTipo";
            this.listTipo.Size = new System.Drawing.Size(96, 43);
            this.listTipo.TabIndex = 28;
            // 
            // btnIns
            // 
            this.btnIns.Enabled = false;
            this.btnIns.Location = new System.Drawing.Point(35, 205);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(166, 43);
            this.btnIns.TabIndex = 27;
            this.btnIns.Text = "Inscribirse";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // listPartidos
            // 
            this.listPartidos.FormattingEnabled = true;
            this.listPartidos.Location = new System.Drawing.Point(35, 46);
            this.listPartidos.Name = "listPartidos";
            this.listPartidos.Size = new System.Drawing.Size(397, 43);
            this.listPartidos.TabIndex = 26;
            this.listPartidos.SelectedIndexChanged += new System.EventHandler(this.listPartidos_SelectedIndexChanged_1);
            // 
            // labelPartidos
            // 
            this.labelPartidos.AutoSize = true;
            this.labelPartidos.Location = new System.Drawing.Point(35, 17);
            this.labelPartidos.Name = "labelPartidos";
            this.labelPartidos.Size = new System.Drawing.Size(107, 13);
            this.labelPartidos.TabIndex = 25;
            this.labelPartidos.Text = "Seleccione el Partido";
            // 
            // labelInscripcion
            // 
            this.labelInscripcion.AutoSize = true;
            this.labelInscripcion.Location = new System.Drawing.Point(32, 108);
            this.labelInscripcion.Name = "labelInscripcion";
            this.labelInscripcion.Size = new System.Drawing.Size(100, 13);
            this.labelInscripcion.TabIndex = 24;
            this.labelInscripcion.Text = "Tipo de Inscripción:";
            this.labelInscripcion.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 39);
            this.button2.TabIndex = 23;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // inscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 338);
            this.ControlBox = false;
            this.Controls.Add(this.listJugadores);
            this.Controls.Add(this.listTipo);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.listPartidos);
            this.Controls.Add(this.labelPartidos);
            this.Controls.Add(this.labelInscripcion);
            this.Controls.Add(this.button2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "inscripciones";
            this.Text = "Inscripciones";
            this.Load += new System.EventHandler(this.inscripciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listJugadores;
        private System.Windows.Forms.ListBox listTipo;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.ListBox listPartidos;
        private System.Windows.Forms.Label labelPartidos;
        private System.Windows.Forms.Label labelInscripcion;
        private System.Windows.Forms.Button button2;
    }
}