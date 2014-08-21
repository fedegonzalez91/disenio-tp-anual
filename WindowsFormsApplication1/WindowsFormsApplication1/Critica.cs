using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDisenio2014
{
    public class Critica
    {
        private int _puntuacion = 0;
        private string _critic;

        public int puntuacion
        {
            get { return _puntuacion; }
            set { _puntuacion = value; }
        }
        public string critica
        {
            get { return _critic; }
            set { _critic = value; }
        }

        public void puntuacionYCriticaSetter(int puntos, string critic)
        {
            this.puntuacion = this.puntuacion + puntos;
            this.critica = critic;
        }

        public void agregarCritica(string critic)
        {
            this.critica = critic;
        }
    }
}
