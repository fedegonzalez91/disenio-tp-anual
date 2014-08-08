﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpAnual
{
    class Hadicap : Criterio
    {
        
        void Criterio.ordenarListaJugadores(List<Jugador> jugadores)
        {
            jugadores.OrderByDescending(unJugador => unJugador.nivelHandicap).ToList();
            
        }

    }
}
