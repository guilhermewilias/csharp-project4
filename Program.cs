using api_project.modelos;
using System.Text.Json;
using api_project.filtros;

using (HttpClient client = new HttpClient()) //Fazendo a ligação com a API - gerenciando um recurso
{

    try {  //Tente executar, se não conseguir -> catch será executado
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<musica>>(resposta)!;
        //linqFilter.filtrarGeneros(musicas);
        linqOrder.exibirOrdemArtistas(musicas);


        //Console.WriteLine("A Api possui : " + musicas.Count + " musicas"); 
    } 
    catch (Exception ex) // Caso o try não funcionar, o catch de expection irá retornar o console.writeline abaixo!
    {
        Console.WriteLine($"Temos um problema! API : não está funcionando : {ex.Message}");
    }
}