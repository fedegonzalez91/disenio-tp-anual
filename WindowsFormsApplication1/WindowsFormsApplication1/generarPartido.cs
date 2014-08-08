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
    public partial class menuAdmin : Form
    {
        private Jugador _jugadorLogueado;

        public Jugador jugadorLogueado
        {
            get { return _jugadorLogueado; }
            set { _jugadorLogueado = value; }
        }
        public menuAdmin()
        {
             InitializeComponent();
        }
        
        private void menuAdmin_Load(object sender, EventArgs e)
        {
           textNombre.Focus();
        }


        private bool chequearVacios ()
        {
            if (nombreText.Text==String.Empty)
             {
                 return true;
             }
            return false;
        }
        

        private void textNombre_TextChanged(object sender, EventArgs e)
        {
            textNombre.BackColor = Color.White;
        }

        private void menuAdmin_Load_1(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
             //TODO  verificar si los campos no son completados
            
           
            if( this.chequearVacios())
            {
                nombreText.BackColor = Color.Red;
                MessageBox.Show("Campo de Nombre Incompleto", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nombreText.Focus();
            }
            else
            {
                if (Administrador.Instance.buscarPartido(nombreText.Text)==null)
                {
                    Administrador.Instance.crearPartido(fechaPick.Value, horaPick.Value, nombreText.Text);
                    MessageBox.Show("El Partido ha sido creado exitosamente", "Alta de Partido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    nombreText.Clear();
                    MessageBox.Show("El nombre del partido ya existe elija otro.", "Partido existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nombreText.Focus();
                }

            }
           
        }

        private void nombreText_TextChanged(object sender, EventArgs e)
        {
            nombreText.BackColor = Color.White;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }



    }
}
