using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moisanBank1
{
    internal class Cliente
    {

        private string nome;
        private string cpf;
        private string endereco;
        private string telefone;
        private string senha;
        private List<Conta> contas;

        public Cliente(string nome, string cpf, string endereco, string telefone)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.telefone = telefone;
            this.contas = new List<Conta>();
        }

        public Cliente()
        {
        }

        public void Cadastro()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Por favor preencha seus dados para o cadastro:");
                Console.Write("NOME: ");
                this.nome = Console.ReadLine();
                Console.WriteLine();
                Console.Write("CPF: ");
                this.cpf = Console.ReadLine();
                Console.WriteLine();
                Console.Write("ENDEREÇO: ");
                this.endereco = Console.ReadLine();
                Console.WriteLine();
                Console.Write("TELEFONE: ");
                this.telefone = Console.ReadLine();
                Console.WriteLine();
                Console.Write("SENHA: ");
                this.senha = Console.ReadLine();
                Console.WriteLine();
                this.contas = new List<Conta>();

                if (!string.IsNullOrEmpty(this.nome) &&
                    !string.IsNullOrEmpty(this.cpf) &&
                    !string.IsNullOrEmpty(this.endereco) &&
                    !string.IsNullOrEmpty(this.telefone) &&
                    !string.IsNullOrEmpty(this.senha))
                {

                    break;
                }
                Console.WriteLine("Por favor preenchar todas as informaçoes pedidas a cima!!!");
                Console.Clear();
            }

        }

        public void AdicionaConta(Conta conta)
        {
            contas.Add(conta);
        }

        public List<Conta> ObtemContas()
        {

            return contas;
        }

    }
}
