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

public struct Cliente
{
    public String nome;
    public String logradouro;
    public String cidade;
    public String estado;
    public String empresa;
    public String cargo;
    public int idade;
    public String sexo;
    public String mae;
    public string pae;
    public double salario;

}

namespace Desafios_RPA
{




    public partial class Window2 : Window
    {
        Cliente[] clientes = new Cliente[10];
        int index = 0;
        int convertIdade = 0;
        double convertSalario = 0;
        public Window2()
        {

            InitializeComponent();


        }

        private void btnGravar_Click(object sender, RoutedEventArgs e)
        {
            if (index <= clientes.Length - 1)
            {
                

                if (convertIdade >= 18 && convertSalario > 1048.00)
                {
                    clientes[index].nome = txtNome.Text;
                    clientes[index].logradouro = txtLogradouro.Text;
                    clientes[index].cidade = txtCidade.Text;
                    clientes[index].estado = cbbEstado.Text;
                    clientes[index].empresa = txtEmpresa.Text;
                    clientes[index].cargo = txtCargo.Text;

                    int.TryParse(txtIdade.Text, out convertIdade);
                    clientes[index].idade = convertIdade;

                    clientes[index].mae = cbbSexo.Text;
                    clientes[index].mae = txtMae.Text;
                    clientes[index].pae = txtPai.Text;

                    Double.TryParse(txtSalario.Text, out convertSalario);
                    clientes[index].salario = convertSalario;

                    lblSucesso.Content = "Cadastrado com Sucesso";
                }
                else
                {
                    lblSucesso.Content = "Cadastro Recusado - Idade ou Salario invalido";
                }

                index += 1;
            }
            else {
                MessageBoxResult result = MessageBox.Show("Aplicativo atingiu o Limite de Cadastros");
            }
            
        }
    }

}

