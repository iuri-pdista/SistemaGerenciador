using System;
using _CLIENTE;
using _USERS;
using _PRODUTOS;

namespace Programming{
    class Program{
        private static void ClienteFunc(){
            Cliente cliente = new Cliente();
            cliente.SalvarCliente(); 
            cliente.GravarCliente();  
        }
        private static void UserFunc(){
            while(true){
                string MenuLog = "\nO que deseja fazer na secção de funcionários?"+ 
                "\n\nPressione >0< para VOLTAR AO MENU"+ 
                "\nPressione >1< para ADICIONAR NOVOS funcionários"+ 
                "\nPressione >2< Para EDITAR um funcionário"+ 
                "\nPressione >3< Para LISTAR TODOS os funcionários\n\n";
                Console.WriteLine(MenuLog);
                string MenuRes = Console.ReadLine();
                if (MenuRes == "0"){break;}
                else if(MenuRes == "1"){
                    User User = new User();
                    User.SalvarUser(); 
                    User.GravarUser();
                }
                else if(MenuRes == "2"){
                    Console.WriteLine("Essa funcionalidade ainda nao foi implementada");
                }
                else if(MenuRes == "3"){
                    
                }
                  
            }
        }

        private static void ProdutoFunc(){
            Produto produto = new Produto();
            produto.SalvarProduto(); 
            produto.GravarProduto();
        }
        private static void Menu(){
            string MenuLog = "\nBem Vindo ao sistema gerenciador de informações"+ 
            "\n\nPressione >0< para SAIR" + 
            "\nPressione >1< para CLIENTES" + 
            "\nPressione >2< Para FUNCIONÁRIOS" + 
            "\nPressione >3< Para produtos\n\n";
            while(true){
                Console.WriteLine(MenuLog);
                string MenuRes = Console.ReadLine();
                if (MenuRes == "0"){break;}
                else if (MenuRes == "1"){
                    ClienteFunc();
                }
                else if (MenuRes == "2"){
                    UserFunc();
                }
                else if (MenuRes == "3"){
                    ProdutoFunc();
                }
            }
        } 
        static void Main(){
            Menu();
        }
    }
}

