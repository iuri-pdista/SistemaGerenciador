using System;
using System.IO;
using System.Text;

namespace _CLIENTE{
    public class Cliente{
        public Cliente(string nome, string cpf, int idade){
            this.Nome = nome;
            this.Cpf = cpf;
            this.Idade = idade;
        }
        public Cliente (){}

        public string Nome;
        public string Cpf;
        public int Idade;

       public void Listar (){
            Console.WriteLine(this.Nome + " " + this.Cpf + " " + this.Idade);
        }
        
        public void SalvarCliente(){
            Console.WriteLine("Digite o NOME do cliente");
            this.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do cliente");
            this.Cpf = Console.ReadLine();
            Console.WriteLine("Digite a IDADE do cliente");
            this.Idade = int.Parse(Console.ReadLine());
        }
        public void GravarCliente(){
            String path = "./DB/Clientes.csv";
            using (FileStream fs = File.Open(path, FileMode.Append)){
                Console.WriteLine(path);
                Byte[] info = new UTF8Encoding(true).GetBytes("\n" + this.Nome + "," + this.Cpf + ","+ this.Idade);
                fs.Write(info, 0, info.Length);
            }
        } 
    } 
}