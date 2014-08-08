using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tpAnual
{
    public sealed class Administrador
    {
        private List<Partido> _partidos;
        private List<Jugador> _miembros;

       // private static  Administrador instance = new Administrador();
        private static Administrador instance = null;
         private Administrador() { }

            public static Administrador Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new Administrador();
                        instance.miembros=new List<Jugador>();
                        instance.partidos=new List<Partido>();
    
                    }
                        
                    return instance;
                }

               
            }
     
        public List<Jugador> miembros
        {
            get { return _miembros; }
            set { _miembros = value; }
        }

        public void InitializeComponent()
        {
            this.partidos = new List<Partido>();
            this.miembros = new List<Jugador>();
        }
        public List<Partido> partidos
        {
            get { return _partidos; }
            set {  _partidos = value;}
        }

        public void agregarPartido(Partido unPartido)
        {
            this.partidos.Add(unPartido);
        }
        public void crearPartido(DateTime tiempoYHora,DateTime hora,string Nombre)
        {
            Partido partido = new Partido();
            partido.InitializeComponent();
            partido.fechaYHora = tiempoYHora;
            partido.fechaYHora.AddHours(hora.Hour);
            partido.fechaYHora.AddMinutes(hora.Minute);
            partido.fechaYHora.AddSeconds(hora.Second);
            partido.nombre = Nombre;
            this.partidos.Add(partido);
        }

     public Jugador buscarMiembro(string user)
     {
         return this.miembros.Find(unMiembro => unMiembro.user == user);
     }

        public bool verificarUsuario(string user)
        {
            if(user=="admin")
            {
                return true;
            }

            return Administrador.Instance.miembros.Exists(unMiembro => unMiembro.user == user);
        }

        public bool verificarUsuarioYContra(string user, string contra)
        {
            if(user=="admin"&&contra=="admin")
            {
                return true;
            }
            return Administrador.instance.miembros.Exists(unMiembro =>userYPass(unMiembro,user,contra));
        }

        public bool userYPass(Jugador unMiembro,string user, string contra)
        {
            if((unMiembro.user==user)&&(unMiembro.contra==contra))
            {
                return true;
            }
            return false;
        }

        public bool nombreYContra(Jugador unMiembro,string user,string contra)
        {
           
            if((unMiembro.user==user)&&(unMiembro.contra==contra))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Partido buscarPartido(string nombre)
        {
            return Administrador.Instance.partidos.Find(unPartido=>unPartido.nombre==nombre);
        }
        public int cantidadDePartidos ()
        {
            int cantidad = this.partidos.Count;
            return cantidad;
        }

        public List<Jugador> generarListaDeJugadores(Partido unPartido)
        {
            unPartido.agregarTodosLosEstandar(unPartido.jugadores);
            unPartido.agregarTodosLosSolidarios(unPartido.jugadores);
            unPartido.agregarTodosLosCondicionales(unPartido.jugadores);
            return unPartido.jugadores;
        }




        public bool proponer(string unAmigo)
        {
            bool resultado;
            //Chequear si lo acepta o no

            resultado = true;
            return resultado;
        }
    }
}
