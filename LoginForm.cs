using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class LoginForm : Form
    {
        private string _userAdmin;
        private char[] _password;
        public LoginForm()
        {
            InitializeComponent();
            _userAdmin = "god";
            _password = new char[] {'a', 'b', 'c' };
        }

        private void _btnIngresar_Click(object sender, EventArgs e)
        {
            if (_usuario.Text.Length > 20)
            {
                Console.WriteLine("Error, el texto es mayor a 20 chars");
                return;
            }
            if (_usuario.Text.Trim() == _userAdmin) Console.WriteLine("Acceso permitido");

        }

        private void _btnCrearCuenta_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
