using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TPDisenio2014
{
    static class Program
    {

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //Jugadores Ya existentes

            Jugador nuevoJugador = new Jugador();
            nuevoJugador.InitializeComponent();
            nuevoJugador.datosPersonalesTodos("juan","juan",DateTime.Today, "juan","juan");
            Administrador.Instance.miembros.Add(nuevoJugador);

   
            Jugador nuevoJugador1 = new Jugador();
            nuevoJugador1.InitializeComponent();
            nuevoJugador1.datosPersonalesTodos("pedro", "pedro", DateTime.Today, "pedro", "pedro");
            Administrador.Instance.miembros.Add(nuevoJugador1);

            Jugador nuevoJugador2 = new Jugador();
            nuevoJugador2.InitializeComponent();
            nuevoJugador2.datosPersonalesTodos("laura", "laura", DateTime.Today, "laura", "laura");
            Administrador.Instance.miembros.Add(nuevoJugador2);

            Jugador nuevoJugador3 = new Jugador();
            nuevoJugador3.InitializeComponent();
            nuevoJugador3.datosPersonalesTodos("rober","rober", DateTime.Today,"rober","rober");
            Administrador.Instance.miembros.Add(nuevoJugador3);

            Jugador nuevoJugador4 = new Jugador();
            nuevoJugador4.InitializeComponent();
            nuevoJugador4.datosPersonalesTodos("sofia", "sofia", DateTime.Today, "sofia", "sofia");
            Administrador.Instance.miembros.Add(nuevoJugador4);

            Jugador nuevoJugador5 = new Jugador();
            nuevoJugador5.InitializeComponent();
            nuevoJugador5.datosPersonalesTodos("cecilia", "cecilia", DateTime.Today, "cecilia", "cecilia");
            Administrador.Instance.miembros.Add(nuevoJugador5);

            Jugador nuevoJugador6 = new Jugador();
            nuevoJugador6.InitializeComponent();
            nuevoJugador6.datosPersonalesTodos("jorge", "jorge", DateTime.Today, "jorge", "jorge");
            Administrador.Instance.miembros.Add(nuevoJugador6);

            Jugador nuevoJugador7 = new Jugador();
            nuevoJugador7.InitializeComponent();
            nuevoJugador7.datosPersonalesTodos("sami", "sami", DateTime.Today, "sami", "sami");
            Administrador.Instance.miembros.Add(nuevoJugador7);

            Jugador nuevoJugador8 = new Jugador();
            nuevoJugador8.InitializeComponent();
            nuevoJugador8.datosPersonalesTodos("luna", "luna", DateTime.Today, "luna", "luna");
            Administrador.Instance.miembros.Add(nuevoJugador8);

            Jugador nuevoJugador9 = new Jugador();
            nuevoJugador9.InitializeComponent();
            nuevoJugador9.datosPersonalesTodos("carlos", "carlos", DateTime.Today, "carlos", "carlos");
            Administrador.Instance.miembros.Add(nuevoJugador9);

            Jugador nuevoJugador10 = new Jugador();
            nuevoJugador10.InitializeComponent();
            nuevoJugador10.datosPersonalesTodos("adrian", "adrian", DateTime.Today, "adrian", "adrian");
            Administrador.Instance.miembros.Add(nuevoJugador10);

          
            Administrador.Instance.crearPartido(DateTime.Today,DateTime.Today,"Partido 1");

            login frmLog = new login();
            Application.Run(frmLog);
            
        }
    }
}
