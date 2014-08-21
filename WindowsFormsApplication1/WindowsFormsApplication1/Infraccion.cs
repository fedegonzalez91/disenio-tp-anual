using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDisenio2014
{
    public class Infraccion
    {
        private DateTime _tiempoYHora;
        private string _motivo;

        public DateTime tiempoYHora
        {
            get { return _tiempoYHora; }
            set { _tiempoYHora = value; }
        }
        public string motivo;
    }
}