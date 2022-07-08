using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    [System.Serializable]
    internal class Ebook : Produto,IEstoque
    {
        public string autor;
        private int vendas;

        public Ebook(string nome, float preco,string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine("Não é possivel dar entrada no estoque de um Ebook , por ser um produto Digital");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar vendas no E-book {nome}");
            Console.WriteLine("Digite a Qtd. de vaendas  que você quer dar entrada:");
            int entrada = int.Parse(Console.ReadLine());
            vendas = vendas + entrada;
            Console.WriteLine("Saida Registrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome:{nome}");
            Console.WriteLine($"Autor:{autor}");
            Console.WriteLine($"Nome:{preco}");
            Console.WriteLine($"Vendas:{vendas}");
            Console.WriteLine("==============================");

        }
    }
}
