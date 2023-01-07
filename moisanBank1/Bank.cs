using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace moisanBank1
{
     class Bank
    {

        List<string> cpfs = new List<string>();
        List<string> titulares = new List<string>();
        List<string> senhas = new List<string>();
        List<double> saldos = new List<double>();
        //areas dos menus
        public void Menu() 
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao meu banco Moisanx; ");
            Console.WriteLine("Se ja tiver conta se dirija ao login se não vá logo fazer a sua: ");
            Console.WriteLine("Login[1]");
            Console.WriteLine("New Cadastro[2]");
            int escolha = int.Parse(Console.ReadLine());
            if (escolha == 1)
            {

                Menu2();
            }
            else 
            {

                RegistrarNovoUsuario(cpfs,titulares,senhas,saldos);
                Menu();
            
            }


        
        }
        //Login
        public void Menu2() 
        {
            Console.Clear();
            Console.WriteLine("LOGIN PARA ACESSAR SUA CONTA:");
            Console.Write("CPF: ");
            string cpfValidar = Console.ReadLine();
            Console.Write("SENHA: ");
            String senhaValidar = Console.ReadLine();


            int validarCpf = cpfs.FindIndex(cpf=> cpf == cpfValidar);

            if (validarCpf != -1) 
            {
                if (senhas[validarCpf] == senhaValidar)
                {

                    Menu3();
                }
            }
                else {

                    Console.WriteLine("cpf ou senha incorreta pfv tente denovo ou volte para o menu principal:");
                    Console.Write("Deseja retorna ao menu digite[1] caso contrario digite[2]: ");
                    int escolha1 = int.Parse(Console.ReadLine());

                    if (escolha1 == 1)
                    {

                        Menu();
                    }
                    else { 
                    
                    Console.ReadKey();
                    Console.Clear();
                    Menu2();
                    
                    
                    }
                
                }
            
        
        
        
        }

        public void Menu3()
        {
            Console.Clear();
            Console.WriteLine("O que desejas fazer na sua conta :");
            Console.WriteLine("Sacar[1]");
            Console.WriteLine("Depositar[2]");
            Console.WriteLine("Transferir[3]");
            Console.WriteLine("Sair da conta[0]");
            int escolha3 = int.Parse(Console.ReadLine());

            switch (escolha3)
            {
                case 0: Menu(); break;
                    case 1:Sacar(); break;
                case 2: Depositar(); break;
                    case 3: Transferir(); break;
                

            }

        }

        private void Transferir()
        {
            throw new NotImplementedException();
        }

        public void Sacar()
        {
            
            Console.Clear();
            Console.Write("Quanto voce deseja sacar: ");
            double sacar = double.Parse(Console.ReadLine());
            saldos.Remove(sacar);
            foreach (double saldo in saldos) 
            {
                Console.WriteLine($"voce sacou{sacar}");

            }
            Menu3();
        
        }

        public void Depositar() {
            Console.Clear();
            Console.Write("Quanto voce deseja depositar: ");
            saldos.Add(double.Parse(Console.ReadLine()));
            foreach (double saldo in saldos) {
                Console.WriteLine($"voce depositou na conta{saldo}");

               
            }

            Menu3();
        }
       

        //Parte teacher
        static void RegistrarNovoUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.Clear();
            Console.WriteLine("Prencha todos os campos para finalizar seu cadastro:");
            Console.Write("Digite o cpf: ");
            cpfs.Add(Console.ReadLine());
            Console.Write("Digite o nome: ");
            titulares.Add(Console.ReadLine());
            Console.Write("Digite a senha: ");
            senhas.Add(Console.ReadLine());
            saldos.Add(0);
            
           
            
        }
       

        static void DeletarUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.Clear();
            Console.WriteLine("Voce deseja deletar sua conta:");
            Console.Write("Digite o cpf: ");
            string cpfParaDeletar = Console.ReadLine();
            int indexParaDeletar = cpfs.FindIndex(cpf => cpf == cpfParaDeletar);

            if (indexParaDeletar == -1)
            {
                Console.WriteLine("Não foi possível deletar esta Conta");
                Console.WriteLine("MOTIVO: Conta não encontrada.");
            }

            cpfs.Remove(cpfParaDeletar);
            titulares.RemoveAt(indexParaDeletar);
            senhas.RemoveAt(indexParaDeletar);
            saldos.RemoveAt(indexParaDeletar);

            Console.WriteLine("Conta deletada com sucesso");
            
        }
        static void ListarTodasAsContas(List<string> cpfs, List<string> titulares, List<double> saldos)
        {

            for (int i = 0; i < cpfs.Count; i++)
            {
                ApresentaConta(i, cpfs, titulares, saldos);
            }
        }

        static void ApresentarUsuario(List<string> cpfs, List<string> titulares, List<double> saldos)
        {

            Console.Write("Digite o cpf: ");
            string cpfParaApresentar = Console.ReadLine();
            int indexParaApresentar = cpfs.FindIndex(cpf => cpf == cpfParaApresentar);

            if (indexParaApresentar == -1)
            {
                Console.WriteLine("Não foi possível apresentar esta Conta");
                Console.WriteLine("MOTIVO: Conta não encontrada.");
            }

            ApresentaConta(indexParaApresentar, cpfs, titulares, saldos);
        }

        static void ApresentarValorAcumulado(List<double> saldos)
        {
            Console.WriteLine($"Total acumulado no banco: {saldos.Sum()}");
            // saldos.Sum(); ou .Agregatte(0.0, (x, y) => x + y)
        }

        static void ApresentaConta(int index, List<string> cpfs, List<string> titulares, List<double> saldos)
        {

            Console.WriteLine($"CPF = {cpfs[index]} | Titular = {titulares[index]} | Saldo = R${saldos[index]:F2}");
        }


    }
}
