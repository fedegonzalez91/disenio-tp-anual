using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace TPDisenio2014
{
    public partial class login : Form
    {
          

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
            bool errorLogin = false;
            SqlConnection myConnection = SQL_Methods.IniciarConnection();


            try
            {
                // Comando donde cargo el store procedure para la validacion del usuario
                SqlCommand comando = new SqlCommand("TP.proc_login", myConnection);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@user_name", SqlDbType.VarChar, 10).Value = this.textUsuario.Text;

                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                da.Fill(ds, "Usuarios");
                if (ds.Tables["Usuarios"].Rows.Count == 0)
                {
                    // No existe el nombre de usuario
                    errorLogin = true;
                }
                else
                {
                    // El usuario existe
                    if (ds.Tables["Usuarios"].Rows[0]["estado"].ToString().Equals("0"))
                    {
                        // Usuario no activo
                        MessageBox.Show("El usuario con el que desea ingresar esta inhabilitado.", "Usuario Inhabilitado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    if (ds.Tables["Usuarios"].Rows[0]["usuario_intentos_fallidos"].ToString().Equals("0"))
                    {
                        // Es la cuarta vez que se intenta iniciar sesion
                        this.deshabilitarUsuario(this.usuario.Text);
                        MessageBox.Show("Ud. ha sido bloqueado, comuniquese con su administrador para que lo desbloquee.", "Usuario bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //errorLogin = true;
                        //return;
                    }
                    else
                    {
                        // Intento valido de inicio de sesion
                        if (ds.Tables["Usuarios"].Rows[0]["password"].ToString() == encriptar(this.contraseña.Text))
                        {
                            // La contraseña es correcta
                            //this.Visible = false;
                            this.Dispose();
                            return;
                        }
                        else
                        {
                            // La contraseña es incorrecta
                            errorLogin = true;
                            this.registrarLoginInvalido(this.usuario.Text);
                        }
                    }
                }

                if (errorLogin)
                {
                    MessageBox.Show("Usuario o contraseña inválidos");
                }
                this.contraseña.Text = "";
                this.usuario.Text = "";
                this.usuario.Select();
            }
            catch (Exception excepcion)
            {
                MessageBox.Show("Error en la aplicación: " + excepcion.Message);
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
