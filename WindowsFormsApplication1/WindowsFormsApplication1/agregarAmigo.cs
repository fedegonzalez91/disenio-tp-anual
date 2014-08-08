using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpAnual
{
       
    public partial class agregarunAmigo : Form
    {
        private Administrador _unAdministrador;
        private Partido _unPartido;
        private Jugador _unJugador;
        public int contador=0;
        private Jugador _jugadorLogueado;

        public Jugador jugadorLogueado
        {
            get { return _jugadorLogueado; }
            set { _jugadorLogueado = value; }
        }


        //private DateTime _FechaYHora;
        public Administrador unAdministrador
        {
            get { return _unAdministrador; }
            set { _unAdministrador = value; }
        }

        public Partido unPartido
        {
            get { return _unPartido; }
            set { _unPartido = value; }
        }

        public Jugador unJugador
        {
            get { return _unJugador; }
            set { _unJugador = value; }
        }

        public agregarunAmigo()
        {
            InitializeComponent();
        }

        private void recomendacion_Load(object sender, EventArgs e)
        {
            if(Administrador.Instance.miembros.Count()==0)
            {
                MessageBox.Show("No hay Jugadores para cargar agregar de amigos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                this.cargarListaJugadores();
                this.unJugador.InitializeComponent();
                labelNombre.Text = this.jugadorLogueado.user;
                listJugadores.Enabled = true;
            }

        }
        
        private void cargarListaJugadores()
        {
            Administrador.Instance.miembros.ForEach(unMiembro =>agregarTodosMenosElmismo (unMiembro));
        }
   

        private void agregarTodosMenosElmismo (Jugador unJugador)
        {
            if(unJugador.user!=this.jugadorLogueado.nombre)
            {
                listJugadores.Items.Add(unJugador.user);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(listJugadores.SelectedIndex==-1)
            {
                MessageBox.Show("Seleccione un Jugador para agregar como amigo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.jugadorLogueado.amigos.Add(Administrador.Instance.buscarMiembro(listJugadores.SelectedItem.ToString()));
                MessageBox.Show("Amigo agregado Exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

 
        private void listJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





        private void textAmigo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void listAmigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAgregarAmigo.Enabled = true;
        }
    }
}
