using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDisenio2014
{
   public class PromedioEnNPartidos : Criterio
{
    private int _cantidadDePartidos;
	
     public int cantidadDePartidos
        {
            get { return _cantidadDePartidos; }
            set {_cantidadDePartidos = value; }
        }

    
    void Criterio.ordenarListaJugadores(List<Jugador> jugadores)
    {
        //jugadores.OrderByDescending(unJugador=>unJugador.promedio(this.cantidadEnNPartidos,Partido unPartido)).ToList();
    }

    }
}



