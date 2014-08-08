using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpAnual
{
    public class Denegacion
    {
        private string _Motivo;
        private DateTime _fechaYHora;

        public string Motivo
        {
            get { return _Motivo; }
            set { _Motivo = value; }
        }
        public DateTime fechaYHora
        {
            get { return _fechaYHora; }
            set { _fechaYHora = value; }
        }
        public void denegacionSetters(string motivo)
        {
            this.Motivo = motivo;
            DateTime fecha = new DateTime();
            this.fechaYHora = fecha;
        }

    }
}