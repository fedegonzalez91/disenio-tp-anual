using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace TPDisenio2014
{
    public partial class inscripciones : Form
    {
        private int _check = 1;
        private Partido _partido;
        private int _primerVez;

        public int primeraVez
        {
            get { return _primerVez; }
            set { _primerVez = value; }
        }

        public Partido partido
        {
            get { return _partido; }
            set { _partido = value; }
        }

        public int check
        {
            get { return _check; }
            set { _check = value; }

        }
        //private DateTime _FechaYHora;

        private static Mutex mut = new Mutex();
  
        public inscripciones()
        {
            InitializeComponent();
        }

        private void limpiarListBox ()
        {
            int cont;
            for(cont=0;listPartidos.Items.Count<cont;cont++)
            {
                listPartidos.Items.RemoveAt(cont);
            }
            
        }
        private void inscripciones_Load(object sender, EventArgs e)
        {
            this.limpiarListBox();
            this.primeraVez = 0;
            if (Administrador.Instance.cantidadDePartidos() == 0)
            {
                MessageBox.Show("No hay partido para inscribirse", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                if(this.primeraVez==0)
                {
                    cargarLista();
                    this.primeraVez = primeraVez + 1;
                }
               
            }
          
        }

        private void cargarLista()
        {
            Administrador.Instance.partidos.ForEach(unPartido => agregarUnPartido(unPartido));
        }

        private void agregarUnPartido(Partido unPartido)
        {
            if (listPartidos.Items.Contains(unPartido.nombre)==false)
            {

                listPartidos.Items.Add(unPartido.nombre);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void listPartidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.partido = Administrador.Instance.buscarPartido(listPartidos.SelectedItem.ToString());

            cargarEstandar();
            cargarCondicional();
            cargarSolidario();

        }
        private void cargarEstandar()
        {
            string nombre = " Estandar";
            if(this.partido.cantidadEstandar()>0)
            {
                this.partido.jugadoresEstandar.ForEach(unEstandar => listJugadores.Items.Add(string.Concat(unEstandar.user, nombre)));
            }
            
        }
        private void cargarSolidario()
        {

            string nombre = " Solidario";
            if (this.partido.cantidadSolidarios() > 0)
            {
                this.partido.jugadoresSolidarios.ForEach(unSolidario => listJugadores.Items.Add(string.Concat(unSolidario.user, nombre)));
            }
        }
        private void cargarCondicional()
        {
            string nombre = " Condicional";
            if (this.partido.cantidadCondicionales() > 0)
            {
                this.partido.jugadoresCondicionales.ForEach(unCondicional => listJugadores.Items.Add(string.Concat(unCondicional.user, nombre)));
            }
        }



        private void listTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnIns.Enabled = true;
        }
        private void ponerEnabled()
        {
            btnIns.Enabled = true;
            listTipo.Enabled = true;
        }
        private void listPartidos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.limpiarListBox();
            if(listPartidos.SelectedIndex!=-1)
            {
                this.partido = Administrador.Instance.buscarPartido(listPartidos.SelectedItem.ToString());
                this.ponerEnabled();
                this.cargarEstandar();
                this.cargarSolidario();
                this.cargarCondicional();
            }



        }

        private void agregarJugadores(Jugador unJugador)
        {
            if (listPartidos.Items.Contains(unJugador.user) == false)
            {

                listPartidos.Items.Add(unJugador.user);
            }
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            string mensaje;
            string cabecera;
            if (listPartidos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un partido", "Campo No Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Agregar el partido seleccionado
                Administrador.Instance.agregarPartido(this.partido);
                //Jugador jugador=new Jugador();
                switch (listTipo.SelectedItem.ToString())
                {
                    case "Estandar":
                        {
                            Estandar jugador = new Estandar();
                            jugador.user = this.jugadorLogueado.user;
                            jugador.InitializeComponent();
                            mensaje = jugador.inscribirse(this.partido);
                            MessageBox.Show(mensaje, "Estandar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;

                    case "Solidario":
                        {
                            Solidario jugador = new Solidario();
                            jugador.user = this.jugadorLogueado.user;
                            jugador.InitializeComponent();
                            mensaje = jugador.inscribirse(this.partido);
                            cabecera = "Solidario";
                            MessageBox.Show(mensaje, "Solidario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;

                    case "Condicional":
                        {
                            Condicional jugador = new Condicional();
                            jugador.user =this.jugadorLogueado.user;
                            jugador.InitializeComponent();
                            mensaje = jugador.inscribirse(this.partido);
                            MessageBox.Show(mensaje, "Condicional", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                }
                this.partido.jugadores.Add(this.jugadorLogueado);
                listPartidos.Items.Clear();
                listJugadores.Items.Clear();
                this.Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listJugadores.ClearSelected();
            listPartidos.ClearSelected();
            this.Close();
        }
    }
}
