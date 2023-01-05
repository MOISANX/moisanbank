using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moisanBank1
{
    internal class Menu
    {
        public void Menu1()
        {
            Console.Clear();
            Console.WriteLine("BEM VINDO AO MEU BANCO MOISANX BANK!!!");
            Console.WriteLine("Voce ja tem uma conta no meu banco ?");

            Console.WriteLine("SIM[1] / NÃO[2]");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {


                case 1:


                    Menu2(); break;

                case 2:
                    new Cliente().Cadastro(); break;

            }


        }

        public void Menu2()

        {
            Console.Clear();
            Console.WriteLine("Faça seu Login: ");
            Console.WriteLine();
            Console.WriteLine("CPF: ");
            Console.WriteLine("SENHA: ");





        }

    }
}
