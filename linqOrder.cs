using api_project.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_project.filtros;

internal class linqOrder
{
    public static void exibirOrdemArtistas (List<musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista)
            .Select(musica => musica.Artista.Distinct().ToList());

        Console.WriteLine("Lista de artistas ordenados");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"--> {artista}");
        }
    }   
    

}
