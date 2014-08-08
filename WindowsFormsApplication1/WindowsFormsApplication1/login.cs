using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpAnual
{
    public partial class login : Form
    {
        private Jugador _jugador;

        public Jugador jugador
        {
            get { return _jugador; }
            set { _jugador = value; }
        }
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool estaVacio(string valor)
        {
            if(string.IsNullOrEmpty(valor)==true)
            {
                return true;
            }
            return false;
        }
        private bool chequeoText()
        {
            bool resultado = false;
            resultado =resultado|string.IsNullOrEmpty(textUsuario.Text);
            if(resultado==true)
            {
                textUsuario.BackColor = Color.Red;
            }
            resultado = false;
            resultado = resultado | string.IsNullOrEmpty(textContra.Text);
            if(resultado==true)
            {
                textContra.BackColor = Color.Red;
            }
            return resultado;
        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if(this.chequeoText())
            {
                MessageBox.Show("Campos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Administrador.Instance.verificarUsuario(textUsuario.Text))
                {
                    if(Administrador.Instance.verificarUsuarioYContra(textUsuario.Text,textContra.Text)==true)
                    {
                        MessageBox.Show("Login exitoso.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        if(textUsuario.Text!="admin")
                        {
                            menuUser menu = new menuUser();
                            Jugador unJugador = new Jugador();
                            this.jugador = Administrador.Instance.miembros.Find(jugador => jugador.user == textUsuario.Text);
                            menu.jugadorLogueado = this.jugador;
                            this.Hide();
                            menu.ShowDialog();
                            this.Show();
                           
                        }
                        else
                        {
                            menuAdministrador menuAdmin = new menuAdministrador();
                            this.Hide();
                            menuAdmin.ShowDialog();
                            this.Show();
                            
                        }
                        
                        
                        
                       
                    }
                    else
                    {
                        MessageBox.Show("Contraseña Incorrecta", "Error Costraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textContra.Clear();
                        textContra.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no existe", "Usuario Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textUsuario.Clear();
                    textUsuario.Focus();
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alta frmAlta = new Alta();
            this.Hide();
            frmAlta.Show();
            //this.Show();
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {
            textUsuario.BackColor = Color.White;
        }

        private void textContraseña_TextChanged(object sender, EventArgs e)
        {
            textContra.BackColor = Color.White;
        }
    }
}
