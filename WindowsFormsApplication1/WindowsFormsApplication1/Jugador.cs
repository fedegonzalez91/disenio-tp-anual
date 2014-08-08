using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpAnual
{
    public class Jugador
    {
        //Atributos
        private List<Critica> _criticas;
        private List<Infraccion> _infracciones;
        private bool _confirmacionDeAsistencia;
        private List<Jugador> _amigos;
        private string _nombre;
        private string _apellido;
        private DateTime _fechaDeNacimiento;
        private int _puntuaciones;
        private int _nivelHandicap;
        private string _contra;
        private string _user;
        private string _tipo = "Jugador";

        public string tipo
        {
            get { return _tipo; }
        }
      

        public string contra
        {
            get { return _contra;}
            set {_contra=value;}
        }
        public string user
        {
            get { return _user; }
            set { _user = value; }
        }
        public int nivelHandicap
        {
            get { return _nivelHandicap; }
            set { _nivelHandicap = value; }
        }
        public void InitializeComponent()
        {
            this.criticas = new List<Critica>();
            this.infracciones = new List<Infraccion>();
            this.confirmacionDeAsistencia = false;
            this.amigos = new List<Jugador>();
            this.puntuaciones = 0;

        }
        public List<Critica> criticas
        {
            get { return _criticas; }
            set { _criticas = value; }

        }
        public void datosPersonalesTodos(string nombre,string apellido,DateTime fecha,string contra,string user)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.contra = contra;
            this.fechaDeNacimiento = fecha;
            this.user = user;
        }

        public void datosPersonales(string nombre,string apellido)
        {
            this.nombre=nombre;
            this.apellido=apellido;
        }

        public void agregarInfraccion(Infraccion nuevaInfraccion)
        {
            this.infracciones.Add(nuevaInfraccion);
        }

        public List<Infraccion> infracciones
        {
            get { return _infracciones; }
            set { _infracciones = value; }
        }
        public bool confirmacionDeAsistencia
        {
            get { return _confirmacionDeAsistencia; }
            set { _confirmacionDeAsistencia = value; }
        }
        public List<Jugador> amigos
        {
            get { return _amigos; }
            set { _amigos = value; }
        }
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public DateTime fechaDeNacimiento
        {
            get { return _fechaDeNacimiento; }
            set { _fechaDeNacimiento = value; }
        }
        public int puntuaciones
        {
            get { return _puntuaciones; }
            set { _puntuaciones = value; }
        }
        public void confirmarAsistencia()
        {
            this.confirmacionDeAsistencia = true;
        }


        public bool generarInfraccion(Jugador otroJugador, Partido unPartido)
        {
            bool hayInfraccion;
            if (otroJugador == null)
            {
                Infraccion infraccion = new Infraccion();
                DateTime diaYHora = new DateTime();
                infraccion.tiempoYHora = diaYHora;
                hayInfraccion = true;
                this.infracciones.Add(infraccion);
                //Settear el Motivo
                //Avisar al Administrador de sistema
            }
            else
            {
                hayInfraccion = false;
            }

            return hayInfraccion;
        }


        public void loadJugador(Partido unPartido,string nombre,string apellido)
        {
            this.InitializeComponent();
            this.datosPersonales(nombre, apellido);
         
        }
        public void proponer(string unAmigo, Partido unPartido,int tipo)
        {
            if (unPartido.unAdministrador.proponer(unAmigo) == true)
            {
                //Cargar los datos
                switch (tipo)
                {
                    case 0:
                        Estandar jugadorAmigo = new Estandar();
                        jugadorAmigo.InitializeComponent();
                        jugadorAmigo.inscribirse(unPartido);
                        break;

                    case 1:
                        Solidario otroAmigo = new Solidario();
                        otroAmigo.InitializeComponent();
                        otroAmigo.inscribirse(unPartido);
                        break;

                    case 2:
                        Condicional otroAmigo1 = new Condicional();
                        otroAmigo1.InitializeComponent();
                        otroAmigo1.inscribirse(unPartido);
                        break;
                }
            }
            else
            {
                Denegacion denegacion = new Denegacion();
                string motivo;
                //Pedir Motiv, es decir, generar los setters
                motivo = "Para que no me tire error";
                denegacion.denegacionSetters(motivo);
            }

        }

        public void calificar(Partido unPartido)
        {
            string mensaje;
            DateTime fechaActual = new DateTime();
            if (unPartido.yaSeJugo(fechaActual) == true)
            {
                int nota;
                string critic;
                int indice;
                for (indice = 0; indice < unPartido.cantidadTotalJugadores(); indice++)
                {
                    nota = Console.Read();
                    critic = Console.ReadLine();
                    Critica critica = new Critica();
                    critica.puntuacionYCriticaSetter(nota, critic);
                    unPartido.jugadores[indice].criticas.Add(critica);
                }
            }
            else
            {
                mensaje = "Es Imposible calificar este partido porque no se ha jugado";
            }
        }

        public void puntuacionSetter(int nota, string critica)
        {
            this.puntuaciones = this.puntuaciones + nota;
        }


    }

}
