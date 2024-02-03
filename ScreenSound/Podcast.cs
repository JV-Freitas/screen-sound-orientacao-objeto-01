using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Podcast
    {
        public Podcast(string nome, string host) { 
            Nome = nome;
            Host = host;
        }

        private List<Episodio> episodios = new List<Episodio>();
        public string Nome { get;}
        public string Host { get;}
        public int TotalEpisodios => episodios.Count();

        public void AdicionarEpisodio(Episodio episodio)
        {
            episodios.Add(episodio);
        }
        public void ExibirDetalhes()
        {

            Console.WriteLine($"O podcast {Nome} apresentado pelo host {Host}.\n");
            foreach (var ep in episodios.OrderBy(e => e.Ordem))
            {
                Console.WriteLine(ep.Resumo);
            }
            Console.WriteLine($"\n\nTotal de {TotalEpisodios} episódios.");
        }
    }
}
