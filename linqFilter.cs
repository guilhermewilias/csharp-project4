using api_project.modelos;
using System.Linq;         

namespace api_project.filtros;

internal class linqFilter
{
    public static void filtrarGeneros(List<musica> musicas)
    {
        var generosMusicais = musicas.Select(generos => generos.genero)
            .Distinct() .ToList();
        foreach(var genero in generosMusicais)
        {
            Console.WriteLine($"--> {genero}");
        }
    }
}
