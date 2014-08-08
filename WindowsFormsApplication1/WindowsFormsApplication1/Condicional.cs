using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpAnual
{
    public class Condicional : Jugador
    {
        private string _condicion;
        private string _tipo="Condicional";

        public string tipo
        {
            get { return _tipo; }
        }

        public string condicion
        {
            get { return _condicion; }
            set { condicion = value; }
        }


        public string inscribirse(Partido unPartido)
        {
            string mensaje;

            if (unPartido.NoHayDiezEstandar() == true)
            {
                if (unPartido.cantidadSolidarios()+unPartido.cantidadEstandar() >= 10)
                {
                    mensaje = "Hay diez jugadores Solidarios/Estandar Incriptos. Inscripción denegada";
                }
                else
                {
                    if (unPartido.cantidadCondicionales()+unPartido.cantidadSolidarios()+unPartido.cantidadEstandar() >= 10)
                    {
                        mensaje = "Hay diez jugadores Estandar/Solidarios/Condicionales Inscriptos. Inscripción Denegada";
                    }
                    else
                    {
                        mensaje = "El Jugador ha sido Inscripto con éxito";
                        //Avisar a los amigos que se inscribió
                        unPartido.agregarCondicional(this);
                    }
                }
            }
            else
            {
                mensaje = "Hay diez jugadores de tipo Estandar Inscriptos. Inscripción denegada";
            }
            return mensaje;
        }

        public void bajaDeUnJugadorDe(Partido unPartido, Estandar otroJugador)
        {
            unPartido.eliminarCondicional(this);
            if (generarInfraccion(otroJugador, unPartido) == false)
            {
                unPartido.agregarEstandar(otroJugador);
            }
        }

        public int eliminar(Partido unPartido)
        {
           unPartido.jugadoresCondicionales.Remove(this);
           return 3;
        }
        public void bajaDeUnJugadorDe(Partido unPartido, Solidario otroJugador)
        {
            unPartido.eliminarCondicional(this);
            if (generarInfraccion(otroJugador, unPartido) == false)
            {
                unPartido.agregarSolidario(otroJugador);
            }
        }

        public void bajaDeUnJugadorDe(Partido unPartido, Condicional otroJugador)
        {
            unPartido.eliminarCondicional(this);
            if (generarInfraccion(otroJugador, unPartido) == false)
            {
                unPartido.agregarCondicional(otroJugador);
            }
        }

    }
}
