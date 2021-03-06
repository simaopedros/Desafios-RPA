using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
    /// Lógica interna para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private Usersenha Users = new Usersenha();
        public Window1()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text;
            string MachineName1 = Environment.MachineName;
            Users.usuario = MachineName1;
            Random randNum = new Random();
            Users.senha = randNum.Next().ToString();
            this.Hide();
            SmtpClient smtp = new SmtpClient();
            MailMessage mail = new MailMessage();
            Attachment arquivoAnexo = new Attachment(".\\Invoice-Data-Currencies.xlsx");

            mail.Attachments.Add(arquivoAnexo);

            smtp.Host = "smtp.office365.com";
            smtp.Port = 587;

            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;

            smtp.Credentials = new System.Net.NetworkCredential("", "");

            mail.From = new MailAddress("simaopedros@live.com");
            mail.To.Add(new MailAddress(email));
            mail.Subject = "Desafio RPA - Planilha de Dados";
            mail.Body = "Usuario: " + Users.usuario  + ", Senha: "+ Users.senha +"";

            smtp.Send(mail);


            var LoginPage = new Login(Users.usuario, Users.senha);
            LoginPage.Show();

        }
    }
}
