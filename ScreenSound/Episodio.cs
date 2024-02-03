using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Episodio
    {
        private List<string> convidados = new List<string>();
        public Episodio(int ordem, string titulo, int duracao)
        {
            Ordem = ordem;
            Titulo = titulo;
            Duracao = duracao;
        }
        public int Duracao { get; set; }
        public int Ordem { get; set; }
        public string Titulo { get; set; }
        public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";



        public void AdicionarConvidado(string convidado)
        {
            convidados.Add(convidado);
        }
    }
}
