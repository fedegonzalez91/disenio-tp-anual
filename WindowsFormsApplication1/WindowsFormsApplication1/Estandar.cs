using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDisenio2014
{
    public class Estandar : Jugador
    {
        private bool _confirmacionDeAsistencia;
        private string _tipo="Estandar";

        public string tipo
        {
            get { return _tipo;}
        }

        public bool confirmacionDeAsistencia
        {
            get { return _confirmacionDeAsistencia; }
            set { _confirmacionDeAsistencia = value; }
        }

        
        public string inscribirse(Partido unPartido)
        {
            string mensaje;
            if (unPartido.NoHayDiezEstandar() == true)
            {

                if (unPartido.cantidadTotalJugadores() >= 10)
                {
                    if (unPartido.cantidadCondicionales()>0)
                    {
                        unPartido.eliminarElPrimerCondicional();
                        mensaje = "Se ha removido un jugador Condicional y se ha agregado con éxito al jugador Estandar";
                        //Avisar a los amigos que se inscribió
                    }
                    else
                    {
                            unPartido.eliminarElPrimerSolidario();
                            mensaje = "Se ha removido un jugador Solidario y se ha agregado con éxito al jugador Estandar";
                            //Avisar a los amigos que se inscribir
                              
                    }
                }
                else
                {
                    mensaje = "Se ha agregado con éxito al jugador de tipo Estandar";
                    //Avisar a los amigos que se inscribió
                }
                //Se agrega al jugador Estandar nuevo
                unPartido.agregarEstandar(this);
               
            }
            else
            {
                mensaje = "Hay diez Jugadores tipo Estandar Inscriptos. Inscripción denegada";
            }
            return mensaje;
        }

        public int eliminar(Partido unPartido)
        {
             unPartido.jugadoresEstandar.Remove(this);
             return 1;
        }

        public void bajaDeUnJugadorDe(Partido unPartido, Estandar otroJugador)
        {
            unPartido.eliminarEstandar(this);
            if (generarInfraccion(otroJugador, unPartido) == false)
            {
                unPartido.agregarEstandar(otroJugador);
            }
        }

        public void bajaDeUnJugadorDe(Partido unPartido, Solidario otroJugador)
        {
            unPartido.eliminarEstandar(this);
            if (generarInfraccion(otroJugador, unPartido) == false)
            {
                unPartido.agregarSolidario(otroJugador);
            }
        }

        public void bajaDeUnJugadorDe(Partido unPartido, Condicional otroJugador)
        {
            unPartido.eliminarEstandar(this);
            if (generarInfraccion(otroJugador, unPartido) == false)
            {
                unPartido.agregarCondicional(otroJugador);
            }
        }






    }
}
