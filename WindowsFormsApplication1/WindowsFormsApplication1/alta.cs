using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPDisenio2014
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void alta_Load(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelApellido_Click(object sender, EventArgs e)
        {

        }

        private void textApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fechaPick_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textContra_TextChanged(object sender, EventArgs e)
        {

        }

        private bool estaVaciaSinEspacio(string valor)
        {
            return (string.IsNullOrEmpty(valor) | string.IsNullOrWhiteSpace(valor));
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
              //  MessageBox.Show("Datos Incompletos o con Espacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
           
            
                if(Administrador.Instance.verificarUsuario(textUser.Text)==true)
                {//El Usuario ya existe
                    MessageBox.Show("El nombre de usuario ya existe","Usuario Existente",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    textUser.Clear();
                    textUser.Focus();
                }
                else{
                    //Dar de alta un nuevo Jugador
                    Jugador nuevoJugador = new Jugador();
                    nuevoJugador.InitializeComponent();
                    nuevoJugador.datosPersonalesTodos(textNombre.Text, textApellido.Text, fechaPick.Value, textContra.Text,textUser.Text);
                    MessageBox.Show("Registro Exitoso","Registron Usuario",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Administrador.Instance.miembros.Add(nuevoJugador);
                    login frmLog = new login();
                    frmLog.Show();
                    this.Close();
                }
                

            
        }

        private void btnAmigos_Click(object sender, EventArgs e)
        {
            this.Hide();
            agregarunAmigo frmaAmigos = new agregarunAmigo();
            frmaAmigos.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
