using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDisenio2014
{

    public class Partido
    {
        private List<Estandar> _jugadoresEstandar;
        private List<Condicional> _jugadoresCondicionales;
        private List<Solidario> _jugadoresSolidarios;
        private List<Jugador> _jugadores;
        private DateTime _fechaYHora;
        private string _nombre;

        public void InitializeComponent()
        {
            this.jugadoresEstandar=new List<Estandar>();
            this.jugadoresCondicionales=new List<Condicional>();
            this.jugadoresSolidarios = new List<Solidario>();
            this.jugadores = new List<Jugador>();

        }
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public List<Estandar> jugadoresEstandar
        {
            get { return _jugadoresEstandar; }
            set { _jugadoresEstandar = value; }
        }
        public List<Condicional> jugadoresCondicionales
        {
            get { return _jugadoresCondicionales; }
            set { _jugadoresCondicionales = value; }
        }
        public List<Solidario> jugadoresSolidarios
        {
            get { return _jugadoresSolidarios; }
            set { _jugadoresSolidarios = value; }
        }
        public List<Jugador> jugadores
        {
            get { return _jugadores; }
            set { _jugadores = value; }
        }
        public DateTime fechaYHora
        {
            get { return _fechaYHora; }
            set { _fechaYHora = value; }
        }




        /*Verifica que haya menos de diez Jugadores Estandar*/
        public bool NoHayDiezEstandar()
        {
            if (this.cantidadEstandar() < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*Agrega los distintos tipos de jugadores a sus respectivas Listas*/
        public void agregarEstandar(Estandar unJugador)
        {
            this.jugadoresEstandar.Add(unJugador);
        }
        public void agregarSolidario(Solidario unJugador)
        {
            this.jugadoresSolidarios.Add(unJugador);
        }

        public void agregarCondicional(Condicional unJugador)
        {
            this.jugadoresCondicionales.Add(unJugador);
        }



        /*Retornan la cantidad de Jugadores de Cada tipo Que hay en el Partido*/
        public int cantidadEstandar()
        {
            return this.jugadoresEstandar.Count;
        }

        public int cantidadSolidarios()
        {
            return this.jugadoresSolidarios.Count;
        }

        public int cantidadCondicionales()
        {
            return this.jugadoresCondicionales.Count;
        }

        /*Retorna la cantidad de Jugadores en Total*/
        public int cantidadTotalJugadores()
        {
            int cantidadTotal = this.cantidadCondicionales() + this.cantidadEstandar() + this.cantidadSolidarios();
            return cantidadTotal;
        }


        /*Elimina de las Listas el primer Elemento*/
        public void eliminarElPrimerCondicional()
        {
            this.jugadoresCondicionales.RemoveAt(0);
        }

        public void eliminarElPrimerSolidario()
        {
            this.jugadoresSolidarios.RemoveAt(0);
        }


        //Agrega Los tipos de Jugadores a una lista
        public void agregarJugador(Jugador unJugador)
        {
            this.jugadores.Add(unJugador);
        }
        public void agregarTodosLosEstandar(List<Jugador> listaDeJugadores)
        {
            int indice;
            for (indice = 0; indice < this.cantidadEstandar(); indice++)
            {
                listaDeJugadores.Add(this.jugadoresEstandar[indice]);
            }
        }


        public void agregarTodosLosSolidarios(List<Jugador> listaDeJugadores)
        {
            int indice;
            for (indice = 0; indice < this.cantidadSolidarios(); indice++)
            {
                listaDeJugadores.Add(this.jugadoresSolidarios[indice]);
            }
        }

        public void agregarTodosLosCondicionales(List<Jugador> listaDeJugadores)
        {
            int indice;
            for (indice = 0; indice < this.cantidadCondicionales(); indice++)
            {
                listaDeJugadores.Add(this.jugadoresCondicionales[indice]);
            }
        }


        public bool estanTodosConfirmados()
        {
            bool resultado = true;
            int indice;
            for (indice = 0; indice < this.cantidadTotalJugadores(); indice++)
            {
                resultado = (resultado) && (this.jugadores[indice].confirmacionDeAsistencia);
            }

            if (resultado == true)
            {
                //Mandar mensaje al Administradir del Sistema
            }
            return resultado;
        }


        public void eliminarEstandar(Estandar unJugador)
        {
            this.jugadores.Remove(unJugador);
            this.jugadoresEstandar.Remove(unJugador);
        }

        public void eliminarSolidario(Solidario unJugador)
        {
            this.jugadores.Remove(unJugador);
            this.jugadoresSolidarios.Remove(unJugador);
        }
        public void eliminarCondicional(Condicional unJugador)
        {
            this.jugadores.Remove(unJugador);
            this.jugadoresCondicionales.Remove(unJugador);
        }

        public bool yaSeJugo(DateTime unaFecha)
        {
            if (this.fechaYHora < unaFecha)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}