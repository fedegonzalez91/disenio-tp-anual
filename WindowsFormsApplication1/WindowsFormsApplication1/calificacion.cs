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

    public partial class calificacion : Form

    {
        private Administrador _unAdministrador;
        private Partido _unPartido;
        private int _contador;
        private Jugador _jugadorTemporal;
        private int _nota;
        private List<Partido> _partidos;
        private Jugador _jugadorLogueado;
        private List<Partido> _partidosJugados;

        public List<Partido> partidosJugados
        {
            get { return _partidosJugados; }
            set { _partidosJugados = value; }
        }

        public Jugador jugadorLogueado
        {
            get { return _jugadorLogueado; }
            set { _jugadorLogueado = value; }
        }


        public int nota
        {
            get { return _nota;}
            set { _nota = value; }
        }
        public Jugador jugadorTemporal
        {
            get { return _jugadorTemporal; }
            set { _jugadorTemporal = value; }
        }

        public int contador
        {
            get { return _contador;}
            set { _contador = value;}
        }


        public Partido unPartido
        {
            get { return _unPartido; }
            set { _unPartido = value;}
        }

        public Administrador unAdministrador
        {
            get { return _unAdministrador; }
            set { _unAdministrador = value; }
        }
        public calificacion()
        {
            InitializeComponent();
        }

        public void cargarLista()
        {
            this.partidosJugados.ForEach(unPartido => agregarUnPartido(unPartido));
        }
        private void agregarUnPartido(Partido unPartido)
        {
            if (listPartidos.Items.Contains(unPartido.nombre) == false)
            {

                listPartidos.Items.Add(unPartido.nombre);
            }
        }

        //Delegar lógica a la clase Administrador
    
        public void partidosDelJugador()
        {
           this.partidosJugados=Administrador.Instance.partidos.Where(unPartido => this.participaElJugador(unPartido)).ToList();
        }
        public bool participaElJugador(Partido unPartido)
        {
            return unPartido.jugadores.Exists(unJugador => unJugador.user == this.jugadorLogueado.user);
        }
        private void calificacion_Load(object sender, EventArgs e)
        {
            this.partidosDelJugador();
            if(this.partidosJugados.Count()==0)
            {
                MessageBox.Show("No hay partidos para para calificar","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                this.cargarLista();
            }
            this.contador = 0;
            this.jugadorTemporal.InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listPartidos_SelectedIndexChanged(object sender, EventArgs e)
        {
                this.unPartido = Administrador.Instance.buscarPartido(listPartidos.SelectedItem.ToString()); 
                btnCCalificar.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            btnCCalificar.Enabled = false;
            textCritica.Enabled = true;
            btnCalificar.Enabled = true;
            habilitarChecks();
            //this.unAdministrador.generarListaDeJugadores(this.unPartido);
            if(this.unPartido.cantidadTotalJugadores()==0)
            {
                MessageBox.Show("No hay Jugadores Inscriptos en este Partido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Close();
            }
            else
            {
                labelJugador.Text = this.unPartido.jugadores[this.contador].nombre.ToString();
                this.jugadorTemporal = this.unPartido.jugadores[this.contador];
            }
        }

        private void habilitarChecks()
        {
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            radioButton7.Enabled = true;
            radioButton8.Enabled = true;
            radioButton9.Enabled = true;
            radioButton10.Enabled = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textCritica.Text))
            {
                MessageBox.Show("Ingrese una Crítica", "Campo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textCritica.BackColor = Color.Red;
            }
            else
            {
                Critica nuevaCritica = new Critica();
                nuevaCritica.critica = textCritica.Text;
                nuevaCritica.puntuacion = this.nota;
                this.unPartido.jugadores[this.contador].criticas.Add(nuevaCritica);
                MessageBox.Show("Jugador calificado", "Informe", MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.contador = this.contador + 1;
                if (this.unPartido.cantidadTotalJugadores() <=this.contador)
                {
                    MessageBox.Show("Fin de Calificación. No hay más jugadores para calificar.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                        labelJugador.Text = this.unPartido.jugadores[this.contador].nombre;
                        this.jugadorTemporal = this.unPartido.jugadores[this.contador];
                        textCritica.Clear();
                }
            }
            
        }

        private void textCritica_TextChanged(object sender, EventArgs e)
        {
            textCritica.BackColor = Color.White;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.nota = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.nota = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.nota = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.nota = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.nota = 5;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.nota = 6;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            this.nota = 7;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            this.nota = 8;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            this.nota = 9;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            this.nota = 10;
        }
    }
}
