using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDisenio2014
{
    public class Solidario : Jugador
    {
        private string _tipo = "Solidario";

        public string tipo
        {
            get { return _tipo; }
        }
        public string inscribirse(Partido unPartido)
        {
            string mensaje;

            if (unPartido.NoHayDiezEstandar() == true)
            {
                if (unPartido.cantidadSolidarios() +unPartido.cantidadEstandar()>= 10)
                {
                    mensaje = "Hay 10 Jugadores de tipo Solidarios/Estandar ya Inscriptos. Inscripción Denegada";
                }
                else
                {
                    if (unPartido.cantidadCondicionales() >= 10)
                    {
                        unPartido.eliminarElPrimerCondicional();
                        mensaje = "Se ha eliminado un Jugador Condicional. Inscripción Exitosa";
                        //Avisar a los amigos que se inscribió
                    }
                    else
                    {
                        mensaje = "La inscripción se ha realizado con éxito";
                        //Avisar a los amigos que se inscribió
                    }
                }


                unPartido.agregarSolidario(this);
            }
            else
            {
                mensaje = "Hay 10 Jugadores de tipo Estandar ya inscriptos. Inscripción Denegada";
            }

            return mensaje;

        }

         public int eliminar (Partido unPartido){
            unPartido.jugadoresSolidarios.Remove(this);
            return 2;
         }

        public void bajaDeUnJugadorDe(Partido unPartido, Estandar otroJugador)
        {
            unPartido.eliminarSolidario(this);
            if (generarInfraccion(otroJugador, unPartido) == false)
            {
                unPartido.agregarEstandar(otroJugador);
            }
        }

        public void bajaDeUnJugadorDe(Partido unPartido, Solidario otroJugador)
        {
            unPartido.eliminarSolidario(this);
            if (generarInfraccion(otroJugador, unPartido) == false)
            {
                unPartido.agregarSolidario(otroJugador);
            }
        }

        public void bajaDeUnJugadorDe(Partido unPartido, Condicional otroJugador)
        {
            unPartido.eliminarSolidario(this);
            if (generarInfraccion(otroJugador, unPartido) == false)
            {
                unPartido.agregarCondicional(otroJugador);
            }
        }

    }

}
