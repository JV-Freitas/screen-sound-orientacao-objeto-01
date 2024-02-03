using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Banda
    {
        public Banda(string nome) { 
            Nome = nome;
        }

        private List<Album> albuns = new List<Album>();
        public string? Nome { get; set; }

        public void AdicionarAlbum(Album album)
        {
            albuns.Add(album);
        }

        public void ExibirDiscografia()
        {
            Console.WriteLine($"\n* Discografia da banda {Nome}:");
            foreach (var album in albuns)
            {
                Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal})");
            }
        }

    }
}
