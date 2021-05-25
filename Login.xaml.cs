using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Desafios_RPA
{
    /// <summary>
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private readonly string user;
        private readonly string senha;

        public Login(String user, String senha)
        {
            InitializeComponent();
            this.user = user;
            this.senha = senha;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) 
        {
            
            var Cadastro = new Window2();
            String usuario = txtUsuario.Text;
            String senhaUsuario = txtSenha.Text; 
            if (usuario == user && senhaUsuario == senha)
            {
                Cadastro.Show();
                this.Hide();
            } else {
                MessageBoxResult result = MessageBox.Show("Usuario ou senha Invalidos");
            }
            

        }

  
    }
}
