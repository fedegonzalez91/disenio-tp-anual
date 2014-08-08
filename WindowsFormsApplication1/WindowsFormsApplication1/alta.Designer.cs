namespace tpAnual
{
    partial class Alta
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
            this.fechaPick = new System.Windows.Forms.DateTimePicker();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textContra = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.btnAmigos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fechaPick
            // 
            this.fechaPick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaPick.Location = new System.Drawing.Point(170, 134);
            this.fechaPick.Name = "fechaPick";
            this.fechaPick.Size = new System.Drawing.Size(167, 20);
            this.fechaPick.TabIndex = 28;
            this.fechaPick.ValueChanged += new System.EventHandler(this.fechaPick_ValueChanged);
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(109, 92);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(228, 20);
            this.textApellido.TabIndex = 27;
            this.textApellido.TextChanged += new System.EventHandler(this.textApellido_TextChanged);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(111, 54);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(226, 20);
            this.textNombre.TabIndex = 26;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Fecha de Nacimiento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(44, 92);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 24;
            this.labelApellido.Text = "Apellido";
            this.labelApellido.Click += new System.EventHandler(this.labelApellido_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(44, 54);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 23;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Contraseña";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textContra
            // 
            this.textContra.Location = new System.Drawing.Point(112, 208);
            this.textContra.Name = "textContra";
            this.textContra.Size = new System.Drawing.Size(225, 20);
            this.textContra.TabIndex = 30;
            this.textContra.TextChanged += new System.EventHandler(this.textContra_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 31);
            this.button1.TabIndex = 31;
            this.button1.Text = "Registrarse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nombre Usuario";
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(128, 169);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(207, 20);
            this.textUser.TabIndex = 33;
            // 
            // btnAmigos
            // 
            this.btnAmigos.Location = new System.Drawing.Point(47, 256);
            this.btnAmigos.Name = "btnAmigos";
            this.btnAmigos.Size = new System.Drawing.Size(193, 36);
            this.btnAmigos.TabIndex = 34;
            this.btnAmigos.Text = "Agregar Amigos";
            this.btnAmigos.UseVisualStyleBackColor = true;
            this.btnAmigos.Click += new System.EventHandler(this.btnAmigos_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 31);
            this.button2.TabIndex = 35;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 397);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAmigos);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textContra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechaPick);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alta";
            this.Text = "Alta";
            this.Load += new System.EventHandler(this.alta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fechaPick;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textContra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Button btnAmigos;
        private System.Windows.Forms.Button button2;
    }
}