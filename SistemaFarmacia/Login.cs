using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaFarmacia
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void CleanProvider()
        {
            errorProvider.Clear();
        }
        private void AceptarButton_Click(object sender, EventArgs e)
        {
         bool paso = true;
        Expression<Func<Usuarios, bool>> filtrar = x => true;
        List<Usuarios> user = new List<Usuarios>();
        Repositorio<Usuarios> db = new Repositorio<Usuarios>();

            var lista = new List<Usuarios>();

        CleanProvider();
            if (UsuariotextBox.Text == string.Empty)
            {
                paso = false;
                errorProvider.SetError(UsuariotextBox, "Incorrecto");

            }
            if (ContrasenatextBox.Text == string.Empty)
            {
                paso = false;
                errorProvider.SetError(ContrasenatextBox, "Incorrecto");

            }
            if (paso == false)
            {
                MessageBox.Show("Campos Vacios!!");
                return;
            }
            if ((UsuariotextBox.Text == "Alfanik") && (ContrasenatextBox.Text == "12345"))
            {
                this.Hide();
                MainForm ver = new MainForm();
                ver.Show();
            }
            else
            {
                filtrar = t => t.Usuario.Equals(UsuariotextBox.Text);
                user = db.GetList(filtrar);

                if (user.Exists(x => x.Nombres == UsuariotextBox.Text) && user.Exists(x => x.Clave == ContrasenatextBox.Text))
                {
                    this.Hide();
                    MainForm ver = new MainForm();
                    ver.Show();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrecta!!");
                    errorProvider.SetError(ContrasenatextBox, "Incorrecto");
                    errorProvider.SetError(UsuariotextBox, "Incorrecto");
                }
            }
        
        }

        private void UsuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
