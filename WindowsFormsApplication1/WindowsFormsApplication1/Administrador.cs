using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tpAnual
{
    public sealed class JugadorLogueado:Jugador
    {
      
        private static JugadorLogueado instance = null;
         private JugadorLogueado() { }

            public static JugadorLogueado Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new JugadorLogueado();
                    }      
                    return instance;
                }

               
            }
     
        /* Agregado como procedure en SQL
        public void agregarPartido(Partido unPartido)
        {
            this.partidos.Add(unPartido);
        }*/
        /* Agregado como procedure en SQL
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
        }*/
    /* Agregado como procedure en SQL
     public Jugador buscarMiembro(string user)
     {
         return this.miembros.Find(unMiembro => unMiembro.user == user);
     }
     */
        /*Agregado como procedure en SQL
        public bool verificarUsuario(string user)
        {
            if(user=="admin")
            {
                return true;
            }

            return Administrador.Instance.miembros.Exists(unMiembro => unMiembro.user == user);
        }
        */

        /* Agregado como procedure en SQL
        public bool verificarUsuarioYContra(string user, string contra)
        {
            if(user=="admin"&&contra=="admin")
            {
                return true;
            }
            return Administrador.instance.miembros.Exists(unMiembro =>userYPass(unMiembro,user,contra));
        }*/

        /* Agregado como procedure en el SQL
        public bool userYPass(Jugador unMiembro,string user, string contra)
        {
            if((unMiembro.user==user)&&(unMiembro.contra==contra))
            {
                return true;
            }
            return false;
        }
        */

        /* Agregado como procedure en SQL
        public Partido buscarPartido(string nombre)
        {
            return Administrador.Instance.partidos.Find(unPartido=>unPartido.nombre==nombre);
        }
         * */

        /* Agregado como procedure en SQL
        public int cantidadDePartidos ()
        {
            int cantidad = this.partidos.Count;
            return cantidad;
        }*/

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
