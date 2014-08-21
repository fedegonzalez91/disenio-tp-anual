using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPDisenio2014
{
    public partial class menuUser : Form
    {
        public menuUser()
        {
            InitializeComponent();
        }

        private void menuUser_Load(object sender, EventArgs e)
        {
            labelUser.Text = this.jugadorLogueado.user;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            inscripciones frmInscripcion = new inscripciones();
            frmInscripcion.jugadorLogueado = this.jugadorLogueado;
            this.Hide();
            frmInscripcion.ShowDialog();
            
            this.Show();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Baja frmBaja = new Baja();
            frmBaja.jugadorLogueado = this.jugadorLogueado;
            this.Hide();
            frmBaja.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calificacion frmaCalificacion = new calificacion();
            frmaCalificacion.jugadorLogueado = this.jugadorLogueado;
            this.Hide();
            frmaCalificacion.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recomendacion frmaRecomendacion = new recomendacion();
            frmaRecomendacion.jugadorLogueado = this.jugadorLogueado;
            this.Hide();
            frmaRecomendacion.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            agregarunAmigo frmaAmigo = new agregarunAmigo();
            frmaAmigo.jugadorLogueado = this.jugadorLogueado;
            this.Hide();
            frmaAmigo.ShowDialog();
            this.Show();
        }
    }
}
