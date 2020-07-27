using System;
using _CLIENTE;
using _USERS;

namespace Programming{
    class Program{
        private static void ClienteFunc(){
            Cliente cliente = new Cliente();
            cliente.SalvarCliente(); 
            cliente.GravarCliente();  
        }
        private static void UserFunc(){
            User User = new User();
            User.SalvarUser(); 
            User.GravarUser();  
        }
        private static void Menu(){
            string MenuLog = "\nBem Vindo ao sistema gerenciador de informações"+ 
            "\n\n Pressione >0< para SAIR" + 
            "\nPressione >1< para CLIENTES" + 
            "\nPressione >2< Para FUNCIONÁRIOS" + 
            "\n Pressione >3< Para produtos";
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
                    Console.WriteLine("Essa funcionalidade ainda não foi implementada");
                    break;
                }
            }
        } 
        static void Main(){
            Menu();
        }
    }
}

