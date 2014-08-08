namespace tpAnual
{
    partial class Baja
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
            this.btnBaja = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listPartidos = new System.Windows.Forms.ListBox();
            this.listJugadores = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(26, 290);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(157, 33);
            this.btnBaja.TabIndex = 0;
            this.btnBaja.Text = "Dar de Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listPartidos
            // 
            this.listPartidos.FormattingEnabled = true;
            this.listPartidos.Location = new System.Drawing.Point(26, 45);
            this.listPartidos.Name = "listPartidos";
            this.listPartidos.ScrollAlwaysVisible = true;
            this.listPartidos.Size = new System.Drawing.Size(387, 69);
            this.listPartidos.TabIndex = 2;
            this.listPartidos.SelectedIndexChanged += new System.EventHandler(this.listPartidos_SelectedIndexChanged);
            // 
            // listJugadores
            // 
            this.listJugadores.Enabled = false;
            this.listJugadores.FormattingEnabled = true;
            this.listJugadores.Location = new System.Drawing.Point(26, 163);
            this.listJugadores.Name = "listJugadores";
            this.listJugadores.ScrollAlwaysVisible = true;
            this.listJugadores.Size = new System.Drawing.Size(387, 56);
            this.listJugadores.TabIndex = 3;
            this.listJugadores.SelectedIndexChanged += new System.EventHandler(this.listJugadores_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Partidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jugadores Reemplazantes";
            // 
            // Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 429);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listJugadores);
            this.Controls.Add(this.listPartidos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBaja);
            this.Name = "Baja";
            this.Text = "Baja";
            this.Load += new System.EventHandler(this.Baja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listPartidos;
        private System.Windows.Forms.ListBox listJugadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}