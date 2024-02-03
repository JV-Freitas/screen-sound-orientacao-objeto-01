using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Musica
    {
        public Musica(Banda artista, string nome) { 
            Artista = artista;
            Nome = nome;
        }
        public string? Nome{ get;}
        public Banda Artista{ get;}
        public int Duracao{ get; set; }
        public bool Disponivel{ get; set; }
        public string Descricao => $"A música {Nome} pertence ao artista {Artista.Nome} e ela tem a duração de {Duracao}mins";

        public void ExibirFichaTecnica()
        {
            Console.WriteLine("\n# Ficha Tecnica");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista.Nome}");
            Console.WriteLine($"Duração: {Duracao}");
            if (Disponivel)
            {
                Console.WriteLine($"A música está disponível no plano");
            }
            else
            {
                Console.WriteLine($"Contrate o Plano Plus+ para obter essa faixa!");
            }

            Console.WriteLine($"- Descrição Resumida: \n{Descricao}");

        }
    }
}
