using System;
using System.IO;
using System.Text;
namespace _PRODUTOS{
    class Produto{
         public Produto(string nome, int id, int setor){
            this.Nome = nome;
            this.Setor = setor;
            this.ID = id;
        }
        public Produto (){}
        
        public string Nome;
        public int ID;
        public int Setor;
        public void SalvarProduto(){
            Console.WriteLine("Digite o NOME do produto");
            this.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CÓDIGO do produto");
            this.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o SETOR do produto");
            this.Setor = int.Parse(Console.ReadLine());
        }
         public void GravarProduto(){
            String path = "./DB/Produtos.csv";
            using (FileStream fs = File.Open(path, FileMode.Append)){
                Console.WriteLine(path);
                Byte[] info = new UTF8Encoding(true).GetBytes("\n" + this.Nome  + ", " + this.Setor + ", " + this.ID);
                fs.Write(info, 0, info.Length);
            }
        } 
    }
} 