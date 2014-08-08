namespace tpAnual
{
    partial class menuAdmin
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
            this.nombreText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fechaPick = new System.Windows.Forms.DateTimePicker();
            this.horaPick = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            // 
            // nombreText
            // 
            this.nombreText.Location = new System.Drawing.Point(25, 61);
            this.nombreText.Name = "nombreText";
            this.nombreText.Size = new System.Drawing.Size(162, 20);
            this.nombreText.TabIndex = 1;
            this.nombreText.TextChanged += new System.EventHandler(this.nombreText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hora";
            // 
            // fechaPick
            // 
            this.fechaPick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaPick.Location = new System.Drawing.Point(28, 121);
            this.fechaPick.Name = "fechaPick";
            this.fechaPick.Size = new System.Drawing.Size(159, 20);
            this.fechaPick.TabIndex = 4;
            // 
            // horaPick
            // 
            this.horaPick.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaPick.Location = new System.Drawing.Point(27, 192);
            this.horaPick.Name = "horaPick";
            this.horaPick.ShowUpDown = true;
            this.horaPick.Size = new System.Drawing.Size(160, 20);
            this.horaPick.TabIndex = 5;
            this.horaPick.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "Generar Partido";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuAdmin
            // 
            this.ClientSize = new System.Drawing.Size(225, 335);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.horaPick);
            this.Controls.Add(this.fechaPick);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nombreText);
            this.Controls.Add(this.label3);
            this.Name = "menuAdmin";
            this.Load += new System.EventHandler(this.menuAdmin_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.DateTimePicker fechaPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker horaPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fechaPick;
        private System.Windows.Forms.DateTimePicker horaPick;
        private System.Windows.Forms.Button button2;
    }
}