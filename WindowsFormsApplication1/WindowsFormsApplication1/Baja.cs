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
    public partial class Baja : Form
    {
        private Partido _partido;
        private Jugador _jugadorLogueado;
        private Jugador _jugadorReemplazante;
        private string _tipoEliminado;

        public string tipoEliminado
        {
            get { return _tipoEliminado; }
            set { _tipoEliminado = value; }
        }

        public Jugador jugadorLogueado
        {
            get { return _jugadorLogueado; }
            set { _jugadorLogueado = value; }
        }
        public Jugador jugadorReemplazante
        {
            get { return _jugadorReemplazante; }
            set { _jugadorReemplazante = value; }
        }

        public Partido partido
        {
            get { return _partido; }
            set { _partido = value; }
        }

        public Jugador jugador
        {
            get { return _jugadorLogueado; }
            set { _jugadorLogueado = value; }
        }
        public Baja()
        {
            InitializeComponent();
        }

        private void Baja_Load(object sender, EventArgs e)
        {
            if(Administrador.Instance.partidos.Count==0)
            {
                MessageBox.Show("No hay partido para darse de baja", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

                Administrador.Instance.partidos.ForEach(unPartido =>agregarUnPartido(unPartido));

         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.partido.jugadores.Remove(this.jugadorLogueado);
            this.eliminarDeListas();
            if(listJugadores.SelectedIndex==-1)
            {
                //Se genera una infraccion
                Infraccion nuevaInfraccion = new Infraccion();
                nuevaInfraccion.motivo = "No selecciona a nadie cuando se da de Baja";
                nuevaInfraccion.tiempoYHora = DateTime.Now;
                this.jugadorLogueado.agregarInfraccion(nuevaInfraccion);
                MessageBox.Show("Se ha generado una infracción.", "No seleccionó ningún reemplazante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Baja exitosa sin recomendación", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {

                this.partido.agregarJugador(this.jugadorReemplazante);
                switch(this.tipoEliminado)
                {
                    case "Estandar":
                    {
                        Estandar nuevoJugador = new Estandar();
                        nuevoJugador.user = this.jugadorReemplazante.user;
                        nuevoJugador.inscribirse(this.partido);
                    }   
                    break;
                    case "Condicional":
                    {
                        Condicional nuevoJugador = new Condicional();
                        nuevoJugador.user = this.jugadorReemplazante.user;
                        nuevoJugador.inscribirse(this.partido);
                    }     
                    break;
                    case "Solidario":
                    {
                        Solidario nuevoJugador = new Solidario();
                        nuevoJugador.user = this.jugadorReemplazante.user;
                        nuevoJugador.inscribirse(this.partido);
                    }  
                    break;
                }
                MessageBox.Show("Baja y recomendación exitosa","Operación Exitosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            
        }

        private void eliminarDeListas()
        {

                Condicional unCondicional = new Condicional();
                unCondicional = this.partido.jugadoresCondicionales.Find(unJugador => unJugador.user == this.jugadorLogueado.user);
                if (unCondicional != null)
                {
                    unCondicional.eliminar(this.partido);
                    this.tipoEliminado = "Condicional";
                }
            

                Estandar unEstandar = new Estandar();
                unEstandar = this.partido.jugadoresEstandar.Find(unJugador => unJugador.user == this.jugadorLogueado.user);
                if (unEstandar != null)
                {
                    unEstandar.eliminar(this.partido);
                    this.tipoEliminado = "Estandar";
                }
            

            
        
            Solidario unSolidario = new Solidario();
            unSolidario = this.partido.jugadoresSolidarios.Find(unJugador => unJugador.user == this.jugadorLogueado.user);
            if (unSolidario != null)
            {
                unSolidario.eliminar(this.partido);
                this.tipoEliminado = "Solidario";
            }
               
            
        }

        private void agregarUnPartido(Partido unPartido)
        {
            if (listPartidos.Items.Contains(unPartido.nombre) == false)
            {

                listPartidos.Items.Add(unPartido.nombre);
            }
        }
        private void listPartidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            listJugadores.Enabled = true;
            this.partido = Administrador.Instance.partidos.Find(unPartido => unPartido.nombre == listPartidos.SelectedItem.ToString());
            this.cargarJugadores(this.partido);
        }

        private void cargarJugadores(Partido unPartido)
        {
            Administrador.Instance.miembros.ForEach(unJugador => this.cargarLista(unJugador));
        }

        private void cargarLista(Jugador unJugador)
        {
            listJugadores.Items.Add(unJugador.user);
        }
        private void listJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.jugadorReemplazante = Administrador.Instance.buscarMiembro(listJugadores.SelectedItem.ToString());
            btnBaja.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
