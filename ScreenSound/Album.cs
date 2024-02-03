using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Album
    {
        public Album(string nome)
        {
            Nome = nome;
        }
        List<Musica> musicas = new List<Musica> ();
        public string Nome { get; }
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public void ListarMusicas()
        {
            Console.WriteLine("\n# Lista de músicas do álbum:");
            foreach (var musica in musicas)
            {
                Console.WriteLine($"Musica: {musica.Nome}");
            }
            Console.WriteLine($"O álbum todo tem uma duração total de: {DuracaoTotal}seg.");
        }
    }
}
