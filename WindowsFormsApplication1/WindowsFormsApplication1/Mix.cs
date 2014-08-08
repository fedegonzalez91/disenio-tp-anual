using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpAnual
{


public class Mix : Criterio
{
    

    private List<Criterio> criterios = new List<Criterio>();


    void Criterio.ordenarListaJugadores(List<Jugador> jugadores)
    {
        //Ordena 
        foreach (Criterio unCriterio in criterios)
 {
unCriterio.ordenarListaJugadores(jugadores);
       }
            
    }

   /* public void AgregarCriterio(Criterio unCriterio)
    {
        this.criterios.Add(unCriterio);
    }
		
   /* public void EliminarCriterio(Criterio unCriterio)
    {
        this.criterios.Remove(unCriterio);
    }*/
	
}



}
