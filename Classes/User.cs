using System;
using System.IO;
using System.Text;


namespace _USERS{
    class User{
         public User(string nome, string cpf, int idade, int setor, string cargo){
            this.Nome = nome;
            this.Cpf = cpf;
            this.Setor = setor;
            this.Cargo = cargo;
        }
        public User (){}
        
        public string Nome;
        public string Cpf;
        public int Setor;
        public string Cargo;
        public void SalvarUser(){
            Console.WriteLine("Digite o NOME do funcionário");
            this.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do funcionário");
            this.Cpf = Console.ReadLine();
            Console.WriteLine("Digite o SETOR do funcionário");
            this.Setor = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o CARGO do funcionário");
            this.Cargo = Console.ReadLine();
        }
         public void GravarUser(){
            String path = "./DB/Users.csv";
            using (FileStream fs = File.Open(path, FileMode.Append)){
                Console.WriteLine(path);
                Byte[] info = new UTF8Encoding(true).GetBytes("\n" + this.Nome + "," + this.Cpf + ","+ this.Setor + "," + this.Cargo);
                fs.Write(info, 0, info.Length);
            }
        } 
    }
}    