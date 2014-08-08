namespace tpAnual
{
    partial class recomendacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recomendacion));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecomendar = new System.Windows.Forms.Button();
            this.listAmigos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listPartidos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listJugadores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amigos";
            // 
            // btnRecomendar
            // 
            this.btnRecomendar.Enabled = false;
            this.btnRecomendar.Location = new System.Drawing.Point(304, 385);
            this.btnRecomendar.Name = "btnRecomendar";
            this.btnRecomendar.Size = new System.Drawing.Size(140, 27);
            this.btnRecomendar.TabIndex = 2;
            this.btnRecomendar.Text = "Recomendar";
            this.btnRecomendar.UseVisualStyleBackColor = true;
            this.btnRecomendar.Click += new System.EventHandler(this.button1_Click);
            // 
            // listAmigos
            // 
            this.listAmigos.Enabled = false;
            this.listAmigos.FormattingEnabled = true;
            this.listAmigos.Location = new System.Drawing.Point(32, 271);
            this.listAmigos.Name = "listAmigos";
            this.listAmigos.Size = new System.Drawing.Size(204, 43);
            this.listAmigos.TabIndex = 3;
            this.listAmigos.SelectedIndexChanged += new System.EventHandler(this.listAmigos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Partidos";
            // 
            // listPartidos
            // 
            this.listPartidos.FormattingEnabled = true;
            this.listPartidos.Location = new System.Drawing.Point(26, 53);
            this.listPartidos.Name = "listPartidos";
            this.listPartidos.Size = new System.Drawing.Size(417, 69);
            this.listPartidos.TabIndex = 5;
            this.listPartidos.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Jugadores:";
            // 
            // listJugadores
            // 
            this.listJugadores.Enabled = false;
            this.listJugadores.FormattingEnabled = true;
            this.listJugadores.Location = new System.Drawing.Point(29, 164);
            this.listJugadores.Name = "listJugadores";
            this.listJugadores.Size = new System.Drawing.Size(413, 69);
            this.listJugadores.TabIndex = 7;
            this.listJugadores.SelectedIndexChanged += new System.EventHandler(this.listJugadores_SelectedIndexChanged);
            // 
            // recomendacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 440);
            this.ControlBox = false;
            this.Controls.Add(this.listJugadores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listPartidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listAmigos);
            this.Controls.Add(this.btnRecomendar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "recomendacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recomendación";
            this.Load += new System.EventHandler(this.recomendacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecomendar;
        private System.Windows.Forms.ListBox listAmigos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listPartidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listJugadores;
    }
}